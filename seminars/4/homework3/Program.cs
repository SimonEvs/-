// Массив из 8 чисел (сделал до сотни)

int[]array = FillArray(8);
Console.WriteLine($"[{String.Join(";", array)}]");

int[] FillArray(int size)
{
    int[] array = new int [size];
    for(int i=0;i<size;i++)
    {
        array[i] =new Random().Next(0,100);
    }
    return array;
}