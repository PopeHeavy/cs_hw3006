/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */

// Console.WriteLine("Enter number of rows (m): ");
// int inputRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns (n): ");
// int inputColumns = Convert.ToInt32(Console.ReadLine());

// ShowArray (Create2DArray(inputRows, inputColumns));

// double[,] Create2DArray(int rows, int columns, int minVal = -50, int maxVal = 50)
// {
//     double[,] createdArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i,j] = Math.Round(
//                                 new Random().Next(minVal, maxVal + 1)
//                               + new Random().NextDouble(),
//                                 1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray (double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 0)
//             {
//                 if (array[i, j] % 1 == 0) Console.Write(array[i, j] + "   ");
//                 else Console.Write(array[i, j] + " ");
//             }
//             else
//             {
//                 if (array[i, j] % 1 == 0) Console.Write(" " + array[i, j] + "   ");
//                 else Console.Write(" " + array[i, j] + " ");
//             }
//         }
//         Console.WriteLine("");
//     }
// }

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет. */

// int[,] randomArray = Create2DArr(new Random().Next(2, 10), new Random().Next(2, 10));
// ShowArray(randomArray);
// ShowIndex(randomArray);

// int[,] Create2DArr(int rows, int columns, int minV = 0, int maxV = 9)
// {
//     int[,] createdArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i,j] = new Random().Next(minV, maxV + 1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray (int [,] arrToShow)
// {
//     for (int i = 0; i < arrToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrToShow.GetLength(1); j++)
//         {
//             Console.Write(arrToShow[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// void ShowIndex (int[,] arrayIndex)
// {
//     Console.Write("Row: ");
//     int row = Convert.ToInt32(Console.ReadLine()) - 1;
//     Console.Write("Column: ");
//     int col = Convert.ToInt32(Console.ReadLine()) - 1;

//     if (row+1 > arrayIndex.GetLength(0) || col+1 > arrayIndex.GetLength(1))
//         Console.WriteLine("Wrong index");
//     else
//         Console.WriteLine("The value is: " + arrayIndex[row, col]);
// }



/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.*/

// int[,] array = Create2DArr(new Random().Next(2, 10), new Random().Next(2, 10));
// ShowArray(array);
// AvgColumn(array);

// int[,] Create2DArr(int rows, int columns, int minVal = 1, int maxVal = 9)
// {
//     int[,] createdArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i,j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray (int [,] arrToShow)
// {
//     for (int i = 0; i < arrToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrToShow.GetLength(1); j++)
//         {
//             Console.Write(arrToShow[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// void AvgColumn (int[,] arrayAvg)
// {
//     double avg = 0;
//     Console.WriteLine("Column averages:");
//     for (int j = 0; j < arrayAvg.GetLength(1); j++)
//     {
//         avg = 0;
//         for (int i = 0; i < arrayAvg.GetLength(0); i++)
//         {
//             avg += arrayAvg[i, j];
//         }
//         if (j == arrayAvg.GetLength(1)-1) Console.WriteLine(Math.Round(avg/arrayAvg.GetLength(0), 1) + " ");
//         else Console.Write(Math.Round(avg/arrayAvg.GetLength(0), 1) + " ");
//     }
// }
