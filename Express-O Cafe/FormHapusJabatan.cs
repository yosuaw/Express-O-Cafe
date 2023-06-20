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
    public partial class FormHapusJabatan : Form
    {
        List<Jabatan> listOfJabatan = new List<Jabatan>();

        public FormHapusJabatan()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data jabatan akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Jabatan jabatan = new Jabatan(int.Parse(textBoxIdJabatan.Text), textBoxNamaJabatan.Text);

                string hasilTambah = Jabatan.HapusData(jabatan);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Jabatan telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus jabatan. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdJabatan.Clear();
            textBoxNamaJabatan.Clear();
            textBoxIdJabatan.Focus();
        }

        private void FormHapusJabatan_Load(object sender, EventArgs e)
        {
            textBoxIdJabatan.MaxLength = 2;
            textBoxNamaJabatan.Enabled = false;
            textBoxIdJabatan.Focus();
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
