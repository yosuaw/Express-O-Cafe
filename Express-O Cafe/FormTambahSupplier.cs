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
    public partial class FormTambahSupplier : Form
    {
        public FormTambahSupplier()
        {
            InitializeComponent();
        }

        private void FormTambahSupplier_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Supplier.GenerateKode();

            textBoxIdSupplier.Text = kodeTerbaru;
            textBoxIdSupplier.Enabled = false;
            textBoxNamaSupplier.Focus();
            textBoxNamaSupplier.MaxLength = 30;
            textBoxAlamatSupplier.MaxLength = 15;
            textBoxNomorTeleponSupplier.MaxLength = 15;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier s = new Supplier(int.Parse(textBoxIdSupplier.Text), textBoxNamaSupplier.Text, textBoxAlamatSupplier.Text, textBoxNomorTeleponSupplier.Text);

                Supplier.TambahData(s);

                MessageBox.Show("Data supplier tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahSupplier_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamatSupplier.Text = "";
            textBoxNomorTeleponSupplier.Text = "";
            FormTambahSupplier_Load(buttonKosongi, e);
        }
    }
}
