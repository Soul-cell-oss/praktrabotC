using System;

public class Program
{

    public static void CheckNumber(int number)
    {
        if (number % 2 == 0)
        {
            throw new ArithmeticException("Четное число: " + number);
        }
        else
        {
            throw new OverflowException("Нечетное число: " + number);
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число (или любой другой символ для выхода):");
            string input = Console.ReadLine();


            if (int.TryParse(input, out int number))
            {
                try
                {
   
                    CheckNumber(number);
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

            }
            else
            {

                Console.WriteLine("Выход из программы.");
                break;
            }
        }
    }
}