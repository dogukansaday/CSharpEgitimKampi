using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz:");

            //string password;

            //password = Console.ReadLine();

            //if(password=="abcd")
            //{

            //    Console.WriteLine("Şifre doğru");


            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");

            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");

            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{

            //    Console.Write("bilgiler doğrulandı");
            //}

            //else
            //{
            //    Console.Write("bilgiler hatalı");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if(number==5)
            //{

            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //    }

            //int exam1, exam2, exam3, avarege;
            //string result="Hata";

            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //avarege = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarege);

            //if (avarege > 0 & avarege <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (avarege > 50 & avarege <= 70)
            //{
            //    result = "Sonuç orta";

            //}
            //if (avarege > 70 & avarege <= 84)
            //{
            //    result = "Sonuç iyi";
            //}

            //if (avarege > 84)

            //{
            //    result = "Sonuç Çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "kars" | city == "istanbul" | city == "ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{

            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}



            #endregion

            #region mod işlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz:");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan:  " + result);
            //Console.Write("Lütfn sayıyı giriniz: ");
            //int number =int.Parse(Console.ReadLine());

            //if (number %2==0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{

            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");

            //        }
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");

            //}

            //    if (team == 'b' | team == 'B')
            //    {
            //    Console.Write("Beşiktaş");
            //}





            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Barbekü Soslu Tavuk");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("Kızartma Tabağı");
            //    Console.WriteLine("-----------Ana Yemekler---------");
            //    Console.WriteLine();



            //}


            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("-----------Çorbalar---------");
            //    Console.WriteLine();



            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("-----------Pizzalar---------");
            //    Console.WriteLine();



            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("-----------İçecekler---------");
            //    Console.WriteLine();



            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("-----------Tatlılar---------");
            //    Console.WriteLine();



            //}

            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapın: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs");break;
            //    case 6: Console.Write("Haziran");break;
            //    case 7: Console.Write("Temmuz");break;
            //    case 8: Console.Write("Ağustos");break;
            //    case 9: Console.Write("Eylül");break;
            //    case 10: Console.Write("Ekim");break;
            //    case 11: Console.Write("Kasım");break;
            //    case 12: Console.Write("Aralık");break;
            //    default: Console.Write("Hatalı Veri girişi"); break;



            //}





            #endregion

            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case  '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;
            //    case '/':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;


        }

        #endregion




    }
}
}
