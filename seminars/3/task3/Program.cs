Console.WriteLine("Введитe число ");
int N = Convert.ToInt32(Console.ReadLine());

int second = 1;
int result = 0;
while (second <= N)
{
    result = second*second;
    
    Console.WriteLine($"Квадрат числа {second} = {result}" );
second++;
}

// for (int i =1;i<=N; i++)
// {
//     Console.WriteLine($"Квадрат числа {i}={i*i}");
// }