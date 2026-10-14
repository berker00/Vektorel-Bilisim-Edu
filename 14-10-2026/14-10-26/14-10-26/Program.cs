// VeriTipi[] ad =new veriTipi[elemanSayisi]
//mevcutta bulunan tüm veri tipleri ile 
//dizi oluşturulabilir.

// int[] numbers = new int[5];
//
// int[] numbers2={1,2,3,4,5};

// int[] numbers3 = null;

//
// string[] fruits = new string[5];
// fruits[0] = "Elma";
// fruits[1] = "Kiraz";
// fruits[2] = "Muz";
// fruits[3] = "Çilek";
// fruits[4] = "Kivi";
//
//
// double[] prices = {49.99, 99.99,109.99,150,89.99};
// double[] buying  = new double[fruits.Length];
// double totalBuying = 0;
// Console.WriteLine($"{fruits[0]} meyvesinin fiyatı: {prices[0]:c2}\n Kaç kilo almak istiyorsunuz?");
// double.TryParse(Console.ReadLine(), out totalBuying);
// buying[0] = totalBuying;
// Console.WriteLine($"{fruits[1]} meyvesinin fiyatı: {prices[1]:c2}\n Kaç kilo almak istiyorsunuz?");
// double.TryParse(Console.ReadLine(), out totalBuying);
// buying[1] = totalBuying;
// Console.WriteLine($"{fruits[2]} meyvesinin fiyatı: {prices[2]:c2}\n Kaç kilo almak istiyorsunuz?");
// double.TryParse(Console.ReadLine(), out totalBuying);
// buying[2] = totalBuying;
// Console.WriteLine($"{fruits[3]} meyvesinin fiyatı: {prices[3]:c2}\n Kaç kilo almak istiyorsunuz?");
// double.TryParse(Console.ReadLine(), out totalBuying);
// buying[3] = totalBuying;
// Console.WriteLine($"{fruits[4]} meyvesinin fiyatı: {prices[4]:c2}\n Kaç kilo almak istiyorsunuz?");
// double.TryParse(Console.ReadLine(), out totalBuying);
// buying[4] = totalBuying;
//
// double totalTutar = buying[0] * prices[0];
// totalTutar = buying[1] * prices[1];
// totalTutar = buying[2] * prices[2];
// totalTutar = buying[3] * prices[3];
// totalTutar = buying[4] * prices[4];
// Console.WriteLine($"Toplam Ödemeniz gereken tutar: {totalTutar:c2}");

// isim yaş cinsiyet

// string[] name = new string[5];
// name[0] = "Berker";
// name[1] = "Ahmet";
// name[2] = "Mehmet";
// name[3] = "Füsun";
// name[4] = "Sanem";
//
// int[] age = {23,24,25,26,27};
//
// char[] sex = {'e','e','e','k','k'};
//
// Console.WriteLine($"İsim \t Yaş \t Cinsiyet");
// Console.WriteLine($"{name[0]} \t {age[0]} \t {(sex[0]=='k'?"Kadın":"Erkek")}");
// Console.WriteLine($"{name[1]} \t {age[1]} \t {(sex[1]=='k'?"Kadın":"Erkek")}");
// Console.WriteLine($"{name[2]} \t {age[2]} \t {(sex[2]=='k'?"Kadın":"Erkek")}");
// Console.WriteLine($"{name[3]} \t {age[3]} \t {(sex[3]=='k'?"Kadın":"Erkek")}");
// Console.WriteLine($"{name[4]} \t {age[4]} \t {(sex[4]=='k'?"Kadın":"Erkek")}");


//bellekteki stack ve heap anlat ve detaylıca özetle ne işe yaradığını ram'de ki farkları ve avantajlarını anlat 


//Döngü 

// for

// for (int i = 1; i <=20; i++)
// {
//     Console.WriteLine("Dön Baba Dönelim" + i);
// }

// for (int i = 1; i<=100; i++)
// {
//     if (i % 4 == 0){
//         Console.WriteLine(i);
//     }
// }

//10 ile 1000 arasındaki palindrom sayılarını bulup yazdıran program

// for (int i = 10; i < 1000; i++)
// {
//     int temp = i;
//     int tersi = 0;
//     tersi += temp%10;
//     temp /= 10;
//
//     if (temp > 0)
//     {
//         tersi = tersi * 10 + temp%10;
//     }
//     temp /= 10;
//     if(temp > 0)
//     {
//         tersi = tersi * 10 + temp%10;
//     }
//
//     if (tersi == i)
//     {
//         Console.WriteLine(i);
//     }
// }

string yazi = "adanada";
string newYazi= string.Empty;
for (int i = yazi.Length-1; i >= 0; i--)
{
    newYazi += yazi[i];
}
Console.WriteLine(newYazi);

//verilen sayıyı yazıya çeviren sistem

