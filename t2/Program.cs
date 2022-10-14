//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма чисел = {SumNumber(number)}");

int SumNumber(int n )
{
int sum = 0;
int a = 0;
while( n > 0)
{
    a = n % 10;
    sum += a;
    n = n / 10;
}
return sum;
}


