using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;
using System.Transactions;

namespace Express_O_LIB
{
    public class Karyawan
    {
        private string kodeKaryawan;
        private string nama;
        private string alamat;
        private DateTime tanggalLahir;
        private int gaji;
        private string username;
        private string password;
        private Jabatan jabatan;

        #region Constructors
        public Karyawan(string kodeKaryawan, string nama, string alamat, DateTime tanggalLahir, int gaji, string username, string password, Jabatan jabatan)
        {
            this.KodeKaryawan = kodeKaryawan;
            this.Nama = nama;
            this.Alamat = alamat;
            this.TanggalLahir = tanggalLahir;
            this.Gaji = gaji;
            this.Username = username;
            this.Password = password;
            this.Jabatan = jabatan;
        }
        #endregion

        #region Properties
        public string KodeKaryawan { get => kodeKaryawan; set => kodeKaryawan = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TanggalLahir { get => tanggalLahir; set => tanggalLahir = value; }
        public int Gaji { get => gaji; set => gaji = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Jabatan Jabatan { get => jabatan; set => jabatan = value; }
        #endregion

        #region Methods
        public static void BuatUserBaru(Karyawan karyawan, string namaServer)
        {
            string sql = "CREATE USER '" + karyawan.Username + "'@'" + namaServer + "' IDENTIFIED BY '" + karyawan.Password + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahPasswordUser(Karyawan karyawan)
        {
            string namaServer = Koneksi.GetNamaServer();

            string sql = "SET PASSWORD FOR '" + karyawan.Username + "'@'" + namaServer + "'=PASSWORD('" + karyawan.Password + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusUser(Karyawan karyawan)
        {
            string namaServer = Koneksi.GetNamaServer();

            string sql = "DROP USER '" + karyawan.Username + "'@'" + namaServer + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void BeriHakAkses(Karyawan karyawan, string namaServer, string namaDatabase)
        {
            string sql = "GRANT ALL PRIVILEGES ON " + namaDatabase + ".* TO '" + karyawan.Username + "'@'" + namaServer + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void ManajemenUser(Karyawan karyawan)
        {
            string namaServer = Koneksi.GetNamaServer();
            string namaDatabase = Koneksi.GetNamaDatabase();

            Karyawan.BuatUserBaru(karyawan, namaServer);
            Karyawan.BeriHakAkses(karyawan, namaServer, namaDatabase);
        }

        public static void TambahData(Karyawan karyawan)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    ManajemenUser(karyawan);

                    string sql = "INSERT INTO Karyawan(KodeKaryawan, Nama, Alamat, TanggalLahir, Gaji, Username, Password, IdJabatan) VALUES ('" + karyawan.KodeKaryawan + "', '" + karyawan.Nama.Replace("'", "\\'") + "', '" + karyawan.Alamat + "', '" + karyawan.TanggalLahir.ToString("yyyy-MM-dd") + "', '" + karyawan.Gaji + "', '" + karyawan.Username + "', '" + karyawan.Password + "', '" + karyawan.Jabatan.IdJabatan + "')";

                    Koneksi.JalankanPerintahDML(sql);
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();

                    throw (new Exception("Penyimpanan data pegawai gagal. Pesan kesalahan: " + ex.Message));
                }
            }
        }

        public static void UbahData(Karyawan karyawan)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    UbahPasswordUser(karyawan);

                    string sql = "UPDATE Karyawan SET Nama = '" + karyawan.Nama.Replace("'", "\\'") + "', Alamat = '" + karyawan.Alamat + "', TanggalLahir = '" + karyawan.TanggalLahir.ToString("yyyy-MM-dd") + "', Gaji = '" + karyawan.Gaji + "', Username = '" + karyawan.Username + "', Password = '" + karyawan.Password + "', IdJabatan = '" + karyawan.Jabatan.IdJabatan + "' WHERE KodeKaryawan = '" + karyawan.KodeKaryawan + "'";

                    Koneksi.JalankanPerintahDML(sql);
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();

                    throw (new Exception("Pengubahan data pegawai gagal. Pesan kesalahan: " + ex.Message));
                }
            }
        }


        public static string HapusData(Karyawan karyawan)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    HapusUser(karyawan);

                    string sql = "DELETE FROM Karyawan WHERE KodeKaryawan = '" + karyawan.KodeKaryawan + "'";

                    Koneksi.JalankanPerintahDML(sql);
                    return ("1");
                }
                catch (MySqlException ex)
                {
                    return ("Pesan kesalahan: " + ex.Message);
                }
            }
        }

        public static List<Karyawan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT k.KodeKaryawan, k.Nama AS 'Nama Karyawan' , k.Alamat, k.TanggalLahir, k.Gaji, k.Username, k.Password, j.IdJabatan, j.Nama AS 'Nama Jabatan' FROM Karyawan k INNER JOIN Jabatan j ON k.IdJabatan = j.IdJabatan";
            }
            else
            {
                sql = "SELECT k.KodeKaryawan, k.Nama AS 'Nama Karyawan' , k.Alamat, k.TanggalLahir, k.Gaji, k.Username, k.Password, j.IdJabatan, j.Nama AS 'Nama Jabatan' FROM Karyawan k INNER JOIN Jabatan j ON k.IdJabatan = j.IdJabatan WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Karyawan> listOfKaryawan = new List<Karyawan>();

            while (hasil.Read() == true)
            {
                Jabatan jabatan = new Jabatan(int.Parse(hasil.GetValue(7).ToString()), hasil.GetValue(8).ToString());
                Karyawan karyawan = new Karyawan(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), (DateTime)hasil.GetValue(3), int.Parse(hasil.GetValue(4).ToString()), hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), jabatan);
                listOfKaryawan.Add(karyawan);
            }

            return (listOfKaryawan);
        }

        public static string GenerateKode(Jabatan jabatan)
        {
            string sql = "SELECT MAX(RIGHT(KodeKaryawan, 2)) FROM Karyawan WHERE IdJabatan = '" + jabatan.IdJabatan + "'";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilKode = jabatan.Nama.Substring(0, 1) + kodeTerbaru.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilKode = jabatan.Nama.Substring(0, 1) + "01";
                }
            }
            return (hasilKode);
        }
        #endregion
    }
}