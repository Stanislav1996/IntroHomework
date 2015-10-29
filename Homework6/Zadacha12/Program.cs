
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("golemi na masiva");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            for (int i = 0; i < n; i++)
            {
                masiv[i] = i;
                
            }
            for (int i = 0; i < n; n--)
            {
                Console.WriteLine(n-1);

            }
        }
    }
}
