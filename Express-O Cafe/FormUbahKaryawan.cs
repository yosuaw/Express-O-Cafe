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
    public partial class FormUbahKaryawan : Form
    {
        List<Karyawan> listOfKaryawan = new List<Karyawan>();
        List<Jabatan> listOfJabatan = new List<Jabatan>();
        public FormUbahKaryawan()
        {
            InitializeComponent();
        }

        private void FormUbahKaryawan_Load(object sender, EventArgs e)
        {
            listOfJabatan = Jabatan.BacaData("", "");
            comboBoxNamaJabatan.DataSource = listOfJabatan;
            comboBoxNamaJabatan.DisplayMember = "Nama";
            comboBoxNamaJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxKodeKaryawan.Focus();

            textBoxKodeKaryawan.MaxLength = 3;
            textBoxNama.MaxLength = 15;
            textBoxAlamat.MaxLength = 30;
            textBoxGaji.MaxLength = 11;
            textBoxUsername.MaxLength = 30;
            textBoxPassword.MaxLength = 15;
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
                    MessageBox.Show("Kode karyawan tidak ditemukan", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Karyawan k = new Karyawan(textBoxKodeKaryawan.Text, textBoxNama.Text, textBoxAlamat.Text, dateTimePickerTanggalLahir.Value, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, (Jabatan)comboBoxNamaJabatan.SelectedItem);
                Karyawan.UbahData(k);
                MessageBox.Show("Data karyawan telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKaryawan.Text = "";
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
