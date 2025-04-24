using System;

class Program
{
    delegate double QuadraticFunction(double x);

    static QuadraticFunction GetQuadraticFunction(double a, double b, double c)
    {
        return x => a * x * x + b * x + c;
    }

    static void Main()
    {
        // Пример использования
        var quadFunc = GetQuadraticFunction(1, 2, 1); // x² + 2x + 1

        Console.WriteLine(quadFunc(0)); // 1
        Console.WriteLine(quadFunc(1)); // 4
        Console.WriteLine(quadFunc(2)); // 9
    }
}