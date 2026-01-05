
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace projects1
{
    internal class Fight
    {
        public static void StartFight()
        {
            int playerHealth = 100;
            int playerDamage =50;
            int enemyHealth = 100;
            int enemyDamage = 50;
            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " Kira");
                Console.WriteLine(enemyHealth + " L ");
            }
            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("ничья");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Kira победил!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("L победил! и съел пирог мисы");
            }
        }
    }
}


