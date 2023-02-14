// Напишите программу 
// 78 - 8
// 12 - 2
// 85 - 2
void MaxDecimal(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if(ed>dec)
    {
        Console.WriteLine($"Большая цифра числа {num} -> {ed}"); // return ed
    }
    else
    {
        Console.WriteLine($"Большая цифра числа {num} -> {dec}"); // return dec
    }
}
int randomnumber = new Random().Next(10, 99 + 1);
MaxDecimal(randomnumber);