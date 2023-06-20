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
    public partial class FormUbahMember : Form
    {
        List<Member> listOfMember = new List<Member>();

        public FormUbahMember()
        {
            InitializeComponent();
        }

        private void FormUbahMember_Load(object sender, EventArgs e)
        {
            textBoxIdMember.MaxLength = 4;
            textBoxNamaMember.MaxLength = 30;
            textBoxAlamatMember.MaxLength = 30;
            textBoxNoTeleponMember.MaxLength = 15;
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member(textBoxIdMember.Text, textBoxNamaMember.Text, textBoxAlamatMember.Text, textBoxNoTeleponMember.Text);

                Member.UbahData(member);

                MessageBox.Show("Data member telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
