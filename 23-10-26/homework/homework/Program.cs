string[] kelimeler = {
    "kod", "kitap", "bilgisayar", "muhendis", 
    "yazilimci", "algoritma", "universite", "teknoloji", 
    "laboratuvar", "gelistirici", "programlama", "veri tabani", 
    "elektrik-elektronik", "yapay zeka teknolojileri", 
    "bilgisayar muhendisligi", "yazilim gelistirme uzmani"
};

int n = kelimeler.Length;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (kelimeler[j].Length > kelimeler[j + 1].Length)
        {
            string gecici = kelimeler[j];
            kelimeler[j] = kelimeler[j + 1];
            kelimeler[j + 1] = gecici;
        }
    }
}

Console.WriteLine("Harf Sayısına Göre Sıralanmış Liste:\n");
for (int i = 0; i < kelimeler.Length; i++)
{
    Console.WriteLine($"{kelimeler[i]} ({kelimeler[i].Length} karakter)");
}

Console.ReadLine();
