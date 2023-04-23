
void FillArray(int[] nums, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
    }
}

void FillArrayWithReal(double[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.NextDouble() * 100;
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void PrintArrayWithReal(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:F2} ");
    }
    Console.WriteLine();
}

int FindEven(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

int FindOddIndex(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + numbers[i];
        }
    }
    return sum;

}

double FindMaxMin(double[] numbers)
{
    double min = numbers[0];
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i]) max = numbers[i];
        else if (min > numbers[i]) min = numbers[i];

    }
    return max - min;

}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Homework34 ()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = FindEven(numbers);
    Console.WriteLine($"Chetnih chisel ravno {count}");
}

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Homework36 ()
{
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 50);
    PrintArray(numbers);
    int count = FindOddIndex(numbers);
    Console.WriteLine($"Summa elementov nechetnich indexov ravna {count}");
}

// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

void Homework38 ()
{
    int size = 4;
    double[] numbers = new double[size];
    FillArrayWithReal(numbers);
    PrintArrayWithReal(numbers);
    double count = FindMaxMin(numbers);
    Console.WriteLine($"Raznitsa ravna {count:F2}");
}

Homework38 ();
