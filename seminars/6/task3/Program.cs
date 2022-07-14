//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа это 0 и 1.
int N=10;
int firstElement=0;
int secondElement=1;

Console.WriteLine(firstElement);
Console.WriteLine(secondElement);


for(int index=3;index<=N;index++)
{
    int nextElement =firstElement+secondElement;
    Console.WriteLine(nextElement);
    firstElement=secondElement;
    secondElement=nextElement;

}