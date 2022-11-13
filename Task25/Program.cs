// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponent(int ax, int bx)
{
    int var = ax;
    for (int i = 2; i <= bx; i++)
    {
        var = var * ax;
    }
    return var;
}

if (b > 0)
{
    int result = Exponent(a, b);
    Console.WriteLine($"Число {a} в степени {b} -> {result}");
}
else Console.WriteLine("Второе число должно быть больше нуля.");