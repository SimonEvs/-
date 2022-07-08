// Принимает на вход число, выводит сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Convert.ToInt32(number);
int count = 0;
while (number != 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Цифр в числе - {count}");

int Y =0;
int Z = 0;
while (Y<count)
{
    Z = Z + number1 % 10;
    number1 = number1 / 10;
    Y++;
}
Console.WriteLine($"Сумма чисел числа равна - {Z}");