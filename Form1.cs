using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epic_Game
{
    public partial class Form1 : Form
    {
        //Definera spelare och motståndare
        public string attacker;
        public string defender;

        //Spelarens stats
        public string playerName;
        public string playerRace;
        public string playerSex;
        public string playerOrigin;
        public int playerHealth = 69;
        public int playerMaxHealth = 420;
        public int playerCrowns = 0;
        public int playerExperience = 0;
        public int playerReqExperience = 100;
        public int playerLevel = 1;
        public int playerAttributePoints = 0;
        public int playerStr = 10;
        public int playerCon = 10;
        public int playerDex = 10;
        public int playerInt = 10;

        //Utrustning stats
        public string weaponName = "Claymore";
        public int weaponDamage = 999;

        //Fiendens stats
        public string enemyName;
        public int enemyHealth;
        public int enemyMaxHealth;
        public int enemyDamage;
        public int enemyCrowns;
        public int enemyExperience;

        //Vilka fiender kan bli hittade
        public string location = "Forest";
        public string[] possibleEnemies = new string[2];

        //Övriga variabler
        public bool playerTurn = true;
        public bool loaded; //-true
        public Random rand = new Random();
        public int explore;
        public int exploreVal;
        public int expReq = 100;
        int atkRoll;
        int[] atkChance = new int[3];
        double[] atkCalc = new double[3];
        string[] atkText = new string[3];
        string atkName;
        double realAtkCalc;
        int bestAtk;
        string[] saveLines = new string[17];
        string[] loadedLines = new string[17];

        string[] attackLoaded = new string[3];

        List<string> attacksList = new List<string>();

        //public int healthTick = 0;

        public Form1()
        {
            InitializeComponent();

            var launcherFrm = Application.OpenForms["Launcher"] as Launcher;
            if (launcherFrm == null)
            {
                launcherFrm = new Launcher();
                launcherFrm.Show();
            }
            playerName = launcherFrm.loadCreateName();
            playerRace = launcherFrm.loadCreateRace();
            playerSex = launcherFrm.loadCreateSex();
            playerOrigin = launcherFrm.loadCreateOrigin();
            playerHealth = 100 + (playerCon * 10);

            if (string.IsNullOrWhiteSpace(playerName) == true)
            {
                for (int i = 0; i <= (launcherFrm.loadLines.Count() - 2); i++)
                {
                    loadedLines[i] = launcherFrm.loadSaveInfo(i);
                }
                playerName = loadedLines[0];
                playerSex = loadedLines[1];
                playerOrigin = loadedLines[2];
                playerLevel = Convert.ToInt32(loadedLines[3]);
                playerExperience = Convert.ToInt32(loadedLines[4]);
                playerReqExperience = Convert.ToInt32(loadedLines[5]);  //Kolla på load istället?
                playerHealth = Convert.ToInt32(loadedLines[6]);
                playerMaxHealth = Convert.ToInt32(loadedLines[7]);      //Kolla på load istället?
                playerCrowns = Convert.ToInt32(loadedLines[8]);
                playerStr = Convert.ToInt32(loadedLines[9]);
                playerCon = Convert.ToInt32(loadedLines[10]);
                playerDex = Convert.ToInt32(loadedLines[11]);
                playerInt = Convert.ToInt32(loadedLines[12]);
                playerAttributePoints = Convert.ToInt32(loadedLines[13]);
                lbxAttacksActive.Items.Add(loadedLines[14]);
                attacksList.Add(loadedLines[14]);
                lbxAttacksActive.Items.Add(loadedLines[15]);
                attacksList.Add(loadedLines[15]);
                lbxAttacksActive.Items.Add(loadedLines[16]);
                attacksList.Add(loadedLines[16]);

                //Ladda Attacklista
                if (attacksList.Contains("Scratch") == false)
                {
                    lbxAttacksInactive.Items.Add("Scratch");
                }

                if (attacksList.Contains("Stab") == false)
                {
                    lbxAttacksInactive.Items.Add("Stab");
                }

                if (attacksList.Contains("Lunge") == false)
                {
                    lbxAttacksInactive.Items.Add("Lunge");
                }

                if (attacksList.Contains("Breath Fire") == false)
                {
                    lbxAttacksInactive.Items.Add("Breath Fire");
                }

                if (attacksList.Contains("Soul Breach") == false)
                {
                    lbxAttacksInactive.Items.Add("Soul Breach");
                }

                if (attacksList.Contains("Breath Fire") == false)
                {
                    lbxAttacksInactive.Items.Add("Breath Fire");
                }

                if (attacksList.Contains("Fireball") == false)
                {
                    lbxAttacksInactive.Items.Add("Fireball");
                }

                if (attacksList.Contains("Shoot") == false)
                {
                    lbxAttacksInactive.Items.Add("Shoot");
                }
            }
            else
            {
                //Ny Attacklista
                lbxAttacksActive.Items.Add("Scratch");
                attacksList.Add("Scratch");
                lbxAttacksActive.Items.Add("Stab");
                attacksList.Add("Stab");
                lbxAttacksActive.Items.Add("Lunge");
                attacksList.Add("Lunge");
                lbxAttacksInactive.Items.Add("Breath Fire");
                lbxAttacksInactive.Items.Add("Soul Breach");
                lbxAttacksInactive.Items.Add("Fireball");
                lbxAttacksInactive.Items.Add("Shoot");
            }

            launcherFrm.Hide();

            cbxLocation.SelectedIndex = 0;
            updatePlayer();
            createWeapon(weaponName);

            lblEnemy.Text = "";
            lblEnemyHP.Text = "";
            lblEnemyCoins.Text = "";                     
        }

        private void createWeapon(string name)
        {
            Item item = new Item(weaponName);
            weaponDamage = item.getItemPower();
        }

        private void tmrTurn_Tick(object sender, EventArgs e)
        {
            //Slåss
            if (explore <= 1)
            {
                if (playerTurn == true)
                {
                    attacker = playerName;
                    defender = enemyName;
                    playerTurn = false;

                    atkRoll = rand.Next(0, (11 + playerDex));

                    //Miss          
                    realAtkCalc = 0;
                    atkName = " misses ";
                    
                    //Attack 0
                    if (atkRoll >= atkChance[0])
                    {
                        realAtkCalc= atkCalc[0];
                        atkName = atkText[0];
                        bestAtk = atkChance[0];
                    }

                    //Attack 1
                    if (atkRoll >= atkChance[1] && atkChance[1] > bestAtk)
                    {
                        realAtkCalc = atkCalc[1];
                        atkName = atkText[1];
                        bestAtk = atkChance[1];
                    }

                    //Attack 2
                    if (atkRoll >= atkChance[2] && atkChance[2] > bestAtk)
                    {
                        realAtkCalc = atkCalc[2];
                        atkName = atkText[2];
                        bestAtk = atkChance[2];
                    }

                    //Kalkylera skada           
                    int damCalc = Convert.ToInt32(realAtkCalc);
                    enemyHealth -= damCalc;

                    lblEnemyHP.Text = enemyHealth.ToString() + "/" + enemyMaxHealth.ToString() + " HP";
                    if (atkName != " misses ")
                    {
                        lbxEvents.Items.Add(attacker + atkName + defender + " for " + damCalc + " damage");
                    }
                    else
                    {
                        lbxEvents.Items.Add(attacker + atkName + defender);
                    }
                    lbxEvents.TopIndex = lbxEvents.Items.Count - 1;

                    //Spelaren vinner
                    if (enemyHealth <= 0)
                    {
                        //Få pengar
                        playerCrowns += enemyCrowns;

                        //Få exp
                        playerExperience += enemyExperience;

                        updatePlayer();
                        lbxEvents.Items.Add(enemyName + " has been defeated. You gained " + enemyExperience + " exp and " + enemyCrowns + " crowns.");
                        playerTurn = true;
                        btnExplore.Enabled = true;
                        if (playerAttributePoints > 0)
                        {
                            btnUpgradeStr.Visible = true;
                            btnUpgradeCon.Visible = true;
                            btnUpgradeDex.Visible = true;
                            btnUpgradeInt.Visible = true;
                        }
                        tmrTurn.Stop();
                    }
                }
                else
                {
                    attacker = enemyName;
                    defender = playerName;
                    playerTurn = true;

                    playerHealth -= enemyDamage;

                    lblPlayerHP.Text = playerHealth.ToString() + "/" + playerMaxHealth + " HP";
                    lbxEvents.Items.Add(attacker + " deals " + enemyDamage + " damage to " + defender);
                    lbxEvents.TopIndex = lbxEvents.Items.Count - 1;

                    //Spelaren dör
                    if (playerHealth <= 0)
                    {
                        lbxEvents.Items.Add(playerName + " has died!");
                        playerTurn = true;
                        btnExplore.Enabled = true;
                        tmrTurn.Stop();
                    }
                }      
            }

            else if (explore == 2)
            {
                //Hitta crowns
                exploreVal = rand.Next(10, 21);
                playerCrowns += exploreVal;

                updatePlayer();
                lbxEvents.Items.Add(playerName + " found " + exploreVal + " Crowns on the ground.");
                btnExplore.Enabled = true;
                tmrTurn.Stop();
            }
            else
            {
                //Hitta exp
                exploreVal = rand.Next(10, 21);
                playerExperience += exploreVal;

                updatePlayer();
                lbxEvents.Items.Add(playerName + " did some jumping jacks and gained " + exploreVal + " experience points.");
                btnExplore.Enabled = true;
                tmrTurn.Stop();
            }
            lbxEvents.TopIndex = lbxEvents.Items.Count - 1;
        }

        private void createEnemy(string name)
        {
            //Skapa fiender
            Enemy enemy = new Enemy(name);
            enemyName = enemy.getEnemyName();
            enemyHealth = enemy.getEnemyHealth();
            enemyMaxHealth = enemyHealth;
            enemyDamage = enemy.getEnemyDamage();
            enemyCrowns = enemy.getEnemyMoney();
            enemyExperience = enemy.getEnemyExperience();

            //Skapa fienders text
            lblEnemy.Text = enemyName;
            lblEnemyHP.Text = enemyHealth.ToString() + "/" + enemyMaxHealth.ToString();
            lblEnemyCoins.Text = "Crowns: " + enemyCrowns.ToString();
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            //Utforska
            explore = rand.Next(0, 4);
            if (explore <= 1)
            {
                //Slåss
                location = cbxLocation.Text;
                if (location == "Forest")
                {
                    possibleEnemies[0] = "Goblin";
                    possibleEnemies[1] = "Orc";
                }
                else if (location == "Mountain")
                {
                    possibleEnemies[0] = "Drowzy Troll";
                    possibleEnemies[1] = "Drowzy Troll";
                }

                //Skapa fiender
                createEnemy(possibleEnemies[rand.Next(0, 2)]);

                //Ladda attacker
                loadAttacks();              
            }
            else
            {
                lblEnemy.Text = "";
                lblEnemyHP.Text = "";
                lblEnemyCoins.Text = "";
            }

            //Stäng av knappar
            btnExplore.Enabled = false;
            btnReplaceAttacks.Enabled = false;
            btnUpgradeStr.Visible = false;
            btnUpgradeCon.Visible = false;
            btnUpgradeDex.Visible = false;
            btnUpgradeInt.Visible = false;

            //Skapa timern
            tmrTurn.Enabled = true;
        }

        private void updatePlayer()
        {
            //Uppdatera spelarens stats
            playerMaxHealth = 100 + (playerCon * 10);

            //Levla upp
            if (playerExperience >= playerReqExperience)
            {
                if (playerLevel < 10)
                {
                    playerLevel++;
                    playerAttributePoints += 2;

                    //Återställ exp
                    playerExperience = playerExperience - playerReqExperience;
                    playerReqExperience = Convert.ToInt32((playerReqExperience + 20) * 1.5);
                    //playerReqExperience = (playerReqExperience - 20) * 2;

                    //Uppdatera hp
                    playerHealth = playerMaxHealth;
                }
            }

            //Explore meny
            lblPlayer.Text = playerName + " Lv." + playerLevel;
            lblPlayerHP.Text = playerHealth.ToString() + "/" + playerMaxHealth.ToString() + " HP";
            lblPlayerExperience.Text = playerExperience + "/" + playerReqExperience + " EXP";
            lblPlayerCrowns.Text = "Crowns: " + playerCrowns.ToString();

            //Inventory meny

            //Character meny
            lblCharPlayer.Text = playerName + " Lv." + playerLevel;

            if (playerAttributePoints > 0)
            {
                lblCharUnspentAtr.Text = playerAttributePoints.ToString() + " Unspent Attribution Points";
            }
            else
            {
                lblCharUnspentAtr.Text = "";
            }

            //Uppdatera värden på "Attributes"
            lbxAttributeValues.Items.Clear();
            lbxAttributeValues.Items.Add(playerStr);
            lbxAttributeValues.Items.Add(playerCon);
            lbxAttributeValues.Items.Add(playerDex);
            lbxAttributeValues.Items.Add(playerInt);

            //Uppdatera knappar för "Attributes"
            if (playerAttributePoints > 0)
            {
                btnUpgradeStr.Visible = true;
                btnUpgradeCon.Visible = true;
                btnUpgradeDex.Visible = true;
                btnUpgradeInt.Visible = true;
            }

            else
            {
                btnUpgradeStr.Visible = false;
                btnUpgradeCon.Visible = false;
                btnUpgradeDex.Visible = false;
                btnUpgradeInt.Visible = false;
            }
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lista på platser
            location = cbxLocation.Text;

            if (location == "Forest")
            {
                lblEnemyLvl.Text = "Enemies lvl 2-3";
            }

            if (location == "Mountain")
            {
                lblEnemyLvl.Text = "Enemies lvl 4";
            }
        }

        private void btnUpgradeStr_Click(object sender, EventArgs e)
        {
            playerStr++;
            playerAttributePoints--;
            updatePlayer();
        }

        private void btnUpgradeCon_Click(object sender, EventArgs e)
        {
            playerCon++;
            playerAttributePoints--;
            updatePlayer();
            playerHealth = playerMaxHealth;
            lblPlayerHP.Text = playerHealth.ToString() + "/" + playerMaxHealth.ToString() + " HP";
        }

        private void btnUpgradeDex_Click(object sender, EventArgs e)
        {
            playerDex++;
            playerAttributePoints--;
            updatePlayer();
        }

        private void btnUpgradeInt_Click(object sender, EventArgs e)
        {
            playerInt++;
            playerAttributePoints--;
            updatePlayer();
        }

        private void btnReplaceAttacks_Click(object sender, EventArgs e)
        {
            lbxAttacksActive.Items.Add(lbxAttacksInactive.SelectedItem.ToString());
            attacksList.Add(lbxAttacksInactive.SelectedItem.ToString());
            lbxAttacksInactive.Items.Remove(lbxAttacksInactive.SelectedItem.ToString());

            lbxAttacksInactive.Items.Add(lbxAttacksActive.SelectedItem.ToString());
            attacksList.Remove(lbxAttacksActive.SelectedItem.ToString());
            lbxAttacksActive.Items.Remove(lbxAttacksActive.SelectedItem.ToString());
        }

        private void lbxAttacksInactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAttacksInactive.SelectedIndex == -1 || lbxAttacksActive.SelectedIndex == -1 && tmrTurn.Enabled == false)
            {
                btnReplaceAttacks.Enabled = false;
            }

            else
            {
                btnReplaceAttacks.Enabled = true;
            }
        }

        private void lbxAttacksActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAttacksInactive.SelectedIndex == -1 || lbxAttacksActive.SelectedIndex == -1)
            {
                btnReplaceAttacks.Enabled = false;
            }

            else
            {
                btnReplaceAttacks.Enabled = true;
            }
        }

        private void tmrSave_Tick(object sender, EventArgs e)
        {
            saveLines[0] = playerName.ToString();
            saveLines[1] = playerSex.ToString();
            saveLines[2] = playerOrigin.ToString();
            saveLines[3] = playerLevel.ToString();
            saveLines[4] = playerExperience.ToString();
            saveLines[5] = playerReqExperience.ToString();  //Kolla på load istället?
            saveLines[6] = playerHealth.ToString();
            saveLines[7] = playerMaxHealth.ToString();      //Kolla på load istället?
            saveLines[8] = playerCrowns.ToString();
            saveLines[9] = playerStr.ToString();
            saveLines[10] = playerCon.ToString();
            saveLines[11] = playerDex.ToString();
            saveLines[12] = playerInt.ToString();
            saveLines[13] = playerAttributePoints.ToString();
            saveLines[14] = attacksList[0].ToString();
            saveLines[15] = attacksList[1].ToString();
            saveLines[16] = attacksList[2].ToString();
            System.IO.File.WriteAllLines(@"..\Saves\autosave.txt", saveLines);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveLines[0] = playerName.ToString();
            saveLines[1] = playerSex.ToString();
            saveLines[2] = playerOrigin.ToString();
            saveLines[3] = playerLevel.ToString();
            saveLines[4] = playerExperience.ToString();
            saveLines[5] = playerReqExperience.ToString();  //Kolla på load istället?
            saveLines[6] = playerHealth.ToString();
            saveLines[7] = playerMaxHealth.ToString();      //Kolla på load istället?
            saveLines[8] = playerCrowns.ToString();
            saveLines[9] = playerStr.ToString();
            saveLines[10] = playerCon.ToString();
            saveLines[11] = playerDex.ToString();
            saveLines[12] = playerInt.ToString();
            saveLines[13] = playerAttributePoints.ToString();
            saveLines[14] = attacksList[0].ToString();
            saveLines[15] = attacksList[1].ToString();
            saveLines[16] = attacksList[2].ToString();
            System.IO.File.WriteAllLines(@"..\Saves\save" + playerName + ".txt", saveLines);
        }

        private void loadAttacks()
        {
            for (int i = 0; i < 3; i++)
            {
                attackLoaded[i] = attacksList[i];

                Attack attack = new Attack(attackLoaded[i]);

                atkChance[i] = attack.getAttackChance();
                atkCalc[i] = attack.getAttackCalc();
                atkText[i] = attack.getAttackText();
            }
        }
    }
}
