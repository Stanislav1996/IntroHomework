using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double d, x, y;
            d = b * b - 4 * a * c;
            if(d==0)
            {
                
                Console.WriteLine(-b/(2*a));
            }
            if(d>0)
            {
                Console.WriteLine((-b + Math.Sqrt(d))/2*a);
                Console.WriteLine((-b + Math.Sqrt(d)) / 2 * a);

            }
            if (d<0)
            {
                Console.WriteLine( "N.R");
            }
        }
    }
}
