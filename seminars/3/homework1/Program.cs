Console.WriteLine("Введите 5-ти значное число: ");
string number = Console.ReadLine();
Console.WriteLine(number);
if (number[0] == number[4] && number[1]==number[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
// // Console.WriteLine($"Да {number}");
// bool Palindrom(int number)
// {
//     return(number[0]==number[4] && number[1]== number[3]);
// }




// int number = Convert.ToInt32(Console.ReadLine());

// bool Kratnost(int number)

// {
//     return (number[0] == number[4] && number[1] == number[3]);


// }

// Console.WriteLine(Kratnost(number));

// // for(int i=0; i<)

// int number = new Random().Next(10000,99999);
// Console.WriteLine(number);
// // if ( number[0]== number[4])
// // {
// //     Console.WriteLine("Yes");

// // }