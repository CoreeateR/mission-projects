using System;

var random  = new Random();
int D6 = random.Next(1, 7);
string player = "Franc";

do
{
    Console.WriteLine($"{player} rolls :{D6}");
    D6++;
}
while ( D6 > 7 );