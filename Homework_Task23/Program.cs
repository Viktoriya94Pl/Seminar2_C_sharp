void PowNumbers(int number)
{
    for (int y = 1; y <= number; y++)
    Console.WriteLine(Math.Pow(y, 3));

}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
PowNumbers(number);

