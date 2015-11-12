using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete strana na kvadratna matrica: ");
            int a = int.Parse(Console.ReadLine());
            int[,] masiv = new int[a, a];
            int b = a * a;
            int[] masiv1 = new int[b];
            int sum = 0;
            Random x = new Random();
            int c,counter=0;
            Console.WriteLine("Vuvedete Simvolite v matricata: ");
            for (int i = 0; i < masiv1.Length; i++)
            {
                c = x.Next(0, 10);
                masiv1[i]= c;
                sum = sum + masiv1[i];
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <a; j++)
                {
                    masiv[ j,i] = masiv1[counter];
                    counter++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(masiv[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumata na masiva e: "+sum);

            for (int i = 0; i < b; i++)
            {
                Console.Write(masiv1[i]);
            }

        }
    }
}
