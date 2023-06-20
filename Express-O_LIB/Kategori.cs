using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Express_O_LIB
{
    public class Kategori
    {
        private int kodeKategori;
        private string nama;

        #region Constructors
        public Kategori(int kodeKategori, string nama)
        {
            this.KodeKategori = kodeKategori;
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Methods
        public static void TambahData(Kategori kategori)
        {
            string sql = "INSERT INTO Kategori (KodeKategori, Nama) VALUES ('" + kategori.KodeKategori + "', '" + kategori.Nama.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Kategori kategori)
        {
            string sql = "UPDATE Kategori SET Nama = '" + kategori.Nama.Replace("'", "\\'") + "' WHERE KodeKategori = '" + kategori.KodeKategori + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Kategori kategori)
        {
            string sql = "DELETE FROM Kategori WHERE KodeKategori = '" + kategori.KodeKategori + "'";

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

        public static List<Kategori> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT * FROM Kategori";
            }
            else
            {
                sql = "SELECT * FROM Kategori WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Kategori> listOfKategori = new List<Kategori>();

            while (hasil.Read() == true)
            {
                Kategori kategori = new Kategori(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString());
                listOfKategori.Add(kategori);
            }

            return (listOfKategori);
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(KodeKategori) FROM Kategori";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                int kodeBaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilKode = kodeBaru.ToString();
            }
            else
            {
                hasilKode = "1";
            }
            return (hasilKode);
        }
        #endregion

    }
}