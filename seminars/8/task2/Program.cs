// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае если это невозможно, программа должна вывест сообщение пользователя.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите левую грацицу рандома:");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую грацицу рандома:");
int maxRandom = Convert.ToInt32(Console.ReadLine());

if(rows!=columns)
{
    Console.WriteLine("Замена невозможна");
    return;
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();


    }
}
// void ChangeRows(int[,] matrix)
// {
//     int indexLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[indexLastRow, i];
//         matrix[indexLastRow,i]=temp;
//     }
// }

// ChangeRows(array);
// Console.WriteLine("результат");
// PrintArray(array);


void PrintReverseArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[j, i] + "\t");
        }
        Console.WriteLine();


    }
}

Console.WriteLine("Сначала покажем обычный массив ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Потом покажем перевернутый массив ");

PrintReverseArray(array);