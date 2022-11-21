using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc=0;
            char islem;

            Console.Write("1.sayıyı giriniz = ");
            sayi1 = double.Parse(Console.ReadLine());            
            Console.Write("2.sayıyı giriniz = ");
            sayi2 = double.Parse(Console.ReadLine());
            Console.Write("Yapmak istediğiniz işlemi seçiniz -> '+' '-' '*' '/' '%' = ");
            islem = char.Parse(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;
            }
            if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            if(islem == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
            }
            if(islem == '%')
            {
                sonuc = sayi1 % sayi2;
            }

            Console.WriteLine("\n{0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc);

            Console.ReadLine();
            
        }
    }
}
