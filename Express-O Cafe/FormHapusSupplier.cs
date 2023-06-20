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
    public partial class FormHapusSupplier : Form
    {
        List<Supplier> listofSupplier = new List<Supplier>();
        public FormHapusSupplier()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data supplier akan terhapus. Apakah Anda yakin? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Supplier s = new Supplier(int.Parse(textBoxIdSupplier.Text), textBoxNamaSupplier.Text, textBoxAlamatSupplier.Text, textBoxNomorTeleponSupplier.Text);

                string hasilTambah = Supplier.HapusData(s);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Supplier telah dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus supplier. Pesan Kesalahan : " + hasilTambah, "Kesalahan",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void FormHapusSupplier_Load(object sender, EventArgs e)
        {
            textBoxIdSupplier.MaxLength = 11;
            textBoxNamaSupplier.MaxLength = 30;
            textBoxAlamatSupplier.MaxLength = 15;
            textBoxNomorTeleponSupplier.MaxLength = 15;
            textBoxNamaSupplier.Enabled = false;
            textBoxAlamatSupplier.Enabled = false;
            textBoxNomorTeleponSupplier.Enabled = false;
        }

        private void textBoxIdSupplier_TextChanged(object sender, EventArgs e)
        {
            listofSupplier = Supplier.BacaData("IdSupplier", textBoxIdSupplier.Text);
            if (listofSupplier.Count > 0)
            {
                textBoxNamaSupplier.Text = listofSupplier[0].Nama;
                textBoxAlamatSupplier.Text = listofSupplier[0].Alamat;
                textBoxNomorTeleponSupplier.Text = listofSupplier[0].NoTelepon;
            }
            else
            {
                MessageBox.Show("Id supplier tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNamaSupplier.Text = "";
                textBoxAlamatSupplier.Text = "";
                textBoxNomorTeleponSupplier.Text = "";
            }
        }
    }
}
