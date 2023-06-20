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
    public partial class FormDaftarBahan : Form
    {
        List<Bahan> listOfBahan = new List<Bahan>();

        public FormDaftarBahan()
        {
            InitializeComponent();
        }

        private void FormDaftarBahan_Load(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("", "");

            if (listOfBahan.Count > 0)
            {
                dataGridViewDaftarBahan.DataSource = listOfBahan;
            }
            else
            {
                dataGridViewDaftarBahan.DataSource = null;
            }

            dataGridViewDaftarBahan.AllowUserToAddRows = false;
            dataGridViewDaftarBahan.ReadOnly = true;
        }

        private void textBoxDaftarBahan_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftarBahan.Text == "Id Bahan")
            {
                listOfBahan = Bahan.BacaData("IdBahan", textBoxDaftarBahan.Text);
            }
            else if (comboBoxDaftarBahan.Text == "Nama")
            {
                listOfBahan = Bahan.BacaData("Nama", textBoxDaftarBahan.Text);
            }
            else if (comboBoxDaftarBahan.Text == "Stok")
            {
                listOfBahan = Bahan.BacaData("Stok", textBoxDaftarBahan.Text);
            }
            else if (comboBoxDaftarBahan.Text == "Harga")
            {
                listOfBahan = Bahan.BacaData("Harga", textBoxDaftarBahan.Text);
            }


            if (listOfBahan.Count > 0)
            {
                dataGridViewDaftarBahan.DataSource = listOfBahan;
            }
            else
            {
                dataGridViewDaftarBahan.DataSource = null;
            }
        }
    }
}
