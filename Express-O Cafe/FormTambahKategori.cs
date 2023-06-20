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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Kategori.GenerateKode();

            textBoxKodeKategori.Text = kodeTerbaru;
            textBoxKodeKategori.Enabled = false;
            textBoxNamaKategori.MaxLength = 30;
            textBoxNamaKategori.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(int.Parse(textBoxKodeKategori.Text), textBoxNamaKategori.Text);

                Kategori.TambahData(kategori);

                MessageBox.Show("Data kategori telah tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahKategori_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaKategori.Clear();
            textBoxNamaKategori.Focus();
        }
    }
}
