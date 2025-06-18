using System;

string warrior = "warriordude";
string mage = "magedude";
string narrative = "The party stared down the stone stairs into darkness.\"we shouldve brought some torches with us,\"remarked WARRIOR. MAGE turned around and replied, \"Worry not dear WARRIOR, let me shine some light for you,\" as she cast a continual light spell.";
Console.WriteLine(narrative);
narrative = narrative.Replace("WARRIOR", warrior).Replace("MAGE", mage);
Console.WriteLine(narrative);

string sayhello = "hello world ass!";
Console.WriteLine(sayhello);
sayhello = sayhello.Replace("hello", "greetings").Replace("ass", "peace");
Console.WriteLine(sayhello);

//sayhello.Replace replacear hello till greetings, för att replacea ett annat ord så behöver du göra en till .Replace.
