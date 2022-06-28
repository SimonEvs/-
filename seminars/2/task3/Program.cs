 Console.WriteLine("Введите первое число ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int second = Convert.ToInt32(Console.ReadLine());


if (first % second == 0)
{
    Console.WriteLine("Числа делятся без остатка");
}
else
{
    Console.WriteLine($"Остаток: {first % second}");
}