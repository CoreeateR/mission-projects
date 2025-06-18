using System;

var random = new Random();
int roll1 = random.Next(0, 11);
int pins = 10;
bool Strike = pins - roll1 == 0;
string.Replace("0", "-");

if (Strike)
{
    Console.WriteLine($"Strike X\nKnocked pins {roll1}");
}
else
{
    int roll2 = random.Next(1, 10 - roll1 + 1);
    int Knockedpins = (roll1 + roll2);
    if (Knockedpins == 10)
        Console.WriteLine($"First roll:{roll1}\nSecond roll:Spare /\nKnocked pins:{Knockedpins}");
    else
        Console.WriteLine($"First roll:{roll1}\nSecond roll:{roll2}\nKnocked pins:{Knockedpins}");
}