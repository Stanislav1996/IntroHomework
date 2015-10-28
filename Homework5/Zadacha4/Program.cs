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

            /*    do
                 {
                     int k = int.Parse(Console.ReadLine());
                     int n = int.Parse(Console.ReadLine());
                 } while (1<k && k<n);
      */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nfakt=1, kfakt=1;
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
