// int[] array = FillArray(20);

// int[] FillArray(int size)
// {
//     double currentNumber = 0;
//     int count = 0;
//     int[] newArray = new int[size];
//     for (int index = 0; index != size; index++)
//     {
//         newArray[index] = new Random().Next(100, 1000);
//         currentNumber = newArray[index];
//         if ((currentNumber % 2) > 0)
//         {
//             count++;
//         }
//     }
//     return newArray;

// Console.WriteLine($"[{String.Join("; ", newArray)}]; {count}");

// }



int[] array = new int[20];
int size = array.Length;
int index = 0;
int count = 0;
double number = 0;

while (index < size)
{
    array[index] = new Random().Next(100, 1000);
    number = array[index];
    if ((number % 2) == 0)
    {
        count++;
    }
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}];");
Console.WriteLine($"Количество четныъх = {count}");