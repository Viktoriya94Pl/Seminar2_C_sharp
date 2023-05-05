
string Input(string text)
{
 Console.WriteLine(text);
 return Console.ReadLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = new Random().Next(0, 50);

      }
      
    }

}

void FillArrayWithReal(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = rnd.NextDouble() * 100;

}

void CheckThePosition(int[,] array, int n, int m)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
      Console.WriteLine("You are out of array");
    } else {
    Console.WriteLine($"The element of the line {n}, te row {m} is {array[n-1,m-1]}");
    }
}


void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }

}

void PrintArrayWithReal(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]:F2} ");
        }
        System.Console.WriteLine();

    }
}

void FindAverage(int[,] array)
{
     for (int j = 0; j < array.GetLength(1); j++)
     {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
             average += array[i, j];
        }
             average = average / array.GetLength(0);
             System.Console.Write($"Average is {average:F2}");
             System.Console.WriteLine();
        }
}

void Homework47 ()
{
 int size1 = Convert.ToInt32(Input("Введите длину массива: "));
 int size2 = Convert.ToInt32(Input("Введите длину массива: "));
 double[,] array = new double[size1, size2];
 FillArrayWithReal(array);
 PrintArrayWithReal(array);
}

void Homework50 ()
{
 int n = Convert.ToInt32(Input("Enter the line number: "));
 int m = Convert.ToInt32(Input("Enter the row number: "));
 int[,] array = new int[10, 10];
 FillArray(array);
 PrintArray(array);
 CheckThePosition(array,n,m);

 
}

void Homework52 ()
{
 int[,] array = new int[3, 4];
 FillArray(array);
 PrintArray(array);
 FindAverage(array);
 
}


Homework52();

