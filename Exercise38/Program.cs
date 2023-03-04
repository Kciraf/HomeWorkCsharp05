// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenDoubleArray(int size, int low, int high, int round)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(low - 1, high) + Math.Round(rnd.NextDouble(), round);
    }
    return array;
}

void PrintDoubleArray(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double[] FindMaxMin(double[] array)
{
    double min = array[0];
    double max = array[1];
    if (max < min)
    {
        max = array[0];
        min = array[1];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double[] MinMax = { min, max };
    return MinMax;
}

System.Console.Write("Введите размер проверяемого случайного массива: ");
double[] newArray = GenDoubleArray(Convert.ToInt32(Console.ReadLine()), 0, 100, 3);
PrintDoubleArray(newArray);
double[] MinMax = FindMaxMin(newArray);
System.Console.WriteLine($"Min = {newArray[0]}, Max = {newArray[1]}, разница между max и min: {newArray[1] - newArray[0]}");