using System;
using System.ComponentModel.Design;

var random = new Random();
int randomInteger = random.Next(int.MinValue,int.MaxValue);
int warriorhp = random.Next(0, 101);
string warrior = "Warrior Dude";
string healthpoints = "HP";

while (warriorhp < 50)
{
    warriorhp += 10;
    Console.WriteLine($"{warrior} {healthpoints}: {warriorhp}");
    Console.WriteLine("Heal");
}
Console.WriteLine("Regeneration complete");
