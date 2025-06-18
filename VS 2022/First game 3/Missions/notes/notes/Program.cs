using System;
using System.Runtime.ExceptionServices;
/*
var random = new Random();
int roll1 = random.Next(0, 11);
int pins = 10;
bool Strike = pins - roll1 == 0;


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
*/

var random = new Random();
int roll1 = random.Next(0, 11);
int pins = 10;
bool strike = pins - roll1 == 0;
int knockedpins = roll1;
string strikestring = $"First roll:{roll1}\nKnocked pins:{knockedpins}";
strikestring = strikestring.Replace("10", "Strike!! X");
strikestring = strikestring.Replace("0", "-");
if (strike)
{
    Console.Write(strikestring);
}
else
{
    int roll2 = random.Next(0, 10 - roll1 + 1);
    int knockedpins2 = roll1 + roll2;
    bool spare = roll1 + roll2 == 10;
    string secondroll = $"First roll:{roll1}\nSecond roll:{roll2}\nKnocked pins:{knockedpins2}";
    secondroll = secondroll.Replace("0", "-");
    secondroll = secondroll.Replace($"{roll2}", "/");
    Console.Write(secondroll);
}