// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void Funk(int N)
{
    if (N != 0)
    {
        Console.Write($" {N}");
        Funk(N - 1);
    }
    else
        Console.WriteLine();
}
Console.Write("Введите число: ");
Funk(Convert.ToInt32(Console.ReadLine()));