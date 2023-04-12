
static string GłówneNaPorządkowe(int liczba)
{
    switch (liczba)
    {
        case 11:
        case 12:
        case 13:
            return $"{liczba}th";
        default:
            int ostatniaCyfra = liczba % 10;

            string przyrostek = ostatniaCyfra switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{liczba}{przyrostek}";
    }
}
static void ZmieńGłówneNaPorządkowe()
{
    for (int liczba = 1; liczba <= 40; liczba++)
    {
        Console.WriteLine($"{GłówneNaPorządkowe(liczba)}");
    }
    Console.WriteLine();
}
ZmieńGłówneNaPorządkowe();