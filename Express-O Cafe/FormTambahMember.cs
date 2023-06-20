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
    public partial class FormTambahMember : Form
    {
        public FormTambahMember()
        {
            InitializeComponent();
        }

        private void FormTambahMember_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Member.GenerateKode();

            textBoxIdMember.Text = kodeTerbaru;
            textBoxIdMember.Enabled = false;
            textBoxNamaDepanMember.MaxLength = 15;
            textBoxNamaBelakangMember.MaxLength = 15;
            textBoxAlamatMember.MaxLength = 30;
            textBoxNoTeleponMember.MaxLength = 15;
            textBoxNamaDepanMember.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                string namaMember = textBoxNamaDepanMember.Text + " " + textBoxNamaBelakangMember.Text;
                Member member = new Member(textBoxIdMember.Text, namaMember, textBoxAlamatMember.Text, textBoxNoTeleponMember.Text);

                Member.TambahData(member);

                MessageBox.Show("Data member telah tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonKosongi_Click(buttonTambah, e);
                FormTambahMember_Load(buttonTambah, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaDepanMember.Clear();
            textBoxNamaBelakangMember.Clear();
            textBoxAlamatMember.Clear();
            textBoxNoTeleponMember.Clear();
            textBoxNamaDepanMember.Focus();
        }
    }
}
