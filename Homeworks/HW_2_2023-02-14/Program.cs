//-----------------------------------------------------------------------------------------------------------------
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int ShowDec(int num)
// {
//     int sot = num % 100;
//     int ed = num % 10;
//     return (sot-ed)/10;
// }
// int randomnumber = new Random().Next(100, 1000);
// //int randomnumber = 456;
// Console.WriteLine($"Произвольное трёхзначное число -> {randomnumber}");
// Console.WriteLine($"Вторая цифра этого числа -> {ShowDec(randomnumber)}");
// Console.WriteLine();


//-----------------------------------------------------------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ВАРИАНТ РЕШЕНИЯ 1 - через int:

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем:
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. 
// Если 3 цифры нет, сообщает об этом:
// int MakeArray(int a, int b)
// {
//     int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//         Console.WriteLine($"Третья цифра введённого числа -> {result}");
//     }
// return result;
// }

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// MakeArray(number, count);
// Console.WriteLine();


// ВАРИАНТ РЕШЕНИЯ 2 - через void:

// void ShowNum(int num)
// {
//     if (num < 0) { num = num * (-1); } // Добавила преобразование на случай, если число отрицательное
//     if (num >= 100)
//     {
//         string stringNum = num.ToString();
//         Console.WriteLine("Третья цифра числа -> " + stringNum[2]);
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифы нет");
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// ShowNum(number);
// Console.WriteLine(); // пустая строка для красоты, чтобы отделить результат от последубщих записей в терминале


//-----------------------------------------------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Обычная проверка значения методом void - 

// ВАРИАНТ РЕШЕНИЯ 1:


void CheckDay (int num)
{
    if (num >= 1 && num <= 7)
        {
            if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
            else Console.WriteLine("Сегодня будний день");
        }
    else Console.WriteLine("Ведено неверное число");
}

Console.Write("Введите число от 1 до 7: ");
int dayN = Convert.ToInt32(Console.ReadLine());
CheckDay(dayN);
Console.WriteLine();


// // ВАРИАНТ РЕШЕНИЯ 2:

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// string WorkHoliday(int a)
// {
//     if (a > 0 && a < 8)
//     {
//         if (a == 7 || a == 6)
//         {
//             Console.Write("День под цифрой " + a + " - Выходной");
//         }
//         else
//         {
//             Console.Write("День под цифрой " + a + " - Рабочий");
//         }
//     }
//     else
//     {
//         Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому невозможно определить");
//     }
//     return " день.";
// }

// int dayNumber = ReadInt("Введите число от 1 до 7: ");
// Console.WriteLine(WorkHoliday(dayNumber));