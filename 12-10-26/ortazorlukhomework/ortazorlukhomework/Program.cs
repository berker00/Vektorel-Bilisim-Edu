Console.Title = "Vektörel Araç Kiralama - Teslimat & Faturalandırma";
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

const decimal GUNLUK_KM_LIMITI = 300m;
const decimal ASIM_KM_UCRET = 6.50m;
const double KDV_ORANI = 0.20;
const decimal GENC_SURUCU = 250m;

Console.Write("Sürücü Adı ve Soyadı: ");
var adSoyad = Console.ReadLine();

Console.Write("Sürücü Doğum Tarihi (GG.AA.YYYY): ");
DateTime.TryParse(Console.ReadLine(), out var dogumTarihi);

Console.Write("Araç Segmenti (ekonomik/suv/premium): ");
string segment = Console.ReadLine();

Console.Write("Kiralama Başlangıç Tarihi (GG.AA.YYYY HH:mm): ");
DateTime.TryParse(Console.ReadLine(), out var baslangic_tarihi);

Console.Write("Teslim Tarihi (GG.AA.YYYY HH:mm): ");
DateTime.TryParse(Console.ReadLine(), out var teslim_tarihi);

Console.Write("Yapılan Toplam Kilometre: ");
int.TryParse(Console.ReadLine(), out var yapilan_km);

Console.Write("Kasko Paketi (tam/mini/yok): ");
string kaskoPaketi = Console.ReadLine();

// 1. Araç Seçimi
var (aracucret, araclar) = segment.ToLowerInvariant() switch
{
    "ekonomik" or "1" => (950m, "Ekonomik (Fiat Egea vb.)"),
    "suv" or "2"      => (1850m, "SUV (Dacia Duster vb.)"),
    "premium" or "3"  => (3200m, "Premium (BMW 3 Serisi vb.)"),
    _                 => (1200m, "Standart Segment")
};

// 2. Süre ve Yaş Hesabı
TimeSpan sure = teslim_tarihi - baslangic_tarihi;
int gunSayisi = (int)Math.Ceiling(sure.TotalDays);
gunSayisi = gunSayisi <= 0 ? 1 : gunSayisi;

int yas = (int)((DateTime.Now - dogumTarihi).TotalDays / 365.25);

// 3. Kilometre Aşım Hesabı
decimal toplamKmLimiti = gunSayisi * GUNLUK_KM_LIMITI;
decimal hamAsimKm = yapilan_km - toplamKmLimiti;
decimal asimKm = hamAsimKm > 0 ? hamAsimKm : 0m;
decimal kmAsimCezasi = asimKm * ASIM_KM_UCRET;

// 4. Kasko Hesabı
decimal kasko_gunluk = kaskoPaketi.ToLowerInvariant() switch
{
    "tam"  => 350m,
    "mini" => 150m,
    _      => 0m,
};
decimal toplamKaskoUcreti = kasko_gunluk * gunSayisi;

// 5. Genç Sürücü Hesabı (21-25 yaş arası gün başına 250 TL)
decimal gencSurucuUcreti = (yas >= 21 && yas < 25) ? GENC_SURUCU * gunSayisi : 0m;

// 6. Fatura Toplamı (Bileşik Atama +=)
decimal kiralamaBedeli = aracucret * gunSayisi;
decimal araToplam = kiralamaBedeli;
araToplam += toplamKaskoUcreti;
araToplam += gencSurucuUcreti;
araToplam += kmAsimCezasi;

decimal kdvTutari = araToplam * (decimal)KDV_ORANI;
decimal genelToplam = araToplam + kdvTutari;

int sozlesmeNo = 10450;

// Çıktı Ekranı
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("======================================================================");
Console.WriteLine("            VEKTÖREL ARAÇ KİRALAMA & TESLİMAT FİŞİ                    ");
Console.WriteLine("======================================================================");
Console.WriteLine($"Sözleşme No: {++sozlesmeNo:D8} \t Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}");
Console.WriteLine($"Müşteri: {adSoyad} (Yaş: {yas})");
Console.WriteLine($"Araç: {araclar}");
Console.WriteLine($"Alış Tarihi:    {baslangic_tarihi:dd.MM.yyyy HH:mm} ({baslangic_tarihi.DayOfWeek})");
Console.WriteLine($"Teslim Tarihi:  {teslim_tarihi:dd.MM.yyyy HH:mm} ({teslim_tarihi.DayOfWeek})");
Console.WriteLine($"Toplam Süre:    {gunSayisi} Gün");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("KİLOMETRE BİLGİLERİ");
Console.WriteLine($"Kullanılan KM:          {yapilan_km} KM");
Console.WriteLine($"Maksimum Limit:         {toplamKmLimiti} KM ({GUNLUK_KM_LIMITI} KM/Gün)");
Console.WriteLine($"Aşım Miktarı:           {asimKm} KM");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("ÜCRET KALEMLERİ");
Console.WriteLine($"Kiralama Bedeli ({gunSayisi} Gün): \t {kiralamaBedeli:c2}");
Console.WriteLine($"Kasko Güvencesi ({kaskoPaketi}): \t {toplamKaskoUcreti:c2}");
Console.WriteLine($"Genç Sürücü Ek Primi:   \t {gencSurucuUcreti:c2}");
Console.WriteLine($"KM Aşım Bedeli:         \t {kmAsimCezasi:c2}");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine($"Ara Toplam:             \t {araToplam:c2}");
Console.WriteLine($"KDV Tutarı (%20):       \t {kdvTutari:c2}");
Console.WriteLine($"GENEL TOPLAM:           \t {genelToplam:c2}");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("Bilgi: \"Aracı çeyrek depo altında teslim etmek ek ücrete tabidir.\"");
Console.WriteLine("======================================================================");