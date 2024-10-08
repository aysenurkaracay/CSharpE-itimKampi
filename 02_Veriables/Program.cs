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

            //  Console.WriteLine("****Fiyat Listesi****");
            //  Console.WriteLine();

            //  double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //  applePrice = 14.85;
            //  orangePrice = 20.95;
            //  strawberryPrice =45;
            //  potatoPrice = 9.74;
            //  tomatoPrice =6.88;

            //  Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + "TL");
            //  Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + "TL");
            //  Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //  Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "TL");
            //  Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //  Console.WriteLine();
            //  Console.WriteLine();

            //  double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //  appleGram =1.245;
            //  orangeGram =2.650;
            //  strawGram =0.750;
            //  potatoGram=4.859;
            //  tomatoGram=3.745;

            //  double appleTotalPrice = appleGram * applePrice;
            //  double orangeTotalPrice = orangeGram * orangePrice;
            //  double strawTotalPrice = strawGram * strawberryPrice;
            //  double tomatoTotalPrice = tomatoGram *  tomatoPrice;
            //  double potatoTotalPrice = potatoGram *  potatoPrice;


            //  Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj:" +appleGram +" - Toplam Tutar: " +appleTotalPrice);

            //  Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj:" + orangeGram +" - Toplam Tutar: " +orangeTotalPrice);

            //  Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj:" + strawGram +" - Toplam Tutar: " + strawTotalPrice);

            //  Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj:" + potatoGram +" - Toplam Tutar: " + potatoTotalPrice);

            //  Console.WriteLine("Alınan Ürün: Domates  - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj:" + tomatoGram +" - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice= appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawTotalPrice + potatoTotalPrice;

            //  Console.WriteLine();
            //  Console.WriteLine();

            //  Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");



            #endregion


            #region Char Değişkenler


            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"'

            //char symbol;
            //symbol ='a';
            //Console.WriteLine(symbol);

            #endregion


            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();



            //Console.WriteLine("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " +  passengerName + " " + passengerSurname + " " + passengerDistrict  + "/ " + passengerCity + " " +  passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandayle sayısını giriniz:");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount* shoePrice + computerCount* computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice );



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz :");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);
            #endregion


            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);




            #endregion
            Console.Read();

        }
    }
}
