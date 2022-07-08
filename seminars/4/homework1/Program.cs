//цикл, который принимает на вход два числа и возводит первое число в степень второго
Console.Clear();
Console.WriteLine("Введите переменную А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите переменную В ");
int B = Convert.ToInt32(Console.ReadLine());
int C =Convert.ToInt32(Math.Pow(A,B));
Console.Clear();
Console.WriteLine($"{A} в степени {B} = {C}");