//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк в массивах: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массивах:");
int columns = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Первая матрица");
int[,] matrix1 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix1[i, j] = new Random().Next(0, 10);
        Console.Write(matrix1[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Вторая матрица");

int[,] matrix2 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix2[i, j] = new Random().Next(0, 10);
        Console.Write(matrix2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Произведение");

int[,] multiplyArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        multiplyArray[i, j] = matrix1[i, j] * matrix2[i, j];
        Console.Write(multiplyArray[i, j] + "\t");
    }
    Console.WriteLine();
}
