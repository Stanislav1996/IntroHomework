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
            Console.WriteLine("Molq vuvedete chislo: ");
            int a = int.Parse(Console.ReadLine());
            if (a<=3 && a>=1)
            {
                a = a * 5;
                Console.WriteLine("Vashiqt rezultat e: "+a);
            }
            else if (a <= 6 && a >= 4)
            {
                a = a * 10;
                Console.WriteLine("Vashiqt rezultat e: "+a);
            }
            else if (a <= 9 && a >= 7)
            {
                a = a * 50;
                Console.WriteLine("Vashiqt rezultat e: "+a);
            }

        }
    }
}
