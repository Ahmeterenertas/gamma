using System;
class numberPiLeibnitz {
  static void Main() 
  {
   
    int pi = 0;

    for (int i = 1; i <= 10; i++)
    {
        
        if(i%2 == 1) {
        Console.Write(i+" ");
        }
        
        else{
        Console.Write((i-2*i)+" ");
            
        }
        }
        
        
    }

  }