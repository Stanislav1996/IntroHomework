using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxi = 0, maxj = 0, mini = 0, minj = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int[,] masiv = new int[a, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    masiv[j, i] = int.Parse(Console.ReadLine());
                   
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (min > masiv[i,j])
                    {
                        min = masiv[i,j];
                        mini = i;
                        minj = j;
                    }
                    if (max < masiv[i, j])
                    {
                        max = masiv[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }

               
            }
            Console.WriteLine("MIN s indeksi " + min + " " + mini + " " + minj);
            Console.WriteLine("MAX s indeksi " + max + " " + maxi + "  " + maxj);
        }
    }
}
