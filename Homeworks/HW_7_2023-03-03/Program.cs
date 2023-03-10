// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Инициализируем массив с цветом символов
// ConsoleColor[] col = new ConsoleColor[]
// {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
// ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
// ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
// ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
// ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
// ConsoleColor.Yellow};

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция (Метод) для заполнения 2D массива вещественными (doubl) числами
double[,] Gen2DArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 101) + new Random().NextDouble(), 4);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}

// 1. Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");

// 2. Генерируем 2D  массив
double[,] arr2D = Gen2DArray(n, m);

// 3. Печатаем двумерный массив
Print2DArr(arr2D);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Функция (Метод) ввода данных с консоли
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


// // Функция (Метод) генерации 2D массива числами Фиббоначи
// int[,] Gen2DArrFibo(int column, int row)
// {
//     // Генерируем 1D массив из чисел Фибоначи, длинной column * row
//     int[] arr1D = new int[column * row];
//     arr1D[0] = 0;
//     arr1D[1] = 1;
//     for (int i = 2; i < arr1D.Length; i++)
//     {
//         arr1D[i] = arr1D[i - 1] + arr1D[i - 2];
//     }
//     // Инициализируем  2D массив из 1D массива
//     int[,] arr2D = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             arr2D[i, j] = arr1D[i * column + j];
//         }
//     }
//     return arr2D;
// }

// // Функция (Метод) поиска существования элемента в массиве и вывод результата в консоль
// void SerchElemAndPrint(int[,] arr2D, int serchElem)
// {
//     bool elemSerch = false;
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             if (serchElem == arr2D[i, j])
//             {
//                 elemSerch = true;
//                 Console.ForegroundColor = System.ConsoleColor.Red;
//             }
//             Console.Write(arr2D[i, j] + " \t");
//             Console.ForegroundColor = System.ConsoleColor.White;
//         }
//         Console.WriteLine();
//     }
//     if (elemSerch == false)
//     {
//         Console.ForegroundColor = System.ConsoleColor.Red;
//         Console.WriteLine("Элемент " + serchElem + " не найден");
//     }
//     Console.ForegroundColor = System.ConsoleColor.White;
// }

// // 1. Получение данных от пользователя
// int column = ReadData("Количество столбцов матрицы: ");
// int row = ReadData("Количество строк матрицы: ");
// int findeNum = ReadData("Введите искомое число ");

// // 2. Генерируем 2D  массив
// int[,] arr2DFibo = Gen2DArrFibo(column, row);

// // 3. Ищем элемент в массиве и выводим результат в консоль
// Console.WriteLine();
// SerchElemAndPrint(arr2DFibo, findeNum);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Функция (Метод) ввода данных с консоли
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


// // Функция (Метод) для заполнения 2D массива целыми (int) числами
// int[,] Gen2DArrayInt(int row, int column)
// {
//     int i = 0; int j = 0;
//     int[,] arr = new int[row, column];
//     while (i < row)
//     {
//         j = 0;
//         while (j < column)
//         {
//             arr[i, j] = new Random().Next(0, 101);
//             j++;
//         }
//         i++;
//     }
//     return arr;
// }

// // Функция (Метод) вывода 2D  массива в консоль
// void Print2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             //Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
//             Console.Write(arr[i, j] + "\t");
//             //Console.ResetColor(); 
//         }
//         Console.WriteLine("");
//     }
// }

// // Метод печати 1D массива в консоль
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }


// // Метод подсчета среднего арифметического по столбцам
// int[] MeanColum(int[,] arr)
// {
//     int[] means = new int[arr.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             means[i] = means[i] + arr[j, i];
//         }
//         means[i] = means[i] / arr.GetLength(0);
//     }
//     return means;
// }

// // Метод подсчета среднего арифметического по диагонали
// int DiagAverage(int[,] arr)
// {
//     int res = 0;
//     int count = 0;
//     int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

//     for (int i = 0; i < min; i = i + 1)
//     {
//         res = res + arr[i, i];
//         count = count + 1;
//     }
//     res = res / count;
//     return res;
// }


// // 1. Получение данных от пользователя
// int row = ReadData("Количество строк матрицы: ");
// int column = ReadData("Количество столбцов матрицы: ");

// // 2. Генерируем 2D массив
// int[,] arr2D = Gen2DArrayInt(row, column);

// // 3. Считаем среднее арифметическое по столбцам
// int[] average = MeanColum(arr2D);

// // 4. Печатаем 2D Массив
// Print2DArr(arr2D);

// Console.WriteLine();
// Console.WriteLine("Среднее арифметическое по столбцам: ");
// // 5. Печатаем 1D Массив
// Print1DArr(average);

// int diagAver = DiagAverage(arr2D);
// Console.WriteLine("Среднее арифметическое по диагонали: ");
// Console.WriteLine(diagAver);
