using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


var random = new Random();
int tankdistance = random.Next (40, 70 + 1);
Console.WriteLine("Danger! A tank is approuching our position. Your artillery is our only hope!\n");
Console.WriteLine("What is your name, commander?");
Console.WriteLine("Enter you name");
string name = Console.ReadLine();
Console.WriteLine("Your name is: " + name);
Console.Write("Here is the map of the battlefield\n\n_/");
int rounds = 5;
int tankhp = 1;

for(int a =1; a <= tankdistance; a++)//Lines before tank
{
    Console.Write("_");
}
Console.Write("T");
for (int a = 1; a <= (80 + 1 - tankdistance); a++)//Lines after tank
{
    Console.Write("_");
}
while (rounds > 0)
{
    
        Console.WriteLine($"\n\nAim your shot,{name}");
        Console.WriteLine("Enter distance:");
        int distance = Convert.ToInt32(Console.ReadLine());
        rounds--;

        for (int a = 1; a <= distance; a++)
        {
            Console.Write(" ");
        }
        Console.Write("  X");
        if (distance < tankdistance)
        {
            Console.WriteLine($"\ntoo short bro T_T\nYou have {rounds} shots left");
        }
        if (distance > tankdistance)
        {
            Console.WriteLine($"\ntoo far bro :/\nYou have {rounds} shots left");
        }
    if (distance == tankdistance)
    {
        Console.WriteLine("\nhit! good job bro. :3");
        Console.WriteLine("You may go to bed now");
        Console.ReadLine();
        Environment.Exit(0);
    }
    if (rounds == 0)
    {
        Console.WriteLine($"we are out of rounds, youve failed us {name}");
    }
}