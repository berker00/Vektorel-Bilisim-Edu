// // Console.Write("Ay adını veya Sırasını giriniz: ");
// // string UserSay =  Console.ReadLine();
// //
// // string month = UserSay.ToLowerInvariant() switch
// // {
// //  "ocak" or "1" or "şubat" or "2" or "aralık" or "12" => "Kış",
// //  "mart" or "3" or "nisan" or "4" or "mayıs" or "5" => "İlkbahar",
// //  "haziran" or "6" or "temmuz" or "7" or "ağustos" or "8" => "Yaz",
// //  "eylül" or "9" or "ekim" or "10" or "kasım" or "11" => "Sonbahar",
// //  _ => "Yok Öyle Bir Ay",
// // };
// //
// // Console.WriteLine(month);
//
//
// // switch (day.ToLower())
// // {
// //     case "pazartesi": Console.WriteLine("monday");break; 
// //     case "salı": Console.WriteLine("tuesday");break; 
// //     case "çarşamba": Console.WriteLine("wednesday");break; 
// //     case "perşembe": Console.WriteLine("thursday");break; 
// //     case "cuma": Console.WriteLine("friday");break; 
// //     case "cumartesi": Console.WriteLine("saturday");break; 
// //     case "pazar": Console.WriteLine("sunday");break; 
// //     default: Console.WriteLine("Bilinen evrende böyle bir gün yok!"); break;
// // }
// //
// // string dayEn = day.ToLowerInvariant() switch
// // {
// //     "pazaresi" or "pzt" => "Monday",
// //     "salı" or "sal" => "tuesday",
// //     "çarşamba" or "çrş" => "wednesday",
// //     "perşembe" or "prş"=> "thursday",
// //     "cuma" or "cuma"=> "friday",
// //     "cumartesi" or "cmt" => "saturday",
// //     "pazar" or "pzt" => "pazar",
// //     _=> "Yok öyle bişey",
// // };
// //
// // Console.WriteLine(dayEn);
//
//
// //
// // DateTime now = DateTime.Now;
// // Console.WriteLine(now);
// // Console.WriteLine(now.Year);
// // Console.WriteLine(now.Month);
// // Console.WriteLine(now.Date);
// // Console.WriteLine(now.Hour);
// // Console.WriteLine(now.Minute);
// // Console.WriteLine(now.Second);
// // Console.WriteLine(now.DayOfWeek);
// // Console.WriteLine(now.DayOfYear );
// //
// // DateTime ay = new DateTime(now.Year, now.Month, now.Day);
// // Console.WriteLine(ay);
//
// // Console.Write("Doğum Yılını Gir: ");
// // int.TryParse(Console.ReadLine(), out int year);
// // DateTime CurrentYear = DateTime.Now;
// //
// // Console.WriteLine(CurrentYear.Year - year+ "Yaşındasın");
//
//
// Console.Write("Doğum Taarihini Gir: ");
// DateTime.TryParse(Console.ReadLine(), out DateTime input);
// DateTime CurrentYear = DateTime.Now;
// TimeSpan ts = DateTime.Now - input;
//
// Console.WriteLine(ts /365  + " Yaşındasın");
//
