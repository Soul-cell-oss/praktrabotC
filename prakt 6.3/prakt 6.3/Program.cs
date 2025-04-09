using System;

class CharArrayException : Exception
{
    public char[] Array { get; }

    public CharArrayException(int size) : base("Исключение с массивом символов")
    {
        Array = new char[size];
        for (int i = 0; i < size; i++)
            Array[i] = (char)('A' + i);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
                throw new ArgumentException("Размер должен быть положительным");

            throw new CharArrayException(size);
        }
        
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (CharArrayException ex)
        {
            Console.WriteLine($"Содержимое массива: {string.Join(" ", ex.Array)}");
        }
    }
}