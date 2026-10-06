Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "Lezzet Restoranı - Kasa v1.0";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();

Console.Write("Müşteri İsmi: ");
string CustomerName = Console.ReadLine();

Console.Write("Müşteri Soyadı: ");
string CustomerLastName = Console.ReadLine();

Console.Write("Masa Numarası: ");
byte TableNumber = byte.Parse(Console.ReadLine());

Console.Write("Sipariş Numarası: ");
int OrderCode = int.Parse(Console.ReadLine()); // ReadLine + Parse ile düzeltildi

Console.Write("Ana Yemek Fiyatı: ");
decimal OrderFood = decimal.Parse(Console.ReadLine());

Console.Write("İçecek Fiyatı: ");
decimal OrderDrink = decimal.Parse(Console.ReadLine());

double Discount = 0.15;

decimal TotalTableCount = OrderFood + OrderDrink;
decimal DiscountTotal = TotalTableCount * (decimal)Discount;
decimal TotalPrice = TotalTableCount - DiscountTotal;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("===========================================");
Console.WriteLine("            Lezzet Restoranı               ");
Console.WriteLine("===========================================");
Console.WriteLine($"Tarih: {DateTime.Now:dd/MM/yyyy}\tMasa No: {TableNumber}");
Console.WriteLine($"Müşteri: {CustomerName} {CustomerLastName}");
Console.WriteLine($"Sipariş No: {OrderCode:D8}");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Hizmet\t\tTUTAR");
Console.WriteLine($"Ana Yemek\t{OrderFood:c2}");
Console.WriteLine($"İçecek\t\t{OrderDrink:c2}");
Console.WriteLine("-------------------------------------------");
Console.WriteLine($"Ara Toplam\t{TotalTableCount:c2}");
Console.WriteLine($"İndirim Oranı\t{Discount:p0}");
Console.WriteLine($"İndirim Tutarı\t{DiscountTotal:c2}");
Console.WriteLine($"Genel Toplam\t{TotalPrice:c2}");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Not: \"Afiyet olsun, tekrar bekleriz!\"");
Console.WriteLine("===========================================");