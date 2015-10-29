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
            int a = int.Parse(Console.ReadLine());
            int[] masiv1 = new int[a];
            for (int i = 0; i < a; i++)
            {

                masiv1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vuvedete chislo koeto tursime: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {


                if (masiv1[i]==b)
                {
                    Console.WriteLine("NIndeksa na chisloto e :"+i);
                    break;
                }
            }
        }
    }
}
