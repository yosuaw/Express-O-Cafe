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
    public partial class FormTambahJabatan : Form
    {
        public FormTambahJabatan()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
           
            try
            {
                Jabatan jabatan = new Jabatan(int.Parse(textBoxIdJabatan.Text), textBoxNamaJabatan.Text);

                Jabatan.TambahData(jabatan);

                MessageBox.Show("Data jabatan telah tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahJabatan_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaJabatan.Clear();
            textBoxNamaJabatan.Focus();
        }

        private void FormTambahJabatan_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Jabatan.GenerateKode();

            textBoxIdJabatan.Text = kodeTerbaru;
            textBoxIdJabatan.Enabled = false;
            textBoxNamaJabatan.MaxLength = 30;
            textBoxNamaJabatan.Focus();
        }
    }
}
