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
    public partial class FormDaftarKategori : Form
    {
        public List<Kategori> listOfKategori = new List<Kategori>();

        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        private void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            listOfKategori = Kategori.BacaData("", "");

            if (listOfKategori.Count > 0)
            {
                dataGridViewDaftarKategori.DataSource = listOfKategori;
            }
            else
            {
                dataGridViewDaftarKategori.DataSource = null;
            }

            dataGridViewDaftarKategori.AllowUserToAddRows = false;
            dataGridViewDaftarKategori.ReadOnly = true;
        }

        private void textBoxDaftarKategori_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftarKategori.Text == "Kode Kategori")
            {
                listOfKategori = Kategori.BacaData("KodeKategori", textBoxDaftarKategori.Text);
            }
            else if (comboBoxDaftarKategori.Text == "Nama Kategori")
            {
                listOfKategori = Kategori.BacaData("Nama", textBoxDaftarKategori.Text);
            }

            if (listOfKategori.Count > 0)
            {
                dataGridViewDaftarKategori.DataSource = listOfKategori;
            }
            else
            {
                dataGridViewDaftarKategori.DataSource = null;
            }
        }
    }
}
