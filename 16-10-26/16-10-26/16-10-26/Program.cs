// Console.OutputEncoding = System.Text.Encoding.UTF8;
// string[] fruits = { "elma", "muz", "armut", "kivi", "şeftali" };
// double[] prices = { 99.50, 60, 65.25, 70.75, 80};
// double[] buying = new double[fruits.Length];
// double TotalPay = 0;
//
// for (int i = 0; i < fruits.Length; i++)
// {
//     Console.WriteLine($"{fruits[i]} Birim Fiyatı: {prices[i]:c2} - Kaç Kilo alacaksın?");
//     double.TryParse(Console.ReadLine(), out buying[i]);
//     
//     TotalPay += buying[i] * prices[i];
// }
//
// Console.WriteLine("----------------------------------------");
// Console.WriteLine($"Toplam Ödenecek Tutar: {TotalPay:c2}");

// bool is_online = true;
// while (is_online)
// {
//     Console.OutputEncoding = System.Text.Encoding.UTF8;
//
//     string[] fruits = { "elma", "muz", "armut", "kivi", "şeftali" };
//     double[] prices = { 99.50, 60, 65.25, 70.75, 80};
//     double[] buying = new double[fruits.Length];
//     double TotalPay = 0;
//
//     Console.WriteLine("----------------------------------------------");
//     Console.WriteLine("                 Manav Paneli                 ");
//     Console.WriteLine("----------------------------------------------");
//     Console.WriteLine("Yapılacak İşlemi seçiniz");
//     Console.WriteLine("[1] - Ürünleri Ve Fiyatlarını Görüntüle");
//     Console.WriteLine("[2] - Satış Yap");
//     Console.WriteLine("[99] - Çıkış Yap!");
//     int.TryParse(Console.ReadLine(), out int Select);
//
//
//     switch (Select)
//     {
//         case 1 :
//             Console.WriteLine($"{fruits[0]} \t {fruits[1]} \t {fruits[2]} \t {fruits[3]} \t {fruits[4]} \t");
//             Console.WriteLine($"{prices[0]} \t {prices[1]} \t {prices[2]} \t {prices[3]} \t {prices[4]} \t");
//             Console.WriteLine("Geri Dönmek İçin Enter'a basın"+Console.ReadLine());
//             Console.Clear();
//             break;
//         case 2 :
//             Console.Clear();
//             for (int  i = 0; i < fruits.Length; i++){
//                 Console.WriteLine($"{fruits[i]} Fiyatı: {prices[i]:c2} - Kaç Kilo Alınacak?");
//                 double.TryParse(Console.ReadLine(), out buying[i]);
//                 TotalPay += buying[i] * prices[i];
//             }
//
//             Console.WriteLine($"Toplam Ödenecek Tutar {TotalPay:c2}");
//             is_online = false;
//             break;
//         case 99:
//             Console.WriteLine($"Çıkış Yapıldı - {DateTime.Now:dd-mm-yy HH-mm}");
//             is_online = false;
//             break;
//         default: 
//             Console.WriteLine("\nBöyle bir işlem yok ne yaptığını sanıyorsun seni daha düzgün birisi sanıyordum saçma sapan bir seçim denedin ne alaka ya bu sana 3 tane seçenek vermişim birinde çıkış yapmanı sağlıyor zaten ne istiyorsun anlayamıyorum sadece bir tane rakama basmak bu kadar zor olmamalı bir tane işin var zaten onu da düzgün yap. Hadi Allaha Emanet");
//             is_online = false;
//             break;
//     }
//
// }




// int count = 0;
// while (count<10)
// {
//     Console.WriteLine("Ahada ilk loop");
//     count++;
// }
//


//
// for (int i = 10; i < 1000; i++)
// {
//     int number = i;
//     int tersi = number % 10;
//     number /= 10;
//     while (number % 10 > 0)
//     {
//         tersi *= 10;
//         tersi += number % 10;
//         number /= 10;
//     }
//
//     if (tersi == i)
//     {
//         Console.WriteLine($"{i} tersi {tersi} dolaysıyla palindromdur");
//     }
//     
// }
//
//

