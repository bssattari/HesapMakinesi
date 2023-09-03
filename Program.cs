using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            OPERATÖRLER
            ARİTMETİK OPERATÖRLER 
            
            + - / * %(mod alma)

            ATAMA OPERATÖRLERİ
            = += -= *= /= %= ++ --
            
            
            int sayi;
            Console.Write("Sayı : ");
            sayi = Convert.ToInt16(Console.ReadLine());
            sayi--;
            Console.WriteLine("Yeni Sayı : " + sayi);

            KARŞILAŞTIRMA OPERATÖRLERİ
            == != <= >=

            MANTIKSAL OPERATÖRLER
            || (OR - VEYA)
            && (AND - VE)
            ! (NOT DEĞİL)

            

            bool ehliyet=false;
            bool evliMi=true;

            Console.WriteLine(ehliyet||evliMi);

            string
                kullanici,
                sifre;

            Console.Write("Kullanıcı : ");
            kullanici = Console.ReadLine()!;

            Console.Write("Şifre : ");
            sifre = Console.ReadLine()!;


            if (kullanici == "admin" && sifre == "123456")
            {
                Console.Write("Hoşgeldiniz!");
            }
            else
            {
                Console.Write("Hatalı Kullanıcı adı / Şifre");                
            }

            */
            int sayi;

            Console.Write("Sayı Giriniz : ");
            sayi = Convert.ToInt16(Console.ReadLine()!);



            if (sayi%2==0)
            {
                Console.Write("{0} Çift Sayıdır", sayi);
            }
            else
            {
                Console.Write("{0} Tek Sayıdır", sayi);
            }
        }
    }
}
