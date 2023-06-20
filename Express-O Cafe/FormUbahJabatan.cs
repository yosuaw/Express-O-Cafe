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
    public partial class FormUbahJabatan : Form
    {
        List<Jabatan> listOfJabatan = new List<Jabatan>();

        public FormUbahJabatan()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Jabatan jabatan = new Jabatan(int.Parse(textBoxIdJabatan.Text), textBoxNamaJabatan.Text);

                Jabatan.UbahData(jabatan);

                MessageBox.Show("Data jabatan telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdJabatan.Clear();
            textBoxNamaJabatan.Clear();
            textBoxIdJabatan.Focus();
        }

        private void FormUbahJabatan_Load(object sender, EventArgs e)
        {
            textBoxIdJabatan.MaxLength = 2;
            textBoxNamaJabatan.MaxLength = 30;
        }

        private void textBoxIdJabatan_TextChanged(object sender, EventArgs e)
        {
            listOfJabatan = Jabatan.BacaData("IdJabatan", textBoxIdJabatan.Text);

            if (listOfJabatan.Count > 0)
            {
                textBoxNamaJabatan.Text = listOfJabatan[0].Nama;
                textBoxNamaJabatan.Focus();
            }
            else
            {
                MessageBox.Show("Id Jabatan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaJabatan.Clear();
            }
        }
    }
}
