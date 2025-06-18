using System;

int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("a and b The answer is greater than 10.");

int c = 3;
if (a + c > 10) Console.WriteLine("a and c The answer is greater than 10.");// Den här visas inte på console för att den inte är högre än > 10

if (a + b > 10)
{
    Console.WriteLine("a and b The answer is greater than 10");
}
else
{
    Console.WriteLine("a and b The aswer is not greater than 10");
}