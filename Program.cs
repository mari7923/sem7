// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы. 

void ShowNumbers(int start, int end)
{
    if (start > end)
        return;

    Console.Write(start);

    if (start < end)
        Console.Write(", ");

    ShowNumbers(start + 1, end);
}

{
    Console.Write("Введите начальное число (M): ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конечное число (N): ");
    int N = Convert.ToInt32(Console.ReadLine());

    ShowNumbers(M, N);

    Console.ReadLine();
}