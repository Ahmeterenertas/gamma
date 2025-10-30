
using System;
class PrimeNumbers2 {
    
  static bool prime(int n)
 {
    bool is_prime = true;
      if(n == 1)
      {
          return false;
      }
      else
      {    
       for(int i=2; i<= n/2; i++ ) 
       {
        if(n % i == 0 )
        {
          is_prime = false;
          break;
        }
       }
      }
    return is_prime;
}   
      
  static void Main() {
      int total = 0;
      for (int i =1; i<=1000; i++)
      {
          if(prime(i))
          {
              total++;
          }
      }
      Console.WriteLine(total);
    
  }
}