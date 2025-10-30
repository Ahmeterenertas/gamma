using System;
class PrimeNumbers {
 
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
    for(int i = 1; i<=20; i++)
    {
      if(prime(i) == true)
      {
      Console.Write(i + ", ");    
      }
    }
  }
} // end of the class
