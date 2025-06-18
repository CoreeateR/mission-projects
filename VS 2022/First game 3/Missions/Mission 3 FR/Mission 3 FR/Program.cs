using System;

var random = new Random();
int dice;
int sum = 0;
do//gör om och om i en infinite loop
{
    dice = random.Next(1, 7);
    //sum = dice; //sum = dice räknar bara 1 dice
    sum = sum + dice;//sum = sum + dice räknar alla dices. Ändra dice till en siffra för specifik addering.
    string playerroll = $"The player rolls:{dice}";
    Console.WriteLine(playerroll);

} while (dice < 6);//Avlsuta loopen om den blir 6
string sumscore = $"The player totalscore:{sum}";
Console.WriteLine(sumscore);