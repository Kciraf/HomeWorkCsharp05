// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenArray(int size, int low, int high)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(low, high + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
   Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CountOddElementsSumm(int[] arr)
{
    int oddSumm = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        oddSumm += arr[i];
    }
    return oddSumm;
}

System.Console.Write("Введите размер проверяемого массива: ");
int[] testArr = GenArray(Convert.ToInt32(Console.ReadLine()), -999, 999);
PrintArray(testArr);

System.Console.WriteLine("Сумма нечетных элементов массива: " + CountOddElementsSumm(testArr));
