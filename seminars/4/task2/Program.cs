// Принимаем на вход число и выводим количество цифр в числе.

int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number != 0) 
{
    number /= 10;
    count++;
}
Console.WriteLine(count);