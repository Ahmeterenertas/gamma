using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("Enter The First Number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Second Number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Third Number");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && b + c > a && c + a > b)
        {
            Console.Write("U Can Make a Triangle");

            if(a*a + b*b == c*c || c * c  + b * b == a * a || a * a + c * c == b * b)
            {
                Console.Write("  And Thats A Rectengular Triangle");
                


            }
        }
        else
        Console.WriteLine("U Can't Make a Triangle");
    }
        



    }