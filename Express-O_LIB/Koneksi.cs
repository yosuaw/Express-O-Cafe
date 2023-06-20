using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Express_O_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Constructors
        public Koneksi()
        {
            this.KoneksiDB = new MySqlConnection();

            this.KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            this.Connect();
        }

        public Koneksi(string pUsername, string pPassword)
        {
            string strCon = "";
            if (pPassword != "")
            {
                strCon = "Server=localhost;Database=express_o_cafe;Uid=" + pUsername + ";Pwd=" + pPassword + ";CharSet=utf8;";
            }
            else
            {
                strCon = "Server=localhost;Database=express_o_cafe;Uid=" + pUsername + ";CharSet=utf8;";
            }

            this.KoneksiDB = new MySqlConnection();

            this.KoneksiDB.ConnectionString = strCon;

            this.Connect();

            this.UpdateAppConfig(strCon);
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }

            KoneksiDB.Open();
        }

        public void UpdateAppConfig(string con)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;

            configuration.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();

            k.Connect();

            using (MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB))
            {
                c.ExecuteNonQuery();
            }

            k.KoneksiDB.Close();
        }

        public static DataTableReader JalankanPerintahQuery(string sql)
        {
            Koneksi koneksi = new Koneksi();

            using (MySqlCommand c = new MySqlCommand(sql, koneksi.KoneksiDB))
            {
                DataTableReader dataTable;
                using (MySqlDataReader hasil = c.ExecuteReader())
                {
                    DataTable data = new DataTable();
                    data.Load(hasil);
                    dataTable = data.CreateDataReader();
                }
                koneksi.Connect();

                return dataTable;
            }
        }

        public static string GetNamaServer()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return (connection.DataSource);
        }

        public static string GetNamaDatabase()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return (connection.Database);
        }
        #endregion
    }
}
