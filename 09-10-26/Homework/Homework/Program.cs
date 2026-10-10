//10.09.2026 Faruk Hocanın verdiği ödev
//Kullanıcıdan alınan YIL verisinin Artık Yıl mı Değil mi sorusunu cevaplayan program

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