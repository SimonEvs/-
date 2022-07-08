// Принимает на вход число, выводит сумму цифр в числе

int number = Convert.ToInt32(Console.ReadLine());
int number1=Convert.ToInt32(number);
int count = 0;
int C = 0;
while (number != 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Цифр в числе - {count}");

for (int i = 0; i < count; i++)
{
    C = C + number1[i];
}
Console.WriteLine(C);