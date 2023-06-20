using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Express_O_LIB
{
    public class Jabatan
    {
        private int idJabatan;
        private string nama;

        #region Constructors
        public Jabatan(int idJabatan, string nama)
        {
            this.IdJabatan = idJabatan;
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int IdJabatan { get => idJabatan; set => idJabatan = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Methods
        public static void TambahData(Jabatan jabatan)
        {
            string sql = "INSERT INTO Jabatan (IdJabatan, Nama) VALUES ('" + jabatan.IdJabatan + "', '" + jabatan.Nama.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Jabatan jabatan)
        {
            string sql = "UPDATE Jabatan SET Nama = '" + jabatan.Nama.Replace("'", "\\'") + "' WHERE IdJabatan = '" + jabatan.idJabatan + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Jabatan jabatan)
        {
            string sql = "DELETE FROM Jabatan WHERE IdJabatan = '" + jabatan.IdJabatan + "'";

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

        public static List<Jabatan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT * FROM Jabatan";
            }
            else
            {
                sql = "SELECT * FROM Jabatan WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Jabatan> listOfJabatan = new List<Jabatan>();

            while (hasil.Read() == true)
            {
                Jabatan jabatan = new Jabatan(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString());
                listOfJabatan.Add(jabatan);
            }

            return (listOfJabatan);
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(IdJabatan) FROM Jabatan";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                int kodeBaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilKode = kodeBaru.ToString().PadLeft(2, '0');
            }
            else
            {
                hasilKode = "01";
            }
            return (hasilKode);
        }
        #endregion
    }
}