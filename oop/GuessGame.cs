using System;

class GuessTheNumber
{
    static string getNum()
    {
        Random random = new Random();
        int num = random.Next(1, 1000);
        return num.ToString();
    }

    static void Main()
    {
        string sayi = getNum();
        Console.WriteLine(sayi);
        int ba = Convert.ToInt32(sayi);
        int cr = 0;
        int guessayi;
        guessayi = 0;
        while (cr == 0)
        {
            guessayi++;
            Console.Write("Guess the Number: ");
            string ourguess = Console.ReadLine();
            int ab;
            ab = Convert.ToInt32(ourguess);


            if (ab < ba)
            {
                Console.WriteLine("Too Small");
            }

            else if (ab > ba)
            {
                Console.WriteLine("Too Big");
            }

            else
            {
                Console.WriteLine("Correct Guess Your Guess is "+ ba + "  Your Guess Count is  : " + guessayi);
                cr = 1;
            }

        }





    }
}
