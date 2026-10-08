//Konsole Konfigürasyon
Console.Title = "Atlas Depo Yönetimi & Hızlı Kasa v2.0";
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Clear();

//Sabit Değerler
const double KDV_ORANI = 0.20;
const int BOX_QUANTITY = 12;
const double DISCOUNT = 0.25;


string musteriNotu = string.Empty;
string sistemKodu = null;

Console.Write("Ürün Adını Giriniz: ");
var ProductName = Console.ReadLine();
Console.Write("Ürün Barkod No Giriniz: ");
long.TryParse(Console.ReadLine(), out long ProductID);
Console.Write("Birim Fiyatını Giriniz: ");
decimal.TryParse(Console.ReadLine(), out decimal ProductPrice);
Console.Write("Sipariş Adedi: ");
int.TryParse(Console.ReadLine(), out int ProductQuantity);
Console.Write("Öğrenci/Kurumsal İndirimi var mı? ");
bool.TryParse(Console.ReadLine(), out bool isDiscount);

int fullBoxCount = ProductQuantity / BOX_QUANTITY;
int leftoverProduct = ProductQuantity % BOX_QUANTITY;

decimal totalPrice = ProductPrice * ProductQuantity;
decimal kdvPrice = totalPrice * (decimal)KDV_ORANI;

decimal discount = isDiscount ? totalPrice * (decimal)DISCOUNT : 0;

decimal TotalPay = totalPrice + kdvPrice - discount;

int processCounter = 100;
int PackageCount = ProductQuantity / BOX_QUANTITY;
Console.Clear();
Console.ForegroundColor =  ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("============================================================");
Console.WriteLine("              ATLAS LOJİSTİK VE DEPO SİSTEMİ                ");
Console.WriteLine("============================================================");
Console.WriteLine($"Tarih: {DateTime.Now}\t İşlem No: {++processCounter}");
Console.WriteLine($"Barkod No: {ProductID:D12}");
Console.WriteLine($"Ürün: {ProductName}");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Sipariş Adedi:\t {ProductQuantity} Adet");
Console.WriteLine($"Paketleme:\t {PackageCount} (Açıkta Kalan {leftoverProduct})");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Birim Fiyat:\t {ProductPrice:c2}");
Console.WriteLine($"Ara Toplam:\t {totalPrice:c2}");
Console.WriteLine($"KDV Oranı:\t {KDV_ORANI:p0}");
Console.WriteLine($"KDV Tutarı:\t {kdvPrice:c2}");
Console.WriteLine($"İndirim Tutarı:\t -{discount:c2}");
Console.WriteLine($"Genel Toplam:\t {TotalPay:c2}");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Kural: \"Paketi açılmış ürünler iade alınmaz!\"");
Console.WriteLine("============================================================");





