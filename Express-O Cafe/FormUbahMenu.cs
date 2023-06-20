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
    public partial class FormUbahMenu : Form
    {
        List<Menus> listOfMenu = new List<Menus>();
        List<Kategori> listOfKategori = new List<Kategori>();

        public FormUbahMenu()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Menus menu = new Menus(textBoxKodeMenu.Text, textBoxNamaMenu.Text, int.Parse(textBoxHargaMenu.Text), int.Parse(textBoxDiskon.Text), (Kategori)comboBoxKategoriMenu.SelectedItem);

                Menus.UbahData(menu);

                MessageBox.Show("Data menu telah diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeMenu.Clear();
            textBoxNamaMenu.Clear();
            textBoxHargaMenu.Clear();
            textBoxDiskon.Clear();
            comboBoxKategoriMenu.SelectedIndex = -1;
            textBoxKodeMenu.Focus();
        }

        private void FormUbahMenu_Load(object sender, EventArgs e)
        {
            textBoxKodeMenu.MaxLength = 3;
            textBoxNamaMenu.MaxLength = 30;
            comboBoxKategoriMenu.DropDownStyle = ComboBoxStyle.DropDownList;

            listOfKategori = Kategori.BacaData("", "");

            comboBoxKategoriMenu.DataSource = listOfKategori;
            comboBoxKategoriMenu.DisplayMember = "Nama";
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
                    textBoxNamaMenu.Focus();
                }
                else
                {
                    MessageBox.Show("Kode Menu tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxKategoriMenu.SelectedIndex = -1;
                    textBoxNamaMenu.Clear();
                    textBoxHargaMenu.Clear();
                    textBoxDiskon.Clear();
                }
            }
        }
    }
}
