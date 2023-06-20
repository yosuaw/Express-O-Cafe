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
    public partial class FormHapusBahan : Form
    {
        List<Bahan> listOfBahan = new List<Bahan>();
        public FormHapusBahan()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data bahan akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Bahan bahan = new Bahan(int.Parse(textBoxIdBahan.Text), textBoxNamaBahan.Text, int.Parse(textBoxStokBahan.Text), int.Parse(textBoxHargaBahan.Text));

                string hasilTambah = Bahan.HapusData(bahan);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Bahan telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus bahan. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void FormHapusBahan_Load(object sender, EventArgs e)
        {
            textBoxIdBahan.MaxLength = 4;
            textBoxNamaBahan.MaxLength = 30;
            textBoxStokBahan.MaxLength = 11;
            textBoxHargaBahan.MaxLength = 11;
            textBoxNamaBahan.Enabled = false;
            textBoxStokBahan.Enabled = false;
            textBoxHargaBahan.Enabled = false;
            textBoxIdBahan.Focus();
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
                textBoxIdBahan.Clear();
            }
        }
    }
}
