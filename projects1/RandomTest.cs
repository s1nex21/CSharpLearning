using System;
using System.Collections.Generic;
using System.Text;

namespace projects1
{
    internal class RandomTest
    {
        public static void Randomaizer()
        {
            Random rand = new Random();
            int value;

            while (true)
            {
                value = rand.Next(0, 999999999 );
                Console.WriteLine(value);
                Console.ReadKey();
            }
        }
    }
}
