using System;
using System.Threading.Channels;

var random = new Random();
int HP = random.Next(1, 101);
string warrior = "WarriorDOOD";
string caster = "Fullmana Caster";
Console.WriteLine($"{warrior} HP:{HP}\nHealer casts Regeneration");
while (HP < 50)//Om jag sätter if istället så avnänds programmet bara 1 gång.
               //Dock med while så upprepas den för alltid och det är därför if kommer efter.
{
    HP = HP + 10;
    Console.WriteLine($"{warrior} HP:{HP}");
    if (HP > 50)//If sätter ett värde att stanna på när {HP} över 50
        Console.WriteLine("Regen complete");
}