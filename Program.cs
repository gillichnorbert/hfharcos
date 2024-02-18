using Harcosos;

Harcos harcos1 = new Harcos("Kálmán", 15000, 20);
Harcos harcos2 = new Harcos("Alekosz", 2000, 50);

Console.WriteLine("A harcosok harcba szállnak:");
Console.WriteLine(harcos1);
Console.WriteLine(harcos2);
Console.WriteLine();

while (!harcos1.Harcol(harcos2))
{
    Console.WriteLine($"{harcos1.Nev} életereje: {harcos1.Eletero}, {harcos2.Nev} életereje: {harcos2.Eletero}");
}

if (harcos1.Eletero <= 0)
    Console.WriteLine($"{harcos1.Nev} vesztett!");
else
    Console.WriteLine($"{harcos2.Nev} vesztett!");

Console.ReadKey();