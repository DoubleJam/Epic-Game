using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epic_Game
{
    class Enemy
    {
        string enemyName;
        int enemyHealth;
        int enemyDamage;
        int enemyCoins;
        int enemyExperience;

        public Enemy(string enemyName)
        {
            this.enemyName = enemyName;

            //Goblin
            if (enemyName == "Goblin")
            {
                enemyHealth = 80;
                enemyDamage = 2;//5
                enemyCoins = 10;
            }

            //Orc
            if (enemyName == "Orc")
            {
                enemyHealth = 120;
                enemyDamage = 3;//6
                enemyCoins = 20;
            }

            //Troll
            if (enemyName == "Drowzy Troll")
            {
                enemyHealth = 250;
                enemyDamage = 4;//8
                enemyCoins = 30;
            }

            //Calc exp
            enemyExperience = Convert.ToInt32(enemyHealth * 1); //0.25/0.20
        }

        public string getEnemyName()
        {
            return enemyName;
        }

        public int getEnemyHealth()
        {
            return enemyHealth;
        }

        public int getEnemyDamage()
        {
            return enemyDamage;
        }

        public int getEnemyMoney()
        {
            return enemyCoins;
        }

        public int getEnemyExperience()
        {
            return enemyExperience;
        }
    }
}
