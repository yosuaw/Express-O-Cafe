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
    public partial class FormMain : Form
    {
        public string status = "0";
        public List<Karyawan> listOfKaryawan = new List<Karyawan>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            timerUp.Start();

            labelLogin.Left = 550;
            labelLogin.Top = 600;

            pictureBoxLogo.Left = 0;
            pictureBoxLogo.Top = 450;

            labelClose.Left = 1250;
            labelClose.Top = 0;
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            labelLogin.Visible = false;

            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();

            if (status == "1")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Owner = this;
                formMenu.ShowDialog();
            }
            this.labelLogin.Visible = true;
            this.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelLogin.Top -= 12;

            if (labelLogin.Top <= 300)
            {
                timerUp.Stop();
            }
        }

        private void labelLogin_MouseHover(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.Green;
            labelLogin.Font = new Font("Comic Sans MS", 45, FontStyle.Bold);
        }

        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.Black;
            labelLogin.Font = new Font("Comic Sans MS", 45, FontStyle.Bold);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
