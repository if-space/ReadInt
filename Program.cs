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
            int number = 0;
            bool isWork = false;

            while (isWork == false)
            {
                Console.WriteLine("Введите целое число: ");

                string userInput = Console.ReadLine();

                isWork = int.TryParse(userInput, out number);

                if (isWork == false)
                    Console.WriteLine("Некорректное число");
            }
            return number;
        }
    }
