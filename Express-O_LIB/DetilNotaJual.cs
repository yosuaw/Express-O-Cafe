using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Express_O_LIB
{
    public class DetilNotaJual
    {
        private int harga;
        private int jumlah;
        private int diskon;
        private Menus menu;

        #region Constructors
        public DetilNotaJual(int harga, int jumlah, int diskon, Menus menu)
        {
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.Diskon = diskon;
            this.Menu = menu;
        }
        #endregion

        #region Properties
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public int Diskon { get => diskon; set => diskon = value; }
        public Menus Menu { get => menu; set => menu = value; }
        #endregion
    }
}