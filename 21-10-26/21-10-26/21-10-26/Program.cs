////sayHello();
////Console.WriteLine("İsminiz nedir???");
//////merhabaDe(Console.ReadLine());
////Console.WriteLine("Buda main içerisindeki birşey");
////string result=merhabaDemeli();
////string maraba = "Merhaba";
////Console.WriteLine(result);
////Console.WriteLine(merhabaDemeli());

////int plaka=sayiAl("Memleketinin plakası kaç?");

////Console.WriteLine(plaka);
////int age = sayiAl("Senin yaşın kaç?");
////Console.WriteLine(age);
//////dönüşü olmayan ve parametresi olmayan metod
////// void metodAdı(){}

////void sayHello()
////{
//// Console.WriteLine("Hello!!!");
////}

//////void sayMaraba()
//////{
////// Console.WriteLine("maraba televole");
//////}

////// dönüşü olmayan parametreli metod
////// void metodAdı(veriTipi parametreAdı){}

////void merhabaDe(string name)
////{
//// Console.WriteLine("merhaba "+name);
////}

////// dönüşü olan parametresiz metod
////// veriTipi metodAdı(){ return veri}

////string merhabaDemeli()
////{
//// return "Merhaba";
////}

////// dönüşü olan parametreli metod
////// veriTipi metodAdı(veriTipi değişkenAdı){return veri}

////int sayiAl(string message)
////{
//// Console.WriteLine(message);
//// int.TryParse(Console.ReadLine(), out int result);
//// return result;
////}


//// Kullanıcıdan iki sayı alıp işlem alıp sonucu dönen programı yazınız.

////489+653


//Console.WriteLine(sayilariBol(metinOku("Yapmak istediğiniz işlemi açıkça yazınız")));




//int sayilariBol(string islem) {
// int[] numbers= null;
// int result = 0;
// if (islem.Contains("+"))
// {
// numbers=sayiyaCevir(islem.Split('+'));
// result = numbers != null ? toplam(numbers[0], numbers[1]) : 0;
// }else if (islem.Contains("*"))
// {
// numbers = sayiyaCevir(islem.Split('*'));
// result = numbers != null ? carp(numbers[0], numbers[1]) : 0;
// }
// else if (islem.Contains("-"))
// {
// numbers = sayiyaCevir(islem.Split('-'));
// result = numbers != null ? cikar(numbers[0], numbers[1]) : 0;
// }
// else if (islem.Contains("/"))
// {
// numbers = sayiyaCevir(islem.Split('/'));
// result = numbers != null ? bol(numbers[0], numbers[1]) : 0;
// }
// return result;
//}
//int[] sayiyaCevir(string[] arr)
//{
// int[] result = new int[2];
// if (arr.Length == 2)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// result[i] = int.Parse(arr[i]);
// }

// return result;
// }
// else
// {
// return null;
// }
//}

//string metinOku(string message)
//{
// Console.WriteLine(message);
// return Console.ReadLine()??string.Empty;
//}

//int toplam(int a,int b)
//{
// return a + b;
//}
//int carp(int a, int b)
//{
// return a * b;
//}
//int cikar(int a, int b)
//{
// return a - b;
//}
//int bol(int a, int b)
//{
// return a / b;
//}
//int deger=0;
//int yeniDeger=Degistir(ref deger);
//Console.WriteLine($"{deger} {yeniDeger}");
//Console.WriteLine($"{deger} {DegistirDefault(deger)}");
//int Degistir(ref int x)
//{
// return x = 20;
//}
//int DegistirDefault(int x)
//{
// return x = 60;
//}


//Console.WriteLine(toplam(out int sonuc,-8 , 5, out string message));
//Console.WriteLine(message+": "+sonuc);
//bool toplam(out int toplam,int a,int b,out string message)
//{
// if (a > 0 && b > 0)
// {
// toplam = a + b;
// message = "İşlem Başarılı";
// return true;
// }
// else
// {
// toplam = 0;
// message = "İşlem Başarısız";
// return false;
// }
//}

//Console.WriteLine(DaireAlanHesapla(out double s,7.7896,Math.PI));
//Console.WriteLine(s);

//bool DaireAlanHesapla(out double sonuc,double r,in double pi)
//{
// if (r <= 0)
// {

// sonuc = 0;
// return false;
// }
// else
// {
// sonuc = (r*r)*pi;
// return true;
// }
//}

//Console.WriteLine(Topla(4,6,8,2,4,6));
//Console.WriteLine(Topla(4,6,8,2));
//int Topla(params int[] sayilar)
//{
// int r = 0;
// foreach (var n in sayilar)
// {
// r += n;
// }
// return r;
//}
//sayHello("Abdullah","Neredesin",5);
//void sayHello(string name, string message = "Merhaba", int tekrar=1)
//{
// for (int i = 0; i < tekrar; i++)
// {
// Console.WriteLine(message + " " + name);
// }
//}

// 6 1-49 sayısal loto
int[] tahmin = new int[6];
int[] sistem = new int[6];
TahminAl(ref tahmin,ref sistem,false);
Console.WriteLine($"Girmiş Olduğunuz Sayılar: {string.Join(", ",tahmin)}");
TahminAl(ref tahmin, ref sistem, true);
Console.WriteLine($"Çekilen Sayılar: {string.Join(", ",sistem)}");
if(Control(ref tahmin, ref sistem, out int sayi))
{
Console.WriteLine($"Tebrikler {sayi} bildiniz...");
}
else
{
Console.WriteLine("Sıkma canını kasa her zaman kazanır...");
}


bool Control(ref int[] tahmin, ref int[] sistem, out int sayi)
{
int count = 0;
for (int i = 0; i < sistem.Length; i++)
{
for (int j = 0; j < tahmin.Length; j++)
{
if (sistem[i] == tahmin[j])
{
count++;
break;
}
}
}
sayi= count;
return count>=5;
}


void TahminAl(ref int[] tahmin,ref int[] sistem, bool isSistem)
{
Random rnd = new Random();
int index = 0;
if (isSistem)
{
while (index <= 5)
{
int sayi=rnd.Next(1,50);
if (isOne(sayi, ref sistem))
{
sistem[index++] = sayi;
}
else
{
Console.WriteLine("Sistem mükerrer sayı girdi: "+sayi);
}
}
}
else
{
while (index <= 5)
{
Console.WriteLine("1-49 arasında bir sayı giriniz");

if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0 && sayi < 50)
{
if (isOne(sayi, ref tahmin))
{
tahmin[index] = sayi;
index++;
}
else
{
Console.WriteLine($"{sayi} daha önceden eklendi");
}
}
else
{
Console.WriteLine("Düzgün bir sayı girsen mi acaba???");
}

}
}
}




bool isOne(int n,ref int[] arr)
{
foreach (var x in arr)
{
if (x == n&&x>0)
{
return false;
}
}
return true;
}