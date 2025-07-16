using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace _01c_yttemelkonuları
{
    internal class Program // Program sınıfı, C# uygulamalarının başlangıç noktasıdır.
    {
        static void Main(string[] args) // Main metodu, uygulamanın başlangıç noktasıdır.
        {
            #region yazdırma komutları 
            /*
            // Yazdırma komutları, konsola çıktı almak için kullanılır. C# dilinde en yaygın olarak kullanılan yazdırma komutları Console.Write ve Console.WriteLine'dır.
            // region, kodun belirli bir bölümünü gruplamak için kullanılır. Bu, kodun okunabilirliğini artırır.

            Console.Write("merhaba dünya"); // Console sınıfı, konsol uygulamalarında çıktı almak için kullanılır.
            Console.WriteLine("merhaba dünya"); // Console.WriteLine metodu, konsola bir satır yazdırır ve imleci bir sonraki satıra taşır.

            //Console.Read(); // Console.Read() metodu, kullanıcıdan bir tuşa basmasını bekler. Bu, konsol penceresinin hemen kapanmamasını sağlar.
            Console.WriteLine("  ");
            */
            #endregion

            #region stringDeğişkenler  
            // Değişkenler, programda veri saklamak için kullanılır. C# dilinde değişkenler, türlerine göre tanımlanır.
            /*

            // string türünde bir değişken tanımlama
            // değişken-türü değişken-ismi = değer; // Değişken tanımlama ve atama işlemi bu şekilde yapılır.
            string name; // string, metin verilerini saklamak için kullanılan bir veri türüdür.
            name = "Zehra"; // Değişkene değer atama işlemi bu şekilde yapılır.
            Console.WriteLine(name); // Değişkenin değerini konsola yazdırma işlemi.

            string isim;
            string soyisim;
            string telefonNumarası;
            string eposta, adres;
            // Değişkenler birden fazla şekilde tanımlanabilir. Yukarıdaki gibi her bir değişken için ayrı satırda tanımlama yapabileceğiniz gibi, virgülle ayırarak da tanımlayabilirsiniz.

            isim= "Zehra"; 
            soyisim = "Korkmaz"; 
            telefonNumarası = "0555 555 55 55";
            eposta = "abc@gmail.com";
            adres = " ";

            Console.WriteLine("İsim soyisim: " + isim + " " + soyisim); 
            Console.WriteLine("Telefon Numarası: " + telefonNumarası); 
            Console.WriteLine("E-posta: " + eposta);    
            Console.WriteLine("Adres: " + adres);
            // Değişkenlerin değerlerini konsola yazdırma işlemi bu şekilde yapılır. + operatörü, string birleştirme işlemi için kullanılır.

            Console.WriteLine("--------------------");

            isim = "Soner"; // Değişkenin değerini güncelleme işlemi. Değişkenler, programın çalışması sırasında değerlerini değiştirebilir.
            soyisim = "Tekinay";
            telefonNumarası = "0555 555 55 55";
            eposta = "cde@gmail.com";
            adres = " ";

            Console.WriteLine("İsim soyisim: " + isim + " " + soyisim);
            Console.WriteLine("Telefon Numarası: " + telefonNumarası);
            Console.WriteLine("E-posta: " + eposta);
            Console.WriteLine("Adres: " + adres);
            */
            #endregion

            #region integerDeğişkenler
            // integer türünde değişkenler, tam sayıları saklamak için kullanılır. C# dilinde int, long, short gibi farklı tam sayı türleri vardır.

            /*
            // int türünde değişken tanımlama
            int yas; // int, 32 bitlik tam sayıları saklamak için kullanılan bir veri türüdür.  
            yas = 25; // Değişkene değer atama işlemi. int türündeki değişkenler, negatif ve pozitif tam sayıları saklayabilir.
            Console.WriteLine("Yaş: " + yas); // Değişkenin değerini konsola yazdırma işlemi.
            */

            #endregion

            #region doubleDeğişkenler
            // double türünde değişkenler, ondalıklı sayıları saklamak için kullanılır. C# dilinde float, decimal gibi farklı ondalıklı sayı türleri vardır.

            /*
            double maas; // double, 64 bitlik ondalıklı sayıları saklamak için kullanılan bir veri türüdür.
            maas = 2500.50; // Değişkene değer atama işlemi. double türündeki değişkenler, ondalıklı sayıları saklayabilir.
                            // kod kısmında noktalı sayılar için virgül yerine nokta kullanılır. consolda virgül kullanılır.

            Console.WriteLine("Maaş: " + maas);
            */

            #endregion

            #region charDeğişkenler
            // char türünde değişkenler, tek bir karakteri saklamak için kullanılır. C# dilinde char, tek tırnak içinde tanımlanır.

            /*
            char ilkHarf; // char, tek bir karakteri saklamak için kullanılan bir veri türüdür.
            ilkHarf = 'Z'; // Değişkene değer atama işlemi. char türündeki değişkenler, tek bir karakteri saklayabilir.
            Console.WriteLine("İlk Harf: " + ilkHarf);
            */

            #endregion

            #region klavyedenStringDeğerAlma
            // Klavyeden değer alma işlemi, kullanıcıdan veri girişi almak için kullanılır. C# dilinde Console.ReadLine() metodu, kullanıcıdan metin girişi almak için kullanılır.

            /*
            Console.WriteLine("***** kimlik bilgileri *****");

            Console.Write("İsim: "); // Konsola isim girişi için mesaj yazdırma.
            string isim = Console.ReadLine(); // Kullanıcıdan isim girişi alma. Console.ReadLine() metodu, kullanıcıdan bir satır metin girişi alır.
            
            Console.Write("Soyisim: "); 
            string soyisim = Console.ReadLine();

            Console.WriteLine("isim: " + isim + " " + soyisim);
            */

            #endregion

            #region klavyedenIntegerDeğerAlma
            // Klavyeden integer değer alma işlemi, kullanıcıdan tam sayı girişi almak için kullanılır. C# dilinde int.Parse() metodu, string ifadeyi tam sayıya dönüştürmek için kullanılır.

            /*
            int shoesPrize, clothesPrize;
            shoesPrize = 500;
            clothesPrize = 1000;

            Console.WriteLine("***** alışveriş *****");

            Console.Write("kaç ayakkabı aldınız: ");
            int shoesCount = int.Parse(Console.ReadLine()); // int.Parse() metodu ile bu metin tam sayıya dönüştürülür.
            Console.WriteLine("ayakkabı fiyatı: " + shoesPrize * shoesCount);

            Console.Write("kaç kıyafet aldınız: ");
            int clothesCount = int.Parse(Console.ReadLine()); 
            Console.WriteLine("kıyafet fiyatı: " + clothesPrize * clothesCount);

            int totalPrize = (shoesCount * shoesPrize) + (clothesCount * clothesPrize); 
            Console.WriteLine("toplam alışveriş tutarı: " + totalPrize);
            */

            #endregion


            #region klavyedenDoubleDeğerAlma
            // Klavyeden double değer alma işlemi, kullanıcıdan ondalıklı sayı girişi almak için kullanılır. C# dilinde double.Parse() metodu, string ifadeyi ondalıklı sayıya dönüştürmek için kullanılır.

            /*
            double exam1, exam2, exam3, result;

            Console.WriteLine("***** not hesaplama *****");

            Console.Write("1. sınav notu: ");
            exam1= double.Parse(Console.ReadLine()); // Kullanıcıdan 1. sınav notu girişi alma ve double'a dönüştürme.

            Console.Write("2. sınav notu: ");
            exam2= double.Parse(Console.ReadLine()); 

            Console.Write("3. sınav notu: ");
            exam3= double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3; // Sınav notlarının ortalamasını hesaplama.
            Console.WriteLine("ortalama: " + result); 
            */

            #endregion

            #region klavyedenCharDeğerAlma
            // Klavyeden char değer alma işlemi, kullanıcıdan tek bir karakter girişi almak için kullanılır. C# dilinde Console.ReadKey() metodu, kullanıcıdan tek bir tuşa basmasını bekler.

            /*
            char gender;
            Console.Write("bir cinsiyet seçin kadın-k erkek- e: ");
            gender= char.Parse(Console.ReadLine()); // Kullanıcıdan cinsiyet girişi alma ve char'a dönüştürme.

            Console.WriteLine("cinsiyet " + gender);
            */

            #endregion





        }
    }
}