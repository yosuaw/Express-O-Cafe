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
    public partial class FormUbahSupplier : Form
    {
        List<Supplier> listOfSupplier = new List<Supplier>();
        public FormUbahSupplier()
        {
            InitializeComponent();
        }

        private void FormUbahSupplier_Load(object sender, EventArgs e)
        {
            textBoxIdSupplier.MaxLength = 11;
            textBoxNamaSupplier.MaxLength = 30;
            textBoxAlamatSupplier.MaxLength = 15;
            textBoxNomorTeleponSupplier.MaxLength = 15;
        }

        private void textBoxIdSupplier_TextChanged(object sender, EventArgs e)
        {
            listOfSupplier = Supplier.BacaData("IdSupplier", textBoxIdSupplier.Text);
            if (listOfSupplier.Count > 0)
            {
                textBoxNamaSupplier.Text = listOfSupplier[0].Nama;
                textBoxAlamatSupplier.Text = listOfSupplier[0].Alamat;
                textBoxNomorTeleponSupplier.Text = listOfSupplier[0].NoTelepon;
            }
            else
            {
                MessageBox.Show("Id supplier tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaSupplier.Text = "";
                textBoxAlamatSupplier.Text = "";
                textBoxNomorTeleponSupplier.Text = "";
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier s = new Supplier(int.Parse(textBoxIdSupplier.Text), textBoxNamaSupplier.Text, textBoxAlamatSupplier.Text, textBoxNomorTeleponSupplier.Text);

                Supplier.UbahData(s);

                MessageBox.Show("Data supplier telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamatSupplier.Text = "";
            textBoxNomorTeleponSupplier.Text = "";
            textBoxIdSupplier.Focus();
        }
    }
}
