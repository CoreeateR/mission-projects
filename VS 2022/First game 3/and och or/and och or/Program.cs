using System;

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b)) 
    // == testar om dem är lika, detta exempel är med a och b o dem är ej lika atm.
    // %% betyder och. båda statements behöver va true för att fortsätta. A och B behöver va true och hela allt måste vara över 10 för att få dem första svaren.
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}