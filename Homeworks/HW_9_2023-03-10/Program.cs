//--------------------------------------------------------------------------------------------------------------------
// + Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {

//     if (n>=1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n-1);

//     }
// }

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


//--------------------------------------------------------------------------------------------------------------------
// + Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void FindSumAllNumsGapNM(int num1, int num2, int sum)
// {
//     if (num2 > num1)
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {sum}."); 
//         return;
//     }
//     sum = sum + num2++;
//     FindSumAllNumsGapNM(num1, num2, sum);
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// FindSumAllNumsGapNM(n, m, 0);


//--------------------------------------------------------------------------------------------------------------------
// + Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m > 0) && (n == 0))
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

Console.Write("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> {Akkerman(m, n)}");


