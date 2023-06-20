using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Express_O_LIB
{
    public class Supplier
    {
        private int idSupplier;
        private string nama;
        private string alamat;
        private string noTelepon;

        #region Constructors
        public Supplier(int idSupplier, string nama, string alamat, string noTelepon)
        {
            this.IdSupplier = idSupplier;
            this.Nama = nama;
            this.Alamat = alamat;
            this.NoTelepon = noTelepon;
        }
        #endregion

        #region Properties
        public int IdSupplier { get => idSupplier; set => idSupplier = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string NoTelepon { get => noTelepon; set => noTelepon = value; }
        #endregion

        #region Method
        public static void TambahData(Supplier supplier)
        {
            string sql = "INSERT INTO Supplier (IdSupplier, Nama, Alamat, NoTelepon) VALUES ('" + supplier.IdSupplier + "', '" + supplier.Nama.Replace("'", "\\'") + "', '" + supplier.Alamat + "', '" + supplier.NoTelepon + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Supplier supplier)
        {
            string sql = "UPDATE Supplier SET Nama = '" + supplier.Nama.Replace("'", "\\'") + "', Alamat = '" + supplier.Alamat + "', NoTelepon = '" + supplier.NoTelepon + "' WHERE IdSupplier = '" + supplier.IdSupplier + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Supplier supplier)
        {
            string sql = "DELETE FROM Supplier WHERE IdSupplier = '" + supplier.IdSupplier + "'";

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

        public static List<Supplier> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT * FROM Supplier";
            }
            else
            {
                sql = "SELECT * FROM Supplier WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Supplier> listOfSupplier = new List<Supplier>();

            while (hasil.Read() == true)
            {
                Supplier supplier = new Supplier(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                listOfSupplier.Add(supplier);
            }

            return (listOfSupplier);
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(IdSupplier) FROM Supplier";

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