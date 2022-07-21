using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вывод после конвертации " + GetNumber().ToString());
    }

    static int GetNumber()
    {
        bool isParse = false;
        int numberForReturn = 0;

        while (isParse == false)
        {
            Console.WriteLine("Введите число: ");
            string numberUser = Console.ReadLine();

            if (isParse = int.TryParse(numberUser, out int number))
            {
                Console.WriteLine("Ваше число преобразовано");
            }

            else
            {
                Console.WriteLine("Преобразование не удалось. Попробуйте ввести число без точек, запятых, скобочек и букв");
            }

            numberForReturn = number;
        }

        return numberForReturn;
    }
}
