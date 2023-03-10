// Задайте двухмерный массив размером m x n, заполненный случайными числами.

int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] newArrray = new int[rows, columns]; //1. Выделяем память под наш создаваемый массив
    //2. Теперь начнём заполнять массив и перемещаться по строкам и столбцам^
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArrray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArrray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); // Добавляем пустую строку, чтобы при вызове метода несколько раз подряд, рез-ты разделялись пустой строкой
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
Show2DArray(array);

