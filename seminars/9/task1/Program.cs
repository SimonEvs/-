//Задайте значение N
// Напишите программу, которая выведет
// все натуральные числа от 1 до N.
//рекурсия

Console.WriteLine("Введите N ");
int n=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(1,n));

string PrintNumbers(int start, int end)
{
    if (start==end) return start.ToString();
    return(start+","+PrintNumbers(start+1,end));
}