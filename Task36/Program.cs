//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

Console.Clear();

int[] array = new int[12];


void PrintArray(int[] arr)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
        if (arr[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    Console.WriteLine();
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}



FillArray(array);
PrintArray(array);
Console.WriteLine();
