using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;

namespace Psuedo_code_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int y = -10; y < 10; y++)
            {
                for (int x = 1; x < 80; x++)
                {
                    double r = 0; //real = double
                    double i = 0;
                    int k = -1;//integer = int
                    while (r * r + i * i < 11 && k < 112)
                    {
                        double t = r;
                        r = (t * t) - (i * i) - 2.3 + x / 24.5; // set = just type it down
                        i = 2 * t * i + y / 8.5;
                        k++;//Increment = ++ or =+                                                  
                    }//end = end of loop, back to previous
                    int c = k % 16;
                    Console.BackgroundColor = (ConsoleColor)c; //Set = just type it down
                    Console.Write(" ");//send = write
                }
               
                Console.WriteLine();//send new line = writeline
            }

        }
    }
}
