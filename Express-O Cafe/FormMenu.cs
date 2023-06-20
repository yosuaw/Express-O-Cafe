using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Express_O_LIB;

namespace Express_O_Cafe
{
    public partial class FormMenu : Form
    {
        public Karyawan karyawanDipilih;

        Panel panelKategoriSubMenu = new Panel();
        Button buttonTambahKategori = new Button();
        Button buttonUbahKategori = new Button();
        Button buttonHapusKategori = new Button();

        Panel panelKaryawanSubMenu = new Panel();
        Button buttonKaryawan = new Button();
        Button buttonTambahKaryawan = new Button();
        Button buttonUbahKaryawan = new Button();
        Button buttonHapusKaryawan = new Button();

        Panel panelJabatanSubMenu = new Panel();
        Button buttonJabatan = new Button();
        Button buttonTambahJabatan = new Button();
        Button buttonUbahJabatan = new Button();
        Button buttonHapusJabatan = new Button();

        Panel panelSupplierSubMenu = new Panel();
        Button buttonSupplier = new Button();
        Button buttonTambahSupplier = new Button();
        Button buttonUbahSupplier = new Button();
        Button buttonHapusSupplier = new Button();

        Panel panelNotaJualSubMenu = new Panel();
        Button buttonNotaJual = new Button();
        Button buttonTambahNotaJual = new Button();

        Panel panelNotaBeliSubMenu = new Panel();
        Button buttonNotaBeli = new Button();
        Button buttonTambahNotaBeli = new Button();

        Panel panelLaporanSubMenu = new Panel();
        Button buttonLaporan = new Button();

        private Form formAktif = null;

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public string namaUser;

        public FormMenu()
        {
            InitializeComponent();
            Design();

            //this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            timerDate.Start();
        }

