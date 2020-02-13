using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebobbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz");
            var sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            var sayi2 = int.Parse(Console.ReadLine());
            int ilk_sayi1 = sayi1, ilk_sayi2=sayi2;
            sayi1 = (sayi1 < 0) ? -sayi1 : sayi1;
            sayi2 = (sayi2 < 0) ? -sayi2 : sayi2;
            while (sayi1!=sayi2)
            {
                if (sayi1>sayi2)
                {
                    sayi1 -= sayi2;
                }
                else
                {
                    sayi2 -= sayi1;
                }
             }
            Console.WriteLine("OBEB({0},{1})={2}", ilk_sayi1, ilk_sayi2, sayi1);
            Console.Read();
        }
    }
}
