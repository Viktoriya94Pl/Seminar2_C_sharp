double PowNumbers()
{
    Console.Write("Enter the first number: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    double b = double.Parse(Console.ReadLine());
    double result = Math.Pow(a, b);
    return result;
}
Console.WriteLine($"Otvet = {PowNumbers()}");


