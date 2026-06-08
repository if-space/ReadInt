using System;

namespace Lessons
{
    class Programm
    {
        static void Main(string[] args)
        {
            int currentValue = GetIntegerFromUser();

            Console.WriteLine($"Все успешно: {currentValue}");
        }

        static int GetIntegerFromUser()
        {
            while (true)
            {
                Console.WriteLine("Введите целое число: ");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))
                    return number;
                else
                    Console.WriteLine("Введено некорректное число");
            }
        }
    }
}