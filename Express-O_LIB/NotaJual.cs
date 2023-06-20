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
    public class NotaJual
    {
        private string nomorNota;
        private DateTime tanggal;
        private string metodePembayaran;
        private Member member;
        private Karyawan karyawan;
        private List<DetilNotaJual> listOfDetilNotaJual;

        #region Constructors
        public NotaJual(string nomorNota, DateTime tanggal, string metodePembayaran, Member member, Karyawan karyawan)
        {
            this.NomorNota = nomorNota;
            this.Tanggal = tanggal;
            this.MetodePembayaran = metodePembayaran;
            this.Member = member;
            this.Karyawan = karyawan;
            this.ListOfDetilNotaJual = new List<DetilNotaJual>();
        }
        #endregion

        #region Properties
        public string NomorNota { get => nomorNota; set => nomorNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }
        public Member Member { get => member; set => member = value; }
        public Karyawan Karyawan { get => karyawan; set => karyawan = value; }
        public List<DetilNotaJual> ListOfDetilNotaJual { get => listOfDetilNotaJual; private set => listOfDetilNotaJual = value; }
        #endregion

        #region Methods
        public void TambahDetilNotaJual(int harga, int jumlah, int diskon, Menus menu)
        {
            DetilNotaJual detilNotaJual = new DetilNotaJual(harga, jumlah, diskon, menu);

            this.ListOfDetilNotaJual.Add(detilNotaJual);
        }


        public static void TambahData(NotaJual notaJual)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string sql1 = "INSERT INTO NotaJual(NomorNota, Tanggal, MetodePembayaran, IdMember, KodeKaryawan) VALUES ('" + notaJual.NomorNota + "', '" + notaJual.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + notaJual.MetodePembayaran + "', '" + notaJual.Member.IdMember + "', '" + notaJual.Karyawan.KodeKaryawan + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (DetilNotaJual detilNotaJuals in notaJual.ListOfDetilNotaJual)
                    {
                        string sql2 = "INSERT INTO DetilNotaJual(NomorNota, KodeMenu, Harga, Jumlah, Diskon) VALUES ('" + notaJual.NomorNota + "', '" + detilNotaJuals.Menu.KodeMenu + "', '" + detilNotaJuals.Harga + "', '" + detilNotaJuals.Jumlah + "', '" + detilNotaJuals.Diskon + "')";

                        Koneksi.JalankanPerintahDML(sql2);

                        string kodeMenu = detilNotaJuals.Menu.KodeMenu;

                        //string sql3 = "SELECT * FROM Menu WHERE KodeMenu = '" + kodeMenu + "'";

                        List<Menus> listOfMenu = Menus.BacaData("KodeMenu", kodeMenu); 

                        foreach (Menus menus in listOfMenu)
                        {
                            foreach (Resep reseps in menus.ListOfResep)
                            {
                                double totalTakaran = reseps.Takaran * detilNotaJuals.Jumlah;
                                Bahan.UpdateStok("Penjualan", reseps.Bahan.IdBahan, totalTakaran);
                            }
                        }
                    }

                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw (new Exception("Penyimpanan transaksi penjualan gagal. Pesan kesalahan: " + ex.Message));
                }
            }
        }

        public static List<NotaJual> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";
            if (kriteria == "")
            {
                sql1 = "SELECT n.NomorNota, n.Tanggal, n.MetodePembayaran, n.IdMember, m.Nama AS NamaMember, m.Alamat AS AlamatMember, n.KodeKaryawan, k.Nama AS NamaKaryawan FROM NotaJual n INNER JOIN Member m ON n.IdMember = m.IdMember INNER JOIN Karyawan k ON n.KodeKaryawan = k.KodeKaryawan ORDER BY n.NomorNota DESC";
            }
            else
            {
                sql1 = "SELECT n.NomorNota, n.Tanggal, n.MetodePembayaran, n.IdMember, m.Nama AS NamaMember, m.Alamat AS AlamatMember, n.KodeKaryawan, k.Nama AS NamaKaryawan FROM NotaJual n INNER JOIN Member m ON n.IdMember = m.IdMember INNER JOIN Karyawan k ON n.KodeKaryawan = k.KodeKaryawan WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%' ORDER BY n.NomorNota DESC";
            }

            DataTableReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            List<NotaJual> listHasilData = new List<NotaJual>();
            while (hasilData1.Read() == true)
            {
                string nomorNota = hasilData1.GetValue(0).ToString();
                DateTime tglNota = DateTime.Parse(hasilData1.GetValue(1).ToString());
                string metodePembayaran = hasilData1.GetValue(2).ToString();
                List<Member> listOfMember = Member.BacaData("IdMember", hasilData1.GetValue(3).ToString());
                List<Karyawan> listOfKaryawan = Karyawan.BacaData("k.KodeKaryawan", hasilData1.GetValue(6).ToString());
                NotaJual notaJual = new NotaJual(nomorNota, tglNota, metodePembayaran, listOfMember[0], listOfKaryawan[0]);

                string sql2 = "SELECT dnj.KodeMenu, m.Nama, dnj.Harga, dnj.Jumlah, dnj.Diskon FROM NotaJual n INNER JOIN DetilNotaJual dnj ON n.NomorNota = dnj.NomorNota INNER JOIN Menu m ON dnj.KodeMenu = m.KodeMenu WHERE n.NomorNota = '" + nomorNota + "'";
                DataTableReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);
                while (hasilData2.Read() == true)
                {
                    int hargaJual = int.Parse(hasilData2.GetValue(2).ToString());
                    int jumlahJual = int.Parse(hasilData2.GetValue(3).ToString());
                    int diskon = int.Parse(hasilData2.GetValue(4).ToString());
                    List<Menus> listOfMenu = Menus.BacaData("m.KodeMenu", hasilData2.GetValue(0).ToString());
                    DetilNotaJual detilNotaJual = new DetilNotaJual(hargaJual, jumlahJual, diskon, listOfMenu[0]);

                    notaJual.TambahDetilNotaJual(hargaJual, jumlahJual, diskon, listOfMenu[0]);
                }
                listHasilData.Add(notaJual);
            }
            return (listHasilData);
        }

        public static string GenerateNoNota(DateTime tanggalDipilih)
        {
            string sql = "SELECT RIGHT(NomorNota, 3) AS NoUrutTransaksi FROM NotaJual WHERE DATE(Tanggal) = '" + tanggalDipilih.ToString("yyyy-MM-dd") + "' ORDER BY Tanggal DESC LIMIT 1";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilNoNota = "";

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int nomorNotaTerakhir = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilNoNota = tanggalDipilih.ToString("yyyy") + tanggalDipilih.ToString("MM") + tanggalDipilih.ToString("dd") + nomorNotaTerakhir.ToString().PadLeft(3, '0');
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
            List<NotaJual> listOfNotaJual = new List<NotaJual>();

            listOfNotaJual = NotaJual.BacaData(kriteria, nilaiKriteria);

            StreamWriter file = new StreamWriter(namaFile);

            foreach (NotaJual nota in listOfNotaJual)
            {
                file.WriteLine("");
                file.WriteLine("EXPRESS-O CAFE");
                file.WriteLine("Jl. Jemursari V / 21, Surabaya");
                file.WriteLine("Telp. (031) - 8710439");
                file.WriteLine("=".PadRight(54, '='));

                file.WriteLine("No.Nota : " + nota.NomorNota);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("Pelanggan : " + nota.Member.Nama);
                file.WriteLine("Alamat    : " + nota.Member.Alamat);
                file.WriteLine("");
                file.WriteLine("Kasir     : " + nota.Karyawan.Nama);
                file.WriteLine("=".PadRight(54, '='));

                int grandTotal = 0;
                foreach (DetilNotaJual dnj in nota.ListOfDetilNotaJual)
                {
                    string nama = dnj.Menu.Nama;

                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);
                    }
                    int jumlah = dnj.Jumlah;
                    int harga = dnj.Harga;
                    int diskon = dnj.Diskon;
                    int subTotal = jumlah * harga - (int)((diskon/100) * (jumlah * harga));
                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,###").PadRight(7, ' '));
                    file.Write(diskon.ToString().PadRight(2, ' '));
                    file.Write("% ");
                    file.Write(subTotal.ToString("#,###").PadRight(10, ' '));
                    file.WriteLine("");
                    grandTotal = grandTotal + subTotal;
                }
                file.WriteLine("=".PadRight(54, '='));
                file.WriteLine("TOTAL : " + grandTotal.ToString("#,###"));
                file.WriteLine("=".PadRight(54, '='));
                file.WriteLine("");
                file.Write("*".PadLeft(22, '*'));
                file.Write("Thank You!");
                file.WriteLine("*".PadRight(22, '*'));
                file.Write("*".PadLeft(19, '*'));
                file.Write("Have A Nice Day*");
                file.Write("*".PadRight(19, '*'));
                file.WriteLine("");
            }
            file.Close();

            Cetak cetak = new Cetak(namaFile, font, 20, 10, 10, 10);
            cetak.CetakKePrinter("text");
        }
        #endregion
    }
}