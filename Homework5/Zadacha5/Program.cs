using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nfakt = 1, kfakt = 1,minusfakt=1,minus=1;
            double result;
            minus = n - k;
            for (int i = 1; i < n; i++)

            {
                nfakt = nfakt * i;
            }
            for (int i = 1; i < k; i++)

            {
                kfakt = kfakt * i;
            }
            for (int i = 1; i < minus; i++)
            {
                minusfakt = minusfakt * i;

            }
            result = (nfakt * kfakt)/minusfakt;
            Console.WriteLine(result);
        }
    }
}
