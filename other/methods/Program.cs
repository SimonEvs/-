// int rows = int.Parse(Console.ReadLine());
// int columns = int.Parse(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 100);
//         }
//         Console.WriteLine();

//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();


//     }
// }

// void ChangeNumbers(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < matrix[i, j + 1])
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[i, j+1];
//                 matrix[i, j+1] = temp;
//             }
//         }
//     }
// }