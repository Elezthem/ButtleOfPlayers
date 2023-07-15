using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 10000;
            int playerDamage = 3;
            int enemyHealth = 15000;
            int enemyDamage = 1;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " игрок.");
                Console.WriteLine(enemyHealth + " враг.");
            }

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Победа врага.");
            }
        }
    }
}