using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odwracanie_tablic__metody_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5, 6, 7 };
            int[] odwroconaTablica = odwrocTablice(tablica);
            Console.WriteLine("Tablica:");
            wypiszTablice(tablica);
            Console.WriteLine("");
            Console.WriteLine("Odwrócona tablica:");
            wypiszTablice(odwroconaTablica);
            Console.ReadKey();
        }

        private static void wypiszTablice(int[] tablica)
        {
            for (int j = 0; j < tablica.Length; j++)
            {
                Console.WriteLine(tablica[j]);
            }
        }

        private static int[] odwrocTablice(int[] tablica)
        {
            int[] odwroconaTablica = new int[tablica.Length];
            int p = odwroconaTablica.Length - 1;

            for (int i = 0; i < tablica.Length; i++)
            {
                odwroconaTablica[i] = tablica[p];
                p--;
            }
            return odwroconaTablica;
        }
    }
}
