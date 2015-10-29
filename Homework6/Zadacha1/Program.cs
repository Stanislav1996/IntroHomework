using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete golemina na masiva: ");
            int a = int.Parse(Console.ReadLine());
            int b,sbor=0;
            int[] masiv1=new int[a] ;
            for (int i = 0; i < a; i++)
            {
                b = int.Parse(Console.ReadLine());
                masiv1[i] = b;
            }
            for (int i = 0; i < a; i++)
            {

                if (i%2==0)
                {
                    sbor = sbor + masiv1[i];
                }
            }
            Console.WriteLine(sbor);
        }
    }
}
