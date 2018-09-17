using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibingerMikulicPonavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaB klasa = new KlasaB();
            int [] niz = new int[5];
            Console.WriteLine("Unesite 5 brojeva.");
            for (int i=0;i<5;i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());

            }
            int zbroj = klasa.Zbroj(niz);
            double prosjek = klasa.Prosjek(niz);
            Console.WriteLine("Zbroj:{0}",zbroj);
            Console.WriteLine("\nProsjek:{0}",prosjek);
            Console.ReadKey();
        }
    }
}
