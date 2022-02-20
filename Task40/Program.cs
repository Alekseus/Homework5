//В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();

int size = new Random().Next(5, 10);

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 1000;
    }
    return array;
}

void PrintDiff(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double diff = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива = {arr.Min()}, максимальное значение массива = {arr.Max()}");
    Console.WriteLine($"Разница составляет {diff}");
    Console.WriteLine();
}

PrintDiff(FillArray(size));

