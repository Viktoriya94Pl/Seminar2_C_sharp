﻿void CreateThreeDementionArray(int[,,] array)
{
 int [] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
 int number;
 for (int i = 0; i < temp.GetLength(0); i++)
 {
    temp[i] = new Random().Next(10,100);
    number = temp[i];
    if (i >=1)
    {
        for (int j = 0; j < 1; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10,100);
                j = 0;
                number = temp[i];
            }
            number = temp[i];
        }
    }
 }
 int count = 0;
 for (int x = 0; x < array.GetLength(0); x++)
 {
    for (int y = 0; y < array.GetLength(1); y++)
    {
        for (int z = 0; z < array.GetLength(2); z++)
        {
            array[x,y,z] = temp[count];
            count++;
        }
    }
 }
}


string Input(string text)
{
 Console.WriteLine(text);
 return Console.ReadLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(0, 50);

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
void PrintThreeDementionArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"X({i}) Y({j}) Z({k}) = {array[i,j,k]}; ");
            }
        }

    }
}

void SortToLower (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) -1; k++)
            {
                if (array[i,k] < array[i, k +1])
            {
                (array[i,k], array[i,k + 1]) = (array[i, k +1], array[i, k]);
            }
            }
        }
    }
}

int FindSumString (int[,] array, int i)
{
    int sum = array[i,0];
     for (int j = 1; j < array.GetLength(1); j++)
    {
        sum+= array[i,j];
    }
    return sum;
}

void FindMinSum(int[,] array)
{
    int minSum = 0;
    int sum = FindSumString(array,0);
     for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = FindSumString(array,i);
        if (sum > tempSum)
        {
            sum = tempSum;
            minSum = i;
        }
    }
  Console.WriteLine($"\n{minSum + 1} - stroka s naimenshey summoy ({sum}) elementov");
}

void FindMatrixProduct (int [,] firstMatrix, int [,] secondMatrix, int[,] resultMatrix)

{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}



void Task54()
{
 int[,] array = new int [3,4];
 FillArray(array);
 PrintArray(array);
 SortToLower(array);
 Console.WriteLine("");
 PrintArray(array);
}

void Task56()
{
 int[,] array = new int [3,4];
 FillArray(array);
 PrintArray(array);
 FindSumString(array,1);
 FindMinSum(array);
}

void Task58()
{
 int[,] firstMatrix = new int [2,2];
 FillArray(firstMatrix);
 Console.WriteLine($"The first matrix is : ");
 PrintArray(firstMatrix);
 int[,] secondMatrix = new int [2,2];
 FillArray(secondMatrix );
 Console.WriteLine($"The second matrix is : ");
 PrintArray(secondMatrix );
 int[,] resultMatrix = new int [2,2];
 FindMatrixProduct(firstMatrix, secondMatrix, resultMatrix);
 Console.WriteLine($"The result matrix is : ");
 PrintArray(resultMatrix);

}

void Task60()
{
 int[,,] array = new int [2,2,2];
 CreateThreeDementionArray(array);
 PrintThreeDementionArray(array);

}

Task60();
