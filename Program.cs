using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вывод после конвертации " + ConvertToInt().ToString());
    }

    static int ConvertToInt()
    {
        Console.WriteLine("Введите число: ");
        string numberUser = Console.ReadLine();
        bool isParse;
        int numberForReturn = 0;

        if (isParse = int.TryParse(numberUser, out int number))
        {
            Console.WriteLine("Ваше число преобразовано");
            numberForReturn = number;
        }

        else
        {
            Console.WriteLine("Преобразование не удалось. Попробуйте ввести число без точек, запятых, скобочек и букв");

            while (!isParse)
            {
                numberUser = Console.ReadLine();

                if(isParse = int.TryParse(numberUser, out int number1))
                {
                    Console.WriteLine("Ваше число преобразовано");
                }

                else
                {
                    Console.WriteLine("Преобразование не удалось. Попробуйте ввести число без точек, запятых, скобочек и букв");
                }

                numberForReturn = number1;
            }
            
        }
        return numberForReturn;
    }
}