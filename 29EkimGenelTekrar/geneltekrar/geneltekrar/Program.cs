Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "Sinema Paneli";
Console.Clear();

const decimal TAM_BILET = 180.00m;
const decimal OGRENCI_BILETI = 120.00m;

int biletSayisi = 0;
decimal toplamBiletTutari = 0m;

string[,] salon = new string[4, 4];
for (int i = 0; i < salon.GetLength(0); i++)
{
    for (int j = 0; j < salon.GetLength(1); j++)
    {
        salon[i, j] = "[0]";
    }
}

string[] bufeUrunler = { "Misir(Buyuk)", "Kola", "Su", "Cikolata" };
decimal[] bufeFiyatlar = { 90.00m, 50.00m, 20.00m, 40.00m };
int[] bufeSepet = new int[bufeUrunler.Length];
decimal ToplamBufeTutari = 0m;

while (true)
{
    Console.WriteLine("\n==========================================================");
    Console.WriteLine("                        Sinema Paneli                    ");
    Console.WriteLine("==========================================================");
    Console.WriteLine("[1] Salon Koltuk Duzeni ve Koltuk Sec");
    Console.WriteLine("[2] Sinema Bufesinden Urun Al");
    Console.WriteLine("[3] Sepeti ve Toplam Tutari Gor");
    Console.WriteLine("[0] Fisi Yazdir ve Cikis Yap");

    int secim = IntAl("Lutfen Islem Seciniz: ");
    switch (secim)
    {
        case 1:
            KoltukSec();
            break;
        case 2:
            UrunAl();
            break;
        case 3:
            decimal genelToplam = toplamBiletTutari + ToplamBufeTutari;
            Console.WriteLine($"\nBilet Tutari: {toplamBiletTutari:c2}");
            Console.WriteLine($"Bufe Tutari:  {ToplamBufeTutari:c2}");
            Console.WriteLine($"Genel Tutar:  {genelToplam:c2}");
            Console.WriteLine("Devam etmek icin bir tusa basiniz...");
            Console.ReadKey();
            break;
        case 0:
            FisYazdir();
            return;
        default:
            Console.WriteLine("\nGecersiz Islem! Yeniden Deneyiniz.");
            break;
    }
}

#region MenuIslemleri

