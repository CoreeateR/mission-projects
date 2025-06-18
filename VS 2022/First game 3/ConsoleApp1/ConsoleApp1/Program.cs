using System;

int a = 5;
int b = 8;
int c = 5;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
//skriv slash slash för egna kommentarer för future self
int counter = 0;
while (counter < 11)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
