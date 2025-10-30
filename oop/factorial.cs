using System;
class TestFactorial {
    
  static long Factorial(int n)
  {
      int result = 1;
      for (int i = 1; i <= n; i++)
      {
          result = result*i;
      }
      return result;
      
  }
   

   static long Factorial2(int n)
  {
      int result = 1;
      int i = 1;
      while (i <= n)
      {
          result = result*i;
          i++;
      }
      return result;
      
  }
   
  static void Main() {
    Console.WriteLine("5! = " + Factorial(5));
    Console.WriteLine("0! = " + Factorial(0));
    Console.WriteLine("25! = " + Factorial(25));
    
    Console.WriteLine("6! = " + Factorial2(6));
    Console.WriteLine("4! = " + Factorial2(4));
  }
}