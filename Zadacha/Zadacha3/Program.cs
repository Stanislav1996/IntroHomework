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
            Console.WriteLine("izberete 1.int ,2.double ili 3.string");
            string x = Console.ReadLine();
            switch (x)
            {
                case "int":
                    Console.WriteLine("Vuvedete chislo");
                    int a = int.Parse(Console.ReadLine());
                    a++;
                    Console.WriteLine(a);
                    break;
                case "double":
                    Console.WriteLine("Vuvedete chislo");
                    double b = double.Parse(Console.ReadLine());
                    b++;
                    Console.WriteLine(b);
                    break;
                case "string":
                    Console.WriteLine("Vuvedete string");
                    string str = Console.ReadLine();

                    Console.WriteLine(str + "*");
                    break;
                default:
                    Console.WriteLine("Gledai si rabotata");
                    break;
            }
        }
    }
}
