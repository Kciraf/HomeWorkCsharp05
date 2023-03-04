// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int CountEvenInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) result++;              
    }
    return result;
}

void PrintArray(int[] arr)
{
   Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

System.Console.Write("Введите размер проверяемого массива: ");
int testSize = Convert.ToInt32(Console.ReadLine());
int[] testArr = GenArray(testSize, 100, 999);
PrintArray(testArr);
System.Console.WriteLine("Количество четных элементов в массиве: " + CountEvenInArray(testArr));
