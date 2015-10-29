using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b, sbor = 0;
            int[] masiv1 = new int[a];
            for (int i = 0; i < a; i++)
            {

                masiv1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {


                if (masiv1[i] != masiv1[a-i-1])
                {
                    Console.WriteLine( "Ne simetrichen");
                    break;
                }
            }

        }
    }
}
