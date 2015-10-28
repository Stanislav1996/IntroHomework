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
            int max=0, min=10000;
            Console.WriteLine("Vudete broq chisla koito iskate da vuvedete: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a + 1; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d>max)
                {
                    max = d; 
                }
                if (d<min)
                {
                    min = d;
                }
            }
            Console.WriteLine("max e " +max);
            Console.WriteLine("min e " +min);
        }
    }
}
