using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 30;

            int[,] masiv = new int[5,6];
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, j] = a;
                    a--;
                }
            }
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    Console.Write("\t " + masiv[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
