using System;

class Program
{
    static void Main(string[] args)
    {
        // Bilgilendirme mesajı
        Console.WriteLine("Bayram Manavına Hoş Geldiniz!");
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Nar = 3 TL");
        Console.WriteLine("Çilek = 2 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diğer bütün meyveler = 4 TL");
        Console.WriteLine(); // Boş satır

        // Kullanıcıdan meyve seçimi alma
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
        string meyve = Console.ReadLine().ToLower(); // Büyük/küçük harf duyarlılığını kaldırıyoruz.

        // Fiyat belirleme
        int fiyat;
        if (meyve == "elma")
        {
            fiyat = 2;
        }
        else if (meyve == "nar")
        {
            fiyat = 3;
        }
        else if (meyve == "çilek")
        {
            fiyat = 2;
        }
        else if (meyve == "muz")
        {
            fiyat = 3;
        }
        else
        {
            fiyat = 4;
        }

        // Çıktı mesajı
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");
    }
}
