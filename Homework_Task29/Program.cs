// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] PrintArray(int number)
{
    int[] result = new int[number];
    for (int i = 0; i < number; i++)
    result[i] = (new Random().Next(0,100));
    return result;
}
Console.Write("Enter the array length: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(String.Join(", ", PrintArray(number)));

