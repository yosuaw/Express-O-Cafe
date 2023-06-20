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
    public partial class FormHapusKategori : Form
    {
        List<Kategori> listOfKategori = new List<Kategori>();

        public FormHapusKategori()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data kategori akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Kategori kategori = new Kategori(int.Parse(textBoxKodeKategori.Text), textBoxNamaKategori.Text);

                string hasilTambah = Kategori.HapusData(kategori);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Kategori telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus kategori. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Clear();
            textBoxNamaKategori.Clear();
            textBoxKodeKategori.Focus();
        }

        private void FormHapusKategori_Load(object sender, EventArgs e)
        {
            textBoxKodeKategori.MaxLength = 2;
            textBoxNamaKategori.Enabled = false;
            textBoxKodeKategori.Focus();
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
    }
}
