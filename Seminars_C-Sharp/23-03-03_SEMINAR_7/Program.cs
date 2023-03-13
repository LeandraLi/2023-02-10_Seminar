//--------------------------------------------------------------------------------------------------------------------
// Задача 1. Задайте двумерный массив размером m x n, заполненный случайными числами.

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
//     Console.WriteLine(); // Добавляем пустую строку, чтобы при вызове метода несколько раз подряд, рез-ты разделялись пустой строкой
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

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);


//--------------------------------------------------------------------------------------------------------------------
// Задача 2. Задайте двумерный массив размера m x n, 
// где каждый элемент массива находится по формуле Amn = m + n
// Выведите полученный массив на экран.

// int[,] Create2DArray(int columns, int rows)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i + j;
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
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// Show2DArray(Create2DArray(columns, rows));


//--------------------------------------------------------------------------------------------------------------------
// Задача 3. Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядит так:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Новый массив будет выглядеть так:
// *1  4  7  2 
//  5 *81 2 *9
// 

// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[,] Gen2DArr(int xlen, int ylen)
// {
//     int[,] arr = new int[ylen, xlen];
//     for (int i = 0; i < ylen; i++)
//     {
//         for (int j = 0; j < xlen; j++)
//         {
//             arr[i, j] = j+i;
//         }
//     }
//     return arr;
// }

// void Print2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }

// void Update2DArr(int[,] arr)
// {
//    for (int i = 0; i < arr.GetLength(0); i=i+2)
//     {
//         for (int j = 0; j < arr.GetLength(1); j=j+2)
//         {
//             //arr[i, j]*=arr[i, j] ;
//             //arr[i, j]=arr[i, j]*arr[i, j];
//             arr[i, j]=(int)Math.Pow(arr[i, j],2);
//         }
//     } 
// }



// int xlen = InputNum("Ваше число столбцов: ");
// int ylen = InputNum("Ваше число строк: ");
// int[,] matrix = Gen2DArr(xlen, ylen);
// Print2DArr(matrix);
// Update2DArr(matrix);
// Console.WriteLine();
// Print2DArr(matrix);


//--------------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с индексом (0,0); (1,1) и т.д.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int DiagSum(int[,] arr)
{
    int res =0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);

   for (int i = 0; i < min; i=i+1)
    {
        res = res+ arr[i, i];
    } 
    return res;
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int sumOfDiagonal = DiagSum(matrix);
Console.WriteLine(sumOfDiagonal);

