// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetCountsEvenNumbers(int[] array)
{
    int counts = 0;
    int sum = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) 
        {
            sum += array[i]; 
            counts ++;
        }
    }
    return sum;
}


int[] GenerateRandomArray(int element , int start, int finish )
{
    int[] array = new int[element];
    for (int i = 0; i < element; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}


int[] array = GenerateRandomArray(5,-99,100);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($" -> {GetCountsEvenNumbers(array)}");