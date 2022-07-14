Console.WriteLine($"Введите размер ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[size];
Console.Clear();
int count =0;
for (int i = 0; i != size; i++)
{


    Console.WriteLine($"Введите{i + 1} число ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if(newArray[i]>0)
    {
        count++;
    }

}

Console.WriteLine($"[{String.Join("; ", newArray)}]");
Console.WriteLine($"Чисел больше 0 :{count}");