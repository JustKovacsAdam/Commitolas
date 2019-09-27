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

            try
            {
                int i = 0;
                while (i < 10)
                {
                    Console.Write("Kérem adja meg az " + (i+1) + ". számot a 10-ből: ");
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                    i++;
                }

                int max = szamok[0];
                int maxIndex = 0;


                for (int j = 0; j < szamok.Count; j++)
                {
                    if (szamok[j] > max)
                    {
                        max = szamok[j];
                        maxIndex = j;
                    }

                }
                Console.WriteLine("A legnagyobb szám az: " + szamok[maxIndex]);

            }
            catch
            {

            }
        }
    }
}
