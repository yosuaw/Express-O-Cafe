using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Express_O_LIB
{
    public class Resep
    {
        Bahan bahan;
        double takaran;

        #region Constructors
        public Resep(Bahan bahan, double takaran)
        {
            this.Bahan = bahan;
            this.Takaran = takaran;
        }
        #endregion

        #region Properties
        public Bahan Bahan { get => bahan; set => bahan = value; }
        public double Takaran { get => takaran; set => takaran = value; }
        #endregion

        #region Methods
        #endregion
    }
}