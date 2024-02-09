// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы. 

// void ShowNumbers(int start, int end)
// {
//     if (start > end)
//         return;

//     Console.Write(start);

//     if (start < end)
//         Console.Write(", ");

//     ShowNumbers(start + 1, end);
// }

// {
//     Console.Write("Введите начальное число (M): ");
//     int M = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите конечное число (N): ");
//     int N = Convert.ToInt32(Console.ReadLine());

//     ShowNumbers(M, N);

//     Console.ReadLine();
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = FindAckerman(m, n);

// Console.WriteLine($"A({m}, {n}) = {result}");

// Console.ReadLine(); 

// int FindAckerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (n == 0)
//         return FindAckerman(m - 1, 1);
//     else
//         return FindAckerman(m - 1, FindAckerman(m, n - 1));
// }

// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 1, 2, 5, 0, 10, 34 };

Console.WriteLine("Исходный массив:");
PrintArrayReversed(array, array.Length - 1);

Console.ReadLine();


void PrintArrayReversed(int[] arr, int index)
{
    if (index < 0)
        return;

    Console.Write(arr[index] + " ");

    PrintArrayReversed(arr, index - 1);
}




