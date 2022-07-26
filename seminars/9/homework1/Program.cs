//Задайте значения M и N.
//Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.

Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(n, m));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));
}