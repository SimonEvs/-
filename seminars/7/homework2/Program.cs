//Программа, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение элемета

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
for (int i = 0; i < rownumber; i++)
{


    for (int j = 0; j < columnnumber; j++)
    {
        matrix[i, j] = new Random().Next(0, 100);
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}

Console.WriteLine("Какое число хотите найти? ");
int find = Convert.ToInt32(Console.ReadLine());
int variable = 0;
for (int i = 0; i < rownumber; i++)
{


    for (int j = 0; j < columnnumber; j++)
    {
        if (matrix[i, j] != find)
        {
        
            variable += 1;
        }


    }
  
}
if (variable == rownumber * columnnumber)
{
    Console.WriteLine("Нету такого числа");
}
else{Console.WriteLine("Есть такое число");}
