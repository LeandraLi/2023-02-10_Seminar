// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  int ShowDec (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return (num - (sot*100 + ed))/10;    
// }
// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// ShowDec(randomnumber);
// Console.WriteLine(ShowDec(randomnumber));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//     }
// return result;
// }

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Обычная проверка значения методом void - 

// Console.Write("Введите число от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 1 && num <= 7)
//     {
//         if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
//         else Console.WriteLine("Сегодня рабочий день");
//     }
// else Console.WriteLine("Ведено неверное число");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("День под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("День под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому невозможно определить");
    }
    return " день.";
}

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));