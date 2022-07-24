// Вычислить А в степени n.
// 0 на 0 тоже 1.
// Итеративный подход.

int PowerFor(int a, int n)
{
    int result =1;
    for (int i=1;i<=n;i++) result *=a;
    return result;
}

// Рекурсивный подход.
int PowerRec(int a, int n)
{  //return n==0?:PowerRec(a,n-1)a;
if (n==0)return 1;
else return PowerRec(a,n-1)*a;
}

Console.WriteLine(PowerFor(2,10));
Console.WriteLine(PowerRec(2,10));