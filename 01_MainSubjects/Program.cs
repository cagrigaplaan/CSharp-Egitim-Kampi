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
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Çağrı";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "email";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);
            //Console.WriteLine("İleştişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: "+  customerEmail);
            //Console.WriteLine("Adres: " +  district + "/" + city);
            //Console.WriteLine("---------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+ 90 100 200 30 40";
            //customerEmail= "email";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İleştişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 20;
            int friesPrice = 100;
            int pizzaPrice = 400;
            int lemonadePrice = 50;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-------Kola: " + cokePrice + "TL");
            Console.WriteLine("-------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-------Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("-------Su: " + waterPrice + "TL");
            Console.WriteLine("-------Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            
            
            Console.WriteLine();
            int totalCount;

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 4;
            friesCount = 4;
            pizzaCount = 2;
            lemonadeCount = 1;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalCokePrice = cokeCount * cokePrice;

            totalCount = totalHamburgerPrice + totalPizzaPrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice + totalCokePrice;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice);
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: "+ totalCount + " TL");
            Console.WriteLine("----------------------------------------");


            #endregion

            Console.Read();
        }
    }
}