void KoltukSec()
{
    Console.Clear();
    Console.WriteLine("--- Salon Duzeni ([0]: Bos, [1]: Dolu) ---\n");

    for (int i = 0; i < salon.GetLength(0); i++)
    {
        for (int j = 0; j < salon.GetLength(1); j++)
        {
            Console.Write($"{salon[i, j]}\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\n[1] Koltuk Sec");
    Console.WriteLine("[0] Geri Don");
    int secim = IntAl("Lutfen Islem Seciniz: ");

    if (secim == 1)
    {
        int sira = IntAl("Sira No (1-4): ") - 1;
        int sutun = IntAl("Sutun No (1-4): ") - 1;

        if (sira >= 0 && sira < 4 && sutun >= 0 && sutun < 4)
        {
            if (salon[sira, sutun] == "[1]")
            {
                Console.WriteLine("\nBu koltuk zaten DOLU! Lutfen baska bir yer seciniz.");
            }
            else
            {
                string koltukTuru = MetinAl("Tarife Seciniz (Ogrenci / Standart): ");

                decimal biletUcreti = koltukTuru.ToLowerInvariant() switch
                {
                    "ogrenci" => OGRENCI_BILETI,
                    _ => TAM_BILET
                };

                salon[sira, sutun] = "[1]";
                biletSayisi++;
                toplamBiletTutari += biletUcreti; 

                Console.WriteLine($"\nKoltuk basariyla secildi! Tutar: {biletUcreti:c2}");
            }
        }
        else
        {
            Console.WriteLine("\nGecersiz Koltuk Koordinati!");
        }

        Console.WriteLine("Devam etmek icin bir tusa basiniz...");
        Console.ReadKey();
    }
}

void UrunAl()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("             BUFE                ");
        Console.WriteLine("=================================");
        Console.WriteLine($"Guncel Bufe Tutari: {ToplamBufeTutari:C2}\n");

        for (int i = 0; i < bufeUrunler.Length; i++)
        {
            Console.WriteLine($"[{i + 1}] {bufeUrunler[i],-15} : {bufeFiyatlar[i]:C2} (Sepette: {bufeSepet[i]})");
        }

        Console.WriteLine("\n[1] Urun Al");
        Console.WriteLine("[2] Urun Cikar");
        Console.WriteLine("[0] Geri Don");

        int secim = IntAl("Lutfen Islem Seciniz: ");

        switch (secim)
        {
            case 1:
                int urunNo = IntAl("Urun No Seciniz: ") - 1;

                if (urunNo >= 0 && urunNo < bufeUrunler.Length)
                {
                    int adet = IntAl($"Kac adet '{bufeUrunler[urunNo]}' almak istiyorsunuz?: ");

                    if (adet > 0)
                    {
                        bufeSepet[urunNo] += adet;
                        decimal araToplam = bufeFiyatlar[urunNo] * adet;
                        ToplamBufeTutari += araToplam;

                        Console.WriteLine($"\n{adet} adet {bufeUrunler[urunNo]} sepete eklendi! (+{araToplam:C2})");
                    }
                    else
                    {
                        Console.WriteLine("\nGecersiz adet girdiniz!");
                    }
                }
                else
                {
                    Console.WriteLine("\nGecersiz urun numarasi!");
                }

                Console.WriteLine("Devam etmek icin bir tusa basiniz...");
                Console.ReadKey();
                break;

            case 2:
                int cikarNo = IntAl("Cikarmak istediginiz urun no: ") - 1;

                if (cikarNo >= 0 && cikarNo < bufeUrunler.Length)
                {
                    if (bufeSepet[cikarNo] > 0)
                    {
                        int cikarAdet = IntAl($"Sepette {bufeSepet[cikarNo]} adet var. Kac adet cikarmak istiyorsunuz?: ");

                        if (cikarAdet > 0 && cikarAdet <= bufeSepet[cikarNo])
                        {
                            bufeSepet[cikarNo] -= cikarAdet;
                            decimal cikarTutar = bufeFiyatlar[cikarNo] * cikarAdet;
                            ToplamBufeTutari -= cikarTutar;

                            Console.WriteLine($"\n{cikarAdet} adet {bufeUrunler[cikarNo]} sepetten cikarildi. (-{cikarTutar:C2})");
                        }
                        else
                        {
                            Console.WriteLine("\nGecersiz adet!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nBu urunden sepetinizde bulunmamaktadir!");
                    }
                }
                else
                {
                    Console.WriteLine("\nGecersiz urun numarasi!");
                }

                Console.WriteLine("Devam etmek icin bir tusa basiniz...");
                Console.ReadKey();
                break;

            case 0:
                return;

            default:
                Console.WriteLine("\nGecersiz secim!");
                Console.ReadKey();
                break;
        }
    }
}

void FisYazdir()
{
    Console.Clear();
    Hesapla(toplamBiletTutari, ToplamBufeTutari, out decimal genelToplam);

    Console.WriteLine("========================================");
    Console.WriteLine("             SINEMA FISI                ");
    Console.WriteLine("========================================");
    Console.WriteLine($"Toplam Bilet Sayisi: \t {biletSayisi}");
    Console.WriteLine($"Toplam Bilet Tutari: \t {toplamBiletTutari:c2}");
    Console.WriteLine($"Toplam Bufe Tutari:  \t {ToplamBufeTutari:c2}");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"TOPLAM ODENECEK:     \t {genelToplam:c2}");
    Console.WriteLine("========================================");
    Console.WriteLine("Iyi seyirler dileriz!");
    Console.ReadKey();
}

void Hesapla(decimal biletTutari, decimal bufeTutari, out decimal genelToplam)
{
    genelToplam = biletTutari + bufeTutari;
}

#endregion

#region Yardimci Metotlar

string MetinAl(string mesaj)
{
    Console.Write(mesaj);
    return Console.ReadLine()?.Trim() ?? string.Empty;
}

int IntAl(string mesaj)
{
    Console.Write(mesaj);
    int.TryParse(Console.ReadLine(), out int deger);
    return deger;
}

#endregion