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
    public partial class FormDaftarJabatan : Form
    {
        List<Jabatan> listOfJabatan = new List<Jabatan>();

        public FormDaftarJabatan()
        {
            InitializeComponent();
        }

        private void FormDaftarJabatan_Load(object sender, EventArgs e)
        {
            listOfJabatan = Jabatan.BacaData("", "");

            if (listOfJabatan.Count > 0)
            {
                dataGridViewDaftarJabatan.DataSource = listOfJabatan;
            }
            else
            {
                dataGridViewDaftarJabatan.DataSource = null;
            }

            dataGridViewDaftarJabatan.AllowUserToAddRows = false;
            dataGridViewDaftarJabatan.ReadOnly = true;
        }

        private void textBoxDaftarJabatan_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftarJabatan.Text == "Id Jabatan")
            {
                listOfJabatan = Jabatan.BacaData("IdJabatan", textBoxDaftarJabatan.Text);
            }
            else if (comboBoxDaftarJabatan.Text == "Nama")
            {
                listOfJabatan = Jabatan.BacaData("Nama", textBoxDaftarJabatan.Text);
            }

            if (listOfJabatan.Count > 0)
            {
                dataGridViewDaftarJabatan.DataSource = listOfJabatan;
            }
            else
            {
                dataGridViewDaftarJabatan.DataSource = null;
            }
        }
    }
}
