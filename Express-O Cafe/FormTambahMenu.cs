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
    public partial class FormTambahMenu : Form
    {
        List<Kategori> listOfKategori = new List<Kategori>();
        Kategori kategoriDipilih;
        Menus menu;
        List<Bahan> listOfBahan = new List<Bahan>();

        public FormTambahMenu()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewResep.Columns.Clear();

            dataGridViewResep.Columns.Add("KodeMenu", "Kode");
            dataGridViewResep.Columns.Add("NamaMenu", "Nama Menu");
            dataGridViewResep.Columns.Add("Diskon", "Diskon");
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

        private void FormTambahMenu_Load(object sender, EventArgs e)
        {
            textBoxNamaMenu.MaxLength = 30;
            textBoxKodeMenu.Enabled = false;
            textBoxIdBahan.MaxLength = 2;
            comboBoxKategoriMenu.DropDownStyle = ComboBoxStyle.DropDownList;

            listOfKategori = Kategori.BacaData("", "");
            comboBoxKategoriMenu.DataSource = listOfKategori;
            comboBoxKategoriMenu.DisplayMember = "Nama";

            listOfBahan = Bahan.BacaData("", "");
            comboBoxNamaBahan.DataSource = listOfBahan;
            comboBoxNamaBahan.DisplayMember = "Nama";

            textBoxHargaMenu.TextAlign = HorizontalAlignment.Right;

            FormatDataGrid();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                menu = new Menus(textBoxKodeMenu.Text, textBoxNamaMenu.Text, int.Parse(textBoxHargaMenu.Text), int.Parse(textBoxDiskon.Text), kategoriDipilih);
                List<Menus> listOfMenu = new List<Menus>();

                for (int i = 0; i < dataGridViewResep.Rows.Count; i++)
                {
                    string idBahan = dataGridViewResep.Rows[i].Cells["IdBahan"].Value.ToString();
                    listOfBahan = Bahan.BacaData("IdBahan", idBahan);
                    double takaran = double.Parse(dataGridViewResep.Rows[i].Cells["Takaran"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    menu.TambahResep(listOfBahan[0], takaran);
                }

                Menus.TambahData(menu);

                MessageBox.Show("Data menu telah tersimpan.", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan menu. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            comboBoxKategoriMenu.SelectedIndex = 0;
            textBoxKodeMenu.Clear();
            textBoxNamaMenu.Clear();
            textBoxHargaMenu.Clear();
            textBoxDiskon.Clear();
            textBoxIdBahan.Clear();
            comboBoxNamaBahan.SelectedIndex = 0;
            textBoxTakaran.Clear();
            comboBoxKategoriMenu.Focus();
        }

        private void comboBoxKategoriMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriDipilih = (Kategori)comboBoxKategoriMenu.SelectedItem;

            textBoxKodeMenu.Text = Menus.GenerateKode(kategoriDipilih);
        }

        private void comboBoxNamaBahan_TextChanged(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("Nama", comboBoxNamaBahan.Text);

            comboBoxNamaBahan.DataSource = listOfBahan;
            comboBoxNamaBahan.DisplayMember = "Nama";
        }

        private void comboBoxNamaBahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfBahan = Bahan.BacaData("Nama", comboBoxNamaBahan.Text);

            if (listOfBahan.Count > 0)
            {
                textBoxIdBahan.Text = listOfBahan[0].IdBahan.ToString();

                textBoxTakaran.Focus();
            }
        }

        private void textBoxTakaran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewResep.Rows.Add(textBoxKodeMenu.Text, textBoxNamaMenu.Text, textBoxDiskon.Text, textBoxIdBahan.Text, comboBoxNamaBahan.Text, textBoxTakaran.Text);

                listOfBahan = Bahan.BacaData("Nama", comboBoxNamaBahan.Text);

                if (listOfBahan.Count > 0)
                {
                    textBoxIdBahan.Text = listOfBahan[0].IdBahan.ToString(); ;
                }

                comboBoxNamaBahan.SelectedIndex = 0;
                textBoxTakaran.Text = "1";
            }
        }

        private void textBoxIdBahan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdBahan.Text.Length == textBoxIdBahan.MaxLength)
            {
                if (textBoxIdBahan.Text.Substring(0, 1) == "0")
                {
                    listOfBahan = Bahan.BacaData("IdBahan", textBoxIdBahan.Text.Substring(1, 1));
                }
                else
                {
                    listOfBahan = Bahan.BacaData("IdBahan", textBoxIdBahan.Text);
                }

                if (listOfBahan.Count > 0)
                {
                    comboBoxNamaBahan.DataSource = listOfBahan;
                    comboBoxNamaBahan.DisplayMember = "Nama";
                    comboBoxNamaBahan.SelectedItem = comboBoxNamaBahan.FindStringExact(listOfBahan[0].Nama);
                    textBoxTakaran.Text = "1";

                    textBoxTakaran.Focus();
                }
                else
                {
                    MessageBox.Show("Menu dengan kode tersebut tidak ditemukan");
                }
            }
        }
    }
}
