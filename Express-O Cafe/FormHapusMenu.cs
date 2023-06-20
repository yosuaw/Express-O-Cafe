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
    public partial class FormHapusMenu : Form
    {
        List<Menus> listOfMenu = new List<Menus>();
        List<Kategori> listOfKategori = new List<Kategori>();
        List<Resep> listOfResep = new List<Resep>();
 
        public FormHapusMenu()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewResep.Columns.Clear();

            dataGridViewResep.Columns.Add("KodeMenu", "Kode");
            dataGridViewResep.Columns.Add("NamaMenu", "Nama Menu");
            dataGridViewResep.Columns.Add("IdBahan", " ID Bahan");
            dataGridViewResep.Columns.Add("NamaBahan", "Nama Bahan");
            dataGridViewResep.Columns.Add("Takaran", "Takaran (L atau Kg)");

            dataGridViewResep.Columns["KodeMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewResep.Columns["NamaMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewResep.Columns["NamaBahan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewResep.Columns["Takaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewResep.Columns["Takaran"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewResep.AllowUserToAddRows = false;
            dataGridViewResep.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewResep.Rows.Clear();

            if (listOfMenu.Count > 0)
            {
                foreach (Menus menus in listOfMenu)
                {
                    foreach (Resep reseps in menus.ListOfResep)
                    {
                        dataGridViewResep.Rows.Add(menus.KodeMenu, menus.Nama, reseps.Bahan.IdBahan, reseps.Bahan.Nama, reseps.Takaran);
                    }
                }
            }
            else
            {
                dataGridViewResep.DataSource = null;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data menu akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Menus menu = new Menus(textBoxKodeMenu.Text, textBoxNamaMenu.Text, int.Parse(textBoxHargaMenu.Text), int.Parse(textBoxDiskon.Text), (Kategori)comboBoxKategoriMenu.SelectedItem);

                string hasilTambah = Menus.HapusData(menu);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Menu telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus menu. Pesan kesalahan : " + hasilTambah, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeMenu.Clear();
            comboBoxKategoriMenu.SelectedIndex = -1;
            textBoxNamaMenu.Clear();
            textBoxHargaMenu.Clear();
            textBoxDiskon.Clear();
            textBoxKodeMenu.Focus();
            dataGridViewResep.Rows.Clear();
        }

        private void FormHapusMenu_Load(object sender, EventArgs e)
        {
            comboBoxKategoriMenu.Enabled = false;
            textBoxKodeMenu.MaxLength = 3;
            textBoxNamaMenu.Enabled = false;
            textBoxHargaMenu.Enabled = false;
            textBoxDiskon.Enabled = false;
            comboBoxKategoriMenu.DropDownStyle = ComboBoxStyle.DropDownList;

            listOfKategori = Kategori.BacaData("", "");

            comboBoxKategoriMenu.DataSource = listOfKategori;
            comboBoxKategoriMenu.DisplayMember = "Nama";

            FormatDataGrid();
        }

        private void textBoxKodeMenu_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeMenu.Text.Length == textBoxKodeMenu.MaxLength)
            {
                listOfMenu = Menus.BacaData("m.KodeMenu", textBoxKodeMenu.Text);
                if (listOfMenu.Count > 0)
                {
                    comboBoxKategoriMenu.SelectedIndex = comboBoxKategoriMenu.FindStringExact(listOfMenu[0].Kategori.Nama);
                    textBoxNamaMenu.Text = listOfMenu[0].Nama;
                    textBoxHargaMenu.Text = listOfMenu[0].Harga.ToString();
                    textBoxDiskon.Text = listOfMenu[0].Diskon.ToString();
                    TampilDataGrid();
                }
                else
                {
                    MessageBox.Show("Kode menu tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxKategoriMenu.SelectedIndex = -1;
                    textBoxNamaMenu.Clear();
                    textBoxHargaMenu.Clear();
                    textBoxDiskon.Clear();
                    dataGridViewResep.Rows.Clear();
                }
            }
        }
    }
}
