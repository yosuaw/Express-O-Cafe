using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Express_O_LIB
{
    public class DetilNotaBeli
    {
        private int harga;
        private int jumlah;
        private Bahan bahan;

        #region Constructors
        public DetilNotaBeli(int harga, int jumlah, Bahan bahan)
        {
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.Bahan = bahan;
        }
        #endregion

        #region Properties
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Bahan Bahan { get => bahan; set => bahan = value; }
        #endregion
    }
}