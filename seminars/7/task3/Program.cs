//Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
//замениет элементы на их квадраты

int rows = Int32.Parse(Console.ReadLine());
int columns = Int32.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        //NextDouble() 0,544444*100=54.NextDouble-от 0 до 1.
        Console.Write(matrix[i, j] + "\t");

        //T- Tab
        //n-new
        // это все литералы
        if (j % 2 == 0 && i % 2 == 0)
        {
            matrix[i, j] *=matrix[i, j];
        }
        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine();
}
