using System;

var random  = new Random();
int randomIntegreter  = random.Next(int.MinValue, int.MaxValue);
int d1 = random.Next(1, 7);
int d2 = random.Next(1, 7);
int d3 = random.Next(1, 7);
int lastthrow = d3 * 3;
int Finalresult = d1 + d2 + lastthrow;
Console.WriteLine($"You roll: {d1}, {d2}, {d3} third throw times 3 is {lastthrow}\nFinal result is: {Finalresult}");
