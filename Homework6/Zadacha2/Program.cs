using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete golemina na masiva: ");
            Console.WriteLine("Pojelanie da e po golqm ot 2 ");
            int a = int.Parse(Console.ReadLine());
            int[] masiv = new int[a];
            masiv[0] = 1;
            masiv[1] = 1;
            for (int i = 2; i < a; i++)
            {
                masiv[i] = masiv[i - 1] + masiv[i - 2];
            }
            for (int i = 1; i < a; i++)
            {
                Console.WriteLine(masiv[i-1]);

            }

        }
    }
}