//
// string userName = "admin";
// string password = "1234";
//
// //Kullanıcı 3 defa yanlış girerse sistemden çıkınız
//
// int UserTry = 0;
//
// while (UserTry < 3 )
// {
//     Console.WriteLine("Kullanıcı Adını Giriniz:");
//     var SayUserName = Console.ReadLine();
//     Console.WriteLine("Şifre Giriniz:");
//     var SayPassword = Console.ReadLine();
//
//     if (userName == SayUserName && password == SayPassword)
//     {
//         Console.WriteLine("Giriş Başarılı");
//         UserTry = 3;
//
//     }
//     else
//     {
//         Console.WriteLine($"Bir daha deneyiniz");
//         UserTry++;
//         Console.WriteLine($"Kalan Deneme Hakkı {3-UserTry}");
//     }
// }



// string metin = "İstanbul'un sel belâsı asırlardır Eylül'de ve Ekim'dedir!";
// string yazar = "Murat Bardakçı";
// string[] kelimeler = metin.Split(" ");
// Console.WriteLine(metin.Length);
// Console.WriteLine(metin.Contains("sel"));
// Console.WriteLine(metin.StartsWith("İ"));
// Console.WriteLine(metin.EndsWith("!"));
// Console.WriteLine(metin.IndexOf("E"));
// Console.WriteLine(metin.LastIndexOf("e"));
// Console.WriteLine(metin.Substring(0, 15));
// Console.WriteLine(string.Concat("Merhaba", " ","Dünya"));
//
// Console.WriteLine(string.Join(", ", kelimeler));
//
// Console.WriteLine(yazar.Remove(6));
// Console.WriteLine(yazar.Remove(0,6));
//
// string url = metin.ToLower().Replace(" ", "-");
// url = url.Replace("ı", "i").Replace("â", "a").Replace("'", "").Replace("ü", "u").Replace("!", "");
// Console.WriteLine(url);
// string kelime = "     kel     ime     ";
// Console.WriteLine(kelime);
// Console.WriteLine(kelime.Trim());
// Console.WriteLine(kelime.TrimStart());
// Console.WriteLine(kelime.TrimEnd());
//
// string yazi = "ABC";
// string yazi2 ="abc";
// Console.WriteLine(yazi.Equals(yazi2));
// Console.WriteLine(yazi.Equals(yazi2,StringComparison.OrdinalIgnoreCase));
// Console.WriteLine(yazi==yazi2);
// Console.WriteLine(string.IsNullOrEmpty(""));
// Console.WriteLine(string.IsNullOrEmpty(null));
// Console.WriteLine(string.IsNullOrEmpty(" "));
// Console.WriteLine(string.IsNullOrWhiteSpace(" "));
//
// char[] isim = yazar.ToCharArray();
// for (int i = 0; i < isim.Length; i++)
// {
//     Console.WriteLine(isim[i]);
// }


// Console.WriteLine(Math.Pow(5, 5));
// Console.WriteLine(Math.PI);
// Console.WriteLine(Math.E);
// Console.WriteLine(Math.Tau);
// Console.WriteLine(Math.Abs(-89));
// Console.WriteLine(Math.Sqrt(7896));
// Console.WriteLine(Math.Min(45,78));
// Console.WriteLine(Math.Max(45,78));
// Console.WriteLine(Math.Floor(4.8963));
// Console.WriteLine(Math.Ceiling(4.8963));
// Console.WriteLine(Math.Truncate(4.8963));
// Console.WriteLine(Math.Round(4.896328347923874923749327492378894));


// Random rnd = new Random();
// Random rnd2 = new Random();
// Console.WriteLine(rnd.Next(1000));
// Console.WriteLine(rnd2.Next(100,1000));
// Console.WriteLine(rnd.NextDouble());


// using System.Text;
//
// var metin = new StringBuilder("bu metin 16 karakterden uzun olması için yazılmıştır");
//
//
// metin.Append(" deneme 1");
//
// Console.WriteLine(metin.Capacity);
// Console.WriteLine(metin.Length);



// string metin = """
//                Merhaba
//                Bugün hava
//                yağmurlu
//                ankarada
//                """;
// Console.WriteLine(metin);
//












