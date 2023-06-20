using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace Express_O_LIB
{
    public class Cetak
    {
        private Font jenisFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;

        #region Constructors
        public Cetak(string namaFile, Font jenisFont, float marginKiri, float marginKanan, float marginAtas, float marginBawah)
        {
            this.FileCetak = new StreamReader(namaFile);
            this.JenisFont = jenisFont;
            this.MarginKiri = marginKiri;
            this.MarginKanan = marginKanan;
            this.MarginAtas = marginAtas;
            this.MarginBawah = marginBawah;
        }
        #endregion

        #region Properties
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion

        #region Methods
        private void CetakTulisan(object sender, PrintPageEventArgs e)
        {
            int jumlahBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah - MarginAtas) / jenisFont.GetHeight(e.Graphics));
            float y = MarginAtas;
            int jumlahBaris = 0;
            string tulisanCetak = FileCetak.ReadLine();

            while (jumlahBaris < jumlahBarisPerHalaman && tulisanCetak != null)
            {
                y = MarginAtas + (jumlahBaris * jenisFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(tulisanCetak, JenisFont, Brushes.Black, MarginKiri, y);
                jumlahBaris++;
                tulisanCetak = FileCetak.ReadLine();
            }

            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void CetakKePrinter(string tipe)
        {
            PrintDocument print = new PrintDocument();

            if (tipe == "text")
            {
                print.PrintPage += new PrintPageEventHandler(CetakTulisan);
            }

            print.Print();

            FileCetak.Close();
        }
        #endregion
    }
}
