using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Express_O_LIB
{
    public class Bahan
    {
        private int idBahan;
        private string nama;
        private double stok;
        private int harga;

        #region Constructors
        public Bahan(int idBahan, string nama, double stok, int harga)
        {
            this.IdBahan = idBahan;
            this.Nama = nama;
            this.Stok = stok;
            this.Harga = harga;
        }
        #endregion

        #region Properties
        public int IdBahan { get => idBahan; set => idBahan = value; }
        public string Nama { get => nama; set => nama = value; }
        public double Stok { get => stok; set => stok = value; }
        public int Harga { get => harga; set => harga = value; }
        #endregion

        #region Methods
        public static void TambahData(Bahan bahan)
        {
            string sql = "INSERT INTO Bahan (IdBahan, Nama, Stok, Harga) VALUES ('" + bahan.IdBahan + "', '" + bahan.Nama + "', '" + bahan.Stok + "', '" + bahan.Harga + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Bahan bahan)
        {
            string sql = "UPDATE Bahan SET Nama = '" + bahan.Nama + "', Stok = '" + bahan.Stok + "', Harga = '" + bahan.Harga + "' WHERE IdBahan = '" + bahan.IdBahan + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Bahan bahan)
        {
            string sql = "DELETE FROM Bahan WHERE IdBahan = '" + bahan.IdBahan + "'";

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

        public static List<Bahan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT * FROM Bahan";
            }
            else
            {
                sql = "SELECT * FROM Bahan WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Bahan> listOfBahan = new List<Bahan>();

            while (hasil.Read() == true)
            {
                Bahan bahan = new Bahan(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), double.Parse(hasil.GetValue(2).ToString()), int.Parse(hasil.GetValue(3).ToString()));
                listOfBahan.Add(bahan);
            }

            return (listOfBahan);
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(IdBahan) FROM Bahan";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                int kodeBaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilKode = kodeBaru.ToString().PadLeft(4, '0');
            }
            else
            {
                hasilKode = "0001";
            }
            return (hasilKode);
        }

        public static void UpdateStok(string jenisTransaksi, int idBahan, double totalTakaran)
        {
            string sql = "";
            if (jenisTransaksi == "Penjualan")
            {
                int gram = (int)(totalTakaran);
                int length = (totalTakaran % 1).ToString().Length - gram.ToString().Length - 1;
                int koma = (int)(totalTakaran % 1 * Math.Pow(10, length));
                string hasilKoma = koma.ToString().PadLeft(length, '0');

                sql = "UPDATE Bahan SET Stok = Stok-" + gram + "." + hasilKoma + " WHERE IdBahan = '" + idBahan + "'";
            }
            else if (jenisTransaksi == "Pembelian")
            {
                sql = "UPDATE Bahan SET Stok = Stok+" + totalTakaran + " WHERE IdBahan = '" + idBahan + "'";
            }

            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}