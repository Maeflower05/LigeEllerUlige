ConsoleKeyInfo KeyInfo;
do
{
    Console.Clear();
    Console.WriteLine("Er dit tal Lige eller Ulige?");
    Console.Write("Indtast venligst dit tal: ");
    string tal = Console.ReadLine();
    int X;
    while (!Int32.TryParse(tal, out X))
    {
        Console.Clear();
        Console.WriteLine("Du kan ikke indtaste en bogstav, du skal skrive et tal. Prøv igen.");
        Console.Write("Indtast venligst dit tal: ");
        tal = Console.ReadLine();
    }
    if (X % 2 == 0)
    {
        Console.WriteLine($"Dit tal, {tal} er Lige.");
    }
    else
    {
        Console.WriteLine($"Dit tal, {tal} er Ulige.");
    }
    KeyInfo = Console.ReadKey();
}
while (KeyInfo.Key != ConsoleKey.Escape);