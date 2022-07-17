// Задайте двумерный массив размера m*n, каждый элемент в массиве находится по формуле A=m+n.
// Выведите полученный массив а экран.
int[,] matrix={{1,2,3,4},{5,6,7,8}};
//int [,]matrix =new int[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // matrix[i,j]= new Random().Next(0,11);
        // Console.Write(matrix[i,j]+"\t");
        matrix[i,j]=i+j;
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();