// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите значение M: ");
    int N = ReadInt("Введите значение N: ");

    Console.Write("Значения от M до N: ");
    PrintNumbersMN(M, N);
    PrintNumbersMN2(M, N);
}

// если M < N, вывод от M до N
void PrintNumbersMN(int M, int N)
{
    if (N < M) return;
    PrintNumbersMN(M, N - 1);
    Console.Write(N + ", ");
}

// если M > N, вывод от M до N
void PrintNumbersMN2(int M, int N)
{
    if (N > M) return;
    PrintNumbersMN2(M, N + 1);
    Console.Write(N + ", ");
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();