// Напишите программу, которая на вход будет принимать число,
//  а на выход выводить сумму его цифр.
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
{
    if (number==0) return 0;
    return (number%10+SumNumbers(number/10));
}

Console.WriteLine($"Сумма = {SumNumbers(number)}");