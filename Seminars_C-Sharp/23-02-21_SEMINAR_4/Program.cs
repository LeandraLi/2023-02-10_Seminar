
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// //int[] myArray = CreateRandomArray(size, minValue, maxValue);

// ShowArray(CreateRandomArray(size, minValue, maxValue));


//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// int FindDigit (int num);
// {
//     int digit=0;
//     while(num>0)
//     {
//         num = num/10;
//         digit++;
//     }
//     return d;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindDigit(num));


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// int FindFactorial(int num)
// {
//   int factorial = 1;
//   for (int i = 1; i <= num; i++)
//   {
//     factorial *= i;
//   }
//   return factorial;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindFactorial(num));

// Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 


// int CountNumber(int num)
// {
//     int count = 0;
//     while (count < num)
//     {
//         num /= 10;
//         count++;

//     }
//     return count;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumber(num));

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

// int Factor(int num)
// {

//     int n = 1;
//     for (int i = 1; i <= num; i++)
//     {

//         n = n * i;

//     }
//     return n;

// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factor(num));

