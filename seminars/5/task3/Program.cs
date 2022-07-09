//Создать массив и найти число
Console.Clear();
int[] array = new int[6];
int size = array.Length;

int index = 0;

while (index < size)
{
    array[index] = new Random().Next(1000);
    index++;
}
Console.WriteLine($"[{String.Join(";", array)}]");

Console.WriteLine("Введите число, которое хотите найти ");
int findNumber = Convert.ToInt32(Console.ReadLine());
index = 0;
int procces = 0;
while (index < size)
{
    if (findNumber == array[index])
    {
        procces++;
    }
    index++;
}
if (procces > 0)
{
    Console.WriteLine("Присутствует");
}
else
{
    Console.WriteLine("Отсутствует");
}
