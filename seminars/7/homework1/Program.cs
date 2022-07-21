//Задайте двумерный массив размерами m*n, заполненный случайными вещественными числами.

int rows = Int32.Parse(Console.ReadLine());
int columns = Int32.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
for(int i=0;i<matrix.GetLength(0);i++)
{

    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] =  new Random().NextDouble()*100;    
        Console.Write(matrix[i, j] + "\t"); 

    }
    Console.WriteLine();
}