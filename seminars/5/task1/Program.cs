//Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9)

// Console.Clear();
// int[] array = FillArray(12);

// Console.WriteLine($"[{String.Join(";", array)}]");
// int i = 0;
// int sum = 0;
// int sum2 = 0;
// while (i != 12)
// {
//     if (array[i] > 0)
//     {
//         sum = sum + array[i];
//         i++;
//     }
//     else
//     {
//         sum2 = sum2 + array[i];
//         i++;
//     }
// }

// Console.WriteLine($"Сумма положительных чисел ={sum}");
// Console.WriteLine($"Сумма отрицательных чисел ={sum2}");
// int[] FillArray(int size)
// {
//     int[] array1 = new int[size];
//     int i = 0;
//     while (i != size)
//     {

//         array1[i] = new Random().Next(-9, 10);
//         i++;

//     }
//     return array1;
// }


int [] array = new int[12];
int size=array.Length;
int resultPositive=0;
int resultNegative=0;
int index=0;

while (index<size)
{
    array[index] =new Random().Next(-9,10); 
    index++;
}
Console.WriteLine($"[{String.Join(";", array)}]");

for (int startIndex=0; startIndex<size;startIndex++)
{
    if (array[startIndex]>0)
    {
        resultPositive+=array[startIndex];
    }
    else
    {
        resultNegative+=array[startIndex];
    }
}

Console.WriteLine($"Сумма положительных чисел ={resultPositive}");
Console.WriteLine($"Сумма положительных чисел ={resultNegative}");