int kek = new Random().Next(100, 1000);
Console.WriteLine($"Случайное 3-х значное число- {kek}");
kek = kek % 100;
kek =kek/10;
Console.WriteLine($"Вторая цифра - {kek}");