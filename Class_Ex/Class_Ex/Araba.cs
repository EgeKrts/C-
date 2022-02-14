using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Ex
{
    class Araba : ArabaDetay
    {
        public String renk;
        public int hız;
        public double motor;
        public String durum;
        public int fiyat;

        private int yil;
        private String Marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        
        public String MARKA
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
