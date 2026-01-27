using System;
class numberPiLeibniz {
  static void Main() 
  {
   
    int k = 1;
    double pi=0;
    int iter=1000000;
    double realPi=3.141592;
    /*for (int i = 1; i <= 10; i+=2)
    {
        if(i%2==0)
        {
            Console.Write(i-(i*2)+" ");
        }
    
        else
        {
            Console.Write(i+" ");
        }
    }*/
    
    
    for (int i = 1; i <= iter; i+=2)
    {
        //Console.Write(1.0/(k*i)+" ");
        pi += 1.0/(k*i);
        k=k*(-1);
    }
    
    double OurPi=pi*4;
    Console.WriteLine("pi:"+OurPi);
    double diff=OurPi-realPi;
    Console.WriteLine("diff =" + Math.Round(diff,10));
    
    
    Console.WriteLine("pi="+ Math.Round(4*pi,4));


  }
}
  
  
