// Console.WriteLine("Hello, World!");
//
// string cevap = Console.ReadLine();
// Console.WriteLine("Kaç Yaşındasın?");
// int yas = int.TryParse(Console.ReadLine(), out int k) ? k : 0;
// Console.WriteLine("Doğum Yılın Nedir?");
// int yil = Convert.ToInt32(Console.ReadLine());
//
// bool.TryParse(Console.ReadLine(), out bool isMarried);
// Console.WriteLine(isMarried);
// Console.WriteLine($"{cevap}, {yas}, {yil}");

//
// Console.Title = "Turkish Bot";
//
// Console.WriteLine("Selamın Aleyküm, Nasılsın?");
// string answer1 = Console.ReadLine();
// Console.WriteLine($"{answer1}, Buna Şükür, Nerelisin?");
// string answer2 = Console.ReadLine();
// Console.WriteLine($"{answer2}, Çok Güzel Memleket ya gitmek nasip olmadı ama olsun. Nerede Yaşıyorsun {answer2}'de mi?");
// bool.TryParse(Console.ReadLine(), out bool isLiveHere);
// Console.WriteLine($"Kaç Yıldır Orada Yaşıyorsun?");
// int.TryParse(Console.ReadLine(), out int LiveAgo);
// Console.WriteLine("İyiymiş hadi Allah'a emanet");
//

// implicit örtük dönüşüm
// int sayi1 = 256;
// long sayi2 = sayi1;
//
// float f = 3.14f;
// double pi = f;
//
// decimal d = sayi1;
// decimal d2 = sayi2;
//
//
// // Explicit açık dönüşüm
//
// int pi2 = (int)pi;
// Console.WriteLine(pi2);
//
// byte convertByte = (byte)sayi1;
// Console.WriteLine(convertByte);
// long n = 897987987979;
// int x = (int)n;
// Console.WriteLine(x);

// int y = Convert.ToInt32(n); // hatalı
// Console.WriteLine(y);

// int z = int.TryParse(x);
// Console.WriteLine(x);

// double ondalik = Convert.ToInt64(n);
// Console.WriteLine(ondalik);
//
// long max = Convert.ToInt64(ondalik);
// Console.WriteLine(max);

//Aritmatik Operatörler
// + - * /

// int n = 65;
// int z = 25;
// Console.WriteLine((n+z) + " Sonuc ");

Console.WriteLine("Sayiyi verin: ");
int.TryParse(Console.ReadLine(), out int sayi1);
Console.WriteLine("Bu sayıya eklenecek sayiyi verin: ");
int.TryParse(Console.ReadLine(), out int sayi2);
Console.WriteLine(sayi1 * sayi2);