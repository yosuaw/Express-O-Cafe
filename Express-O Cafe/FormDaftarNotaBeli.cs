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
    public partial class FormDaftarNotaBeli : Form
    {
        List<NotaBeli> listOfNotaBeli = new List<NotaBeli>();
        string kriteria = "";
        public FormDaftarNotaBeli()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarNotaBeli.Columns.Clear();

            dataGridViewDaftarNotaBeli.Columns.Add("NomorNota", "No Nota");
            dataGridViewDaftarNotaBeli.Columns.Add("Tanggal", "Tanggal");
            dataGridViewDaftarNotaBeli.Columns.Add("IdSupplier", "ID Supplier");
            dataGridViewDaftarNotaBeli.Columns.Add("NamaSupplier", "Nama Supplier");
            dataGridViewDaftarNotaBeli.Columns.Add("AlamatSupplier", "Alamat Supplier");
            dataGridViewDaftarNotaBeli.Columns.Add("KodeKaryawan", "Kode Karyawan");
            dataGridViewDaftarNotaBeli.Columns.Add("NamaKaryawan", "Nama Karyawan");
            dataGridViewDaftarNotaBeli.Columns.Add("IdBahan", "Kode Bahan");
            dataGridViewDaftarNotaBeli.Columns.Add("NamaBahan", "Nama Bahan");
            dataGridViewDaftarNotaBeli.Columns.Add("Harga", "Harga");
            dataGridViewDaftarNotaBeli.Columns.Add("Jumlah", "Jumlah");

            dataGridViewDaftarNotaBeli.Columns["NomorNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["IdSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["NamaSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["AlamatSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["KodeKaryawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["Namakaryawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["IdBahan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["NamaBahan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaBeli.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarNotaBeli.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarNotaBeli.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarNotaBeli.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarNotaBeli.AllowUserToAddRows = false;
            dataGridViewDaftarNotaBeli.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarNotaBeli.Rows.Clear();

            if (listOfNotaBeli.Count > 0)
            {
                foreach (NotaBeli notaBelis in listOfNotaBeli)
                {
                    foreach (DetilNotaBeli detilNotaBeli in notaBelis.ListDetilNotaBeli)
                    {
                        dataGridViewDaftarNotaBeli.Rows.Add(notaBelis.NomorNota, notaBelis.Tanggal, notaBelis.Supplier.IdSupplier, notaBelis.Supplier.Nama, notaBelis.Supplier.Alamat, notaBelis.Karyawan.KodeKaryawan, notaBelis.Karyawan.Nama, detilNotaBeli.Bahan.IdBahan, detilNotaBeli.Bahan.Nama, detilNotaBeli.Harga, detilNotaBeli.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewDaftarNotaBeli.DataSource = null;
            }
        }

        public void FormDaftarNotaBeli_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listOfNotaBeli = NotaBeli.BacaData("", "");
            TampilDataGrid();
        }

        private void textBoxDaftarNotaBeli_TextChanged(object sender, EventArgs e)
        {
            kriteria = textBoxDaftarNotaBeli.Text;
            if (comboBoxDaftarNotaBeli.Text == "Nomor Nota")
            {
                kriteria = "n.NomorNota";
            }
            else if (comboBoxDaftarNotaBeli.Text == "Tanggal")
            {
                kriteria = "n.Tanggal";
            }
            else if (comboBoxDaftarNotaBeli.Text == "ID Supplier")
            {
                kriteria = "n.IdSupplier";
            }
            else if (comboBoxDaftarNotaBeli.Text == "Nama Supplier")
            {
                kriteria = "s.Nama";
            }
            else if (comboBoxDaftarNotaBeli.Text == "Alamat Supplier")
            {
                kriteria = "s.Alamat";
            }
            else if (comboBoxDaftarNotaBeli.Text == "Kode Karyawan")
            {
                kriteria = "n.KodeKaryawan";
            }
            else if (comboBoxDaftarNotaBeli.Text == "Nama Karyawan")
            {
                kriteria = "k.Nama";
            }
            listOfNotaBeli = NotaBeli.BacaData(kriteria, textBoxDaftarNotaBeli.Text);
            this.TampilDataGrid();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaBeli.CetakNota(kriteria, textBoxDaftarNotaBeli.Text, "daftar_nota_beli.txt", new Font("Courier New", 12));

                MessageBox.Show("Daftar nota beli berhasil dicetak", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar nota beli gagal dicetak. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
