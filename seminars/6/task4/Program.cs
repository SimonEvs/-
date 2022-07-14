//Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
Console.WriteLine("Введите число 10системы исчисления ");
int inputNumber= Convert.ToInt32(Console.ReadLine());

void Binary(int number)
{
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    
    }
    Console.WriteLine($"В двоичной будет так={result}");
}
Binary(inputNumber);