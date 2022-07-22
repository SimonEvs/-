//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива. 

int rows = 3;

int columns = 3;

int[,] matrix = new int[rows, columns];
int min = int.MaxValue;
int indexRows = 0;
int indexColumns = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        if (min > matrix[i, j])
        {
            min = matrix[i, j];
            indexRows = i;
            indexColumns = j;

        }
    }
    Console.WriteLine();
}
Console.WriteLine(min);

for (int i = 0; i < rows; i++)
{
    if (indexRows != i)
    {
        for (int j = 0; j < columns; j++)
        {
            if (indexColumns != j)
            {
                Console.Write(matrix[i, j]+"\t");
            }
        }
         Console.WriteLine();
    }
}