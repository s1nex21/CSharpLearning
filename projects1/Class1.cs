namespace CSlight
{
    internal class Functions
    {
        public static void PasswordCheker()
        {
            string correctPassword = "zxcghoul";
            int inputAttempts = 3;
            bool isCorrect = false;
            while (inputAttempts-- > 0 && !isCorrect)
            {
                Console.WriteLine("Введите пароль");
                string pasword = Console.ReadLine();
                if (pasword != correctPassword)
                {
                    Console.WriteLine($"Осталось {inputAttempts} попытки доказать что ты дота репер");
                    Console.WriteLine("Пароль не верный ты не дота репер");
                }
                else
                {
                    isCorrect = true;
                }
            }
            if (isCorrect)
            {
                Console.WriteLine("Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Папытки закончились не дота репер");
            }

            Console.ReadLine();
        }

        private static void WeigtInTargerine()
        {
            float tangerineWeight = 0.14f;
            Console.WriteLine("Введите ваш вес");
            int weight = Convert.ToInt32(Console.ReadLine());
            int humanWeightInTangerines = Convert.ToInt32(weight / tangerineWeight);
            Console.WriteLine($"Ваш вес в мандаринах: {humanWeightInTangerines} мандаринов");
            Console.ReadLine();
        }
    }
}
