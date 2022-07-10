double[] array = new double[10];
int size = array.Length;
int index = 0;

while (index != size)
{
    array[index] = new Random().Next(-100, 100);

    index++;
}
double Min = array[0];
double Max = array[0];
for (index = 0; index != size; index++)
{
    if(Min>array[index])
    {
        Min=array[index];
    }
    
    if (Max<array[index])
    {
        Max=array[index];
    }
}
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Максимальное ={Max}; Минимальное ={Min}");
Console.WriteLine($"Разность = {Max-Min}");