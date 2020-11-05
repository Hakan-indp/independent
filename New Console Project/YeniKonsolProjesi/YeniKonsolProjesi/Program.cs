using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace YeniKonsolProjesi
{
    class Program
    {
        static void Main(string[] args)
        {

            double boy, kilo, vki;
            Console.WriteLine("Lütfen kilonuzu giriniz");
            kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz");
            boy = Convert.ToDouble(Console.ReadLine());
            vki = kilo / (boy * boy);
            if (vki<= 18.4)
            {
                Console.WriteLine("Vücut kitle endeksi:{0} kategori:zayıf", vki);
            }

            else if (vki<= 24.9)
            {
                Console.WriteLine("vücut kitle endeksi:{0} kategori: orta", vki);
            }

            else if (vki<= 29.9)
            {
                Console.WriteLine("vücut kitle endeksi:{0} kategori: kilolu", vki);
            }
            else
            {
                Console.WriteLine("bilgileri yanlış girdiniz");
            }

            Console.ReadKey();

    }

           
    }
}
