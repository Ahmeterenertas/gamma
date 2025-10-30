/******************************************************************************
*******************************************************************************/
using System;
class numberPi{
    
static double leibnizPiMethod(int numberOfItr)
  {
    double total=0;
    int k = 1;
    
    for (int i = 1; i <= numberOfItr; i+=2)
    {
        total += 1.0/(k*i);
        k=k*(-1);
    }
     
    return(4*total);
  }
//----------------------------------------

static double numberPiEuler(int numberOfItr)
{
   double total=0;
    for (int i = 1; i <= numberOfItr; i++)
    {
        total += 1.0/(i*i);
    
    }
    return(Math.Sqrt(6*total));
}
//-----------------------------------
  static void Main() 
  {
      
    double RealPi=3.141592;
    double OurPi= numberPiEuler(1000);
    Console.WriteLine("pi Euler:"+OurPi);
    double diff=OurPi-RealPi;
    Console.WriteLine("diff =" + Math.Abs(Math.Round(diff,10)));
    
    OurPi= leibnizPiMethod(1000);
    Console.WriteLine("pi Leibniz:"+OurPi);
    diff=OurPi-RealPi;
    Console.WriteLine("diff =" + Math.Abs(Math.Round(diff,10)));
      
  }
}
