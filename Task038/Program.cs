// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

int SearchDiffMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    return max - min;
}

int[] myArray = CreateArray(10, 1, 20);
PrintArray(myArray);
Console.Write($" -> {SearchDiffMinMax(myArray)}");
Console.WriteLine();