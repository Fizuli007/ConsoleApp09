// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, Fizuli!");
Console.WriteLine("zehmet olmasa emeliyat secin:");
Console.WriteLine("1-toplama");
Console.WriteLine("2-cixma");
Console.WriteLine("3-vurma");
Console.WriteLine("4-bolme");

int reqem=int.Parse(Console.ReadLine());
decimal reqem1 = decimal.Parse(Console.ReadLine());
decimal reqem2 =decimal.Parse(Console.ReadLine());



switch (reqem)

{
        case 1:
      
        Console.WriteLine(reqem1+reqem2);
        break;

        case 2:
        
        Console.WriteLine(reqem1-reqem2);
        break ;

        case 3:
        
        Console.WriteLine(reqem1*reqem2);
        break ;

        case 4:
        
        
        if (reqem2 == 0)
        {
            Console.WriteLine("0-a bolmek olmaz"); 
        }
        Console.WriteLine(reqem1 / reqem2);
        break;
        
 


}


