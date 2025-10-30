using System;
using System.Diagnostics;

class Program
{
    // Yaklaşım 1: sabit sayıda terim kullan (terms >= 1)
    static double LeibnizPiByTerms(long terms)
    {
        double sum = 0.0;
        for (long k = 0; k < terms; k++)
        {
            // (-1)^k / (2k + 1)
            double term = ((k & 1) == 0) ? 1.0 / (2.0 * k + 1.0) : -1.0 / (2.0 * k + 1.0);
            sum += term;
        }
        return 4.0 * sum;
    }

    // Yaklaşım 2: hedef hassasiyete göre (epsilon). 
    // Serinin atlanan ilk teriminin (4/(2n+1)) pi hatasını sınadığımızı kullanırız.
    static (double pi, long terms) LeibnizPiByEpsilon(double epsilon)
    {
        if (epsilon <= 0) throw new ArgumentException("Epsilon pozitif olmalı.", nameof(epsilon));

        double sum = 0.0;
        long k = 0;
        // Hedef: 4/(2n+1) < epsilon  => hata < epsilon
        while (4.0 / (2.0 * k + 1.0) >= epsilon)
        {
            double term = ((k & 1) == 0) ? 1.0 / (2.0 * k + 1.0) : -1.0 / (2.0 * k + 1.0);
            sum += term;
            k++;
        }
        return (4.0 * sum, k);
    }

    static void Main()
    {
        Console.WriteLine("Leibniz serisiyle pi yaklaşıklaması\n");

        // Örnek 1: Sabit terim sayısı
        long terms = 1000000; // 1.000.000 terim
        var sw = Stopwatch.StartNew();
        double piApprox1 = LeibnizPiByTerms(terms);
        sw.Stop();
        Console.WriteLine($"Terim sayısı = {terms:N0} => pi ≈ {piApprox1:R} (süre {sw.ElapsedMilliseconds} ms)");

        // Örnek 2: Epsilon ile (hata < epsilon)
        double epsilon = 1e-6; // hedef hata
        sw.Restart();
        var result = LeibnizPiByEpsilon(epsilon);
        sw.Stop();
        Console.WriteLine($"Epsilon = {epsilon} => pi ≈ {result.pi:R} (kullanılan terim sayısı = {result.terms:N0}, süre {sw.ElapsedMilliseconds} ms)");

        // İstersen kullanıcı girişi ile çalıştır:
        Console.WriteLine("\nKendi terim sayınızı girin (boş bırakıp Enter ile atlayın):");
        string input = Console.ReadLine();
        if (long.TryParse(input, out long userTerms) && userTerms > 0)
        {
            sw.Restart();
            double piFromUser = LeibnizPiByTerms(userTerms);
            sw.Stop();
            Console.WriteLine($"Terim sayısı = {userTerms:N0} => pi ≈ {piFromUser:R} (süre {sw.ElapsedMilliseconds} ms)");
        }
        else
        {
            Console.WriteLine("Terim sayısı girilmedi ya da geçersiz. Çıkılıyor.");
        }
    }
}

