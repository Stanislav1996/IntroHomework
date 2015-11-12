using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
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
            for (int i = 0; i < a; i++)
            {
                if (masiv1[i]>masiv1[i+1])
                {
                    i++; 
                }
                
            }
            foreach (var item in masiv1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
