using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    // bura -BASE CLASS-
    // bura da tüm geometrik şekillerin temel sınıfı
    class Figure
    {
        // seklin boyutunu tutar (çizgi = 0 boyut, düzlem = 2 boyut gibi)
        protected int dimension;

        // Constructor: Şekil oluşturulurken boyut bilgisi girilir
        public Figure(int dimension)
        {
            this.dimension = dimension;
        }

        // Property  kısmı, boyut (dimension) değerine erişmek için kullanılır
        public int Dimension
        {
            get { return dimension; }
            set { dimension = value; }
        }

        // Sanal metod (virtual) 
        // Alt sınıflar kendi alan hesaplarını yazabilsin diye virtual tanımladım
        // Varsayılan olarak alanı olmayan şekiller için 0 döner, getarea kısmı.
        public virtual double GetArea()
        {
            return 0;
        }
    }

    // DERIVED CLASS 
    // Rectangle sınıfı Figure sınıfından miras alır, inhertance kısmı
    class Rectangle : Figure
    {
        // Dikdörtgenin kenarları kısmı
        private double width;
        private double length;
    
        // Constructor kısmı, Rectangle 2 boyutlu olduğu için base(2) cagriliyo 
        public Rectangle(double width, double length) : base(2)
        {
            this.width = width;
            this.length = length;
        }

        // Genişlik özelliği atama
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Uzunluk özelliğini atama
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        // Parametre alarak alan hesaplayan ek metod
        public double GetArea(double w, double l)
        {
            return w * l;
        }

        // Figure sınıfındaki GetArea metodunu override etmece
        // Böylece polymorfizmi de sağladim
        public override double GetArea()
        {
            return width * length;
        }
    }

    // PROGRAM ksimi
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle nesnelerini Figure tipinde bir listede tutuyoruz
            // Bu, polymorphism kullanımını gösterir
            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(4, 5),
                new Rectangle(3.5, 6),
                new Rectangle(10, 2)
            };

            Console.WriteLine("Dikdörtgenlerin boyutları ve alanları:\n");

            // Listedeki her şekil geziliyo
            foreach (Figure f in figures)
            {
                // Eğer nesne Rectangle ise genişlik ve uzunluk bilgilerine erisebiliyom
                if (f is Rectangle r)
                {
                    Console.WriteLine($"Genişlik: {r.Width}, Uzunluk: {r.Length}, Alan: {r.GetArea()}");
                }
            }

            // LINQ kullanarak ortalama alan hesaplanan kisim
            double averageArea = figures.Average(f => f.GetArea());

            Console.WriteLine($"\nOrtalama Alan: {averageArea}");

            Console.ReadLine();
        }
    }
}
