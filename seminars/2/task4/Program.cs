int wow=new Random().Next(161, 10000);
Console.WriteLine(wow);
bool Kratnost(int number)

{
    return (number % 7 == 0 && number % 23 == 0);


}

Console.WriteLine(Kratnost(wow));

