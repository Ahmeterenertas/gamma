using System;

class FibonacciNumbers
{
    static void FibNumbers()
    {
        int a = 1;
        int b = 1;

        Console.WriteLine(a);
        Console.WriteLine(b);

        int c = a + b;

        while (c < 1000)
        {
            Console.WriteLine(c);

            a = b;
            b = c;
            c = a + b;
        }
    }

    static void Main()
    {
        FibNumbers();
    }
}