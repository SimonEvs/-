//Напишите программу, которая будет находить сумму натуральных чисел
// от заданного промежутка от M до N


Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма промежутка равна = {SumNumber(n, m)}");

int SumNumber(int first,int second)
{
    if (first==second) return first;
    return first+SumNumber(first+1,second);
}