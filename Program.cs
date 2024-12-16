using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_gitFeladatok
{
    internal class Program
    {
        static void F1(int[] tomb)
        {
            Random rnd = new Random();
            for (int a = 0; a < tomb.Length; a++)
            {
                tomb[a] = rnd.Next(1,51);
                Console.WriteLine(tomb[a]);
            }
        }

        static int F2(int[] tomb)
        {
            int szamlalo = 0;
            for (int a = 0; a < tomb.Length; a++)
            {
                if (tomb[a] % 2 == 0) { szamlalo++; }
            }
            return szamlalo;
        }

        static double F3(int[] tomb)
        {
            double atlag = 0;

            for (int a = 0; a < tomb.Length; a++)
            {
                atlag += tomb[a];
            }

            atlag /= tomb.Length;
            return atlag;
        }

        static int[] F4(int[] tomb)
        {
            int[] paratlanok = new int[10];

            for(int a = 0; a < tomb.Length; a++)
            {
                if (tomb[a] % 2 == 0) {tomb[a]++;}
                paratlanok[a] = tomb[a];
            }
            return paratlanok;
        }

        static void Main(string[] args)
        {
        }
    }
}
