int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число - {number} ");
int digitOne =number /10;
int digitTwo =number % 10;
int result = Math.Max(digitOne,digitTwo);
Console.WriteLine($"Наибольшая цифра - {result}");


