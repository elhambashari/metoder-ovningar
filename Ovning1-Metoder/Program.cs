Console.Write("Skriv första talet: ");
int tal1 = int.Parse(Console.ReadLine()!);

Console.Write("Skriv andra talet: ");
int tal2 = int.Parse(Console.ReadLine()!);

Console.Write("Skriv talet som summan ska multipliceras med: ");
int tal3 = int.Parse(Console.ReadLine()!);

int resultat = Berakna(tal1, tal2, tal3);

Console.WriteLine($"Resultatet är: {resultat}");

static int LaggTill(int a, int b)
{
    return a + b;
}

static int Berakna(int x, int y, int z)
{
    int summa = LaggTill(x, y);

    return summa * z;
}