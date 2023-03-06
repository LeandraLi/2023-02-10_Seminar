// Задача 1. Напишите программу, которая перевернёт отдномерный массив
// (последний элемент будет а первом месте, а первый - на последнем.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 5 4] -> [4 5 7 6]


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// int[] reversedArray = ReverseArray(myArray);
// ShowArray(reversedArray);



// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой дилины.
// Самое важное тут знать правило, что каждая сторона должна быть меньше суммы двух других строн.

// bool CheckTriangle(int x, int y, int z)
// {
//     if (x < y + z && y < x + z && z < x + y)
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Input side a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input side b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input side c");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Triangle with sides {a}, {b}, {c} exists -> {CheckTriangle(a, b, c)}");



// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: a и b.
// info: числа Фибоначчи - это последовательность чисел, в которой первые два числа - это 0 и 1, 
// а все последующие - это сумма двух предыдущих.
// [0 1 2 3 5 8 13...]

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Fibonacci(int size, int a, int b)
// {
//     int[] myArray = new int[size];
//     myArray[0] = a;
//     myArray[1] = b;
//     for (int i = 2; i < myArray.Length; i++)
//     {
//         myArray[i] = myArray[i - 1] + myArray[i - 2];
//     }
//     return myArray;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input 0 index num a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 1 index num b");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] fibonacci = Fibonacci(size, a, b);
// ShowArray(fibonacci);



// Задача 4. **** Напишите программу, которая будет преобразовывать десятичное чсило в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DualNumber(int num)
{
    string Sum = string.Empty;
    while (num > 0)
    {
        Sum = num % 2 + Sum;
        num = num / 2;
    }
    Console.WriteLine(Sum);
}

Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());

DualNumber(num);
