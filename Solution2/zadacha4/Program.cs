using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sbor1 = 0;
            int sbor2 = 0;
            int indikator = 0;
            int[] masiv1 = new int[a+5];
            for (int i = 0; i < a; i++)
            {

                masiv1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <a; i++)
            {
                sbor1 = masiv1[i] + masiv1[i + 1] + masiv1[i + 2] + masiv1[i + 3] + masiv1[i + 4];
                if (sbor2<sbor1)
                {
                    sbor2 = sbor1;
                    indikator = i;
                }

            }
            Console.WriteLine(sbor2);
            Console.WriteLine(masiv1[indikator] +" "+ masiv1[indikator + 1] + " " + masiv1[indikator + 2] + " " + masiv1[indikator
                + 3] + " " + masiv1[indikator + 4]);

        }
    }
}
