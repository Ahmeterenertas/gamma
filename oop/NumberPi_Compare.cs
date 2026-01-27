using System;
class NumberPi {
//--------------------------------  
  static double NumberPiLeibnitz(int num) 
  {
    double total = 0;
    int k = 1;
    for(int i=1; i<=num; i+=2)
    {
        total += 1.0/(k*i);
        k = k*(-1); // changing the signs
    }
      return(4*total);
  }
//--------------------------------
static double NumberPiEuler(int num)
{
 double total = 0;
 for(int i=1; i<=num; i++)
    {
        total += 1.0/(i*i);
        
    }
    return((Math.Sqrt(6*total)));
}
//---------------------------------
static double NumberPiWallis(int num) 
  {
    double total = 1;
    for(int i=1; i<=num; i++)
    {
        total *= 1.0*2*i/(2*i-1)*2*i/(2*i+1);
    }
      return(2*total);
  }

//----------------------------------

  static void Main() {
    double RealPi = 3.141592; 
    int NumberOfIterations = 100;
    double leibnitz = NumberPiLeibnitz(NumberOfIterations);
    double euler = NumberPiEuler(NumberOfIterations);
    double wallis = NumberPiWallis(NumberOfIterations);
    Console.WriteLine("Leibnitz after {0} iterations: {1}", NumberOfIterations, leibnitz);
    Console.WriteLine("Euler after {0} iterations: {1}", NumberOfIterations, euler);
    Console.WriteLine("Wallis after {0} iterations: {1}", NumberOfIterations, wallis);
    
    Console.WriteLine("How many iterations we need for the difference smaller than 0.1:");
    double diff = 1;
    int i = 1;
    
    while (Math.Abs(diff) >= 0.1)
    {
        diff = NumberPiLeibnitz(i) - RealPi;
        i++;
    }
    Console.WriteLine("For Lebnitz: The difffrence {0}, number of iterations:  {1}", diff, i);

    diff = 1;
    i = 1;
    while (Math.Abs(diff) >= 0.1)
    {
        diff = NumberPiEuler(i) - RealPi;
        i++;
    }
    Console.WriteLine("For Euler: The difffrence {0}, number of iterations:  {1}", diff, i);

    diff = 1;
    i = 1;
    while (Math.Abs(diff) >= 0.1)
    {
        diff = NumberPiWallis(i) - RealPi;
        i++;
    }
    Console.WriteLine("For Wallis: The difffrence {0}, number of iterations:  {1}", diff, i);




  }
}