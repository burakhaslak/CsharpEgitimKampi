using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Console.Write, Console.WriteLine, Parse bunlar birer methoddu. Hazır metotlardı. Şimdi kendi metodlarımızı oluşturucaz.

            // Bir yapıyı () method yapar. Mor renkte küp method olduğunu bildirir.
            // Metotlar ikiye ayrılır.
            //Geriye Değer Döndürmeyen Metotlar. Void metotlar olarak tanımlanır.
            //Customer --> Listele, ekle, sil, güncelle
            //her seferinde aynı kodları yazmak yerine,tek bir metot oluşturup istediğin yerde onu çağırabilirsin.


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye değer döndürmeyen String Parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + "" + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen Int Parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}


            //Sum(4, 5, 6);



            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region  Geriye Değer döndüren String parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " +  countryName +" - Başkent:  "  + capital + " - Bayrak Rengi: " + flagColor;
            //    return(cardInfo);
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));


            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));   //önceden veri girdik

            #endregion

            #region Geriye değer döndüren Int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion

            #region Örnek Uygulama 

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavdan kaldı " + "Ortalama: " + result; 
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));




            #endregion



            Console.Read();
        }
    }
}
