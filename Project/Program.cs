using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {

        public static List<int> szamok = new List<int>();

        static void Main(string[] args)
        {
            
            Bekeres();
            Console.ReadLine();
        }

        static void Bekeres()
        {
            Console.WriteLine("Kérem adja meg hogy hány számot akar beírni: ");
            String darab = Console.ReadLine();

            try
            {
                int i = 0;
                while (i < Convert.ToInt32(darab))
                {
                    Console.Write("Kérem adja meg az " + (i+1) + ". számot a" + darab + " : ");
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                    i++;
                }

                int max = szamok[0];
                int maxIndex = 0;
                int min = szamok[0];
                int minIndex = 0;

                for (int j = 0; j < szamok.Count; j++)
                {
                    if (szamok[j] > max)
                    {
                        max = szamok[j];
                        maxIndex = j;
                    }
                    if (szamok[j] < min)
                    {
                        min = szamok[j];
                        minIndex = j;
                    }
                }
                Console.WriteLine("A legnagyobb szám az: " + szamok[maxIndex] + "\nA legkisebb szám az: " + szamok[minIndex]);

            }
            catch
            {
                Console.WriteLine("Nem elfogadott karakter használat!");
            }
        }
    }
}
