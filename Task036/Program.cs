// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}

int[] CreateArray(int len, int start, int stop)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(start, stop);
    }
    return array;
}

int SumOddPos(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }

    return result;
}

int[] myArray = CreateArray(10, 1, 20);
PrintArray(myArray);
Console.Write($" -> {SumOddPos(myArray)}");
Console.WriteLine();