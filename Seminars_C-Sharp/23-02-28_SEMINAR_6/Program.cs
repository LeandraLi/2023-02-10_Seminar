// Задача 1. Напишите программу, которая перевернёт отдномерный массив
// (последний элемент будет а первом месте, а первый - на последнем.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 5 4] -> [4 5 7 6]


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReverseArray(int[] array)
{
    
    for (int i =0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
    return array;
}


Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
int[] reversedArray = ReverseArray(myArray);
ShowArray(reversedArray);

