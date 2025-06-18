using System;

var random = new Random();
int randomInteger = random.Next(int.MinValue, int.MaxValue);
int Dice1 = random.Next(1, 7);//av någon anledning går det inte att göra int (siffra först)??????
int Dice2 = random.Next(1, 7);
int Dice3 = random.Next(1, 7);
Console.WriteLine($"First dice throw :{Dice1}\nSecond dice throw :{Dice2}\nThird dice throw :{Dice3}");

