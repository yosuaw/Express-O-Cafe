using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Express_O_LIB;

namespace Express_O_Cafe
{
    public partial class FormDaftarMenu : Form
    {
        List<Menus> listOfMenu = new List<Menus>();

        public FormDaftarMenu()
        {
            InitializeComponent();
        }

        private void FormatDatagrid()
        {
            dataGridViewDaftarMenu.Columns.Clear();

            dataGridViewDaftarMenu.Columns.Add("KodeMenu", "Kode Menu");
            dataGridViewDaftarMenu.Columns.Add("Nama", "Nama");
            dataGridViewDaftarMenu.Columns.Add("Harga", "Harga");
            dataGridViewDaftarMenu.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewDaftarMenu.Columns.Add("NamaKategori", "Nama Kategori");
            dataGridViewDaftarMenu.Columns.Add("Diskon", "Diskon");

            dataGridViewDaftarMenu.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarMenu.Columns["Diskon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarMenu.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarMenu.Columns["KodeMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMenu.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMenu.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMenu.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMenu.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMenu.Columns["Diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarMenu.AllowUserToAddRows = false;
            dataGridViewDaftarMenu.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarMenu.Rows.Clear();

            if (listOfMenu.Count > 0)
            {
                foreach (Menus menu in listOfMenu)
                {
                    dataGridViewDaftarMenu.Rows.Add(menu.KodeMenu, menu.Nama, menu.Harga, menu.Kategori.KodeKategori, menu.Kategori.Nama, menu.Diskon);
                }
            }
            else
            {
                dataGridViewDaftarMenu.DataSource = null;
            }
        }

        private void FormDaftarMenu_Load(object sender, EventArgs e)
        {
            FormatDatagrid();

            listOfMenu = Menus.BacaData("", "");

            TampilDataGrid();
        }

        private void textBoxDaftarMenu_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxDaftarMenu.Text == "Kode Menu")
            {
                kriteria = "m.KodeMenu";
            }
            else if (comboBoxDaftarMenu.Text == "Nama")
            {
                kriteria = "m.Nama";
            }
            else if (comboBoxDaftarMenu.Text == "Harga")
            {
                kriteria = "m.Harga";
            }
            else if (comboBoxDaftarMenu.Text == "Kode Kategori")
            {
                kriteria = "k.KodeKategori";
            }
            else if (comboBoxDaftarMenu.Text == "Nama Kategori")
            {
                kriteria = "k.Nama";
            }
            else if (comboBoxDaftarMenu.Text == "Diskon(%)")
            {
                kriteria = "m.Diskon";
            }

            listOfMenu = Menus.BacaData(kriteria, textBoxDaftarMenu.Text);

            TampilDataGrid();
        }
    }
}
