// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GatArray(int size, int minValue, int maxValue)
{
    Console.Write("[");
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;
}
int [] array = GatArray(7, -100, 100);
int SumNumbers(int[] array1)
{
    int index = 0;
    int n = 0;
    int sum = 0;

    while (index < array1.Length)
    {
        if (n % 2 != 0)
        {
            sum = sum + array1[n];
        }
            index = index + 1;
            n = n + 1;
        
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива = {SumNumbers(array)}");