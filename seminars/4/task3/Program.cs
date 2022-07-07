//факториал
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int result =1;

for(int i = 2;i<=N;i++)
{
    result=N*result;
}

        Console.WriteLine($"Факториал числа = {result}");
