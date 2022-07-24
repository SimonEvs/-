//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов
Console.Clear();
int rows = 3;
// int n = 0;
int localsum = 0;

int columns = 4;
int sum = 0;

Console.WriteLine("Матрица");
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
        sum = sum + matrix[i, j];
        
    }

localsum = sum;
sum = 0;
Console.WriteLine($"Сумма {i + 1} строчки = {localsum}");

}

// Console.WriteLine();

// while (n < rows)
// {
//     for (int k = 0; k < columns; k++)
//     {
//         // if(i>rows)
//         // {i++;}
//         sum = sum + matrix[n, k];
//     }
//     localsum = sum;
//     sum = 0;
//     Console.WriteLine($"Сумма {n + 1} строчки = {localsum}");
//     n++;

// }
