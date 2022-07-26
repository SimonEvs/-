// Напишите программу, которая на вход будет принимать два числа А и В,
//  и возводит число А в целую степень В с помощью рекурсии.

Console.WriteLine("Введите число A ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int second = Convert.ToInt32(Console.ReadLine());

int PowerNumbers(int first,int second)
{
    if (second==0) return 1;
    return (first*PowerNumbers(first,second-1));
}

Console.WriteLine($"Степень = {PowerNumbers(first,second)}");