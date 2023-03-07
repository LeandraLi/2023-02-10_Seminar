// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree(int numA, int numB)
// {
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     return result;
// }

// Console.WriteLine("Введите первое число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число B");
// int B = Convert.ToInt32(Console.ReadLine());

// int result = Degree(A, B);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int result=0;
    while(number > 0)
    {
        result += number %10;
        number = number/10;
    }
    return result;
    
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

SumDigits(num);
Console.WriteLine($"Сумма чисел введённого числа равна: {SumDigits(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int [8]; // это если задаём рандомный массив из 8ми элементов и печатаем его (2 метода используем)
// FillArray(array);


// int[] array = {6, 1, 33}; // это если мы заданный массив вводим, а потом печатем его методом PrintArray
// PrintArray(array);

