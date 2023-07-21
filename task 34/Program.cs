// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetCountsEvenNumbers(int[] array)
{
    int counts = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) counts ++;
    }
    return counts;
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = GenerateRandomArray(5, 126, 1000);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($" -> {GetCountsEvenNumbers(array)}");

