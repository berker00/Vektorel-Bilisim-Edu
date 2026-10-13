Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "Vektörel Butik Otel - Rezervasyon & Kasa Sistemi";
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();

const double TABAN_GECELIK_UCRET = 1500;
const double KDV_ORANI = 0.10;

Console.Write("Müşteri Adını Giriniz: ");
var AdSoyad = Console.ReadLine();

Console.Write("Rezervasyon Yapılacak Ay (Ay ismi veya Ay sırası ile giriniz!): ");
string rezervasyon_ayi = Console.ReadLine();

Console.Write("Otele Giriş Tarihi (GG.AA.YYYY): ");
DateTime.TryParse(Console.ReadLine(), out DateTime Check_in);

Console.Write("Otelden Çıkış Tarihi (GG.AA.YYYY): ");
DateTime.TryParse(Console.ReadLine(), out DateTime Check_out);

Console.Write("VIP üye mi? (true/false): ");
bool.TryParse(Console.ReadLine(), out bool is_vip);

// Tek bir switch expression ile hem çarpanı hem sezon adını alıyoruz
var (sezon_carpani, sezon_ismi) = rezervasyon_ayi.ToLowerInvariant() switch
{
    "haziran" or "6" or "temmuz" or "7" or "ağustos" or "8" => (1.5, "Yaz Sezonu"),
    "eylül" or "9" or "ekim" or "10" or "kasım" or "11"     => (1.0, "Sonbahar Sezonu"),
    "aralık" or "12" or "ocak" or "1" or "şubat" or "2"     => (0.8, "Kış Sezonu"),
    "mart" or "3" or "nisan" or "4" or "mayıs" or "5"       => (1.2, "İlkbahar Sezonu"),
    _                                                      => (1.0, "Standart Sezon")
};

// Tarih farkı ve gün kontrolü
TimeSpan konaklamasuresi = Check_out - Check_in;
int geceSayisi = (int)konaklamasuresi.TotalDays <= 0 ? 1 : (int)konaklamasuresi.TotalDays;

// Fiyat hesaplamaları
double günlük_net_ücret = TABAN_GECELIK_UCRET * sezon_carpani;
double konaklama_tutari = günlük_net_ücret * geceSayisi;
double indirim = is_vip ? konaklama_tutari * 0.15 : 0;
double kdv = (konaklama_tutari - indirim) * KDV_ORANI;
double genel_toplam = (konaklama_tutari - indirim) + kdv;

int rezervasyonNo = 5000;

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("============================================================");
Console.WriteLine("           Vektörel BUTİK OTEL REZERVASYON FİŞİ              ");
Console.WriteLine("============================================================");
Console.WriteLine($"Rezervasyon No: {++rezervasyonNo:D6} \t Düzenleme: {DateTime.Now:dd.MM.yyyy HH:mm}");
Console.WriteLine($"Müşteri: {AdSoyad}");
Console.WriteLine($"Giriş Tarihi: {Check_in:dd.MM.yyyy} ({Check_in.DayOfWeek})");
Console.WriteLine($"Çıkış Tarihi: {Check_out:dd.MM.yyyy} ({Check_out.DayOfWeek})");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Dönem / Sezon:\t\t {sezon_ismi}");
Console.WriteLine($"Konaklama Süresi:\t {geceSayisi} Gece");
Console.WriteLine($"Taban Gecelik:\t\t {TABAN_GECELIK_UCRET:c2}");
Console.WriteLine($"Günlük Ücret (Sezonlu):\t {günlük_net_ücret:c2}");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Ara Toplam:\t\t {konaklama_tutari:c2}");
Console.WriteLine($"VIP İndirimi (%15):\t -{indirim:c2}");
Console.WriteLine($"KDV Tutarı (%10):\t {kdv:c2}");
Console.WriteLine($"GENEL TOPLAM:\t\t {genel_toplam:c2}");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Kural: \"Giriş saati 14:00, çıkış saati 11:00'dir.\"");
Console.WriteLine("============================================================");