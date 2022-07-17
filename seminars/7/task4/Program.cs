//Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
//замениет элементы на их квадраты *по главной диагонали*

int[,] matrix={{1,2,3,4},{5,6,7,8},{9,10,11,12}};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j==i)
        {
            matrix[i, j] *=matrix[i, j];
        }
        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine();
}
