using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables{
    
    internal class Program {

        static void Main(string[] args)
        {
     /*     #region Double Değişkenler
               // double number;

               // number = 4.85;

               // Console.WriteLine(number);

                Console.WriteLine("***** Fiyat Listesi ******");
                Console.WriteLine();

                double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

                applePrice = 14.85;
                orangePrice = 20.23;
                strawberryPrice = 47.34;
                potatoPrice = 34.34;
                tomatoPrice = 15.89;

                Console.WriteLine("Elma Birim Fiyatı: " + applePrice );
                Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice);
                Console.WriteLine("Çilek Birim Fiyatı: "+ strawberryPrice);
                Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice);
                Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice);

                Console.WriteLine();
                Console.WriteLine();

                double appleGram = 1.324,
                       orangeGram = 2.345,
                       strawberryGram = 3.456,
                       potatoGram = 4.567,
                       tomatoGram = 5.678;

                double appleTotalPrice = appleGram * applePrice,
                       orangeTotalPrice = orangeGram * orangePrice,
                       strawberryTotalPrice = strawberryGram * strawberryPrice,
                       potatoTotalPrice = potatoGram * potatoPrice,
                       tomatoTotalPrice = tomatoGram * tomatoPrice;

                 Console.WriteLine("ALınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar: " + appleTotalPrice );        
                 Console.WriteLine("ALınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice  + " - Gramaj:" + orangeGram + " - Toplam Tutar: " + orangeTotalPrice );        
                 Console.WriteLine("ALınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice );        
                 Console.WriteLine("ALınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar: " + potatoTotalPrice );        
                 Console.WriteLine("ALınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice );        


                double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;                
                
                Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice);

                #endregion   */

          #region char değişkenler


                char sembol;
                sembol = 'e';
                 Console.WriteLine(sembol );        

              #endregion
                
                #region Klavyeden değer alma

            Console.WriteLine("**** Yolcu Bilgileri ****");

                string passengerName, passengerSurname, passengerDistrict, passengerCity;

                int passengerAge, passengerID;

                Console.Write("Yolcu Adı: ");
                passengerName = Console.ReadLine();

                Console.Write("Yolcu Soyadı: ");
                passengerSurname = Console.ReadLine();

                Console.Write("İlçe Bilgisi: ");
                passengerDistrict = Console.ReadLine();

                Console.Write("İl Bilgisi: ");
                passengerCity = Console.ReadLine();

                Console.Write("Yaş: ");
                passengerAge = int.Parse(Console.ReadLine());

                Console.Write("Kimlik Numarası: ");
                passengerID = int.Parse(Console.ReadLine());


                Console.WriteLine("1.Yolcu----> " + "Ad: " + passengerName + " Soyad: " + passengerSurname + " Yaşadığı Yer: " + passengerCity + "/" + passengerDistrict + " Yaş: " + passengerAge + " Kimlik Numarası: " +passengerID);

                #endregion
              
                Console.Read();

        }
    }
}
