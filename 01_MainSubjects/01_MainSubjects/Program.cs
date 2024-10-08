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
            #region Yazdırma Komurları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("****Yemek Kategorisi****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****Yemek Kategorisi****");
            #endregion


            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name="Ayşenur";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPohone;
            //string customerEmail, district, city;

            //customerName ="Ayşenur";
            //customerSurname ="Karaçay";
            //customerPohone ="+90 500 400 30 20";
            //customerEmail ="deneme@gmail.com";
            //district ="Ataşehir";
            //city ="İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " +customerPohone);
            //Console.WriteLine("Email Adresi" +customerEmail);
            //Console.WriteLine("Adres" +district+ "/" +city);
            //Console.WriteLine("-----------------------------------------");

            //customerName ="Betül";
            //customerSurname ="Karaçay";
            //customerPohone ="+90 400 600 10 10";
            //customerEmail ="@deneme.gmail.com";
            //district ="Nusaybin";
            //city ="Mardin";

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " +customerPohone);
            //Console.WriteLine("Email Adresi" +customerEmail);
            //Console.WriteLine("Adres" +district+ "/" +city);
            //Console.WriteLine("------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

           

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("----Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("----Kola:" + cokePrice + "TL");
            Console.WriteLine("----Limonata:" + lemonadePrice + "TL");
            Console.WriteLine("----Kızartma:" + friesPrice + "TL");
            Console.WriteLine("----su:" + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("****Restoran Menü Fiyatı****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            
            int totalHamburgerPrice ;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonataPrice;

            hamburgerCount= 3;
            cokeCount =3;
            waterCount =3;
            friesCount =3;
            pizzaCount =3;
            lemonadeCount =3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLemonataPrice =lemonadeCount * lemonadePrice;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " +totalPizzaPrice + "TL");
            Console.WriteLine("Su Tutarı: " +totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " +totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " +totalLemonataPrice + "TL");
            Console.WriteLine("Kola Tutarı: " +totalCokePrice + "TL");

            Console.WriteLine();

            int totalPrice=totalCokePrice+totalWaterPrice+totalLemonataPrice+totalHamburgerPrice+totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " +totalPrice+ "TL");




            #endregion



            Console.Read();
        }
    }
}
