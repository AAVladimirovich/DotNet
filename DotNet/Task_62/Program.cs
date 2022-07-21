// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine(@"Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
");

List<int> CreateNumberList(int argMaxValue = 1000)
{

    List<int> numbersList = new List<int>();
    for (int i = 0; i < argMaxValue; i++)
        numbersList.Add(i);
    return numbersList;
}

void FillMatrixElementsWithRndListIntValues(int[,] argArray, List<int> numbersList)
{
    var rndGenerator = new Random();
    int memoryIndex = 0;

    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            memoryIndex = rndGenerator.Next(0, numbersList.Count);
            argArray[i, j] = numbersList[memoryIndex];
            numbersList.RemoveAt(memoryIndex);
        }
    }

}

// void FillMatrixElementsSpiralWithListIntValues(int[,] argArray, int argCurrentNumber, int argStartIndexI,
//                                                             int argStartIndexJ, int prohodRight, int prohodDown, int prohodLeft, int prohodUp, string direction)
// {

//     int spiralStep = 0;
//     int markerI = 0;
//     int markerJ = 0;
//     int endPoint = 0;

//     if (argCurrentNumber >= argArray.Length) return;
//     switch (direction)
//     {
//         case "Right":
//             endPoint = argArray.GetLength(0) - prohodDown;
//             for (spiralStep = argStartIndexJ+prohodRight; spiralStep < endPoint; spiralStep++)
//             {
//                 argArray[argStartIndexI, spiralStep] = argCurrentNumber++;
//                 markerI = argStartIndexI;
//                 markerJ = spiralStep;
//             }
//             prohodRight++;
//             FillMatrixElementsSpiralWithListIntValues(argArray, argCurrentNumber, markerI, markerJ, prohodRight, prohodDown, prohodLeft, prohodUp, "Down");
//             break;
//         case "Down":
//             endPoint = argArray.GetLength(1) - prohodLeft;
//             for (spiralStep = argStartIndexI+prohodRight; spiralStep < endPoint; spiralStep++)
//             {
//                 argArray[spiralStep, argStartIndexJ] = argCurrentNumber++;
//                 markerI = spiralStep;
//                 markerJ = argStartIndexJ;
//             }
//             prohodDown++;
//             FillMatrixElementsSpiralWithListIntValues(argArray, argCurrentNumber, markerI, markerJ, prohodRight, prohodDown, prohodLeft, prohodUp, "Left");
//             break;
//         case "Left":
//             endPoint = 0 + prohodUp;
//             for (spiralStep = argStartIndexJ-prohodDown; spiralStep >= endPoint; spiralStep--)
//             {
//                 argArray[argStartIndexI, spiralStep] = argCurrentNumber++;
//                 markerI = argStartIndexI;
//                 markerJ = spiralStep;
//             }
//             prohodLeft++;
//             FillMatrixElementsSpiralWithListIntValues(argArray, argCurrentNumber, markerI, markerJ, prohodRight, prohodDown, prohodLeft, prohodUp, "Up");
//             break;
//         case "Up":
//             endPoint = 0 + prohodRight;
//             for (spiralStep = argStartIndexI; spiralStep >= endPoint; spiralStep--)
//             {
//                 argArray[spiralStep, argStartIndexJ] = argCurrentNumber++;
//                 markerI = spiralStep;
//                 markerJ = argStartIndexJ;
//             }
//             prohodUp++;
//             FillMatrixElementsSpiralWithListIntValues(argArray, argCurrentNumber, markerI, markerJ, prohodRight, prohodDown, prohodLeft, prohodUp, "Right");
//             break;
//         default:
//             Console.WriteLine($"SPIRAL RECURSIA!");
//             break;
//     }
// }

void FillMatrixElementsSpiralWithListIntValues(int[,] argArray, int argNumber)
{
    if ( argArray[i,j] != Empty || i >= argArray.GetLength(0))
    {
        FillMatrixElementsSpiralWithListIntValues(argArray,argNumber);
    }
    else
    {
        argArray[i,j] = argNumber;
    }
}

// void FillMatrixElementsSpiralWithListIntValues(int[,] argArray, int argStep)
// {
//     int k = 0;
//     int i = 0;
//     int j = 0;

//     while (k < 1)
//     {
//         for (j = 0 + k; j < argArray.GetLength(1) - k; j++)
//         {
//             argArray[i, j] = argStep++;
            
//         }
//         j = argArray.GetLength(1) -1;
//         for (i = 0 + k; i < argArray.GetLength(0) - k; i++)
//         {
//             argArray[i, j] = argStep++;
            
//         }
//         // j = argArray.GetLength(1) - 1- k;
//         // Console.WriteLine($"j = {j}");
//         // for (i = + k; i < argArray.GetLength(0) - k; i++)
//         // {
//         //      argArray[i, j] = argStep++;
//         // }
//         // Console.WriteLine($"j = {j}");
//         k++;
//     }

// }

void PrintMatrix(int[,] argArray, bool showIndexes, string argText = "")
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
            if (showIndexes == true)
            {
                if (j == 0) Console.Write("|");
                if (j < argArray.GetLength(1) - 1) Console.Write($"| [{i}][{j}] = {argArray[i, j],4} |");
                else Console.Write($"| [{i}][{j}] = {argArray[i, j],4} ||");
            }
            else
            {
                if (j == 0) Console.Write("|");
                if (j < argArray.GetLength(1) - 1) Console.Write($"| {argArray[i, j],4} |");
                else Console.Write($"| {argArray[i, j],4} ||");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер строк и столбцов для массива = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] firstArrayForTask = new int[m, m];
List<int> listForNumbers = CreateNumberList(firstArrayForTask.Length);
// FillMatrixElementsSpiralWithListIntValues(firstArrayForTask, 1, 0, 0, 0, 0, 0, 0, "Right");
FillMatrixElementsSpiralWithListIntValues(firstArrayForTask, 1);
PrintMatrix(firstArrayForTask, true, "************* МАТРИЦА A *************");