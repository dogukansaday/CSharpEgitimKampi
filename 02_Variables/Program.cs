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
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi *****");
            //    Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyatı:" + applePrice +"TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("-----Patates Birim Fiyatı:" + potato + "TL");
            //Console.WriteLine("-----Domates Birim Fiyatı:" + tomato + "TL");


            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.65;
            //strawGram = 0.75;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangePrice;
            //strawTotalPrice = strawGram * strawberryPrice;
            //potatoTotalPrice = potatoGram * potato;
            //tomatoTotalPrice = tomatoGram * tomato;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + "- Gramaj: " + appleGram + "- Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + "- Gramaj: " + orangeGram + "- Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + "- Gramaj: " + strawGram + "- Toplam Tutar:" + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potato + "- Gramaj: " + potatoGram + "- Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomato + "- Gramaj: " + tomatoGram + "- Toplam Tutar:" + tomatoTotalPrice);



            //double shoppingTotalPrice;

            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice + strawTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine(shoppingTotalPrice);




            #endregion


            #region Char Değişkenler

            //ABCDEFGH
            //DEF.....
            //TOPLANTI SAAT 20:00'DE
            // String değişkenler "" ile char değişkenler '' ile tanımlanır

            //char symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion



            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("TckNo:");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine( "Yolcu TC Kimlik No" + passengerIdentityNumber +      "---Yolcu Ad Soyad:" + passengerName + " " + passengerSurname  +  passengerDistrict + "/" +passengerCity);





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount =int.Parse( Console.ReadLine());



            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());



            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());



            //Console.Write("Lütfen aldığınız tv sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount* chairPrice + tvPrice* tvPrice;
            //Console.WriteLine();

            //Console.WriteLine("toplam ödemeniz gereken tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı Giriş İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2. sınav notunu giriniz:");
            //exam2=double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3. sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3 )/ 3;

            //Console.WriteLine(result);
            #endregion

            #region Klavyeden Karakter Girişleri

            // char gender;

            // Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            // Console.Write("Seçtiğiniz Cinsiyet:" + gender);




            #endregion


            Console.Read();

        }
    }
}
