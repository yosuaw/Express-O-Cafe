using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Express_O_LIB;
using System.Globalization;

namespace Express_O_Cafe
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void radioButtonTahun_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBulan.Enabled = false;
            labelJudul.Text = comboBoxTahun.Text;
            labelBulanTerbanyak.Visible = true;
            labelBulanPenjualan.Visible = true;
        }

        private void radioButtonBulan_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBulan.Enabled = true;
            labelJudul.Text = comboBoxBulan.Text + comboBoxTahun.Text;
            labelBulanTerbanyak.Visible = false;
            labelBulanPenjualan.Visible = false;
        }

        private void comboBoxTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tahun = comboBoxTahun.Text;
            TampilData(tahun);
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tahun = comboBoxTahun.Text;
            string bulan = "";
            switch (comboBoxBulan.Text)
            {
                case "Januari":
                    bulan = "1";
                    break;
                case "Februari":
                    bulan = "2";
                    break;
                case "Maret":
                    bulan = "3";
                    break;
                case "April":
                    bulan = "4";
                    break;
                case "Mei":
                    bulan = "5";
                    break;
                case "Juni":
                    bulan = "6";
                    break;
                case "Juli":
                    bulan = "7";
                    break;
                case "Agustus":
                    bulan = "8";
                    break;
                case "September":
                    bulan = "9";
                    break;
                case "Oktober":
                    bulan = "10";
                    break;
                case "November":
                    bulan = "11";
                    break;
                case "Desember":
                    bulan = "12";
                    break;
            }
            labelJudul.Text = comboBoxBulan.Text + " " + comboBoxTahun.Text;
            TampilData(tahun, bulan);
        }

        private void HapusIsiLabel()
        {
            labelJumlahTransaksi.Text = "0";
            labelJumlahPenjualan.Text = "0";
            labelNamaMenu.Text = "";
            labelPendapatan.Text = "0";
            labelPengeluaran.Text = "0";
            labelBulanTerbanyak.Text = "";
        }

        private void TampilData(string tahun)
        {
            string sql1 = "SELECT COUNT(notajual.NomorNota) FROM notajual WHERE YEAR(notajual.Tanggal) = '" + tahun + "'";
            string sql2 = "SELECT SUM(dnj.Jumlah) AS Jumlah, m.Nama FROM detilnotajual dnj INNER JOIN notajual n ON dnj.NomorNota = n.NomorNota INNER JOIN menu m ON dnj.KodeMenu = m.KodeMenu WHERE YEAR(n.Tanggal) = '" + tahun + "' GROUP BY dnj.KodeMenu ORDER BY Jumlah DESC LIMIT 1";
            string sql3 = "SELECT SUM(Harga.Hasil) FROM(SELECT (dnj.Harga - ROUND(dnj.Harga * dnj.Diskon / 100)) * dnj.Jumlah AS Hasil FROM detilnotajual dnj INNER JOIN notajual n ON n.NomorNota = dnj.NomorNota WHERE YEAR(n.Tanggal) = '" + tahun + "') AS Harga";
            string sql4 = "SELECT SUM(Harga.Hasil) FROM(SELECT dnb.Harga * dnb.Jumlah AS Hasil FROM detilnotabeli dnb INNER JOIN notabeli n ON n.NomorNota = dnb.NomorNota WHERE YEAR(n.Tanggal) = '" + tahun + "') AS Harga";
            string sql5 = "SELECT MONTH(notajual.Tanggal) FROM notajual WHERE YEAR(notajual.Tanggal) = '" + tahun + "' GROUP BY MONTH(notajual.Tanggal) ORDER BY COUNT(notajual.NomorNota) DESC LIMIT 1";
            DataTableReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            DataTableReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);
            DataTableReader hasilData3 = Koneksi.JalankanPerintahQuery(sql3);
            DataTableReader hasilData4 = Koneksi.JalankanPerintahQuery(sql4);
            DataTableReader hasilData5 = Koneksi.JalankanPerintahQuery(sql5);
            if (hasilData1.Read() == true)
            {
                labelJumlahTransaksi.Text = hasilData1.GetValue(0).ToString();
            }
            else
            {
                HapusIsiLabel();
            }
            if (hasilData2.Read() == true)
            {
                if (hasilData2.GetValue(0).ToString() != "" && hasilData2.GetValue(1).ToString() != "")
                {
                    labelJumlahPenjualan.Text = hasilData2.GetValue(0).ToString();
                    labelNamaMenu.Text = hasilData2.GetValue(1).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            if (hasilData3.Read() == true)
            {
                if (hasilData3.GetValue(0).ToString() != "")
                {
                    labelPendapatan.Text = hasilData3.GetValue(0).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            if (hasilData4.Read() == true)
            {
                if (hasilData4.GetValue(0).ToString() != "")
                {
                    labelPengeluaran.Text = hasilData4.GetValue(0).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            labelKeuntungan.Text = (int.Parse(labelPendapatan.Text) - int.Parse(labelPengeluaran.Text)).ToString();
            string bulanTertinggi = "";
            if (hasilData5.Read() == true)
            {
                bulanTertinggi = hasilData5.GetValue(0).ToString();
            }
            else
            {
                HapusIsiLabel();
            }

            switch (bulanTertinggi)
            {
                case "1":
                    labelBulanTerbanyak.Text = "Januari";
                    break;
                case "2":
                    labelBulanTerbanyak.Text = "Februari";
                    break;
                case "3":
                    labelBulanTerbanyak.Text = "Maret";
                    break;
                case "4":
                    labelBulanTerbanyak.Text = "April";
                    break;
                case "5":
                    labelBulanTerbanyak.Text = "Mei";
                    break;
                case "6":
                    labelBulanTerbanyak.Text = "Juni";
                    break;
                case "7":
                    labelBulanTerbanyak.Text = "Juli";
                    break;
                case "8":
                    labelBulanTerbanyak.Text = "Agustus";
                    break;
                case "9":
                    labelBulanTerbanyak.Text = "September";
                    break;
                case "10":
                    labelBulanTerbanyak.Text = "Oktober";
                    break;
                case "11":
                    labelBulanTerbanyak.Text = "November";
                    break;
                case "12":
                    labelBulanTerbanyak.Text = "Desember";
                    break;
            }
        }

        private void TampilData(string tahun, string bulan)
        {
            string sql1 = "SELECT COUNT(notajual.NomorNota) FROM notajual WHERE YEAR(notajual.Tanggal) = '" + tahun + "' AND MONTH(notajual.Tanggal) = '" + bulan + "'";
            string sql2 = "SELECT SUM(dnj.Jumlah) AS Jumlah, m.Nama FROM detilnotajual dnj INNER JOIN notajual n ON dnj.NomorNota = n.NomorNota INNER JOIN menu m ON dnj.KodeMenu = m.KodeMenu WHERE YEAR(n.Tanggal) = '" + tahun + "' AND MONTH(n.Tanggal) = '" + bulan + "' GROUP BY dnj.KodeMenu ORDER BY Jumlah DESC LIMIT 1";
            string sql3 = "SELECT SUM(Harga.Hasil) FROM(SELECT (dnj.Harga - ROUND(dnj.Harga * dnj.Diskon / 100)) * dnj.Jumlah AS Hasil FROM detilnotajual dnj INNER JOIN notajual n ON n.NomorNota = dnj.NomorNota WHERE YEAR(n.Tanggal) = '" + tahun + "' AND MONTH(n.Tanggal) = '" + bulan + "') AS Harga";
            string sql4 = "SELECT SUM(Harga.Hasil) FROM(SELECT dnb.Harga * dnb.Jumlah AS Hasil FROM detilnotabeli dnb INNER JOIN notabeli n ON n.NomorNota = dnb.NomorNota WHERE YEAR(n.Tanggal) = '" + tahun + "' AND MONTH(n.Tanggal) = '" + bulan + "') AS Harga";
            DataTableReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            DataTableReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);
            DataTableReader hasilData3 = Koneksi.JalankanPerintahQuery(sql3);
            DataTableReader hasilData4 = Koneksi.JalankanPerintahQuery(sql4);
            if (hasilData1.Read() == true)
            {
                if (hasilData1.GetValue(0).ToString() != "")
                {
                    labelJumlahTransaksi.Text = hasilData1.GetValue(0).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            if (hasilData2.Read() == true)
            {
                if (hasilData2.GetValue(0).ToString() != "" && hasilData2.GetValue(1).ToString() != "")
                {
                    labelJumlahPenjualan.Text = hasilData2.GetValue(0).ToString();
                    labelNamaMenu.Text = hasilData2.GetValue(1).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            if (hasilData3.Read() == true)
            {
                if (hasilData3.GetValue(0).ToString() != "")
                {
                    labelPendapatan.Text = hasilData3.GetValue(0).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            if (hasilData4.Read() == true)
            {
                if (hasilData4.GetValue(0).ToString() != "")
                {
                    labelPengeluaran.Text = hasilData4.GetValue(0).ToString();
                }
                else
                {
                    HapusIsiLabel();
                }
            }
            labelKeuntungan.Text = (int.Parse(labelPendapatan.Text) - int.Parse(labelPengeluaran.Text)).ToString();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            radioButtonTahun.Checked = true;
            radioButtonBulan.Checked = false;

            comboBoxTahun.DataSource = DapatTahun();
            labelJudul.Text = comboBoxTahun.Text;
        }

        private List<int> DapatTahun()
        {
            List<int> listTahun = new List<int>();
            string sql = "SELECT DISTINCT YEAR(tanggal) FROM notajual";
            DataTableReader hasilData = Koneksi.JalankanPerintahQuery(sql);
            while (hasilData.Read() == true)
            {
                listTahun.Add(int.Parse(hasilData.GetValue(0).ToString()));
            }
            return listTahun;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("Laporan Express-O Cafe.txt");

                file.WriteLine("EXPRESS-O CAFE");
                file.WriteLine("Laporan Penjualan & Pembelian");
                file.WriteLine("");
                file.WriteLine("-".PadRight(64, '-'));

                if (radioButtonTahun.Checked)
                {
                    file.WriteLine("Tahun: " + comboBoxTahun.Text);

                }
                else if (radioButtonBulan.Checked)
                {
                    file.WriteLine("Bulan-Tahun: " + comboBoxBulan.Text + "-" + comboBoxTahun.Text);

                }

                file.WriteLine("-".PadRight(64, '-'));
                file.WriteLine("1. Jumlah Transaksi Jual".PadRight(60, ' ') + labelJumlahTransaksi.Text.PadLeft(4, ' '));
                file.WriteLine("2. Jumlah Penjualan Menu Terbanyak".PadRight(60, ' ') + labelJumlahPenjualan.Text.PadLeft(4, ' '));
                file.WriteLine("3. Nama Penjualan Menu Terbanyak".PadRight(44, ' ') + labelNamaMenu.Text.PadLeft(20, ' '));
                file.WriteLine("4. Pendapatan".PadRight(55, ' ') + labelPendapatan.Text.PadLeft(9, ' '));
                file.WriteLine("5. Pengeluaran".PadRight(55, ' ') + labelPengeluaran.Text.PadLeft(9, ' '));
                file.WriteLine("6. Keuntungan".PadRight(55, ' ') + labelKeuntungan.Text.PadLeft(9, ' '));

                if (radioButtonTahun.Checked)
                {
                    file.WriteLine("7. Bulan Dengan Penjualan Terbanyak".PadRight(55, ' ') + labelBulanTerbanyak.Text.PadLeft(9, ' '));
                }

                file.WriteLine("-".PadRight(64, '-'));

                file.Close();

                Cetak cetak = new Cetak("Laporan Express-O Cafe.txt", new Font("Courier New", 12), 20, 10, 10, 10);
                cetak.CetakKePrinter("text");

                MessageBox.Show("Laporan berhasil dicetak", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Laporan gagal dicetak. Pesan kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
