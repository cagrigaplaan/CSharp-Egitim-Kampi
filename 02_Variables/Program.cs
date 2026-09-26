using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram,potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram +
            //    " - Toplam Tutar: " + appleTotalPrice + " TL");


            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            // " '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu: "+ passengerName + " "+ passengerSurname);
            //Console.WriteLine("Yaşadığı Yer: " + passengerDistrict);
            //Console.WriteLine("TC Kimlik Numarası: "+ passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız Ayakkabı Fiyatını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız PC sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: "+ totalPrice +" TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1.Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " +  result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //string Gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //Gender = Console.ReadLine();

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +  Gender);

            #endregion

            //Console.Read();
        }
    }
}
