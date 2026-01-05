using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CSlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            projects1.Gameygadaichislo.StartGame();
        }

        static void BarFacer()
        {
            int age;
            Console.WriteLine("Добро пожаловать в наш молочный бар!");
            Console.WriteLine("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age < 100)
            {
                Console.WriteLine("Скажите ваше имя");
                string? name = Console.ReadLine();
                if (name == "валя" || name == "Валя" || name == "Валентина" || name == "валентина")
                {
                    Console.WriteLine("сюда вход только котикам вы пес");
                }
                else
                {
                    Console.WriteLine("Какое молочко будете пить?");
                    Console.WriteLine("у нас есть кислое, сладкое и горькое ");
                    string? drinkName = Console.ReadLine();
                    switch (drinkName)
                    {

                        case "сладкое":
                            Console.WriteLine("хороший выбор!");
                            break;
                        case "горькое":
                            Console.WriteLine("Да вы любтель по крепе!");
                            break;
                        case "кислое":
                            Console.WriteLine("Да вы гурман!");
                            break;
                        default:
                            Console.WriteLine("такого молочка у нас нет;(");
                            break;

                    }
                }
            }
            else if (age >= 100)
            {
                Console.WriteLine("вам нельзя молочко ваше сердечко не выдержит:(");
            }
            else
            {
                Console.WriteLine("Ты слишком молод! ты не можешь пить молочко:(");
                Console.WriteLine($"Молочко будет доступно через: {18 - age} лет ");
            }
            Console.ReadLine();
        }
    }
}

