using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachaotchas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int a = int.Parse(Console.ReadLine());

            int[,] masiv = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    masiv[i, j] = a;
                    a--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t " + masiv[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
