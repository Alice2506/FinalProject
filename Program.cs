// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Numbers(int n)
{
    if(n >= 1) return $"{n} " + Numbers(n - 1);
    else return String.Empty;
}
Console.WriteLine(Numbers(16));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    int result = 0;
    for (int i = m; i <= n; i++)
    {
        result = m + Sum(m + 1, n);
    }
    return result;
}
Console.WriteLine(Sum(2,6));



