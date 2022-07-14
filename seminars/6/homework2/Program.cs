Console.WriteLine("Вводим значиене k1");
int k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене k2");
int k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене b1");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значиене b2");
int b2=Convert.ToInt32(Console.ReadLine());
double x=((b2-b1)/(k1-k2))+((b2-b1)%(k1-k2));
double y=(k1*x+b1);
Console.WriteLine($"x={x},y={y}");



