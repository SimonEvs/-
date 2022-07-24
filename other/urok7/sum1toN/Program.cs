//Сумма чисел от 1 до n.

// Итеративный подход.
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

//Рекурсивный подход.
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);

}

Console.WriteLine(SumFor(5));
Console.WriteLine(SumRec(5));