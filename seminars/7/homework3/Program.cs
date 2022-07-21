//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов вкаждом столбце.
Console.Clear();
Console.WriteLine("Введите количество строк ");
int rows = Int32.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите количество столбцов ");
int columns = Int32.Parse(Console.ReadLine());
Console.Clear();
double[,] matrix = new double[rows, columns];
int rownumber = matrix.GetLength(0);
int columnnumber = matrix.GetLength(1);
double sum = 0;
double othersum = 0;
for (int i = 0; i < rownumber; i++)
{


    for (int j = 0; j < columnnumber; j++)
    {

        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int j = 0; j < columnnumber; j++)
{
    sum=0;
    for (int i = 0; i < rownumber; i++)
    {
        sum += matrix[i, j];
        othersum = sum;
        

    }
   
    Console.WriteLine($"Среднее арифметическое {j + 1} столба равна{othersum/rownumber}");

}