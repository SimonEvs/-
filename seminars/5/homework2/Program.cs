int[] array = new int[6];
int size = array.Length;
int index = 0;
int sum = 0;
double currentNumber = 0;

while (index < size)
{
    array[index] = new Random().Next(1, 1000);
    currentNumber = array[index];
    if ((currentNumber % 2)> 0)
    {
        sum+=array[index];
    }
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}];");
Console.WriteLine($"Сумма нечетных = {sum}.");