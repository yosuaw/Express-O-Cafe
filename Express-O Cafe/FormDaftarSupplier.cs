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
    public partial class FormDaftarSupplier : Form
    {
        List<Supplier> listOfSupplier = new List<Supplier>();

        public FormDaftarSupplier()
        {
            InitializeComponent();
        }

        private void FormDaftarSupplier_Load(object sender, EventArgs e)
        {
            listOfSupplier = Supplier.BacaData("", "");

            if (listOfSupplier.Count > 0)
            {
                dataGridViewDaftarSupplier.DataSource = listOfSupplier;
            }
            else
            {
                dataGridViewDaftarSupplier.DataSource = null;
            }

            dataGridViewDaftarSupplier.AllowUserToAddRows = false;
            dataGridViewDaftarSupplier.ReadOnly = true;
        }

        private void textBoxDaftarSupplier_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftarSupplier.Text == "Id Supplier")
            {
                listOfSupplier = Supplier.BacaData("IdSupplier", textBoxDaftarSupplier.Text);
            }
            else if (comboBoxDaftarSupplier.Text == "Nama")
            {
                listOfSupplier = Supplier.BacaData("Nama", textBoxDaftarSupplier.Text);
            }
            else if (comboBoxDaftarSupplier.Text == "Alamat")
            {
                listOfSupplier = Supplier.BacaData("Alamat", textBoxDaftarSupplier.Text);
            }
            else if (comboBoxDaftarSupplier.Text == "Nomor Telepon")
            {
                listOfSupplier = Supplier.BacaData("NoTelepon", textBoxDaftarSupplier.Text);
            }

            if (listOfSupplier.Count > 0)
            {
                dataGridViewDaftarSupplier.DataSource = listOfSupplier;
            }
            else
            {
                dataGridViewDaftarSupplier.DataSource = null;
            }
        }
    }
}
