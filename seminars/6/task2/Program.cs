//Напишите программу, которач принимает на вход три числа и проверяет
// може ли существовать труегольник с сторонами такой длины.

int firstSide=3;
int secondSide=7;
int thirdSide=71;

if(firstSide+secondSide>thirdSide&&secondSide+thirdSide>firstSide&&firstSide+thirdSide>secondSide)
{
    Console.WriteLine("Существует");
}
else
Console.WriteLine("Не существует");