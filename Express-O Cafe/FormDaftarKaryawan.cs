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
    public partial class FormDaftarKaryawan : Form
    {
        List<Karyawan> listOfKaryawan = new List<Karyawan>();

        public FormDaftarKaryawan()
        {
            InitializeComponent();
        }

        private void FormatDatagrid()
        {
            dataGridViewDaftarKaryawan.Columns.Clear();

            dataGridViewDaftarKaryawan.Columns.Add("KodeKaryawan", "Kode Karyawan");
            dataGridViewDaftarKaryawan.Columns.Add("Nama", "Nama");
            dataGridViewDaftarKaryawan.Columns.Add("Alamat", "Alamat");
            dataGridViewDaftarKaryawan.Columns.Add("TanggalLahir", "Tanggal Lahir");
            dataGridViewDaftarKaryawan.Columns.Add("Gaji", "Gaji");
            dataGridViewDaftarKaryawan.Columns.Add("Username", "Username");
            dataGridViewDaftarKaryawan.Columns.Add("IdJabatan", "Id Jabatan");
            dataGridViewDaftarKaryawan.Columns.Add("NamaJabatan", "Nama Jabatan");

            dataGridViewDaftarKaryawan.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarKaryawan.Columns["Gaji"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarKaryawan.Columns["KodeKaryawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["TanggalLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["Gaji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["IdJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKaryawan.Columns["NamaJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarKaryawan.AllowUserToAddRows = false;
            dataGridViewDaftarKaryawan.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarKaryawan.Rows.Clear();

            if (listOfKaryawan.Count > 0)
            {
                foreach (Karyawan karyawan in listOfKaryawan)
                {
                    dataGridViewDaftarKaryawan.Rows.Add(karyawan.KodeKaryawan, karyawan.Nama, karyawan.Alamat, karyawan.TanggalLahir,
                    karyawan.Gaji, karyawan.Username, karyawan.Jabatan.IdJabatan, karyawan.Jabatan.Nama);
                }
            }
            else
            {
                dataGridViewDaftarKaryawan.DataSource = null;
            }
        }

        private void FormDaftarKaryawan_Load(object sender, EventArgs e)
        {
            FormatDatagrid();

            listOfKaryawan = Karyawan.BacaData("", "");

            TampilDataGrid();
        }

        private void textBoxDaftarKaryawan_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxDaftarKaryawan.Text == "Kode Karyawan")
            {
                kriteria = "k.KodeKaryawan";
            }
            else if (comboBoxDaftarKaryawan.Text == "Nama")
            {
                kriteria = "k.Nama";
            }
            else if (comboBoxDaftarKaryawan.Text == "Alamat")
            {
                kriteria = "k.Alamat";
            }
            else if (comboBoxDaftarKaryawan.Text == "Tanggal Lahir")
            {
                kriteria = "k.TanggalLahir";
            }
            else if (comboBoxDaftarKaryawan.Text == "Gaji")
            {
                kriteria = "k.Gaji";
            }
            else if (comboBoxDaftarKaryawan.Text == "Username")
            {
                kriteria = "k.Username";
            }
            else if (comboBoxDaftarKaryawan.Text == "Id Jabatan")
            {
                kriteria = "k.IdJabatan";
            }
            else if (comboBoxDaftarKaryawan.Text == "Nama Jabatan")
            {
                kriteria = "j.Nama";
            }

            listOfKaryawan = Karyawan.BacaData(kriteria, textBoxDaftarKaryawan.Text);

            TampilDataGrid();
        }
    }
}
