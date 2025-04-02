using System;

public class EquationSolver
{

    public static int? Solve(int A, int B)
    {

        if (A == 0)
        {
            if (B == 0)
            {

                Console.WriteLine("Решение: любое целое число x является решением.");
                return null; 
            }
            else
            {

                Console.WriteLine("Нет решения, так как A = 0 и B ≠ 0.");
                return null;
            }
        }


        if (B % A == 0)
        {
            int x = B / A;
            return x;
        }
        else
        {
            Console.WriteLine("Нет целого решения, так как B не делится на A без остатка.");
            return null;
        }
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите значение A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение B:");
            int B = int.Parse(Console.ReadLine());

            int? solution = Solve(A, B);

            if (solution.HasValue)
            {
                Console.WriteLine($"Решение: x = {solution.Value}");
            }
            else
            {
                Console.WriteLine("Решение не найдено.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: необходимо ввести целое число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
