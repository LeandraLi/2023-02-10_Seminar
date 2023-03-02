// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] randomArray(int size) 
// { 
//  Random random = new Random(); 
//  int[] array = new int[size]; 
//  for(int i = 0; i < array.Length; i++) 
// 	{ 
//  	array[i] = random.Next(100,1000); 
// 	}
//  return array; 
// }

// int countOfEven(int[] array) 
// { 
//  int count = 0; 
//  for(int i = 0; i < array.Length; i++) 
// 	{ 
//  	if(array[i] % 2 == 0) 
// 		{ 
//  		count++; 
// 		}
// 	}
//  	return count; 
// }

// int[] array = randomArray(4); 
// Console.WriteLine($"[{string.Join(",",array)}] -> {countOfEven(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] randomArray(int size) 
// { 
//  Random random = new Random(); 
//  int[] array = new int[size]; 
//  for(int i = 0; i < array.Length; i++) 
// 	{ 
//  	array[i] = random.Next(-10,100); 
// 	}
//  return array; 
// }

// int sumOfOdd(int[] array) 
// { 
//  int sum = 0; 
//  for(int i = 0; i < array.Length; i++) 
// 	{ 
//  	if(i % 2 != 0) 
// 		{ 
// 		sum += array[i]; 
// 		}
// 	}
//  return sum; 
// }

// int[] array = randomArray(4); 
// Console.WriteLine($"[{string.Join(",",array)}] -> {sumOfOdd(array)}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] randomArray(int size) 
{ 
Random random = new Random(); 
double[] array = new double[size]; 
for(int i = 0; i < array.Length; i++) 
	{ 
	array[i] = Math.Round(random.NextDouble(), 3); 
	}
return array; 
}

double getMin(double[] array) 
{ 
double min = array[0]; 
for(int i = 1; i < array.Length; i++) 
	{ 
	if(array[i] < min) 
		{ 
		min = array[i]; 
        	}
    }
return min; 
}

double getMax(double[] array) 
{ 
double max = array[0]; 
for(int i = 1; i < array.Length; i++) 
	{ 
	if(array[i] > max) 
		{ 
		max = array[i]; 
        	}
	}
return max; 
}

double[] array = randomArray(4); 
Console.WriteLine($"[{string.Join(", ",array)}] -> {(Math.Round(getMax(array) - getMin(array), 3))}"); 
