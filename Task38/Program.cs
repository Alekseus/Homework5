//Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();

int[] array = new int[12];


void PrintArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел в нечетной позиции = {sum} ");
    Console.WriteLine();
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(0, 30);
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();