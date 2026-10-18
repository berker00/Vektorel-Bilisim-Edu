Console.Write("0 ile 9999 arasında bir sayı giriniz: ");
bool basarili = int.TryParse(Console.ReadLine(), out int sayi);

if (!basarili || sayi < 0 || sayi > 9999)
{
    Console.WriteLine("Hata: Lütfen 0 ile 9999 aralığında geçerli bir tam sayı giriniz!");
}
else if (sayi == 0)
{
    Console.WriteLine("Okunuşu: Sıfır");
}
else
{
    // 0. indeksler boş bırakılır çünkü basamak değeri 0 ise hiçbir şey yazdırılmaz.
    string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
    string[] onlar  = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

    // Basamakların ayrıştırılması
    int binlerBasamagi = sayi / 1000;
    int yuzlerBasamagi = (sayi % 1000) / 100;
    int onlarBasamagi  = (sayi % 100) / 10;
    int birlerBasamagi = sayi % 10;

    string yaziKarsiligi = string.Empty;

    // 1. Binler Basamağı Kontrolü
    if (binlerBasamagi == 1)
    {
        yaziKarsiligi += "Bin ";
    }
    else if (binlerBasamagi > 1)
    {
        yaziKarsiligi += birler[binlerBasamagi] + " Bin ";
    }

    // 2. Yüzler Basamağı Kontrolü
    if (yuzlerBasamagi == 1)
    {
        yaziKarsiligi += "Yüz ";
    }
    else if (yuzlerBasamagi > 1)
    {
        yaziKarsiligi += birler[yuzlerBasamagi] + " Yüz ";
    }

    // 3. Onlar Basamağı
    if (onlarBasamagi > 0)
    {
        yaziKarsiligi += onlar[onlarBasamagi] + " ";
    }

    // 4. Birler Basamağı
    if (birlerBasamagi > 0)
    {
        yaziKarsiligi += birler[birlerBasamagi];
    }

    // Sonuçtaki gereksiz baş/son boşluklarını temizleyip yazdırıyoruz
    Console.WriteLine($"Okunuşu: {yaziKarsiligi}");
}