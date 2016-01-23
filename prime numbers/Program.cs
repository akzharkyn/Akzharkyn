using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args) // string args; 
        {
            
            //проверка простых чисел
            int q;
            bool intisprime = true;

            for(int i=0; i < args.Length; i++)
            {
                intisprime = true; 
                q = int.Parse(args[i]); //q = (int)args[i]
                if (q == 1 || q == 2) { Console.WriteLine(q + "is prime"); continue; }// 1 i 2 proveryat' ne nado

                for (int j=2; j<=Math.Sqrt(q); j++) //obrawaemsya k biblio math
                                                  //sqrt pishem dlya togo 4toby uscorit process
                {
                    if( q % j == 0) { Console.WriteLine(q + "is not prime"); intisprime = false;  break; }  //cout<<q<<"is not prime""
                }

                if( intisprime == true ) Console.WriteLine(q + "is prime");
            }
        }
    }
}
