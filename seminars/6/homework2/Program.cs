Console.WriteLine("Вводим значиене k1");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене k2");
double k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене b1");
double b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене b2");
double b2=Convert.ToInt32(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=(k1*x+b1);
Console.WriteLine($"x={x},y= {y}");



