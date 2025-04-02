using System;

public class CustomException : Exception
{

    public char[] CharArray { get; private set; }


    public CustomException(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Размер массива должен быть положительным.");
        }

        CharArray = new char[size];


        for (int i = 0; i < size; i++)
        {
            CharArray[i] = (char)('A' + i);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {

            CustomException customException = new CustomException(26); 


            throw customException;
        }
        catch (CustomException ex)
        {

            Console.WriteLine("Содержимое символьного массива:");
            Console.WriteLine(string.Join(", ", ex.CharArray));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
