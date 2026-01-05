using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;

namespace elachkatebenravitsa
{
    internal class Elka
    {
        public static void Draw(int height)
        {
            if (height < 5 || height > 20)
            {
                Console.WriteLine("Высота должна быть от 5 до 10");
                return;
            }
            for (int i = 0; i < height; i++)
            {
                int spacesCount;
                int symbolCount;
                if (height == i + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    symbolCount = height / 3 + 1;
                    int maxWidth = height * 2 - 2;
                    spacesCount = (maxWidth - symbolCount) / 2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    symbolCount = 1 + i * 2;
                    spacesCount = height - 2 - i;
                }
                string spaces = new String(' ', spacesCount);
                Console.Write(spaces);
                string text = new String('*', symbolCount);
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}