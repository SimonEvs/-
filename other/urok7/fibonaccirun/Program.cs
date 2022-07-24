//Сравнение двух методов для фионачи.

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciInteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
for (int n = 1; n < 40; n++)
{
    Console.WriteLine($"FibonacciInteration({n})={FibonacciInteration(n)} fIte={fIte}");
    fIte = 0;
}
Console.WriteLine();
Console.ReadLine();

for (int n = 0; n < 40; n++)
{
    Console.WriteLine($"FibonacciInteration({n})={FibonacciRecursion(n)} fIte={fRec}");
    fRec = 0;
}
Console.ReadLine();