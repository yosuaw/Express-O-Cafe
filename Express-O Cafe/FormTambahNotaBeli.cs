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
    public partial class FormTambahNotaBeli : Form
    {
        FormMenu formMenu;
        List<Supplier> listOfSupplier = new List<Supplier>();
        List<Bahan> listOfBahan = new List<Bahan>();
        NotaBeli notaBeli;

        public FormTambahNotaBeli()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewNotaBeli.Columns.Clear();

            dataGridViewNotaBeli.Columns.Add("IdBahan", "ID");
            dataGridViewNotaBeli.Columns.Add("NamaBahan", "Nama Bahan");
            dataGridViewNotaBeli.Columns.Add("HargaBeli", "Harga Beli");
            dataGridViewNotaBeli.Columns.Add("Jumlah", "Jumlah");
            dataGridViewNotaBeli.Columns.Add("SubTotal", "SubTotal");

            dataGridViewNotaBeli.Columns["IdBahan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaBeli.Columns["NamaBahan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaBeli.Columns["HargaBeli"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaBeli.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaBeli.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewNotaBeli.Columns["HargaBeli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNotaBeli.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNotaBeli.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewNotaBeli.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
            dataGridViewNotaBeli.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            dataGridViewNotaBeli.AllowUserToAddRows = false;
            dataGridViewNotaBeli.ReadOnly = true;
        }

        private void HitungSubTotal()
        {
            int harga = int.Parse(labelHarga.Text);
            int jumlah = int.Parse(textBoxJumlah.Text);
            int subTotal = harga * jumlah;
            labelSubTotal.Text = subTotal.ToString("#,###");
        }

        private void FormTambahNotaBeli_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.ParentForm;
            textBoxNomorNota.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxID.MaxLength = 2;

            textBoxNomorNota.Text = NotaJual.GenerateNoNota(dateTimePickerTanggal.Value);
            labelNama.Text = formMenu.karyawanDipilih.Nama;
            dateTimePickerTanggal.Value = DateTime.Today;
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            listOfSupplier = Supplier.BacaData("", "");
            comboBoxSupplier.DataSource = listOfSupplier;
            comboBoxSupplier.DisplayMember = "Nama";

            listOfBahan = Bahan.BacaData("", "");
            comboBoxNamaBahan.DataSource = listOfBahan;
            comboBoxNamaBahan.DisplayMember = "Nama";

            FormatDataGrid();
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupplier.SelectedIndex != -1)
            {
                Supplier supplier = (Supplier)comboBoxSupplier.SelectedItem;
                textBoxAlamat.Text = supplier.Alamat;
            }
            else
            {
                labelAlamat.Text = "";
            }
        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {
            textBoxNomorNota.Text = NotaBeli.GenerateNoNota(dateTimePickerTanggal.Value);
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == textBoxID.MaxLength)
            {
                if (textBoxID.Text.Substring(0, 1) == "0")
                {
                    listOfBahan = Bahan.BacaData("IdBahan", textBoxID.Text.Substring(1, 1));                  
                }
                else
                {
                    listOfBahan = Bahan.BacaData("IdBahan", textBoxID.Text);
                }

                if (listOfBahan.Count > 0)
                {
                    comboBoxNamaBahan.DataSource = listOfBahan;
                    comboBoxNamaBahan.DisplayMember = "Nama";
                    comboBoxNamaBahan.SelectedItem = comboBoxNamaBahan.FindStringExact(listOfSupplier[0].Nama);
                    labelHarga.Text = listOfBahan[0].Harga.ToString();
                    textBoxJumlah.Text = "1";

                    textBoxJumlah.Focus();
                }
                else
                {
                    MessageBox.Show("Bahan dengan kode tersebut tidak ditemukan");
                }
            }
        }
        private int HitungGrandTotal()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewNotaBeli.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewNotaBeli.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal += subTotal;
            }
            return grandTotal;
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int subTotal = int.Parse(textBoxJumlah.Text) * int.Parse(labelHarga.Text);

                dataGridViewNotaBeli.Rows.Add(textBoxID.Text, comboBoxNamaBahan.Text, labelHarga.Text, textBoxJumlah.Text, subTotal);

                labelGrandTotal.Text = HitungGrandTotal().ToString("#,###");

                listOfBahan = Bahan.BacaData("Nama", comboBoxNamaBahan.Text);

                if (listOfBahan.Count > 0)
                {
                    textBoxID.Text = listOfBahan[0].IdBahan.ToString();
                }

                comboBoxNamaBahan.SelectedIndex = 0;
                textBoxJumlah.Text = "1";
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplierDipilih = (Supplier)comboBoxSupplier.SelectedItem;
                Karyawan karyawanDipilih = formMenu.karyawanDipilih;
                notaBeli = new NotaBeli(textBoxNomorNota.Text, dateTimePickerTanggal.Value, supplierDipilih, karyawanDipilih);
                List<Bahan> listOfBahan = new List<Bahan>();

                for (int i = 0; i < dataGridViewNotaBeli.Rows.Count; i++)
                {
                    string idBahan = dataGridViewNotaBeli.Rows[i].Cells["IdBahan"].Value.ToString();
                    int harga = int.Parse(dataGridViewNotaBeli.Rows[i].Cells["HargaBeli"].Value.ToString());
                    int jumlah = int.Parse(dataGridViewNotaBeli.Rows[i].Cells["Jumlah"].Value.ToString());
                    listOfBahan = Bahan.BacaData("IdBahan", idBahan);
                    notaBeli.TambahDetilNotaBeli(harga, jumlah, listOfBahan[0]);
                }

                NotaBeli.TambahData(notaBeli);

                MessageBox.Show("Data nota beli telah tersimpan.", "Informasi");

                try
                {
                    NotaBeli.CetakNota("NomorNota", textBoxNomorNota.Text, "nota_beli.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota beli telah tercetak");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nota beli gagal dicetak. Pesan kesalahan : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nota. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void comboBoxNamaBahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("Bahan.Nama", comboBoxNamaBahan.Text);

            if (listOfBahan.Count > 0)
            {
                textBoxID.Text = listOfBahan[0].IdBahan.ToString();
                labelHarga.Text = listOfBahan[0].Harga.ToString();
                textBoxJumlah.Text = "1";

                HitungSubTotal();
                textBoxJumlah.Focus();
            }
        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJumlah.Text == "" || int.Parse(textBoxJumlah.Text) <= 0)
                {
                    textBoxJumlah.Text = "1";
                    textBoxID.Focus();
                    textBoxJumlah.Focus();
                }

                HitungSubTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void comboBoxNamaBahan_TextChanged(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("Bahan.Nama", comboBoxNamaBahan.Text);

            comboBoxNamaBahan.DataSource = listOfBahan;
            comboBoxNamaBahan.DisplayMember = "Nama";
        }
    }
}
