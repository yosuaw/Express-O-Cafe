using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace Express_O_LIB
{
    public class Menu
    {
        private string kodeMenu;
        private string nama;
        private int harga;
        private Kategori kategori;

        #region Constructors
        public Menu(string kodeMenu, string menu, int harga, Kategori kategori)
        {
            this.KodeMenu = kodeMenu;
            this.Nama = nama;
            this.Harga = harga;
            this.Kategori = kategori;
        }
        #endregion

        #region Properties
        public string KodeMenu { get => kodeMenu; set => kodeMenu = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Harga { get => harga; set => harga = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion

        #region Methods
        public static void TambahData(Menu menu)
        {
            string sql = "INSERT INTO Menu(KodeMenu, Nama, Harga, KodeKategori) VALUES ('" + menu.KodeMenu + "', '" + menu.Nama + "', '" + menu.Harga + "', '" + menu.Kategori.KodeKategori + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Menu menu)
        {
            string sql = "UPDATE Menu SET Nama = '" + menu.Nama + "', Harga = '" + menu.Harga + "', KodeKategori = '" + menu.Kategori.KodeKategori + "' WHERE KodeMenu = '" + menu.KodeMenu + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Menu menu)
        {
            string sql = "DELETE FROM Menu WHERE KodeMenu = '" + menu.KodeMenu + "'";

            try
            {
                Koneksi.JalankanPerintahDML(sql);
                return ("1");
            }
            catch (MySqlException ex)
            {
                return (ex.Message + ". Perintah sql : " + sql);
            }
        }

        public static List<Menu> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT m.KodeMenu, m.Nama AS 'Nama Menu' , m.Harga, k.KodeKategori, k.Nama AS 'Nama Kategori' FROM Menu m INNER JOIN Kategori k ON m.KodeKategori = k.KodeKategori";
            }
            else
            {
                sql = "SELECT m.KodeMenu, m.Nama AS 'Nama Menu' , m.Harga, k.KodeKategori, k.Nama AS 'Nama Kategori' FROM Menu m INNER JOIN Kategori k ON m.KodeKategori = k.KodeKategori WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Menu> listOfMenu = new List<Menu>();

            while (hasil.Read() == true)
            {
                Kategori kategori = new Kategori(int.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString());
                Menu menu = new Menu(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), kategori);
                listOfMenu.Add(menu);
            }

            return (listOfMenu);
        }

        public static string GenerateKode(Kategori kategori)
        {
            string sql = "SELECT MAX(RIGHT(KodeMenu, 2)) FROM Menu WHERE KodeKategori = '" + kategori.KodeKategori + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                hasilKode = kategori.Nama.Substring(0, 1) + kodeTerbaru.ToString().PadLeft(2, '0');
            }
            else
            {
                hasilKode =  kategori.Nama.Substring(0, 1) + "01";
            }

            return (hasilKode);
        }
        #endregion
    }
}