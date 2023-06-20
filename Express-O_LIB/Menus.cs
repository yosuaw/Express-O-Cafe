using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;
using System.Transactions;

namespace Express_O_LIB
{
    public class Menus
    {
        private string kodeMenu;
        private string nama;
        private int harga;
        private int diskon;
        private Kategori kategori;
        List<Resep> listOfResep = new List<Resep>();

        #region Constructors
        public Menus(string kodeMenu, string nama, int harga, int diskon, Kategori kategori)
        {
            this.KodeMenu = kodeMenu;
            this.Nama = nama;
            this.Harga = harga;
            this.Diskon = diskon;
            this.Kategori = kategori;
            this.ListOfResep = new List<Resep>();
        }
        #endregion

        #region Properties
        public string KodeMenu { get => kodeMenu; set => kodeMenu = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Diskon { get => diskon; set => diskon = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        public List<Resep> ListOfResep { get => listOfResep; set => listOfResep = value; }
        #endregion

        #region Methods
        public void TambahResep(Bahan idBahan, double takaran)
        {
            Resep resep = new Resep(idBahan, takaran);

            this.ListOfResep.Add(resep);
        }

        public static void TambahData(Menus menu)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string sql1 = "INSERT INTO Menu(KodeMenu, Nama, Harga, KodeKategori, Diskon) VALUES ('" + menu.KodeMenu + "', '" + menu.Nama.Replace("'", "\\'") + "', '" + menu.Harga + "', '" + menu.Kategori.KodeKategori + "', '" + menu.Diskon + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (Resep reseps in menu.ListOfResep)
                    {
                        int gram = (int)(reseps.Takaran);
                        int length = (reseps.Takaran % 1).ToString().Length - gram.ToString().Length - 1;
                        int koma = (int)(reseps.Takaran % 1 * Math.Pow(10, length));
                        string hasilKoma = koma.ToString().PadLeft(length, '0');
                        string sql2 = "INSERT INTO Resep(KodeMenu, IdBahan, Takaran) VALUES ('" + menu.KodeMenu + "', '" + reseps.Bahan.IdBahan + "', '" + gram + "." + hasilKoma + "')";

                        Koneksi.JalankanPerintahDML(sql2);
                    }

                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw (new Exception("Penyimpanan menu gagal. Pesan kesalahan: " + ex.Message));
                }
            }
        }

        public static void UbahData(Menus menu)
        {
            string sql = "UPDATE Menu SET Nama = '" + menu.Nama.Replace("'", "\\'") + "', Harga = '" + menu.Harga + "', KodeKategori = '" + menu.Kategori.KodeKategori + "', Diskon = '" + menu.Diskon + "' WHERE KodeMenu = '" + menu.KodeMenu + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Menus menu)
        {
            try
            {
                string sql1 = "SELECT KodeMenu FROM Resep Where KodeMenu = '" + menu.KodeMenu + "'";

                DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql1);

                while (hasil.Read() == true)
                {
                    string sql2 = "DELETE FROM Resep WHERE KodeMenu = '" + hasil.GetValue(0) + "'";
                    Koneksi.JalankanPerintahDML(sql2);
                }

                string sql3 = "DELETE FROM Menu WHERE KodeMenu = '" + menu.KodeMenu + "'";
                Koneksi.JalankanPerintahDML(sql3);
                return ("1");
            }
            catch (MySqlException ex)
            {
                return (ex.Message);
            }
        }

        public static List<Menus> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";

            if (kriteria == "")
            {
                sql1 = "SELECT m.KodeMenu, m.Nama AS NamaMenu, m.Harga, m.Diskon, m.KodeKategori, k.Nama AS NamaKategori FROM Menu m INNER JOIN Kategori k ON m.KodeKategori = k.KodeKategori ORDER BY m.KodeMenu DESC";
            }
            else
            {
                sql1 = "SELECT m.KodeMenu, m.Nama AS NamaMenu, m.Harga, m.Diskon, m.KodeKategori, k.Nama AS NamaKategori FROM Menu m INNER JOIN Kategori k ON m.KodeKategori = k.KodeKategori WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%' ORDER BY m.KodeMenu DESC";
            }

            DataTableReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);   
            List<Menus> listHasilData = new List<Menus>();
            while (hasilData1.Read() == true)
            {
                string kodeMenu = hasilData1.GetValue(0).ToString();
                string nama = hasilData1.GetValue(1).ToString();
                int harga = int.Parse(hasilData1.GetValue(2).ToString());
                int diskon = int.Parse(hasilData1.GetValue(3).ToString());
                List<Kategori> listOfKategori = Kategori.BacaData("KodeKategori", hasilData1.GetValue(4).ToString());
                Menus menu = new Menus(kodeMenu, nama, harga, diskon, listOfKategori[0]);

                string sql2 = "SELECT r.IdBahan, b.Nama, r.Takaran FROM Menu m INNER JOIN Resep r ON m.KodeMenu = r.KodeMenu INNER JOIN Bahan b ON r.IdBahan = b.IdBahan WHERE m.KodeMenu = '" + kodeMenu + "'";
                DataTableReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);
                while (hasilData2.Read() == true)
                {
                    List<Bahan> listOfBahan = Bahan.BacaData("IdBahan", hasilData2.GetValue(0).ToString());
                    double takaran = double.Parse(hasilData2.GetValue(2).ToString());

                    Resep resep = new Resep(listOfBahan[0], takaran);

                    menu.TambahResep(listOfBahan[0], takaran);
                }
                listHasilData.Add(menu);
            }
            return (listHasilData);
        }

        public static string GenerateKode(Kategori kategori)
        {
            string sql = "SELECT MAX(RIGHT(KodeMenu, 2)) FROM Menu WHERE KodeKategori = '" + kategori.KodeKategori + "'";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "") //jika ditemukan barang dengan kategori tersebut
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilKode = kategori.Nama.Substring(0, 1) + kodeTerbaru.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilKode = kategori.Nama.Substring(0, 1) + "01";
                }
            }
            return (hasilKode);
        }
        #endregion
    }
}