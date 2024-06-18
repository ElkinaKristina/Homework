// Задача 2: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите m: ");
    int n = ReadInt("Введите n: ");
    AckermannFunction(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана = " + AckermannFunction(m, n));
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }

    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
