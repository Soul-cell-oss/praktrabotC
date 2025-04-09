using System.Linq.Expressions;

class Program 
{

    static void Main()
    {

        try
        {

            Console.WriteLine("A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == 0)

            {
                Console.WriteLine(B == 0 ? "x любое" : "решений нет");
            }

            else

            {

                if (B % A == 0)
                {
                    Console.WriteLine($"x={B / A}");
                }


                else if (A % B == 0)
                {
                    Console.WriteLine($"x={A / B}");
                }

                else
                {
                    Console.WriteLine("Нет целого решения");
                }
            }
        }


        catch (FormatException)
        {
            Console.WriteLine("Введино не число ");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
        }
 
        }
    
    }

