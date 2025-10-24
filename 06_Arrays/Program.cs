using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8,
            //sarı,kırmızı,mavi, turuncu
            //adana,ankara,bayburt,istanbul
            //değişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.Write(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "Hasselt";
            //cities[1] = "Brugge";
            //cities[2] = "Maastricht";
            //cities[3] = "Eindhoven";
            //cities[4] = "Leuven";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10]; //BIR INDEKSE DEĞER ATAMASI YAPMADIGIMIZDA O INDEKSIN DEFAULT DEGERİ 0 OLUR. numbers[7] yazınca 0 cıkacak cünkü dizide olmasına rağmen değer atanmamış.
            //numbers[0] = 50;
            //numbers[1] = 100;
            //numbers[2] = 200;
            //numbers[3] = 24;
            //numbers[9] = 656;

            //Console.Write(numbers[7]);


            //Dizilerin başka bir oluşturma yöntemi de bu şekilde.
            //string[] cities = { "Prag", "Roma", "Atina", "Bursa" };

            //Console.WriteLine(cities[2]);






            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for(int i = 0;  i < colors.Length; i++)             //colors.Length 7. 0'dan 6'ya gelene kadar 7 karakteri de yazdırdık ancak 7.de 7<7 oluyor false ve dizi zaten bitiyor. 7<=7 olsaydı hata alırdık.
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for( int i = 0; i < numbers.Length; i++ )
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for(int i =0;  i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "mehmet", "enes", "ayşe", "sabri" };
            //Console.WriteLine(persons.Length);   //Length bize dizinin uzunluğunu verdi.







            #endregion

            #region Dizi Metotları

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);  // bu method küçükten büyüğe sıralıyor
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);  // diziyi komple tersten sıralıyor.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" }; //IndexOf metodu dizi içerisinde aranan değerin indeks sırasını verir.
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min()); //Max Min = dizinin en büyük ve en küçük elemanlarını verir.











            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1} . Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i =0;  i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %  2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}


            #endregion

            Console.Read();





        }
    }
}
