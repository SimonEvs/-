int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");
int digitOne= number/100;
int digitThree= number % 10;
Console.WriteLine("Склеиваем первую цифру и третью");

Console.WriteLine($"Получаем: {digitOne}{digitThree}");
