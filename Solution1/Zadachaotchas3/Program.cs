using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachaotchas3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int[,] masiv = new int[a, a];
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
                    Console.Write(masiv[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <a; i++)
            {
                b = b + masiv[i, i];
            }
            Console.WriteLine(b);
        }
    }
}