        private void Design()
        {
            panelMemberSubMenu.Visible = false;
            panelMenuSubMenu.Visible = false;
            panelBahanSubMenu.Visible = false;
            panelKategoriSubMenu.Visible = false;
            panelKaryawanSubMenu.Visible = false;
            panelJabatanSubMenu.Visible = false;
            panelSupplierSubMenu.Visible = false;
            panelNotaJualSubMenu.Visible = false;
            panelNotaBeliSubMenu.Visible = false;
            panelLaporanSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(panelMemberSubMenu.Visible == true)
            {
                panelMemberSubMenu.Visible = false;
            }
            if(panelMenuSubMenu.Visible == true)
            {
                panelMenuSubMenu.Visible = false;
            }
            if(panelBahanSubMenu.Visible == true)
            {
                panelBahanSubMenu.Visible = false;
            }
            if(panelKategoriSubMenu.Visible == true)
            {
                panelKategoriSubMenu.Visible = false;
            }
            if(panelKaryawanSubMenu.Visible == true)
            {
                panelKaryawanSubMenu.Visible = false;
            }
            if(panelJabatanSubMenu.Visible == true)
            {
                panelJabatanSubMenu.Visible = false;    
            }
            if(panelSupplierSubMenu.Visible == true)
            {
                panelSupplierSubMenu.Visible = false;
            }
            if(panelNotaJualSubMenu.Visible == true)
            {
                panelNotaJualSubMenu.Visible = false;
            }
            if(panelNotaBeliSubMenu.Visible == true)
            {
                panelNotaBeliSubMenu.Visible = false;
            }
            if(panelLaporanSubMenu.Visible == true)
            {
                panelLaporanSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (formAktif != null)
            {
                formAktif.Close();
            }

            formAktif = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDaftar.Controls.Add(childForm);
            panelDaftar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void PengaturanHakAksesMenu(Jabatan jabatan)
        {
            if(jabatan.IdJabatan == 1)
            {
                buttonMember.Visible = true;
                buttonMenu.Visible = true;
                buttonBahan.Visible = true;
                buttonKategori.Visible = true;
                buttonKaryawan.Visible = true;
                buttonJabatan.Visible = true;
                buttonSupplier.Visible = true;
                buttonNotaJual.Visible = true;
                buttonNotaBeli.Visible = true;
                buttonLaporan.Visible = true;
            }
            else if(jabatan.IdJabatan == 2)
            {
                buttonMember.Visible = false;
                buttonMenu.Visible = true;
                buttonBahan.Visible = false;
                buttonKategori.Visible = false;
                buttonKaryawan.Visible = false;
                buttonJabatan.Visible = false;
                buttonSupplier.Visible = false;
                buttonNotaJual.Visible = false;
                buttonNotaBeli.Visible = false;
                buttonLaporan.Visible = false;
            }
            else if (jabatan.IdJabatan == 3)
            {
                buttonMember.Visible = true;
                buttonMenu.Visible = false;
                buttonBahan.Visible = false;
                buttonKategori.Visible = false;
                buttonKaryawan.Visible = false;
                buttonJabatan.Visible = false;
                buttonSupplier.Visible = false;
                buttonNotaJual.Visible = true;
                buttonNotaBeli.Visible = false;
                buttonLaporan.Visible = false;
            }
            else if (jabatan.IdJabatan == 4)
            {
                buttonMember.Visible = false;
                buttonMenu.Visible = false;
                buttonBahan.Visible = true;
                buttonKategori.Visible = false;
                buttonKaryawan.Visible = false;
                buttonJabatan.Visible = false;
                buttonSupplier.Visible = true;
                buttonNotaJual.Visible = false;
                buttonNotaBeli.Visible = true;
                buttonLaporan.Visible = false;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain = (FormMain)this.Owner;
            PengaturanHakAksesMenu(formMain.listOfKaryawan[0].Jabatan);
            labelUsername.Text = formMain.listOfKaryawan[0].Nama;
            karyawanDipilih = formMain.listOfKaryawan[0];

            #region Kategori
            panelKategoriSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelKategoriSubMenu.Dock = DockStyle.Top;
            panelKategoriSubMenu.Width = 206;
            panelKategoriSubMenu.Height = 107;
            panelKategoriSubMenu.Location = new Point(0, 270);

            panelSideMenu.Controls.Add(panelKategoriSubMenu);
            panelKategoriSubMenu.BringToFront();

            buttonTambahKategori.BackColor = buttonTambahMember.BackColor;
            buttonTambahKategori.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahKategori.Dock = DockStyle.Top;
            buttonTambahKategori.FlatStyle = FlatStyle.Flat;
            buttonTambahKategori.FlatAppearance.BorderSize = 0;
            buttonTambahKategori.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahKategori.Padding = new Padding(35, 0, 0, 0);
            buttonTambahKategori.Width = 206;
            buttonTambahKategori.Height = 35;
            buttonTambahKategori.Text = "Tambah";
            buttonTambahKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahKategori.Cursor = Cursors.Hand;
            buttonTambahKategori.Click += new System.EventHandler(buttonTambahKategori_Click);

            buttonUbahKategori.BackColor = buttonTambahMember.BackColor;
            buttonUbahKategori.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonUbahKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahKategori.Dock = DockStyle.Top;
            buttonUbahKategori.FlatStyle = FlatStyle.Flat;
            buttonUbahKategori.FlatAppearance.BorderSize = 0;
            buttonUbahKategori.ForeColor = buttonTambahMember.ForeColor;
            buttonUbahKategori.Padding = new Padding(35, 0, 0, 0);
            buttonUbahKategori.Width = 206;
            buttonUbahKategori.Height = 35;
            buttonUbahKategori.Text = "Ubah";
            buttonUbahKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahKategori.Cursor = Cursors.Hand;
            buttonUbahKategori.Click += new System.EventHandler(buttonUbahKategori_Click);

            buttonHapusKategori.BackColor = buttonTambahMember.BackColor;
            buttonHapusKategori.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonHapusKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusKategori.Dock = DockStyle.Top;
            buttonHapusKategori.FlatStyle = FlatStyle.Flat;
            buttonHapusKategori.FlatAppearance.BorderSize = 0;
            buttonHapusKategori.ForeColor = buttonTambahMember.ForeColor;
            buttonHapusKategori.Padding = new Padding(35, 0, 0, 0);
            buttonHapusKategori.Width = 206;
            buttonHapusKategori.Height = 35;
            buttonHapusKategori.Text = "Hapus";
            buttonHapusKategori.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusKategori.Cursor = Cursors.Hand;
            buttonHapusKategori.Click += new System.EventHandler(buttonHapusKategori_Click);

            panelKategoriSubMenu.Controls.Add(buttonTambahKategori);
            panelKategoriSubMenu.Controls.Add(buttonUbahKategori);
            panelKategoriSubMenu.Controls.Add(buttonHapusKategori);

            buttonTambahKategori.SendToBack();
            buttonHapusKategori.BringToFront();
            #endregion

            #region Karyawan
            buttonKaryawan.BackColor = buttonMember.BackColor;
            buttonKaryawan.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonKaryawan.Dock = DockStyle.Top;
            buttonKaryawan.FlatStyle = FlatStyle.Flat;
            buttonKaryawan.FlatAppearance.BorderSize = 0;
            buttonKaryawan.ForeColor = Color.WhiteSmoke;
            buttonKaryawan.Padding = new Padding(10, 0, 0, 0);
            buttonKaryawan.Width = 206;
            buttonKaryawan.Height = 40;
            buttonKaryawan.Text = "Karyawan";
            buttonKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonKaryawan.Cursor = Cursors.Hand;
            buttonKaryawan.Click += new System.EventHandler(buttonKaryawan_Click);
            
            panelSideMenu.Controls.Add(buttonKaryawan);
            buttonKaryawan.BringToFront();

            panelKaryawanSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelKaryawanSubMenu.Dock = DockStyle.Top;
            panelKaryawanSubMenu.Width = 206;
            panelKaryawanSubMenu.Height = 107;
            panelKaryawanSubMenu.Location = new Point(0, 310);

            panelSideMenu.Controls.Add(panelKaryawanSubMenu);
            panelKaryawanSubMenu.BringToFront();

            buttonTambahKaryawan.BackColor = buttonTambahMember.BackColor;
            buttonTambahKaryawan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahKaryawan.Dock = DockStyle.Top;
            buttonTambahKaryawan.FlatStyle = FlatStyle.Flat;
            buttonTambahKaryawan.FlatAppearance.BorderSize = 0;
            buttonTambahKaryawan.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahKaryawan.Padding = new Padding(35, 0, 0, 0);
            buttonTambahKaryawan.Width = 206;
            buttonTambahKaryawan.Height = 35;
            buttonTambahKaryawan.Text = "Tambah";
            buttonTambahKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahKaryawan.Cursor = Cursors.Hand;
            buttonTambahKaryawan.Click += new System.EventHandler(buttonTambahKaryawan_Click);

            buttonUbahKaryawan.BackColor = buttonTambahMember.BackColor;
            buttonUbahKaryawan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonUbahKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahKaryawan.Dock = DockStyle.Top;
            buttonUbahKaryawan.FlatStyle = FlatStyle.Flat;
            buttonUbahKaryawan.FlatAppearance.BorderSize = 0;
            buttonUbahKaryawan.ForeColor = buttonTambahMember.ForeColor;
            buttonUbahKaryawan.Padding = new Padding(35, 0, 0, 0);
            buttonUbahKaryawan.Width = 206;
            buttonUbahKaryawan.Height = 35;
            buttonUbahKaryawan.Text = "Ubah";
            buttonUbahKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahKaryawan.Cursor = Cursors.Hand;
            buttonUbahKaryawan.Click += new System.EventHandler(buttonUbahKaryawan_Click);

            buttonHapusKaryawan.BackColor = buttonTambahMember.BackColor;
            buttonHapusKaryawan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonHapusKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusKaryawan.Dock = DockStyle.Top;
            buttonHapusKaryawan.FlatStyle = FlatStyle.Flat;
            buttonHapusKaryawan.FlatAppearance.BorderSize = 0;
            buttonHapusKaryawan.ForeColor = buttonTambahMember.ForeColor;
            buttonHapusKaryawan.Padding = new Padding(35, 0, 0, 0);
            buttonHapusKaryawan.Width = 206;
            buttonHapusKaryawan.Height = 35;
            buttonHapusKaryawan.Text = "Hapus";
            buttonHapusKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusKaryawan.Cursor = Cursors.Hand;
            buttonHapusKaryawan.Click += new System.EventHandler(buttonHapusKaryawan_Click);

            panelKaryawanSubMenu.Controls.Add(buttonTambahKaryawan);
            panelKaryawanSubMenu.Controls.Add(buttonUbahKaryawan);
            panelKaryawanSubMenu.Controls.Add(buttonHapusKaryawan);

            buttonTambahKaryawan.SendToBack();
            buttonHapusKaryawan.BringToFront();
            #endregion

            #region Jabatan
            buttonJabatan.BackColor = buttonMember.BackColor;
            buttonJabatan.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonJabatan.Dock = DockStyle.Top;
            buttonJabatan.FlatStyle = FlatStyle.Flat;
            buttonJabatan.FlatAppearance.BorderSize = 0;
            buttonJabatan.ForeColor = Color.WhiteSmoke;
            buttonJabatan.Padding = new Padding(10, 0, 0, 0);
            buttonJabatan.Width = 206;
            buttonJabatan.Height = 40;
            buttonJabatan.Text = "Jabatan";
            buttonJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonJabatan.Cursor = Cursors.Hand;
            buttonJabatan.Click += new System.EventHandler(buttonJabatan_Click);

            panelSideMenu.Controls.Add(buttonJabatan);
            buttonJabatan.BringToFront();

            panelJabatanSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelJabatanSubMenu.Dock = DockStyle.Top;
            panelJabatanSubMenu.Width = 206;
            panelJabatanSubMenu.Height = 107;
            panelJabatanSubMenu.Location = new Point(0, 350);

            panelSideMenu.Controls.Add(panelJabatanSubMenu);
            panelJabatanSubMenu.BringToFront();

            buttonTambahJabatan.BackColor = buttonTambahMember.BackColor;
            buttonTambahJabatan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahJabatan.Dock = DockStyle.Top;
            buttonTambahJabatan.FlatStyle = FlatStyle.Flat;
            buttonTambahJabatan.FlatAppearance.BorderSize = 0;
            buttonTambahJabatan.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahJabatan.Padding = new Padding(35, 0, 0, 0);
            buttonTambahJabatan.Width = 206;
            buttonTambahJabatan.Height = 35;
            buttonTambahJabatan.Text = "Tambah";
            buttonTambahJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahJabatan.Cursor = Cursors.Hand;
            buttonTambahJabatan.Click += new System.EventHandler(buttonTambahJabatan_Click);

            buttonUbahJabatan.BackColor = buttonTambahMember.BackColor;
            buttonUbahJabatan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonUbahJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahJabatan.Dock = DockStyle.Top;
            buttonUbahJabatan.FlatStyle = FlatStyle.Flat;
            buttonUbahJabatan.FlatAppearance.BorderSize = 0;
            buttonUbahJabatan.ForeColor = buttonTambahMember.ForeColor;
            buttonUbahJabatan.Padding = new Padding(35, 0, 0, 0);
            buttonUbahJabatan.Width = 206;
            buttonUbahJabatan.Height = 35;
            buttonUbahJabatan.Text = "Ubah";
            buttonUbahJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahJabatan.Cursor = Cursors.Hand;
            buttonUbahJabatan.Click += new System.EventHandler(buttonUbahJabatan_Click);

            buttonHapusJabatan.BackColor = buttonTambahMember.BackColor;
            buttonHapusJabatan.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonHapusJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusJabatan.Dock = DockStyle.Top;
            buttonHapusJabatan.FlatStyle = FlatStyle.Flat;
            buttonHapusJabatan.FlatAppearance.BorderSize = 0;
            buttonHapusJabatan.ForeColor = buttonTambahMember.ForeColor;
            buttonHapusJabatan.Padding = new Padding(35, 0, 0, 0);
            buttonHapusJabatan.Width = 206;
            buttonHapusJabatan.Height = 35;
            buttonHapusJabatan.Text = "Hapus";
            buttonHapusJabatan.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusJabatan.Cursor = Cursors.Hand;
            buttonHapusJabatan.Click += new System.EventHandler(buttonHapusJabatan_Click);

            panelJabatanSubMenu.Controls.Add(buttonTambahJabatan);
            panelJabatanSubMenu.Controls.Add(buttonUbahJabatan);
            panelJabatanSubMenu.Controls.Add(buttonHapusJabatan);

            buttonTambahJabatan.SendToBack();
            buttonHapusJabatan.BringToFront();
            #endregion

            #region Supplier
            buttonSupplier.BackColor = buttonMember.BackColor;
            buttonSupplier.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupplier.Dock = DockStyle.Top;
            buttonSupplier.FlatStyle = FlatStyle.Flat;
            buttonSupplier.FlatAppearance.BorderSize = 0;
            buttonSupplier.ForeColor = Color.WhiteSmoke;
            buttonSupplier.Padding = new Padding(10, 0, 0, 0);
            buttonSupplier.Width = 206;
            buttonSupplier.Height = 40;
            buttonSupplier.Text = "Supplier";
            buttonSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupplier.Cursor = Cursors.Hand;
            buttonSupplier.Click += new System.EventHandler(buttonSupplier_Click);

            panelSideMenu.Controls.Add(buttonSupplier);
            buttonSupplier.BringToFront();

            panelSupplierSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelSupplierSubMenu.Dock = DockStyle.Top;
            panelSupplierSubMenu.Width = 206;
            panelSupplierSubMenu.Height = 107;
            panelSupplierSubMenu.Location = new Point(0, 350);

            panelSideMenu.Controls.Add(panelSupplierSubMenu);
            panelSupplierSubMenu.BringToFront();

            buttonTambahSupplier.BackColor = buttonTambahMember.BackColor;
            buttonTambahSupplier.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahSupplier.Dock = DockStyle.Top;
            buttonTambahSupplier.FlatStyle = FlatStyle.Flat;
            buttonTambahSupplier.FlatAppearance.BorderSize = 0;
            buttonTambahSupplier.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahSupplier.Padding = new Padding(35, 0, 0, 0);
            buttonTambahSupplier.Width = 206;
            buttonTambahSupplier.Height = 35;
            buttonTambahSupplier.Text = "Tambah";
            buttonTambahSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahSupplier.Cursor = Cursors.Hand;
            buttonTambahSupplier.Click += new System.EventHandler(buttonTambahSupplier_Click);

            buttonUbahSupplier.BackColor = buttonTambahMember.BackColor;
            buttonUbahSupplier.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonUbahSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahSupplier.Dock = DockStyle.Top;
            buttonUbahSupplier.FlatStyle = FlatStyle.Flat;
            buttonUbahSupplier.FlatAppearance.BorderSize = 0;
            buttonUbahSupplier.ForeColor = buttonTambahMember.ForeColor;
            buttonUbahSupplier.Padding = new Padding(35, 0, 0, 0);
            buttonUbahSupplier.Width = 206;
            buttonUbahSupplier.Height = 35;
            buttonUbahSupplier.Text = "Ubah";
            buttonUbahSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonUbahSupplier.Cursor = Cursors.Hand;
            buttonUbahSupplier.Click += new System.EventHandler(buttonUbahSupplier_Click);

            buttonHapusSupplier.BackColor = buttonTambahMember.BackColor;
            buttonHapusSupplier.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonHapusSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusSupplier.Dock = DockStyle.Top;
            buttonHapusSupplier.FlatStyle = FlatStyle.Flat;
            buttonHapusSupplier.FlatAppearance.BorderSize = 0;
            buttonHapusSupplier.ForeColor = buttonTambahMember.ForeColor;
            buttonHapusSupplier.Padding = new Padding(35, 0, 0, 0);
            buttonHapusSupplier.Width = 206;
            buttonHapusSupplier.Height = 35;
            buttonHapusSupplier.Text = "Hapus";
            buttonHapusSupplier.TextAlign = ContentAlignment.MiddleLeft;
            buttonHapusSupplier.Cursor = Cursors.Hand;
            buttonHapusSupplier.Click += new System.EventHandler(buttonHapusSupplier_Click);

            panelSupplierSubMenu.Controls.Add(buttonTambahSupplier);
            panelSupplierSubMenu.Controls.Add(buttonUbahSupplier);
            panelSupplierSubMenu.Controls.Add(buttonHapusSupplier);

            buttonTambahSupplier.SendToBack();
            buttonHapusSupplier.BringToFront();
            #endregion

            #region Nota Jual
            buttonNotaJual.BackColor = buttonMember.BackColor;
            buttonNotaJual.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonNotaJual.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotaJual.Dock = DockStyle.Top;
            buttonNotaJual.FlatStyle = FlatStyle.Flat;
            buttonNotaJual.FlatAppearance.BorderSize = 0;
            buttonNotaJual.ForeColor = Color.WhiteSmoke;
            buttonNotaJual.Padding = new Padding(10, 0, 0, 0);
            buttonNotaJual.Width = 206;
            buttonNotaJual.Height = 40;
            buttonNotaJual.Text = "Nota Jual";
            buttonNotaJual.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotaJual.Cursor = Cursors.Hand;
            buttonNotaJual.Click += new System.EventHandler(buttonNotaJual_Click);

            panelSideMenu.Controls.Add(buttonNotaJual);
            buttonNotaJual.BringToFront();

            panelNotaJualSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelNotaJualSubMenu.Dock = DockStyle.Top;
            panelNotaJualSubMenu.Width = 206;
            panelNotaJualSubMenu.Height = 36;
            panelNotaJualSubMenu.Location = new Point(0, 350);

            panelSideMenu.Controls.Add(panelNotaJualSubMenu);
            panelNotaJualSubMenu.BringToFront();

            buttonTambahNotaJual.BackColor = buttonTambahMember.BackColor;
            buttonTambahNotaJual.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahNotaJual.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahNotaJual.Dock = DockStyle.Top;
            buttonTambahNotaJual.FlatStyle = FlatStyle.Flat;
            buttonTambahNotaJual.FlatAppearance.BorderSize = 0;
            buttonTambahNotaJual.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahNotaJual.Padding = new Padding(35, 0, 0, 0);
            buttonTambahNotaJual.Width = 206;
            buttonTambahNotaJual.Height = 35;
            buttonTambahNotaJual.Text = "Tambah";
            buttonTambahNotaJual.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahNotaJual.Cursor = Cursors.Hand;
            buttonTambahNotaJual.Click += new System.EventHandler(buttonTambahNotaJual_Click);

            panelNotaJualSubMenu.Controls.Add(buttonTambahNotaJual);

            buttonTambahNotaJual.SendToBack();
            #endregion

            #region Nota Beli
            buttonNotaBeli.BackColor = buttonMember.BackColor;
            buttonNotaBeli.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonNotaBeli.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotaBeli.Dock = DockStyle.Top;
            buttonNotaBeli.FlatStyle = FlatStyle.Flat;
            buttonNotaBeli.FlatAppearance.BorderSize = 0;
            buttonNotaBeli.ForeColor = Color.WhiteSmoke;
            buttonNotaBeli.Padding = new Padding(10, 0, 0, 0);
            buttonNotaBeli.Width = 206;
            buttonNotaBeli.Height = 40;
            buttonNotaBeli.Text = "Nota Beli";
            buttonNotaBeli.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotaBeli.Cursor = Cursors.Hand;
            buttonNotaBeli.Click += new System.EventHandler(buttonNotaBeli_Click);

            panelSideMenu.Controls.Add(buttonNotaBeli);
            buttonNotaBeli.BringToFront();

            panelNotaBeliSubMenu.BackColor = panelMemberSubMenu.BackColor;
            panelNotaBeliSubMenu.Dock = DockStyle.Top;
            panelNotaBeliSubMenu.Width = 206;
            panelNotaBeliSubMenu.Height = 36;
            panelNotaBeliSubMenu.Location = new Point(0, 350);

            panelSideMenu.Controls.Add(panelNotaBeliSubMenu);
            panelNotaBeliSubMenu.BringToFront();

            buttonTambahNotaBeli.BackColor = buttonTambahMember.BackColor;
            buttonTambahNotaBeli.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            buttonTambahNotaBeli.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahNotaBeli.Dock = DockStyle.Top;
            buttonTambahNotaBeli.FlatStyle = FlatStyle.Flat;
            buttonTambahNotaBeli.FlatAppearance.BorderSize = 0;
            buttonTambahNotaBeli.ForeColor = buttonTambahMember.ForeColor;
            buttonTambahNotaBeli.Padding = new Padding(35, 0, 0, 0);
            buttonTambahNotaBeli.Width = 206;
            buttonTambahNotaBeli.Height = 35;
            buttonTambahNotaBeli.Text = "Tambah";
            buttonTambahNotaBeli.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahNotaBeli.Cursor = Cursors.Hand;
            buttonTambahNotaBeli.Click += new System.EventHandler(buttonTambahNotaBeli_Click);

            panelNotaBeliSubMenu.Controls.Add(buttonTambahNotaBeli);

            buttonTambahNotaBeli.SendToBack();
            #endregion

            #region Laporan
            buttonLaporan.BackColor = buttonMember.BackColor;
            buttonLaporan.Font = new Font("Cooper Black", 20, FontStyle.Bold);
            buttonLaporan.TextAlign = ContentAlignment.MiddleLeft;
            buttonLaporan.Dock = DockStyle.Top;
            buttonLaporan.FlatStyle = FlatStyle.Flat;
            buttonLaporan.FlatAppearance.BorderSize = 0;
            buttonLaporan.ForeColor = Color.WhiteSmoke;
            buttonLaporan.Padding = new Padding(10, 0, 0, 0);
            buttonLaporan.Width = 206;
            buttonLaporan.Height = 40;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.TextAlign = ContentAlignment.MiddleLeft;
            buttonLaporan.Cursor = Cursors.Hand;
            buttonLaporan.Click += new System.EventHandler(buttonLaporan_Click);

            panelSideMenu.Controls.Add(buttonLaporan);
            buttonLaporan.BringToFront();
            #endregion
        }

        #region Member Sub Menu
        private void buttonMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarMember());

            ShowSubMenu(panelMemberSubMenu);
            labelHome.Text = "Member";
            pictureBoxHome.Image = Properties.Resources.Member;
        }

        private void buttonTambahMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahMember());
            HideSubMenu();
            labelHome.Text = "Tambah Member";
        }

