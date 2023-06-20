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
    public partial class FormHapusKaryawan : Form
    {
        List<Karyawan> listOfKaryawan = new List<Karyawan>();
        List<Jabatan> listOfJabatan = new List<Jabatan>();
        public FormHapusKaryawan()
        {
            InitializeComponent();
        }

        private void FormHapusKaryawan_Load(object sender, EventArgs e)
        {
            listOfJabatan = Jabatan.BacaData("", "");
            comboBoxNamaJabatan.DataSource = listOfJabatan;
            comboBoxNamaJabatan.DisplayMember = "Nama";

            comboBoxNamaJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxNama.Focus();

            textBoxKodeKaryawan.MaxLength = 3;
            textBoxNama.MaxLength = 15;
            textBoxAlamat.MaxLength = 30;
            textBoxGaji.MaxLength = 11;
            textBoxUsername.MaxLength = 30;
            textBoxPassword.MaxLength = 15;

            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            dateTimePickerTanggalLahir.Enabled = false;
            textBoxGaji.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;
            comboBoxNamaJabatan.Enabled = false;
        }

        private void textBoxKodeKaryawan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeKaryawan.Text.Length == textBoxKodeKaryawan.MaxLength)
            {
                listOfKaryawan = Karyawan.BacaData("KodeKaryawan", textBoxKodeKaryawan.Text);
                if (listOfKaryawan.Count > 0)
                {
                    textBoxNama.Text = listOfKaryawan[0].Nama;
                    textBoxAlamat.Text = listOfKaryawan[0].Alamat;
                    dateTimePickerTanggalLahir.Value = listOfKaryawan[0].TanggalLahir;
                    textBoxGaji.Text = (listOfKaryawan[0].Gaji).ToString();
                    textBoxUsername.Text = listOfKaryawan[0].Username;
                    textBoxPassword.Text = listOfKaryawan[0].Password;
                    comboBoxNamaJabatan.SelectedIndex = comboBoxNamaJabatan.FindStringExact(listOfKaryawan[0].Jabatan.Nama);
                }
                else
                {
                    MessageBox.Show("Kode karyawan tidak ditemukan.", "Kesalahan");
                    textBoxNama.Text = "";
                    textBoxAlamat.Text = "";
                    textBoxGaji.Text = "";
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    comboBoxNamaJabatan.SelectedIndex = -1;
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data karyawan akan terhapus. Apakah Anda yakin? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Karyawan k = new Karyawan(textBoxKodeKaryawan.Text, textBoxNama.Text, textBoxAlamat.Text, dateTimePickerTanggalLahir.Value, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, (Jabatan)comboBoxNamaJabatan.SelectedItem);

                string hasilTambah = Karyawan.HapusData(k);
                if (hasilTambah == "1")
                {
                    MessageBox.Show("Karyawan telah dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus karyawan. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Today;
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBoxNamaJabatan.SelectedIndex = -1;
        }
    }
}
