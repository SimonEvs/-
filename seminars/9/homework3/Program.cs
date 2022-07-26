// Функция Аккермана с помощью рекурсии.



Console.WriteLine("Введите Первое ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана {Akker(first, second)}");

int Akker(int first, int second)
{
    if (first == 0) return second + 1;
    if (first > 0 && second == 0) return Akker(first - 1, 1);
    if (first > 0 && second > 0) return Akker(first - 1, Akker(first, second - 1));
}