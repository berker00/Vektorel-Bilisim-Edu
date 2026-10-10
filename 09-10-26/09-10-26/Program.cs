//Atama Operatörleri  = += -= *= /= %=
// int number = 5;
// int x = 10;
// x += number;
// x += 5;
// double y = 40;
//
// string metin = string.Empty;
// metin += "Merhaba ";
// metin += "Bugün ";
// metin += "Cuma ";
// metin += "Hava ";
// metin += "Muhtelif ";
//
// x -= 10;
// x *= 3;
// x /= 7; // int
// y /= 7; // bool
// x %= 7;
//
//
//
//
// Console.WriteLine(x);

//Karşılaşma Operatörleri < > >= <= == !=
// int a = 5;
// int c = 3;
//
// Console.WriteLine(a<c); //False
// Console.WriteLine(a>c); //True
// Console.WriteLine(a<=c); //False
// Console.WriteLine(a>=c); //True
// Console.WriteLine(a==c); //False
// Console.WriteLine(a!=c); //True
//
// string name = "ali";
// Console.WriteLine(name == "ali"); //True

//Mantıksal Operatörler  && || ! 
// int a = 5;
// int c = 3;
// string name = "ali";
// bool status = a>c && c>a; // False çünkü && ve demek
// status = a < c || c == 96 || ("ali"==name&&33<5);
// Console.WriteLine(!status);

//Termal Operatör
// string durum = 3 > 5 ? "3 büyük beşten" : "5 büyük 3 ten";
// Console.WriteLine(durum);

//vize1 vize2 dönem ödevi ve final notu al
//vizelerin ortalamasıının %30
//dönem ödevinin %20
//final notunun %50
//ortalama 50 => geçti : kaldı


 // Console.Write("Vize 1 Notunu Giriniz: ");
 // int.TryParse(Console.ReadLine(),out int Vize1 );
 // Console.Write("Vize 2 Notunu Giriniz: ");
 // int.TryParse(Console.ReadLine(),out int Vize2 );
 // Console.Write("Dönem Ödevi Notunu Giriniz: ");
 // int.TryParse(Console.ReadLine(),out int Homework );
 // Console.Write("Final Notunu Giriniz: ");
 // int.TryParse(Console.ReadLine(),out int Final);
 //
 // double vizeOrt = (Vize1 + Vize2) / 2 * 0.3;
 // double HomeworkOrt = Homework * 0.2;
 // double FinalOrt = Final * 0.5;
 //
 // string Durum = vizeOrt + HomeworkOrt + FinalOrt >= 50 ? "Geçti" : "Kaldı"; 
 //
 // Console.WriteLine(Durum);

//  int ortalama = 10;
//
// if (ortalama >= 50)
//  {
//      Console.WriteLine("Dersi Geçtin");
//  }
// else
// {
//     Console.WriteLine("Seneye Görüşürüz");
// }

//Kullanıcının sistemdeki abonelik türünü ekrana yazan program
// 500 => Gold Üye
//350 => Silver Üye
//200 => Bronz Üye
//üye


// Console.Write("Puanınızı giriniz: ");
// int.TryParse(Console.ReadLine(), out int puan);
//
// if (puan>=500)
// {
//  Console.WriteLine("Gold Üye");
// } else if (puan<=500&&puan>350)
// {
//  Console.WriteLine("Silver Üye");
// }else if (puan >= 200 && puan < 350 )
// {
//  Console.WriteLine("Bronz Üye");
// }else if (puan < 200)
// {
//  Console.WriteLine("Üye");
// }
// else
// {
//  Console.WriteLine("üYE MİSİN?");
// }

// string user = "admin";
// string password = "ruhi123";
//
// Console.WriteLine("Kullanıcı Adınızı Giriniz");
// string userName = Console.ReadLine();
// Console.WriteLine("Parolanızı Giriniz");
// string pass =  Console.ReadLine();
//
// if (userName == user && password == pass)
// {
//  Console.WriteLine("Giriş Başarılı!");
// }
// else
// {
//  Console.WriteLine("nOLUYO YA");
// }


//Doğum Yılını 12'ye böl ve kalana bak:

// Console.Write("Doğum Yılını Giriniz: ");
// int.TryParse(Console.ReadLine(), out int year);
//
// int chineseyear = year % 12;
//
// if (chineseyear == 0)
// {
//  Console.WriteLine("Maymun");
// }else if (chineseyear == 1)
// {
//  Console.WriteLine("Horoz");
// }else if (chineseyear == 2)
// {
//  Console.WriteLine("Köpek");
// }else if (chineseyear == 3)
// {
//  Console.WriteLine("Domuz");
// }else if (chineseyear == 4)
// {
//  Console.WriteLine("Fare");
// }else if (chineseyear == 5)
// {
//  Console.WriteLine("Öküz");
// }else if (chineseyear == 6)
// {
//  Console.WriteLine("Kaplan");
// }else if (chineseyear == 7)
// {
//  Console.WriteLine("Tavşan");
// }else if (chineseyear == 8)
// {
//  Console.WriteLine("Ejderha");
// }else if (chineseyear == 9)
// {
//  Console.WriteLine("Yılan");
// }else if (chineseyear == 10)
// {
//  Console.WriteLine("At");
// }else if (chineseyear == 11)
// {
//  Console.WriteLine("At");
// }else if (chineseyear == 12)
// {
//  Console.WriteLine("Keçi");
// }
// else
// {
//  Console.WriteLine("Nesin sen ?");
// }
//
//
//

// double OpenCost = 200;
// double KmCost = 40;
// int MinKm = 5;
// double MinCost = 250; 
//
// Console.WriteLine("Şenkardeşler Taksi ve ulaşım hizmetine hoşgeldin Gardeşım! Kaç Km Gidicen?");
// int.TryParse(Console.ReadLine(), out int kmgo);
//
// if (kmgo>MinKm)
// {
//  Console.WriteLine((kmgo * KmCost)+OpenCost);
// }else if (kmgo <= MinKm)
// {
//  Console.WriteLine(MinCost + OpenCost);
// }




Console.WriteLine("Hesaplanmasını istediğiniz yılı giriniz: ");
int.TryParse(Console.ReadLine(), out int yil);

if ((yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0))
{
    Console.WriteLine($"{yil} bir artık yıldır.");
}
else
{
    Console.WriteLine($"{yil} bir artık yıl değildir.");
}






