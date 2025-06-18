using System;

var random  = new Random();
int dice;
int Strength = 0;
int slime = 40;
int slimearmy = 0;
for (int throws = 1; throws <=3; throws++)
{
    dice = random.Next(1, 7);
    Strength = Strength + dice;
    string simulatethrows = $"Character stat gen:{dice}";
    Console.WriteLine(simulatethrows);
}
for (int throws = 1; throws < 8; throws++)
{
    dice = random.Next(1, 11);
    slime = slime + dice;
    string simulatethrows = $"Slime stat gen:{slime}";
    Console.WriteLine(simulatethrows);
}
for (int amount = 1; amount < 100; amount++)
{
    slime = 40;
    for (int throws = 1; throws <= 10; throws++)
    {
        dice = random.Next(1, 11);
        slime = slime + dice;
    }
    slimearmy = slimearmy + slime;
}
Console.WriteLine($"A character with strength {Strength}");
Console.WriteLine($"a gelatinous cube with {slime} HP appears");
Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {slimearmy} HP. we are doomed!");