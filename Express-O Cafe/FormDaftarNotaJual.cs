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
    public partial class FormDaftarNotaJual : Form
    {
        List<NotaJual> listOfNotaJual = new List<NotaJual>();
        string kriteria = "";
        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarNotaJual.Columns.Clear();

            dataGridViewDaftarNotaJual.Columns.Add("NomorNota", "No Nota");
            dataGridViewDaftarNotaJual.Columns.Add("Tanggal", "Tanggal");
            dataGridViewDaftarNotaJual.Columns.Add("IdMember", "ID Member");
            dataGridViewDaftarNotaJual.Columns.Add("NamaMember", "Nama Member");
            dataGridViewDaftarNotaJual.Columns.Add("AlamatMember", "Alamat Member");
            dataGridViewDaftarNotaJual.Columns.Add("KodeKaryawan", "Kode Karyawan");
            dataGridViewDaftarNotaJual.Columns.Add("NamaKaryawan", "Nama Karyawan");
            dataGridViewDaftarNotaJual.Columns.Add("MetodePembayaran", "Metode Bayar");
            dataGridViewDaftarNotaJual.Columns.Add("KodeMenu", "Kode Menu");
            dataGridViewDaftarNotaJual.Columns.Add("NamaMenu", "Nama Menu");
            dataGridViewDaftarNotaJual.Columns.Add("Harga", "Harga");
            dataGridViewDaftarNotaJual.Columns.Add("Jumlah", "Jumlah");

            dataGridViewDaftarNotaJual.Columns["NomorNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["IdMember"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["NamaMember"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["AlamatMember"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["KodeKaryawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["Namakaryawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["MetodePembayaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["Kodemenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["NamaMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarNotaJual.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarNotaJual.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarNotaJual.AllowUserToAddRows = false;
            dataGridViewDaftarNotaJual.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarNotaJual.Rows.Clear();

            if (listOfNotaJual.Count > 0)
            {
                foreach (NotaJual notaJuals in listOfNotaJual)
                {
                    foreach (DetilNotaJual detilNotaJual in notaJuals.ListOfDetilNotaJual)
                    {
                        dataGridViewDaftarNotaJual.Rows.Add(notaJuals.NomorNota, notaJuals.Tanggal, notaJuals.Member.IdMember, notaJuals.Member.Nama, notaJuals.Member.Alamat, notaJuals.Karyawan.KodeKaryawan, notaJuals.Karyawan.Nama, notaJuals.MetodePembayaran, detilNotaJual.Menu.KodeMenu, detilNotaJual.Menu.Nama, detilNotaJual.Harga, detilNotaJual.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewDaftarNotaJual.DataSource = null;
            }
        }

        public void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listOfNotaJual = NotaJual.BacaData("", "");
            TampilDataGrid();
        }

        private void textBoxDaftarNotaJual_TextChanged(object sender, EventArgs e)
        {
            kriteria = textBoxDaftarNotaJual.Text;
            if (comboBoxDaftarNotaJual.Text == "Nomor Nota")
            {
                kriteria = "n.NomorNota";
            }
            else if (comboBoxDaftarNotaJual.Text == "Tanggal")
            {
                kriteria = "n.Tanggal";
            }
            else if (comboBoxDaftarNotaJual.Text == "ID Member")
            {
                kriteria = "n.IdMember";
            }
            else if (comboBoxDaftarNotaJual.Text == "Nama Member")
            {
                kriteria = "m.Nama";
            }
            else if (comboBoxDaftarNotaJual.Text == "Alamat Member")
            {
                kriteria = "m.Alamat";
            }
            else if (comboBoxDaftarNotaJual.Text == "Kode Karyawan")
            {
                kriteria = "n.KodeKaryawan";
            }
            else if (comboBoxDaftarNotaJual.Text == "Nama Karyawan")
            {
                kriteria = "k.Nama";
            }
            else if (comboBoxDaftarNotaJual.Text == "Metode Pembayaran")
            {
                kriteria = "n.MetodePembayaran";
            }
            listOfNotaJual = NotaJual.BacaData(kriteria, textBoxDaftarNotaJual.Text);
            this.TampilDataGrid();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota(kriteria, textBoxDaftarNotaJual.Text, "daftar_nota_jual.txt", new Font("Courier New", 12));

                MessageBox.Show("Daftar nota jual berhasil dicetak", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar nota jual gagal dicetak. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
