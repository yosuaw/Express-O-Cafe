using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Transactions;
using System.IO;
using System.Drawing;

namespace Express_O_LIB
{
    public class NotaBeli
    {
        private string nomorNota;
        private DateTime tanggal;
        private Supplier supplier;
        private Karyawan karyawan;
        private List<DetilNotaBeli> listOfDetilNotaBeli;

        #region Constructors
        public NotaBeli(string nomorNota, DateTime tanggal, Supplier supplier, Karyawan karyawan)
        {
            this.NomorNota = nomorNota;
            this.Tanggal = tanggal;
            this.Supplier = supplier;
            this.Karyawan = karyawan;
            this.ListDetilNotaBeli = new List<DetilNotaBeli>();
        }
        #endregion

        #region Properties
        public string NomorNota { get => nomorNota; set => nomorNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Karyawan Karyawan { get => karyawan; set => karyawan = value; }
        public List<DetilNotaBeli> ListDetilNotaBeli { get => listOfDetilNotaBeli; private set => listOfDetilNotaBeli = value; }
        #endregion

        #region Methods
        public void TambahDetilNotaBeli(int harga, int jumlah, Bahan bahan)
        {
            DetilNotaBeli detilNotaBeli = new DetilNotaBeli(harga, jumlah, bahan);

            this.ListDetilNotaBeli.Add(detilNotaBeli);
        }

        public static void TambahData(NotaBeli notaBeli)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string sql1 = "INSERT INTO NotaBeli(NomorNota, Tanggal, IdSupplier, KodeKaryawan) VALUES ('" + notaBeli.NomorNota + "', '" + notaBeli.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + notaBeli.Supplier.IdSupplier + "', '" + notaBeli.Karyawan.KodeKaryawan + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (DetilNotaBeli detilNotaBelis in notaBeli.ListDetilNotaBeli)
                    {
                        string sql2 = "INSERT INTO DetilNotaBeli(NomorNota, IdBahan, Harga, Jumlah) VALUES ('" + notaBeli.NomorNota + "', '" + detilNotaBelis.Bahan.IdBahan + "', '" + detilNotaBelis.Harga + "', '" + detilNotaBelis.Jumlah + "')";

                        Koneksi.JalankanPerintahDML(sql2);

                        Bahan.UpdateStok("Pembelian", detilNotaBelis.Bahan.IdBahan, detilNotaBelis.Jumlah);
                    }

                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw (new Exception("Penyimpanan transaksi pembelian gagal. Pesan kesalahan: " + ex.Message));
                }
            }
        }

        public static List<NotaBeli> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";
            if (kriteria == "")
            {
                sql1 = "SELECT n.NomorNota, n.Tanggal, n.IdSupplier, s.Nama AS NamaSupplier, s.Alamat AS AlamatSupplier, n.KodeKaryawan, k.Nama AS NamaKaryawan FROM NotaBeli n INNER JOIN Supplier s ON n.IdSupplier = s.IdSupplier INNER JOIN Karyawan k ON n.KodeKaryawan = k.KodeKaryawan ORDER BY n.NomorNota DESC";
            }
            else
            {
                sql1 = "SELECT n.NomorNota, n.Tanggal, n.IdSupplier, s.Nama AS NamaSupplier, s.Alamat AS AlamatSupplier, n.KodeKaryawan, k.Nama AS NamaKaryawan FROM NotaBeli n INNER JOIN Supplier s ON n.IdSupplier = s.IdSupplier INNER JOIN Karyawan k ON n.KodeKaryawan = k.KodeKaryawan WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%' ORDER BY n.NomorNota DESC";
            }

            DataTableReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            List<NotaBeli> listHasilData = new List<NotaBeli>();
            while (hasilData1.Read() == true)
            {
                string nomorNota = hasilData1.GetValue(0).ToString();
                DateTime tglNota = DateTime.Parse(hasilData1.GetValue(1).ToString());
                List<Supplier> listOfSupplier = Supplier.BacaData("IdSupplier", hasilData1.GetValue(2).ToString());
                List<Karyawan> listOfKaryawan = Karyawan.BacaData("k.KodeKaryawan", hasilData1.GetValue(5).ToString());
                NotaBeli notaBeli = new NotaBeli(nomorNota, tglNota, listOfSupplier[0], listOfKaryawan[0]);

                string sql2 = "SELECT dnb.IdBahan, b.Nama, dnb.Harga, dnb.Jumlah FROM NotaBeli n INNER JOIN DetilNotaBeli dnb ON n.NomorNota = dnb.NomorNota INNER JOIN Bahan b ON dnb.IdBahan = b.IdBahan WHERE n.NomorNota = '" + nomorNota + "'";
                DataTableReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);
                while (hasilData2.Read() == true)
                {
                    int hargaJual = int.Parse(hasilData2.GetValue(2).ToString());
                    int jumlahJual = int.Parse(hasilData2.GetValue(3).ToString());
                    List<Bahan> listOfBahan = Bahan.BacaData("IdBahan", hasilData2.GetValue(0).ToString());
                    DetilNotaBeli detilNotaBeli = new DetilNotaBeli(hargaJual, jumlahJual, listOfBahan[0]);

                    notaBeli.TambahDetilNotaBeli(hargaJual, jumlahJual, listOfBahan[0]);
                }
                listHasilData.Add(notaBeli);
            }
            return (listHasilData);
        }

        public static string GenerateNoNota(DateTime tanggalDipilih)
        {
            string sql = "SELECT RIGHT(NomorNota, 3) AS NoUrutTransaksi FROM NotaBeli WHERE DATE(Tanggal) ='" + tanggalDipilih.ToString("yyyy-MM-dd") + "' ORDER BY Tanggal DESC LIMIT 1";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilNoNota = "";

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int noNotaTerakhir = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilNoNota = tanggalDipilih.ToString("yyyy") + tanggalDipilih.ToString("MM") + tanggalDipilih.ToString("dd") + noNotaTerakhir.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilNoNota = tanggalDipilih.ToString("yyyy") + tanggalDipilih.ToString("MM") + tanggalDipilih.ToString("dd") + "001";
            }
            return hasilNoNota;
        }

        public static void CetakNota(string kriteria, string nilaiKriteria, string namaFile, Font font)
        {
            List<NotaBeli> listOfNotaBeli = new List<NotaBeli>();

            listOfNotaBeli = NotaBeli.BacaData(kriteria, nilaiKriteria);

            StreamWriter file = new StreamWriter(namaFile);

            foreach (NotaBeli nota in listOfNotaBeli)
            {
                file.WriteLine("");
                file.WriteLine("EXPRESS-O CAFE");
                file.WriteLine("Jl. Jemursari V / 21, Surabaya");
                file.WriteLine("Telp. (031) - 8710439");
                file.WriteLine("=".PadRight(54, '='));

                file.WriteLine("No.Nota : " + nota.NomorNota);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("Supplier : " + nota.Supplier.Nama);
                file.WriteLine("Alamat   : " + nota.Supplier.Alamat);
                file.WriteLine("");
                file.WriteLine("Kasir    : " + nota.Karyawan.Nama);
                file.WriteLine("=".PadRight(50, '='));

                int grandTotal = 0;
                foreach (DetilNotaBeli dnb in nota.ListDetilNotaBeli)
                {
                    string nama = dnb.Bahan.Nama;

                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);
                    }
                    int jumlah = dnb.Jumlah;
                    int harga = dnb.Harga;
                    int subTotal = jumlah * harga;
                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,###").PadRight(7, ' '));
                    file.Write(subTotal.ToString("#,###").PadRight(10, ' '));
                    file.WriteLine("");
                    grandTotal = grandTotal + subTotal;
                }
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("TOTAL : " + grandTotal.ToString("#,###"));
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("");
            }
            file.Close();

            Cetak cetak = new Cetak(namaFile, font, 20, 10, 10, 10);
            cetak.CetakKePrinter("text");
        }
        #endregion
    }
}