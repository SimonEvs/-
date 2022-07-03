Console.WriteLine("Введите число от 1 до 4");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Значения переменных будут: ");
if (number==1)
{
    Console.WriteLine("X>0;Y>0");
}

if (number==2)
{
    Console.WriteLine("X>0;Y<0");
}

if (number==3)
{
    Console.WriteLine("X<0;Y<0");
}

if (number==4)
{
    Console.WriteLine("X<0;Y>0");
}
