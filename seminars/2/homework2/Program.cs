Console.WriteLine("Введите число ");
int kek = Convert.ToInt32(Console.ReadLine());

if (kek / 100 != 0)
{
    kek =kek/100;
    kek = kek%10;
    Console.Clear();
    Console.WriteLine($"Третья цифра {kek}");
    
}
else
Console.WriteLine("Третьей цифры нету");
// int Vivod(int kek)
// {
//     return( kek/100 ==555);
//    // return (pool / 100 != 0 && pool % 1000> 99);
// }

