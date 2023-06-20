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
    public partial class FormHapusMember : Form
    {
        List<Member> listOfMember = new List<Member>();

        public FormHapusMember()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data member akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Member member = new Member(textBoxIdMember.Text, textBoxNamaMember.Text, textBoxAlamatMember.Text, textBoxNoTeleponMember.Text);

                string hasilTambah = Member.HapusData(member);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Member telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus member. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxIdMember.Clear();
            textBoxNamaMember.Clear();
            textBoxAlamatMember.Clear();
            textBoxNoTeleponMember.Clear();
            textBoxIdMember.Focus();
        }

        private void FormHapusMember_Load(object sender, EventArgs e)
        {
            textBoxIdMember.MaxLength = 4;
            textBoxNamaMember.MaxLength = 30;
            textBoxAlamatMember.MaxLength = 11;
            textBoxNoTeleponMember.MaxLength = 11;
            textBoxNamaMember.Enabled = false;
            textBoxAlamatMember.Enabled = false;
            textBoxNoTeleponMember.Enabled = false;
            textBoxIdMember.Focus();
        }

        private void textBoxIdMember_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdMember.Text.Length == textBoxIdMember.MaxLength)
            {
                listOfMember = Member.BacaData("IdMember", textBoxIdMember.Text);
                if (listOfMember.Count > 0)
                {
                    textBoxNamaMember.Text = listOfMember[0].Nama;
                    textBoxAlamatMember.Text = listOfMember[0].Alamat;
                    textBoxNoTeleponMember.Text = listOfMember[0].NoTelepon;
                    textBoxNamaMember.Focus();
                }
                else
                {
                    MessageBox.Show("Id Member tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNamaMember.Clear();
                    textBoxAlamatMember.Clear();
                    textBoxNoTeleponMember.Clear();
                }
            }
        }
    }
}
