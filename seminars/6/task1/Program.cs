// Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и последний и тд
// Результат запишите в новом массиве.

int[] inputArray = { 1, 2, 3, 4, 5 };
int lastIndex = inputArray.Length - 1;
int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
    if (i == lastIndex - i)
    {
        resultArray[i] = inputArray[i];
    }
    Console.Write($"{resultArray[i]} ");
}
