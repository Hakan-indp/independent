using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string plaka;
            Console.WriteLine("Lütfen plaka numaranızı giriniz");
            plaka = Console.ReadLine();
            switch (plaka)

            {
                case "33":
                    Console.WriteLine("33 Mersin");
                    break;
                case "34":
                    Console.WriteLine("34 İstanbul");
                    break;
                case "01":
                    Console.WriteLine("01 Adana");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    break;
                    Console.ReadKey();




            }






        }
    }
}
