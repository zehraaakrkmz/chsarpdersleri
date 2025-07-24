using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02c_yt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else yapıları
            // if (koşul)
            // if yapılarından sonra ; ifadesi gelmez.
            // if (koşul)
            // { kodlar }
            // karakterler büyük-küçük harfe duyarlıdır.


            /*
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());
            if (sayi == 56789)
                {
                Console.WriteLine("Sayı 56789'a eşittir.");
            }
            else if (sayi < 56789)
            {
                Console.WriteLine("Sayı 56789'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Sayı 56789'dan büyüktür.");
            }
            */

            #endregion

            #region mod operatörü
            // Mod operatörü % işareti ile gösterilir.
            // Mod operatörü, bir sayının diğerine bölümünden kalanını verir.

            /*
            Console.Write("Lütfen bir sayı giriniz: ");
            int number;
            number = int.Parse(Console.ReadLine());
            int result = number % 2;
            if (result == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }

            char team;
            Console.Write("Lütfen bir takım sembolü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'F' || team == 'f')
            {
                Console.WriteLine("Takımınız Fenerbahçe.");
            }
            else if (team == 'B' || team == 'b')
            {
                Console.WriteLine("Takımınız Beşiktaş.");
            }
            else if (team == 'G' || team == 'g')
            {
                Console.WriteLine("Takımınız Galatasaray.");
            }
            else
            {
                Console.WriteLine("Takımınız bilinmiyor.");
            }

            */

            #endregion

            #region switch case yapısı
            // switch case yapısı, bir değişkenin değerine göre farklı kod bloklarını çalıştırmak için kullanılır.
            // switch case yapısı, if else yapısına göre daha okunabilir ve yönetilebilir bir yapıdır.
            // switch case yapısında, her case bloğunun sonunda break ifadesi kullanılır.
            // break ifadesi, switch case yapısından çıkmak için kullanılır.
            // Eğer break ifadesi kullanılmazsa, program sonraki case bloklarını da çalıştırır.
            // switch case yapısında, default bloğu, hiçbir case bloğu çalışmazsa çalıştırılır.
            // switch case yapısı, sadece int, char, string ve enum türündeki değişkenlerle kullanılabilir.

            /*
            int ay;
            Console.Write("Lütfen bir ay numarası giriniz (1-12): ");
            ay = int.Parse(Console.ReadLine());

            switch (ay)
            { case 1: Console.WriteLine("Ocak"); break;
              case 2: Console.WriteLine("şubat"); break;
              case 3: Console.WriteLine("mart"); break;
              case 4 : Console.WriteLine("nisan"); break;
              case 5: Console.WriteLine("mayıs"); break;
              case 6: Console.WriteLine("haziran"); break;
              case 7: Console.WriteLine("temmuz"); break;
              case 8: Console.WriteLine("ağustos"); break;
              case 9: Console.WriteLine("eylül"); break;
              case 10: Console.WriteLine("ekim"); break;
              case 11: Console.WriteLine("kasım"); break;
              case 12: Console.WriteLine("aralık"); break;
              default: Console.WriteLine("Geçersiz ay numarası."); break;
            }

            int sayi1, sayi2, sonuç;
            char işlem;

            Console.Write("Lütfen birinci sayıyı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen bir işlem giriniz (+, -, *, /): ");
            işlem = char.Parse(Console.ReadLine());

            switch (işlem)
            {
                case '+':
                    sonuç = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: "+ sonuç);
                    break;
                case '-':
                    sonuç = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuç);
                    break;
                case '*':
                    sonuç = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: "+ sonuç);
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuç = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: "+ sonuç);
                    }
                    else
                    {
                        Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }
            */

            #endregion


        }
    }
}
