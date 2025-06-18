using System;

var random = new Random();
int shots = random.Next(1, 31);
int hits = random.Next(0, shots+1);
decimal acc = ((decimal)hits /(decimal) shots);
Console.WriteLine($"Shots fired :{shots}\nTotal hits :{hits}\nAccuracy{acc}%");
