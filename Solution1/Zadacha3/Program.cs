using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete a i b : kato b>a");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (; a < b; a++)
            {
                if (a%3==0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
