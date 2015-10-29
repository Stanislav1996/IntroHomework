
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
      
            int[] masiv1 = new int[a];
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                masiv1[i] = b;
            }
            for (int i = 0; i < a/2; i++)
            {
                int c = masiv1[i];
                masiv1[i] = masiv1[a-i-1];
                masiv1[a - i - 1] = c;
            }

            foreach (var asd in masiv1)
            {
                Console.WriteLine(asd);
            }
        }
    }
}
