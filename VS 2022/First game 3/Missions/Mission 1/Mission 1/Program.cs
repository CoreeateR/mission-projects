using System;
using System.ComponentModel.Design;

var random = new Random();
int randominteger = random.Next(int.MinValue, int.MaxValue);
int ball1 = random.Next (0, 11);

if (ball1 == 10)
{
    Console.WriteLine($"Strike X\nKnocked pins:10");
}
else
{
    int ball2 = random.Next(0, 11 - ball1);
    string ball1result = ball1 == 0 ? "-" : ball1.ToString();
    string ball2result;
    if (ball1 + ball2 == 10)
    {
        ball2result = "/";
    }
    else
    {
        ball2result = ball2 == 0 ? "-" : ball2.ToString();
    }
    int pinsleft = (10 - (ball1 + ball2));
    Console.WriteLine($"First roll: {ball1result}");
    Console.WriteLine($"Second roll: {ball2result}");
    Console.WriteLine($"Pins left: {pinsleft}");
}

