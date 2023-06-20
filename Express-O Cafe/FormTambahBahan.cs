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
    public partial class FormTambahBahan : Form
    {
        public FormTambahBahan()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Bahan bahan = new Bahan(int.Parse(textBoxIdBahan.Text), textBoxNamaBahan.Text, int.Parse(textBoxStokBahan.Text), int.Parse(textBoxHargaBahan.Text));

                Bahan.TambahData(bahan);

                MessageBox.Show("Data bahan telah tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahBahan_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaBahan.Clear();
            textBoxStokBahan.Clear();
            textBoxHargaBahan.Clear();
            textBoxNamaBahan.Focus();
        }

        private void FormTambahBahan_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Bahan.GenerateKode();

            textBoxIdBahan.Text = kodeTerbaru;
            textBoxIdBahan.Enabled = false;
            textBoxNamaBahan.MaxLength = 30;
            textBoxNamaBahan.Focus();
        }
    }
}
