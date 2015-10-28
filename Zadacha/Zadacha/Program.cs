using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 5)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Chisloto e chetno i e v intervala 1-5");

                }
                else
                {
                    Console.WriteLine("Chisloto e nechetno i e v intervala 1-5");
                }
            }
            else if (a >= 6 && a <= 15)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine("chisloto e v intervala 6-15 i se deli na 3");
                }
                else
                {
                    Console.WriteLine("chisloto e v intervala 6-15 i ne se deli na 3");
                }

            }
            else if (a == 0)
            {
                Console.WriteLine("Chisloto e 0");
            }
            else if (a < 0)
            {
                Console.WriteLine("Chisloto e otricatelno");
            }
            else if (a > 15)
            {
                Console.WriteLine("Chisloto e polojitelno");
            }
        }
    }
}
