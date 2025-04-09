using System;

void CheckNumber(int number)
{
    if (number % 2 == 0)
        throw new ArithmeticException("Чётное число");
    else
        throw new OverflowException("Нечётное число");
}


while (true)
{
    try
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        try
        {
            CheckNumber(num);
        }

        catch (OverflowException ex)
        {
            Console.WriteLine("число нечётное");
        }

        catch (ArithmeticException ex)
        {
            Console.WriteLine("число чётное");
        }
      
    }
    catch (FormatException)
    {
        Console.WriteLine("Выход из программы");
        break;
    }
}
