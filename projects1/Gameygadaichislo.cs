using System;
using System.Collections.Generic;
using System.Text;

namespace projects1
{
    internal class Gameygadaichislo
    {
        public static void StartGame()
        {
            int number;
            int lower, higgher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();
            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higgher = rand.Next(number + 1, number + 10);
            Console.WriteLine($"Я загодал число от 1 до 100 докажи что ты не иван золкин, оно больше чем {lower}, " +
                $"но меньше чем {higgher}");
            Console.WriteLine($"Что это за число? у тебя {triesCount} попыток доказать что ты не иван золкин.");

            while (triesCount-- > 0)
            {
                Console.WriteLine("Гани Ответ:");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Поздровляем! Ты не иван золкин. Это было число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("НЕ ВЕРНО");
                }
            }

            if (triesCount < 0)
            {
                Console.WriteLine("Увы но ты иван золкин это было число " + number + ".");
            }


        }
    }
}
