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
    public partial class FormDaftarMember : Form
    {
        List<Member> listOfMember = new List<Member>();

        public FormDaftarMember()
        {
            InitializeComponent();
        }

        private void FormDaftarMember_Load(object sender, EventArgs e)
        {
            listOfMember = Member.BacaData("", "");

            if (listOfMember.Count > 0)
            {
                dataGridViewDaftarMember.DataSource = listOfMember;
            }
            else
            {
                dataGridViewDaftarMember.DataSource = null;
            }

            dataGridViewDaftarMember.AllowUserToAddRows = false;
            dataGridViewDaftarMember.ReadOnly = true;
        }

        private void textBoxDaftarMember_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftarMember.Text == "Id Member")
            {
                listOfMember = Member.BacaData("IdMember", textBoxDaftarMember.Text);
            }
            else if (comboBoxDaftarMember.Text == "Nama")
            {
                listOfMember = Member.BacaData("Nama", textBoxDaftarMember.Text);
            }
            else if (comboBoxDaftarMember.Text == "Alamat")
            {
                listOfMember = Member.BacaData("Alamat", textBoxDaftarMember.Text);
            }
            else if (comboBoxDaftarMember.Text == "Nomor Telepon")
            {
                listOfMember = Member.BacaData("NoTelepon", textBoxDaftarMember.Text);
            }

            if (listOfMember.Count > 0)
            {
                dataGridViewDaftarMember.DataSource = listOfMember;
            }
            else
            {
                dataGridViewDaftarMember.DataSource = null;
            }
        }
    }
}
