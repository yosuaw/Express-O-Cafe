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
    public partial class FormUbahKategori : Form
    {
        List<Kategori> listOfKategori = new List<Kategori>();

        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(int.Parse(textBoxKodeKategori.Text), textBoxNamaKategori.Text);

                Kategori.UbahData(kategori);

                MessageBox.Show("Data kategori telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            textBoxKodeKategori.MaxLength = 2;
            textBoxNamaKategori.MaxLength = 30;
        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            listOfKategori = Kategori.BacaData("KodeKategori", textBoxKodeKategori.Text);

            if (listOfKategori.Count > 0)
            {
                textBoxNamaKategori.Text = listOfKategori[0].Nama;
                textBoxNamaKategori.Focus();
            }
            else
            {
                MessageBox.Show("Kode Kategori tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaKategori.Clear();
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Clear();
            textBoxNamaKategori.Clear();
            textBoxKodeKategori.Focus();
        }
    }
}
