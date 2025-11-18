using System;

class GuessGameRandomNumber
{
	static void Main()
	{
		Random rnd = new Random();
		int sayi = rnd.Next(1, 21);
		int a = 0;
		int tahminsayisi = 0;

		while (a != sayi)
		{
			Console.Write("Guess (1-20): ");
			a = int.Parse(Console.ReadLine());

			if (a < sayi)
				Console.WriteLine("Try Bigger");
				tahminsayisi++;
			
			if (a > sayi)
				Console.WriteLine("Try Smaller");
				tahminsayisi++;
			if (a == sayi)
				Console.WriteLine("TRUE!");
		}
		Console.WriteLine("Game Over, YOU WON \n You Tried " + tahminsayisi);
	}
}
