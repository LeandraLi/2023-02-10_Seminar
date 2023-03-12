//--------------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа:
// 78 - 8
// 12 - 2
// 85 - 8

// void MaxDecimal(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}"); // return ed
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}"); // return dec
//     }
// }
// int randomnumber = new Random().Next(10, 99 + 1);
// MaxDecimal(randomnumber);


//--------------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//Вариант 1 решения через int:
//
// int DeleteDecimal (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }
//
// int randomnumber = new Random().Next(100, 1000); // рандомное число от 100 до 1000
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// // или такой вариант:
// Console.WriteLine(DeleteDecimal(randomnumber)); // это вместо строк 41 и 42 - как альтернативный способ

//Вариант 2 решения через void:

// void DelMid(int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     Console.WriteLine($"Новое число из рандомного {num} - это {ed + sot * 10}");
// }

// int number = new Random().Next(100, 1000);
// DelMid(number);


//--------------------------------------------------------------------------------------------------------
// Задача самостоятельная 1_Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
// написать метод проверки

// void Krat2(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} не кратно заданным числам 7 и 23");
//     }
// }
// Console.Write("Введите проверяемое число: ");
// int randomnumber = Convert.ToInt32(Console.ReadLine());
// Krat2(randomnumber);
// Console.WriteLine();


//--------------------------------------------------------------------------------------------------------
// Задача самостоятельная 2_Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

void Krat2(int m, int n)
{
    if (m % n == 0)
    {
        Console.WriteLine($"Число {m} кратно {n}");
    }
    else
    {
        // int ostatok = m % n;
        // Console.WriteLine($"не кратно, остаток {ostatok}");
        Console.WriteLine($"Остаток от деления {m} на {n} равен {m % n}");
    }
}
Console.Write("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Krat2(a, b);
Console.WriteLine();
