using System;
using System.Collections.Generic;
using System.Linq;
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


        static void Main(string[] args)
        {
        }
    }
}
