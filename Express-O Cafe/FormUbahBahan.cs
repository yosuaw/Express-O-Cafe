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
    public partial class FormUbahBahan : Form
    {
        List<Bahan> listOfBahan = new List<Bahan>();

        public FormUbahBahan()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Bahan bahan = new Bahan(int.Parse(textBoxIdBahan.Text), textBoxNamaBahan.Text, int.Parse(textBoxStokBahan.Text), int.Parse(textBoxHargaBahan.Text));

                Bahan.UbahData(bahan);

                MessageBox.Show("Data bahan telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUbahBahan_Load(object sender, EventArgs e)
        {
            textBoxIdBahan.MaxLength = 4;
            textBoxNamaBahan.MaxLength = 30;
            textBoxStokBahan.MaxLength = 11;
            textBoxHargaBahan.MaxLength = 11;
        }

        private void textBoxIdBahan_TextChanged(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("IdBahan", textBoxIdBahan.Text);

            if (listOfBahan.Count > 0)
            {
                textBoxNamaBahan.Text = listOfBahan[0].Nama;
                textBoxStokBahan.Text = listOfBahan[0].Stok.ToString();
                textBoxHargaBahan.Text = listOfBahan[0].Harga.ToString();
                textBoxNamaBahan.Focus();
            }
            else
            {
                MessageBox.Show("Id Bahan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaBahan.Clear();
                textBoxStokBahan.Clear();
                textBoxHargaBahan.Clear();
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdBahan.Clear();
            textBoxNamaBahan.Clear();
            textBoxStokBahan.Clear();
            textBoxHargaBahan.Clear();
            textBoxIdBahan.Focus();
        }
    }
}
