using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachaotchas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] masiv = new int[4, 4];
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    if (masiv[i, j] % 2 == 1)
                    {
                        masiv[i, j] = masiv[i, j] * 2;
                    }
                }
            }
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    Console.Write(masiv[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
