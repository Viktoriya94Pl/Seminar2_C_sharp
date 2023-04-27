string Input(string text)
{
 Console.WriteLine(text);
 return Console.ReadLine();
}

void FillArrayKeyboart (double[] numbers)
{
 for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = Convert.ToInt32(Input($"Enter {i + 1} number: "));
  }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int CountNumber (double[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] > 0) count++;
  }
  return count;
}

double[] FindCrossingLines (double[] line1, double[] line2)
{
double[] coord = new double[2];
if (line1[1] == line2[1] && line1[0] == line2[0]) System.Console.WriteLine("Lines match");
else if (line1[1] == line2[1]) System.Console.WriteLine("Lines are parallel");
else 
{
coord[0] = (line1[0]-line2[0]) / (line2[1]-line1[1]);
coord[1] = line1[1] * coord[0] + line1[0];
}
return coord;
}

void Homework41()
{
 int size = Convert.ToInt32(Input("Введите длину массива: "));
 double[] numbers = new double[size];
 FillArrayKeyboart(numbers);
 Console.Write("Массив ");
 PrintArray(numbers);
 double count = CountNumber(numbers);
 Console.WriteLine($"Чисел больше 0 равно {count}");
}

void Homework43()
{
double[] line1 = new double[2];
FillArrayKeyboart(line1);
Console.Write("The line1 coordinate is: ");
PrintArray(line1);
double[] line2 = new double[2];
FillArrayKeyboart(line2);
Console.Write($"The line2 coordinate is: ");
PrintArray(line2);
double[] coord = FindCrossingLines(line1, line2);
Console.WriteLine($"The result of crossing two lines is ({coord[0]},{coord[1]})");
}

Homework43();
