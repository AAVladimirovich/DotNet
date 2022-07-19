// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine(@"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
");

void FillMatrixElementsWithRandomIntValue(int[,] argArray, int argMinRndValue = 1, int argMaxRndValue = 20)
{
    var rndGenerator = new Random();
    int[] intArray = new int[argArray.GetLength(1)];

    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            argArray[i, j] = rndGenerator.Next(argMinRndValue, argMaxRndValue + 1);
        }

    }

}

int ReturnMinimunRowNumber(int[,] argArray)
{
    int[] intArray = new int[argArray.GetLength(1)];
    int sum = 9999;
    int memoryRow =0;

    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            intArray[i] += argArray[i, j];
        }
        // Console.WriteLine($"Сумма строки {i} = {intArray[i]}"); //для проверки

        if (sum > intArray[i]) 
        {
            sum = intArray[i];
            memoryRow = i;
        }

    }

    return memoryRow;

}
void PrintMatrix(int[,] argArray, string argText = "")
{
    Console.WriteLine();
    if (argText != "") Console.WriteLine(@$" [{argText}] ");

    Console.WriteLine(@$"
    Массив размерности [{argArray.GetLength(0)},{argArray.GetLength(1)}] ↓
    ");

    for (int i = 0; i < argArray.GetLength(0); i++)
    {

        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < argArray.GetLength(1) - 1) Console.Write($"| [{i}][{j}] = {argArray[i, j],4} |");
            else Console.Write($"| [{i}][{j}] = {argArray[i, j],4} ||");
        }

        Console.WriteLine();

    }
}

Console.Write("Введите число стороны для двумерном массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arrayForTask = new int[m, m];
int[,] secondArrayForTask = new int[m, m];

FillMatrixElementsWithRandomIntValue(arrayForTask);
FillMatrixElementsWithRandomIntValue(secondArrayForTask);
PrintMatrix(arrayForTask, "!!!!!!Первоначальный массив A!!!!!!");
PrintMatrix(secondArrayForTask, "!!!!!!Первоначальный массив B!!!!!!");

Console.WriteLine($"{ReturnMinimunRowNumber(arrayForTask)} строка с наименьшими числами");