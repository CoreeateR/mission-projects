using System;

var random = new Random();
string Player = "Franc";
int D6 = random.Next(1, 7);
do
{
    Console.WriteLine($"{Player} rolls {D6}");
    D6++;
} while (D6 > 7);