using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] masiv2 = new int[a];
            int[] masiv1 = new int[a];
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                masiv1[i] = b;
            }
            for (int i = 0; i < a; i++)
            {
               
                masiv2[i] = masiv1[i];
            }

            foreach (var asd in masiv2)
            {
                Console.WriteLine(asd);
            }
        }
    }
}
