using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploy
{
    class MyClasses
    {
        public class Urun
        {
            public int Id { get; set; }
            public string UrunAd { get; set; }
            public int Yukseklik { get; set; }
            public virtual double Hacim()
            {
                double hacim = Math.Pow(Convert.ToDouble(Yukseklik), 3);
                return Convert.ToInt32(hacim);
            }
            public int Fire()
            {
                return Convert.ToInt32(this.Hacim() * 0.20f);
            }
        }
        public class KupuKutu:Urun
        {

        }
        public class DortgenKutu : Urun
        {
            public int KisaKenar { get; set; }
            public int UzunKenar { get; set; }
            public override double Hacim()
            {
                return Yukseklik*KisaKenar*UzunKenar;
            }
        }
        public   class Silindir:Urun
        {
            private int yariCap;

            public int YariCap
            {
                get { return yariCap; }
                set { yariCap = value; }
            }
            public override double Hacim()
            {
                return Math.PI*Math.Pow(yariCap,2)*Yukseklik;    
            }

        }
    }
}
