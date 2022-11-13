// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Length(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }

    return count;
}

int length = Length(number);

int Sum(int num, int leng)
{
    int sum = 0;
    for (int i = 0; i <= length; i++)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

int result = Sum(number, length);
Console.WriteLine($"Сумма цифр в числе {number} -> {result}");