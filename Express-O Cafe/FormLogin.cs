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
    public partial class FormLogin : Form
    {
        List<Karyawan> listOfKaryawan = new List<Karyawan>();
        FormMain formMain;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Clear();
            }

            pictureBoxUsername.BackgroundImage = Properties.Resources.UserBlue;
            panelUsername.BackColor = buttonSignIn.BackColor;
            textBoxUsername.ForeColor = buttonSignIn.BackColor;

            pictureBoxPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.FromArgb(128, 128, 255);
            textBoxPassword.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Clear();
            }

            textBoxPassword.PasswordChar = '*';

            pictureBoxPassword.BackgroundImage = Properties.Resources.PasswordBlue;
            panelPassword.BackColor = buttonSignIn.BackColor;
            textBoxPassword.ForeColor = buttonSignIn.BackColor;

            pictureBoxUsername.BackgroundImage = Properties.Resources.user;
            panelUsername.BackColor = Color.FromArgb(128, 128, 255);
            textBoxUsername.ForeColor = Color.FromArgb(128, 128, 255);
        }

        public void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    string password = "";
                    if (textBoxPassword.Text == "Password")
                    {
                        password = "";
                    }
                    else
                    {
                        password = textBoxPassword.Text;
                    }
                    Koneksi koneksi = new Koneksi(textBoxUsername.Text, password);

                    Koneksi koneksi2 = new Koneksi();

                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenu formMenu = new FormMenu();

                    listOfKaryawan = Karyawan.BacaData("Username", textBoxUsername.Text);

                    if(listOfKaryawan.Count > 0)
                    {
                        formMain.listOfKaryawan = listOfKaryawan;
                        formMain.status = "1";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            formMain.labelLogin.Visible = true;
            formMain.Enabled = true;
            formMain.status = "0";
            this.Close();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            formMain = new FormMain();
            formMain = (FormMain)this.Owner;
        }
    }
}
