using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1t
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi=0;
            int drugi=0;
            int treci=0;

            prvii: Console.Write("Upisi 1. dvoznamenkasti broj:");
            prvi = Convert.ToInt32(Console.ReadLine());
            if (prvi < 10 || prvi > 100)
            {
                goto prvii;
            }
            drugii: Console.Write("Upisi 2. dvoznamenkasti broj:");
            drugi = Convert.ToInt32(Console.ReadLine());
            if (drugi < 10 || drugi > 100)
            {
                goto drugii;
            }
            trecii: Console.Write("Upisi 3. dvoznamenkasti broj:");
            treci = Convert.ToInt32(Console.ReadLine());
            if (treci < 10 || treci > 100)
            {
                goto trecii;
            }

            if (prvi > drugi)
            {
                if (prvi > treci) 
                {
                    Console.WriteLine(prvi);
                }
            }
            if (drugi > prvi)
            {
                if (drugi > treci)
                {
                    Console.WriteLine(drugi);
                }
            }
            if (treci > prvi)
            {
                if (treci > drugi)
                {
                    Console.WriteLine(treci);
                }
            }

            if (prvi == drugi || prvi == treci)
            {
                Console.WriteLine("Nemojte upisivati dva ista broja");
            }
            if (drugi == prvi || drugi == treci)
            {
                Console.WriteLine("Nemojte upisivati dva ista broja");
            }
            if (treci == drugi || treci == prvi)
            {
                Console.WriteLine("Nemojte upisivati dva ista broja");
            }

            Console.ReadKey();
        }
    }
}