        private void buttonUbahMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahMember());
            HideSubMenu();
            labelHome.Text = "Ubah Member";
        }

        private void buttonHapusMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusMember());
            HideSubMenu();
            labelHome.Text = "Hapus Member";
        }
        #endregion

        #region Menu Sub Menu
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarMenu());

            ShowSubMenu(panelMenuSubMenu);
            labelHome.Text = "Menu";
            pictureBoxHome.Image = Properties.Resources.Menu;
        }

        private void buttonTambahMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahMenu());
            HideSubMenu();
            labelHome.Text = "Tambah Menu";
        }

        private void buttonUbahMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahMenu());
            HideSubMenu();
            labelHome.Text = "Ubah Menu";
        }

        private void buttonHapusMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusMenu());
            HideSubMenu();
            labelHome.Text = "Hapus Menu";
        }
        #endregion

        #region Bahan Sub Menu
        private void buttonBahan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarBahan());

            ShowSubMenu(panelBahanSubMenu);
            labelHome.Text = "Bahan";
            pictureBoxHome.Image = Properties.Resources.Bahan;
        }

        private void buttonTambahBahan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahBahan());
            HideSubMenu();
            labelHome.Text = "Tambah Bahan";
        }

        private void buttonUbahBahan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahBahan());
            HideSubMenu();
            labelHome.Text = "Ubah Bahan";
        }

        private void buttonHapusBahan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusBahan());
            HideSubMenu();
            labelHome.Text = "Hapus Bahan";
        }
        #endregion

        #region Kategori Sub Menu
        private void buttonKategori_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarKategori());

            ShowSubMenu(panelKategoriSubMenu);
            labelHome.Text = "Kategori";
            pictureBoxHome.Image = Properties.Resources.Kategori;
        }

        private void buttonTambahKategori_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahKategori());
            HideSubMenu();
            labelHome.Text = "Tambah Kategori";
        }

        private void buttonUbahKategori_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahKategori());
            HideSubMenu();
            labelHome.Text = "Ubah Kategori";
        }

        private void buttonHapusKategori_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusKategori());
            HideSubMenu();
            labelHome.Text = "Hapus Kategori";
        }
        #endregion

        #region Karyawan Sub Menu
        private void buttonKaryawan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarKaryawan());

            ShowSubMenu(panelKaryawanSubMenu);
            labelHome.Text = "Karyawan";
            pictureBoxHome.Image = Properties.Resources.Karyawan;
        }

        private void buttonTambahKaryawan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahKaryawan());
            HideSubMenu();
            labelHome.Text = "Tambah Karyawan";
        }

        private void buttonUbahKaryawan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahKaryawan());
            HideSubMenu();
            labelHome.Text = "Ubah Karyawan";
        }

        private void buttonHapusKaryawan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusKaryawan());
            HideSubMenu();
            labelHome.Text = "Hapus Karyawan";
        }
        #endregion

        #region Jabatan Sub Menu
        private void buttonJabatan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarJabatan());

            ShowSubMenu(panelJabatanSubMenu);
            labelHome.Text = "Jabatan";
            pictureBoxHome.Image = Properties.Resources.Jabatan;
        }

        private void buttonTambahJabatan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahJabatan());
            HideSubMenu();
            labelHome.Text = "Tambah Jabatan";
        }

        private void buttonUbahJabatan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahJabatan());
            HideSubMenu();
            labelHome.Text = "Ubah Jabatan";
        }

        private void buttonHapusJabatan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusJabatan());
            HideSubMenu();
            labelHome.Text = "Hapus Jabatan";
        }
        #endregion

        #region Supplier Sub Menu
        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarSupplier());

            ShowSubMenu(panelSupplierSubMenu);
            labelHome.Text = "Supplier";
            pictureBoxHome.Image = Properties.Resources.Supplier;
        }

        private void buttonTambahSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahSupplier());
            HideSubMenu();
            labelHome.Text = "Tambah Supplier";
        }

        private void buttonUbahSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUbahSupplier());
            HideSubMenu();
            labelHome.Text = "Ubah Supplier";
        }

        private void buttonHapusSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHapusSupplier());
            HideSubMenu();
            labelHome.Text = "Hapus Supplier";
        }
        #endregion

        #region Nota Jual Sub Menu
        private void buttonNotaJual_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarNotaJual());

            ShowSubMenu(panelNotaJualSubMenu);
            labelHome.Text = "Nota Jual";
            pictureBoxHome.Image = Properties.Resources.notajual;
        }

        private void buttonTambahNotaJual_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahNotaJual());
            HideSubMenu();
            labelHome.Text = "Tambah Nota Jual";
        }

        private void buttonUbahNotaJual_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            labelHome.Text = "Ubah Nota Jual";
        }

        private void buttonHapusNotaJual_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            labelHome.Text = "Hapus Nota Jual";
        }
        #endregion

        #region Nota Beli Sub Menu
        private void buttonNotaBeli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDaftarNotaBeli());

            ShowSubMenu(panelNotaBeliSubMenu);
            labelHome.Text = "Nota Beli";
            pictureBoxHome.Image = Properties.Resources.notabeli;
        }

        private void buttonTambahNotaBeli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTambahNotaBeli());
            HideSubMenu();
            labelHome.Text = "Tambah Nota Beli";
        }
        #endregion

        #region Laporan Sub Menu
        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLaporan());

            HideSubMenu();
            labelHome.Text = "Laporan";
            pictureBoxHome.Image = Properties.Resources.laporan;
        }
        #endregion

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            labelHome.Text = "Home";
            pictureBoxHome.Image = Properties.Resources.home;

            if (formAktif != null)
            {
                formAktif.Close();
            }
        }

        private void panelUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelLogOut_MouseHover(object sender, EventArgs e)
        {
            labelLogOut.ForeColor = Color.Red;
            labelLogOut.Font = new Font("Century", 13, FontStyle.Regular);
        }

        private void labelLogOut_MouseLeave(object sender, EventArgs e)
        {
            labelLogOut.ForeColor = Color.Black;
            labelLogOut.Font = new Font("Century", 13, FontStyle.Regular);
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDate.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain = (FormMain)this.Owner;
            formMain.labelLogin.Visible = true;
            formMain.Enabled = true;
            this.Close();
        }

        public void NamaUser(string username)
        {
            List<Karyawan> karyawan = Karyawan.BacaData("Username", username);
            namaUser = karyawan[0].Nama.ToString();
        }
    }
}
