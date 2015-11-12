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
            int a = int.Parse(Console.ReadLine());

            int[] masiv1 = new int[a];
            int[] masiv2 = new int[a];
            Console.WriteLine("Vuvedete purvi masiv: ");
            for (int i = 0; i < masiv1.Length; i++)
            {

                masiv1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vuvedete vtori masiv: ");
            for (int i = 0; i < masiv2.Length; i++)
            {

                masiv2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < masiv1.Length; i++)
            {
                for (int j = 0; j < masiv2.Length; j++)
                {
                    if(masiv1[i]==masiv2[j])
                    {
                        Console.WriteLine("Chisloto "+masiv1[i]+" sushtestvuva v dvata masiva");
                    }

                }
            }
        }
    }
}
