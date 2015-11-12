using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            int[] masiv1 = new int[10];
            for (int i = 0; i < masiv1.Length; i++)
            {

                masiv1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i=i+2)//chetni
            {

                if(min<masiv1[i])
                {
                    min = masiv1[i];
                }
            }

            for (int i = 1; i < 10; i = i + 2)//nechetni
            {

                if (max > masiv1[i])
                {
                    max = masiv1[i];
                }
            }
            Console.WriteLine("max "+min);
            Console.WriteLine("min "+max);
        }
    }
}
