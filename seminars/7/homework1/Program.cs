//Задайте двумерный массив размерами m*n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Введите количество строк ");
int rows = Int32.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите количество столбцов ");
int columns = Int32.Parse(Console.ReadLine());
Console.Clear();
double[,] matrix = new double[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble() * 100;
        Console.Write(Math.Round(matrix[i, j],2) + "\t");
        
    }
    Console.WriteLine();
}