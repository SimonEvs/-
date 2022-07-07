//Массив из 8 элементов, заполненный нулями и единицами
int[] array = BinaryArray(8);
Console.WriteLine($"{String.Join("; ", array)}");
int[] BinaryArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(0, 2);
    }
    return resultArray;
}