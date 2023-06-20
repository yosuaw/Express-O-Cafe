using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Express_O_LIB
{
    public class Member
    {
        private string idMember;
        private string nama;
        private string alamat;
        private string noTelepon;

        #region Constructors
        public Member(string idMember, string nama, string alamat, string noTelepon)
        {
            this.IdMember = idMember;
            this.Nama = nama;
            this.Alamat = alamat;
            this.NoTelepon = noTelepon;
        }
        #endregion

        #region Properties
        public string IdMember { get => idMember; set => idMember = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string NoTelepon { get => noTelepon; set => noTelepon = value; }
        #endregion

        #region Methods
        public static void TambahData(Member member)
        {
            string sql = "INSERT INTO Member (IdMember, Nama, Alamat, NoTelepon) VALUES ('" + member.IdMember + "', '" + member.Nama.Replace("'", "\\'") + "', '" + member.Alamat + "', '" + member.NoTelepon + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Member member)
        {
            string sql = "UPDATE Member SET Nama = '" + member.Nama.Replace("'", "\\'") + "', Alamat = '" + member.Alamat + "', NoTelepon = '" + member.NoTelepon + "' WHERE IdMember = '" + member.IdMember + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static string HapusData(Member member)
        {
            string sql = "DELETE FROM Member WHERE IdMember = '" + member.IdMember + "'";

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

        public static List<Member> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "SELECT * FROM Member";
            }
            else
            {
                sql = "SELECT * FROM Member WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Member> listOfMember = new List<Member>();

            while (hasil.Read() == true)
            {
                Member member = new Member(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                listOfMember.Add(member);
            }

            return (listOfMember);
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(IdMember) FROM Member";

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
        #endregion
    }
}