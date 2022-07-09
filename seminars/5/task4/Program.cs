//Задать одномерный массив из123 случайных чисел. Найти количество эментов принадлежащих отрезку
// от 10 до 99.
Console.Clear();
int []array =new int [123];
int size=array.Length;
int count =0;
for (int index=0; index<size;index++)
{
    array[index]=new Random().Next(0,1000);

}
Console.WriteLine($"Исходный массив {String.Join("; ", array)}");
for(int i=0;i<size;i++)
{
    if (array[i]>9&&array[i]<100)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел удовлетворяющих диапазону {count}");
