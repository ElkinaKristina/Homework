// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = new int[arraySize];

    GenerateArray(array);

    PrintArray(array);

    Console.WriteLine();
    PrintReverseArray(array);
}

void PrintReverseArray(int[] array, int i = 0)
{
    if (i >= array.Length) return;
    PrintReverseArray(array, i + 1);
    Console.Write(array[i] + " ");
}

void PrintArray(int[] array, int i = 0)
{
    if (i >= array.Length) return;
    Console.Write(array[i] + " ");
    PrintArray(array, i + 1);
}

void GenerateArray(int[] array, int i = 0)
{
    Random rnd = new Random();
    if (i >= array.Length) return;
    array[i] = rnd.Next(1, 100);
    GenerateArray(array, i + 1);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
