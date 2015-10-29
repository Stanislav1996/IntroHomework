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
            /*
            bool first, second;
            int n, k;
            do
            {
                Console.WriteLine("Vuvedete N :");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedete K :");
                k = int.Parse(Console.ReadLine());
                first = k > 1;
                second = n > k;
            } while (first == true && second == true);
            */
             int n = int.Parse(Console.ReadLine());
             int k = int.Parse(Console.ReadLine());
            int nfakt = 1, kfakt = 1;
            double result;
            for (int i = 1; i < n; i++)

            {
                nfakt = nfakt * i;
            }
            for (int i = 1; i < k; i++)

            {
                kfakt = kfakt * i;
            }
            result = nfakt / kfakt;
            Console.WriteLine(result);
        }

    }
}
