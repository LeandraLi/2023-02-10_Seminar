//--------------------------------------------------------------------------------------------------------------------
// + Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArrray = new int[rows, columns]; //1. Выделяем память под наш создаваемый массив
//     //2. Теперь начнём заполнять массив и перемещаться по строкам и столбцам:
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArrray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArrray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); 
// }

// void SortInRows(int[,] sortedArray) 
// {
//     for (int i = 0; i < sortedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortedArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < sortedArray.GetLength(1) - 1; k++)
//             {
//                 if (sortedArray[i, k] < sortedArray[i, k + 1])
//                 {
//                     int temp = sortedArray[i, k + 1];
//                     sortedArray[i, k + 1] = sortedArray[i, k];
//                     sortedArray[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue); // Создаём рандомный двумерный массив
// Console.WriteLine("Generated 2D random array: ");
// Show2DArray(array);

// SortInRows(array); // Сортируем созданный массив методом

// Console.WriteLine("Sorted 2D array: ");
// Show2DArray(array); // Выводим отсортированный массив


//--------------------------------------------------------------------------------------------------------------------
// + Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArrray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArrray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArrray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumLine(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue); // Создаём рандомный двумерный массив
// Console.WriteLine("Generated 2D random array: ");
// Show2DArray(array);

// int minSumLine = 0;
// int sumLine = SumLine(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int tempSumLine = SumLine(array, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }
// minSumLine = minSumLine + 1;

// Console.WriteLine("Строка с наименьшей суммой под №" + minSumLine);
// Console.WriteLine("Наименьшая сумма этой строки равна -> " + sumLine);
// Console.WriteLine();


//--------------------------------------------------------------------------------------------------------------------
// + Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Multiply(int[,] arr1, int[,] arr2, int[,] resultArr)
// {
//     if (arr1.GetLength(0) != arr2.GetLength(1))
//     {
//         throw new ArgumentException("Matrices cannot be multiplied.");
//     }

//     for (int i = 0; i < resultArr.GetLength(0); i++)
//         {
//             for (int j = 0; j < resultArr.GetLength(1); j++)
//                 {
//                     int sum = 0;
//                 for (int n = 0; n < arr1.GetLength(1); n++)
//                     {
//                     sum += arr1[i, n] * arr2[n, j];
//                     }
//                     resultArr[i,j] = sum;
//                 }
//         }
// }

// Console.WriteLine(">>> You need to input data for the correct solution of th problem <<<");
// Console.WriteLine(">>> The number of columns of the 1st matrix must be equal to the number of rows of the 2nd <<<");

// Console.WriteLine("Input number of rows in 1st matrix: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of ROWS of 1st matrix & number of COLUMNS of 2nd matrix: ");
// int colFirstRowSec = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns in 2nd matrix: ");
// int col2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array1 = Create2DRandomArray(row1, colFirstRowSec, minValue, maxValue); 
// Console.WriteLine("Generated 1st 2D random matrix: ");
// Show2DArray(array1);

// int[,] array2 = Create2DRandomArray(colFirstRowSec, col2, minValue, maxValue); 
// Console.WriteLine("Generated 2nd 2D random matrix: ");
// Show2DArray(array2);

// int[,] res2DArr = new int[row1, col2];
// Console.WriteLine("Newly multiplied 2D random matrix is the following: ");
// Multiply(array1, array2, res2DArr);
// Show2DArray(res2DArr);


//--------------------------------------------------------------------------------------------------------------------
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
// {
//     int[,,] matrix = new int[row, col, dep];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                 {
//                     matrix[i,j,k] = rnd.Next(min, max);
//                 }
//         }
//     }
//     return matrix;
// } 

// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i <  matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {

//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//             Console.Write($"{matrix}({i},{j},{k})| ");            
//             }
//             Console.WriteLine();
//         }     
//     }        
// }

// Console.Write("Input number of rows in matrix: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in matrix: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input depth of matrix: ");
// int dep = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value in matrix: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value in matrix: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] array3D = CreateMatrix(row, col, dep, min, max);
// PrintMatrix(array3D);
// Console.WriteLine();


//--
//V2:

int[,,] Random3dArray(int field, int rows, int columns)
{
    int[,,] newArray = new int[field, rows, columns];
    for (int i = 0; i < field; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                newArray[i, j, k] = i + j + k;
            }
        }
    }
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of field: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,,] array = Random3dArray(m, n, l);
Show3dArray(array);


//--------------------------------------------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07







