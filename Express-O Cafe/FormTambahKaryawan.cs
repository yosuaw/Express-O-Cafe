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
    public partial class FormTambahKaryawan : Form
    {
        List<Jabatan> listOfJabatan = new List<Jabatan>();
        public FormTambahKaryawan()
        {
            InitializeComponent();
        }

        private void FormTambahKaryawan_Load(object sender, EventArgs e)
        {
            listOfJabatan = Jabatan.BacaData("", "");
            comboBoxNamaJabatan.DataSource = listOfJabatan;
            comboBoxNamaJabatan.DisplayMember = "Nama";

            comboBoxNamaJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxKodeKaryawan.Enabled = false;

            textBoxKodeKaryawan.MaxLength = 3;
            textBoxNamaDepan.MaxLength = 15;
            textBoxNamaBelakang.MaxLength = 15;
            textBoxAlamat.MaxLength = 30;
            textBoxGaji.MaxLength = 11;
            textBoxUsername.MaxLength = 30;
            textBoxPassword.MaxLength = 15;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeKaryawan = textBoxKodeKaryawan.Text;
                string namaPegawai = textBoxNamaDepan.Text + " " + textBoxNamaBelakang.Text;
                string alamat = textBoxAlamat.Text;
                DateTime tanggalLahir = dateTimePickerTanggalLahir.Value;
                int gaji = int.Parse(textBoxGaji.Text);
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                Jabatan jabatanDipilih = (Jabatan)comboBoxNamaJabatan.SelectedItem;

                Karyawan k = new Karyawan(kodeKaryawan, namaPegawai, alamat, tanggalLahir, gaji, username, password, jabatanDipilih);
                Karyawan.TambahData(k);

                MessageBox.Show("Data karyawan berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahKaryawan_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKaryawan.Text = "";
            textBoxNamaDepan.Text = "";
            textBoxNamaBelakang.Text = "";
            textBoxAlamat.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Today;
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxNamaDepan.Focus();
        }

        private void comboBoxNamaJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jabatan jabatan = (Jabatan)comboBoxNamaJabatan.SelectedItem;
            string kodeTerbaru = Karyawan.GenerateKode(jabatan);
            textBoxKodeKaryawan.Text = kodeTerbaru.ToString();
        }
    }
}
