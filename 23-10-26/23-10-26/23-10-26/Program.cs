//int bakiye = 1000;
//int bahisMiktari = 0, bahisAti = -1;
//string[] horses = { "Rüzgar", "Sergen", "Yıldız", "BSaray", "Tümer", "ŞanslıS" };
//bool islem = true;
//while (islem&&bakiye>0)
//{

// int input = SayiAl("1- At Yarışı Oyna");
// if (input != 1)
// {
// Console.WriteLine("Güle Güle...");
// islem = false;
// }
// else
// {
// bahisMiktari = BahisKoy();
// bakiye -= bahisMiktari;
// bahisAti = AtSec(ref horses);
// int winner = StartRace(ref horses, bahisAti);
// Console.WriteLine($"Seçilen At: {horses[bahisAti]}");
// if (winner == bahisAti)
// {

// Console.WriteLine("Tebrikler kazandınız...");
// bakiye += bahisMiktari * 2;
// }
// else
// {
// Console.WriteLine("Unutma evlat kasa herzaman kazanır...");

// }
// Console.WriteLine("Mevcut bakiyeniz: "+bakiye);
// }
//}

//int StartRace(ref string[] horses, int bahisAti)
//{
// Random rnd = new Random();
// int[] distance = new int[horses.Length];
// bool isWinner = true;
// int winner = -1;
// while (isWinner)
// {
// Console.Clear();
// for (int i = 0; i < horses.Length; i++)
// {
// if (i == bahisAti)
// {
// distance[i] += rnd.Next(1, 3);
// }
// else
// {
// distance[i] += rnd.Next(1, 5);
// }
// for (int j = 0; j <= distance[i]; j++)
// {
// Console.Write("-");
// }
// Console.WriteLine(">" + horses[i]+" " + distance[i]);
// Thread.Sleep(100);
// if (WinControl(distance[i]))
// {
// winner = i;
// Console.WriteLine("Kazanan: " + horses[i]);
// isWinner= false;
// break;
// }
// }

// }
// return winner;
//}

//bool WinControl(int distance)
//{
// return distance >= 50;
//}

//int BahisKoy()
//{
// int islem = SayiAl("Bahis Miktarı\n1- 100\n2- 200\n3- 300");
// if (islem >= 1 && islem <= 3)
// {
// return islem * 100;
// }
// else
// {
// return 100;
// }

//}
//int AtSec(ref string[] horses)
//{
// Random rnd = new Random();
// for (int i = 0; i < horses.Length; i++)
// {
// Console.WriteLine($"Sıra No: {i + 1} At: {horses[i]}");
// }
// int result = SayiAl("Bahse gireceğiniz atın sıra numarasını giriniz: ");
// result = result >= 0 && result <= horses.Length ? result : rnd.Next(horses.Length)+1;
// result--;
// Console.WriteLine("Seçim: " + horses[result]);
// return result;
//}

//int SayiAl(string message)
//{
// Console.WriteLine(message);
// int.TryParse(Console.ReadLine(), out int result);
// return result;
//}

//Console.WriteLine("");



//void Hesapla(int[] arr)
//{
// Console.WriteLine("bişey");
//}

//int Hesapla(string arr)
//{
// Console.WriteLine("bişey");
// return 0;
//}

//int[] numbers = { 5, 6, 7, 8, 9 }; // => Tek Boyutlu Dizi
//for (int i = 0; i < numbers.Length; i++)
//{
// Console.WriteLine(numbers[i]);
//}
//string[,] apartman = new string[3,4];

//for (int i = 0; i < apartman.GetLength(0); i++)
//{
// for (int j = 0; j < apartman.GetLength(1); j++)
// {
// Console.WriteLine($"{i+1}. Kat {j+1}. Dairede Oturanın adını yazınız");
// apartman[i,j] = Console.ReadLine()??"";
// }
//}

//for (int i = 0; i < apartman.GetLength(0); i++)
//{
// for (int j = 0; j < apartman.GetLength(1); j++)
// {
// Console.WriteLine($"{i + 1}. Kat {j + 1}. Dairede Oturanın adı: {apartman[i, j]}");

// }
//}

// Jagged Arrays - Düzensiz Dizilerint

//int[][] numbers = new int[3][];


//numbers[0] = new int[] { 1,2,3 };
//numbers[1] = new int[] { 1,2,3,8,9 };
//numbers[2] = new int[] { 3 };

//for (int i = 0; i < numbers.Length; i++)
//{
// Console.WriteLine("numbers"+i);
// for (int j = 0; j < numbers[i].Length; j++)
// {

// Console.WriteLine(numbers[i][j]);
// }
//}

string[] names = { "Şukufe", "Arzu", "Elif", "Ahmet", "Abdullah", "Zübeyde" };
Console.WriteLine(Array.Find(names, n => n.StartsWith("A")));
Array.Sort(names);
Console.WriteLine(string.Join(", ",names));
Console.WriteLine(Array.Find(names, n => n.StartsWith("A")));
Array.Reverse(names);
Console.WriteLine(string.Join(", ", names));

Console.WriteLine(Array.IndexOf(names,"Şukufe"));
Console.WriteLine(Array.IndexOf(names,3));

Console.WriteLine(Array.Exists(names, n=>n=="Abdullah"));

Console.WriteLine(Array.Find(names, n => n.StartsWith("A")));

Console.WriteLine(string.Join(", ", names));

string[] names2 = new string[10];
Console.WriteLine(names2.Length);
Array.Copy(names, 3, names2, 3, 2);
Console.WriteLine(string.Join(", ", names2));
Console.WriteLine(names2.Length);

Array.Resize(ref names, 15);

Console.WriteLine(string.Join(", ", names));