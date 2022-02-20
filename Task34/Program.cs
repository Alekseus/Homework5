//Написать программу для замены элементов массива на противоположные.

Console.Clear();

int[] array = new int[5];


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} \t ");
    }
}

void OppPrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} \t ");
    }
}


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(-50, 50);
    }
}

void OppFillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
OppFillArray(array);
OppPrintArray(array);
Console.WriteLine();