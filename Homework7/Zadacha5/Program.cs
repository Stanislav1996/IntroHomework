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
            for (int i = 10; i < 999; i++)
            {
                if (i<100)
                {
                    Malki(i);
                }
                if (i>100)
                {
                  Golemi(i);
                }
            }
        }

        private static void Golemi(int i)
        {
            int b = i / 100;
            //Console.WriteLine(b);
            if(b==i)
            {
                Console.WriteLine(i);
            }
        }

        private static void Malki(int i)
        {
            int a=i/10;
            Console.WriteLine(a);
            if (a==i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
