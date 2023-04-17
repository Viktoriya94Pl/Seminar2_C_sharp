 int CntNumber(int number)
 {
    int count = Convert.ToString(number).Length;
    int result = 0;
     for (int i = 0; i < count; i++)
     {
        result += number % 10;
        number /= 10;

     }
     return result;
 }

 Console.Write("Enter the number: ");
 int number = int.Parse(Console.ReadLine());
 Console.WriteLine("Summa is: {0} ", CntNumber(number));





