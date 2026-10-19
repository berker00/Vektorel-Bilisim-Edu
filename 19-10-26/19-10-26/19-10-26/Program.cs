bool status = false;
//while (status)
//{
// Console.WriteLine("burda dünyanın sırrını paylaşıyorum...");
//}

//do
//{
// Console.WriteLine("burda dünyanın sırrını paylaşıyorum...");
//}
//while (status);

// asal sayı
// 1 den ve kendisinden başka sayıya tam bölünmeyecek

//Console.WriteLine("ASAL Kontrolü yapılacak sayıyı giriniz");
//int.TryParse(Console.ReadLine(), out int n);
//if (n > 2)
//{
// bool isAsal = true;
// int divede = 2;
// while (divede < n)
// {
// if (n % divede == 0)
// {
// isAsal = false;
// break;
// }
// divede++;
// }

// string durum = isAsal ? $"{n} ASAL bir sayıdır" : $"{n} ASAL bir sayı değildir";
// Console.WriteLine(durum);
//}
//else
//{
// Console.WriteLine("yaw he he");
//}

//Console.WriteLine("Sayıyı giriniz");
//int.TryParse(Console.ReadLine(), out int n);
//StringBuilder sb = new StringBuilder("1, 2");
//if (n > 2)
//{
// for (int i = 3; i < n; i++)
// {
// bool isAsal = true;
// for (int j = 2; j < i; j++)
// {
// if (i % j == 0)
// {
// isAsal = false;
// break;
// }
// }
// if (isAsal)
// {
// sb.Append($", {i}");
// }
// }
// Console.WriteLine($"Girmiş olduğunuz {n} sayısına kadar olan ASAL Sayılar:");
// Console.WriteLine(sb.ToString());
//}
//else
//{
// Console.WriteLine("yaw he he");
//}

// Faktöryel Hesaplama
// Kullanıcıdan aldığınız sayının faktöryelini hesaplayın

// 5= 5*4*3*2*1


//Console.WriteLine("Faktöryeli hesaplanacak sayıyı giriniz");
//long.TryParse(Console.ReadLine(), out long n);
//long faktoryel = n;
//for (long i = n-1; i >0; i--)
//{
// faktoryel *= i;
//}
//Console.WriteLine($"{n} sayısının faktöryeli: {faktoryel}");

// Fibonacci Serisi Yazdırma
// Kullanıcıdan aldığınız sayı kadar fibonacci serisi yazınız.

//Console.WriteLine("Faktöryeli hesaplanacak sayıyı giriniz");
//if(int.TryParse(Console.ReadLine(), out int n)&& n > 0)
//{
// long a = 0;
// long b = 1;
// for (int i = 0; i < n; i++)
// {
// Console.Write(a+" ");
// long temp = a;
// a = b;
// b = temp+b;
// }
//}
//else
//{
// Console.WriteLine("Oğlum bak git...");
//}
//int n = 5;
//for (int i = 0; i <= n; i++)// sütun
//{
// for (int j = 0; j <= n; j++)// satır
// {
// if(i==0 || j == 0 || i == n || j == n)
// {
// Console.Write("*");
// }
// else
// {
// Console.Write(" ");
// }
// }
// Console.WriteLine();
//}

//int n = 10;

//for (int i = 0; i <= n; i++)// sütun
//{
// for (int j= 0; j<=i; j++)// satır
// {
// if (i == 0 || i == j || i == n||j==0)
// {
// Console.Write("*");
// }
// else
// {
// Console.Write(" ");
// }

// }
// Console.WriteLine();
//}

//int yuk = 10;

//for (int i = 1; i <= yuk; i++)
//{
// for (int j = 1; j <= yuk-i; j++)
// {
// Console.Write(" ");
// }
// for (int k = 1; k <=(2*i-1) ; k++)
// {
// Console.Write("*");
// }
// Console.WriteLine();
//}

// 3 kat 4 daire

//int kat = 3, daire = 4;
//int kapiNo = 1;
//for (int i = 1; i <= kat; i++)
//{
// Console.WriteLine($"{i}. kata geldim");

// for (int j = 1; j <= daire; j++)
// {
// Console.WriteLine($"{i}. kat {j}. Daire {kapiNo} kapısını çaldı... Tak tak tak");
// Console.WriteLine($"{i}. kat {j}. Daire kapısından sel geldi... Kim oooo");
// Console.WriteLine("Ben kapıcı ibo");
// Console.WriteLine("Ne var akşam akşam?");
// Console.WriteLine("aidatını öde artislik yapma");
// kapiNo++;
// Thread.Sleep(2000);

// }
//}

string[] names = { "Abdullah", "Ayşe", "Kezban", "Şukufe", "Murtaza", "Musa" };
for (int i = 0; i < names.Length; i++)
{

}

foreach (string name in names)
{
Console.WriteLine(name);
}