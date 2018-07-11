using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epic_Game
{
    public class Attack
    {
        int atkChance;
        int atkType;    // 0=true; 1=phys; 2=fire; 3=cold; 4=strm
        double atkCalc;
        string atkText;
        string atkDesc;

        public Form1 game = new Form1();
        public Attack(string atkName)
        {
            //Scratch
            if (atkName == "Scratch")
            {
                atkChance = 8;
                atkType = 1;
                atkText = " scratches ";
                atkDesc = "Damage: ??\n Required Roll: 8\n A scratch will not cut very deep";

                atkCalc = (game.playerStr + game.weaponDamage) * 0.5;
            }

            //Stab
            if (atkName == "Stab")
            {
                atkChance = 12;
                atkType = 1;
                atkText = " stabs ";
                atkDesc = "Damage: ??\n Required Roll: 12\n Stab your opponents guts out";

                atkCalc = (game.playerStr + game.weaponDamage) * 1.0;
            }

            //Lunge
            if (atkName == "Lunge")
            {
                atkChance = 18;
                atkType = 1;
                atkText = " lunges at ";
                atkDesc = "Damage: ??\n Required Roll: 8\n Take a leap for some strong hits";

                atkCalc = (game.playerStr + game.weaponDamage) * 1.5;
            }

            //Breath Fire
            if (atkName == "Breath Fire")
            {
                atkChance = 14;
                atkType = 2;
                atkText = " scorches ";
                atkDesc = "Damage: ??\n Required Roll: 14\n Your breath smells like burning corpses";

                atkCalc = (game.playerCon + game.playerInt) * 1.0;
            }

            //Soul Breach
            if (atkName == "Soul Breach")
            {
                atkChance = 16;
                atkType = 0;
                atkText = " tears at the soul of ";
                atkDesc = "Damage: ??\n Required Roll: 16\n A bolt that goes right for their souls";

                atkCalc = ((game.playerInt * 2.0) - game.playerCon) * 1.5;
            }

            //Fireball
            if (atkName == "Fireball")
            {
                atkChance = 10;
                atkType = 2;
                atkText = " burns ";
                atkDesc = "Damage: ??\n Required Roll: 14\n A small bolt of fire";

                atkCalc = (game.playerInt) * 1.0;
            }

            //Shoot
            if (atkName == "Shoot")
            {
                atkChance = 10;
                atkType = 1;
                atkText = " shoots at ";
                atkDesc = "Damage: ??\n Required Roll: 14\n Discharge a projectile at your opponent";

                atkCalc = ((game.playerDex * 0.5) + game.weaponDamage) * 1.0;
            }
        }

        public int getAttackChance()
        {
            return atkChance;
        }

        public double getAttackCalc()
        {
            return atkCalc;
        }

        public string getAttackText()
        {
            return atkText;
        }
    }
}
