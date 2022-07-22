//Задайте двумерный массив. Hапишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
//Convert - ковертирует абсолютно все(преобразует в любой тип данных).
// Parse конвертирует только в Инт(к целому числу строчку).
//Если в Convert 0 вписать, то выдаст null, Parse же выдаст исключение.
// null- ссылка в пустоту.
//
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

///summary-описание метода(три слэша).
// m на n (m-количсетво строк,n-количество столбцов).
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

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

void ChangeRows(int[,] matrix)
{
    int indexLastRow = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[indexLastRow, i];
        matrix[indexLastRow,i]=temp;
    }
}