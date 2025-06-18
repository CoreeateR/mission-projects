using System;

var random  = new Random();
int roll1 = random.Next (0, 11);
int roll2 = random.Next (0, (11 - roll1));

Console.WriteLine($"First roll: {roll1}\nSecond roll: {roll2}");