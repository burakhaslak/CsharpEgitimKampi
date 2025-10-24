using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string:Alfabetik değişkenler Şöyle tanımlanır
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Burak";
            //Console.Write(name); //Çift tırnağa gerek yok 

            //string customerName; //değişkenler adlandırılırken kullanılan isimlendirme standartları vardır. bunlardan biri camelcase. Birinci kelimenin ilk harf küçük sonraki kelimelerin ilk harfleri büyük. Değişkenler adlandırılırken boşluk bırakılmaz.
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city; //bir satırda aynı türde birden fazla değişken tanımlanabilir. 3 değişken var

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 456 32";
            //customerEmail = "denemeemail@hotmail.com";
            //district = "Kadıköy";
            //city = "Istanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Baha";
            //customerSurname = "Haşbaş";
            //customerPhone = "+90 531 35 22";
            //customerEmail = "hello@gmail.com";
            //district = "Merkez";
            //city = "Bayburt";

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //int = Sayısal değişken. Tam sayı türündeki değişkenler.
           
         
           
            int hamburgerPrice;
            int pizzaPrice;
            int kolaPrice;
            int lemonadePrice;
            int friesPrice;
            int waterPrice;

            hamburgerPrice = 300;
            pizzaPrice = 250;
            kolaPrice = 35;
            lemonadePrice = 30;
            friesPrice = 50;
            waterPrice = 10;

        
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("------Kola: " + kolaPrice + " TL");
            Console.WriteLine("------Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("------Kızartma: " + friesPrice + " TL");
            Console.WriteLine("------Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");


            Console.WriteLine();
            int hamburgerCount;
            int kolaCount;
            int pizzaCount;
            int friesCount;
            int waterCount;
            int lemonadeCount;

            hamburgerCount = 3;
            kolaCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalKolaPrice;
            int totalFriesPrice;
            int totalWaterPrice;
            int totalLemonadePrice;

            
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalKolaPrice = kolaCount * kolaPrice;
            totalWaterPrice= waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice; 
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalKolaPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice + totalKolaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");


            #endregion






            Console.Read();
        }
    }
}
