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
    public partial class FormTambahNotaJual : Form
    {
        FormMenu formMenu;
        List<Member> listOfMember = new List<Member>();
        List<Menus> listOfMenu = new List<Menus>();
        NotaJual notaJual;
        int subTotal;

        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewNotaJual.Columns.Clear();

            dataGridViewNotaJual.Columns.Add("KodeMenu", "Kode");
            dataGridViewNotaJual.Columns.Add("NamaMenu", "Nama Menu");
            dataGridViewNotaJual.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewNotaJual.Columns.Add("Jumlah", "Jumlah");
            dataGridViewNotaJual.Columns.Add("Diskon", "Diskon");
            dataGridViewNotaJual.Columns.Add("SubTotal", "SubTotal");

            dataGridViewNotaJual.Columns["KodeMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaJual.Columns["NamaMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaJual.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaJual.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaJual.Columns["Diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNotaJual.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewNotaJual.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNotaJual.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNotaJual.Columns["Diskon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNotaJual.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewNotaJual.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";
            dataGridViewNotaJual.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            dataGridViewNotaJual.AllowUserToAddRows = false;
            dataGridViewNotaJual.ReadOnly = true;
        }

        private void HitungSubTotal()
        {
            int harga = int.Parse(labelHarga.Text);
            int jumlah = int.Parse(textBoxJumlah.Text);
            double diskon = double.Parse(labelDiskonPersen.Text);
            int nilaiDiskon = (int)(diskon / 100 * (harga * jumlah));

            subTotal = harga * jumlah - nilaiDiskon;
            labelSubTotal.Text = subTotal.ToString("#,###");
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.ParentForm;
            textBoxNomorNota.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxKode.MaxLength = 3;

            textBoxNomorNota.Text = NotaJual.GenerateNoNota(dateTimePickerTanggal.Value);
            labelNama.Text = formMenu.labelUsername.Text;
            comboBoxNamaMember.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;

            listOfMember = Member.BacaData("", "");
            comboBoxNamaMember.DataSource = listOfMember;
            comboBoxNamaMember.DisplayMember = "Nama";

            listOfMenu = Menus.BacaData("", "");
            comboBoxNamaMenu.DataSource = listOfMenu;
            comboBoxNamaMenu.DisplayMember = "Nama";
            comboBoxNamaMenu.SelectedIndex = 0;

            comboBoxMetodePembayaran.Items.Add("Cash");
            comboBoxMetodePembayaran.Items.Add("Kartu Kredit");
            comboBoxMetodePembayaran.Items.Add("OVO");
            comboBoxMetodePembayaran.Items.Add("GoPay");
            comboBoxMetodePembayaran.SelectedIndex = 0;

            FormatDataGrid();


        }

        private void comboBoxNamaMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNamaMember.SelectedIndex != -1)
            {
                Member member = (Member)comboBoxNamaMember.SelectedItem;
                textBoxAlamat.Text = member.Alamat;
            }
            else
            {
                labelAlamat.Text = "";
            }
        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {
            textBoxNomorNota.Text = NotaJual.GenerateNoNota(dateTimePickerTanggal.Value);
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length == textBoxKode.MaxLength)
            {
                listOfMenu = Menus.BacaData("KodeMenu", textBoxKode.Text);

                if (listOfMenu.Count > 0)
                {
                    comboBoxNamaMenu.DataSource = listOfMenu;
                    comboBoxNamaMenu.DisplayMember = "Nama";
                    comboBoxNamaMenu.SelectedItem = comboBoxNamaMenu.FindStringExact(listOfMenu[0].Nama);
                    labelHarga.Text = listOfMenu[0].Harga.ToString();
                    labelDiskonPersen.Text = listOfMenu[0].Diskon.ToString();
                    textBoxJumlah.Text = "1";

                    textBoxJumlah.Focus();
                }
                else
                {
                    MessageBox.Show("Menu dengan kode tersebut tidak ditemukan");
                }
            }
        }

        private int HitungGrandTotal()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewNotaJual.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewNotaJual.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal += subTotal;
            }
            return grandTotal;
        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                if (textBoxJumlah.Text == "" || int.Parse(textBoxJumlah.Text) <= 0)
                {
                    textBoxJumlah.Text = "1";
                    textBoxKode.Focus();
                    textBoxJumlah.Focus();
                }

                HitungSubTotal();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewNotaJual.Rows.Add(textBoxKode.Text, comboBoxNamaMenu.Text, labelHarga.Text, textBoxJumlah.Text, labelDiskonPersen.Text, subTotal);

                labelGrandTotal.Text = HitungGrandTotal().ToString("#,###");

                listOfMenu = Menus.BacaData("m.Nama", comboBoxNamaMenu.Text);

                if (listOfMenu.Count > 0)
                {
                    textBoxKode.Text = listOfMenu[0].KodeMenu;
                }

                comboBoxNamaMenu.SelectedIndex = 0;
                textBoxJumlah.Text = "1";
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Member memberDipilih = (Member)comboBoxNamaMember.SelectedItem;
                Karyawan karyawanDipilih = formMenu.karyawanDipilih;
                notaJual = new NotaJual(textBoxNomorNota.Text, dateTimePickerTanggal.Value, comboBoxMetodePembayaran.Text, memberDipilih, karyawanDipilih);
                List<Menus> listOfMenu = new List<Menus>();

                for (int i = 0; i<dataGridViewNotaJual.Rows.Count; i++)
                {
                    string kodeMenu = dataGridViewNotaJual.Rows[i].Cells["KodeMenu"].Value.ToString();
                    int harga = int.Parse(dataGridViewNotaJual.Rows[i].Cells["HargaJual"].Value.ToString());
                    int jumlah = int.Parse(dataGridViewNotaJual.Rows[i].Cells["Jumlah"].Value.ToString());
                    int diskon = int.Parse(dataGridViewNotaJual.Rows[i].Cells["Diskon"].Value.ToString());
                    listOfMenu = Menus.BacaData("KodeMenu", kodeMenu);
                    notaJual.TambahDetilNotaJual(harga, jumlah, diskon, listOfMenu[0]);
                }

                NotaJual.TambahData(notaJual);

                MessageBox.Show("Data nota jual telah tersimpan.", "Informasi");

                try
                {
                    NotaJual.CetakNota("NomorNota", textBoxNomorNota.Text, "nota_jual.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota jual berhasil dicetak");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nota jual gagal dicetak. Pesan kesalahan : " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nota. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }      

        private void comboBoxNamaMenu_TextChanged(object sender, EventArgs e)
        {
            listOfMenu = Menus.BacaData("m.Nama", comboBoxNamaMenu.Text);

            comboBoxNamaMenu.DataSource = listOfMenu;
            comboBoxNamaMenu.DisplayMember = "Nama";
        }

        private void comboBoxNamaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfMenu = Menus.BacaData("m.Nama", comboBoxNamaMenu.Text);

            if (listOfMenu.Count > 0)
            {
                textBoxKode.Text = listOfMenu[0].KodeMenu;
                labelHarga.Text = listOfMenu[0].Harga.ToString();
                labelDiskonPersen.Text = listOfMenu[0].Diskon.ToString();
                textBoxJumlah.Text = "1";

                HitungSubTotal();
                textBoxJumlah.Focus();
            }
        }
    }
}
