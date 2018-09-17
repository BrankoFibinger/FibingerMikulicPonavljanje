using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibingerMikulicPonavljanje
{
    class KlasaB
    {
        int zbroj;
        double prosjek;

        public double GetProsjek()
        {
            return prosjek;
        }

        public void SetProsjek(double value)
        {
            prosjek = value;
        }

        public int GetZbroj()
        {
            return zbroj;
        }

        public void SetZbroj(int value)
        {
            zbroj = value;
        }
        double broj = 0;
        public int Zbroj (int[]zbrojNiz)
        {
            
            for (int i=0;i<5;i++)
            {
                broj = broj + zbrojNiz[i];
            }
            return Convert.ToInt32(broj);

        }
        double broj2;
        public double Prosjek (int [] prosjekNiz)
        {
            for (int j=0;j<5;j++)
            {
                broj2 = broj / 5;
            }
            return broj2;
        }
    }
}
