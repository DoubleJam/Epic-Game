using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Epic_Game
{
    public partial class Launcher : Form
    {
        //Variables
        string saveText;
        string charName;
        string charRace;
        string charSex;
        string charOrigin;
        string tempRace;
        public Random rand = new Random();
        int nameGen;
        int nameOld = -1;

        //Randomized names
        string[] HumMan = new string[8];
        string[] HumFem = new string[8];
        string[] ElfMan = new string[8];
        string[] ElfFem = new string[8];
        string[] DwaMan = new string[8];
        string[] DwaFem = new string[8];
        string[] SauMan = new string[8];
        string[] SauFem = new string[8];

        List<string> originList = new List<string>();

        //Save file array
        public string[] loadLines = new string[17];

        public Launcher()
        {
            InitializeComponent();
            btnLoad.BringToFront();

            System.IO.Directory.CreateDirectory(@"..\Saves");

            HumMan[0] = "Mathil";   HumMan[1] = "Luin";     HumMan[2] = "Jorm";     HumMan[3] = "Jorgen";
            HumMan[4] = "Philyp";   HumMan[5] = "Tarnon";   HumMan[6] = "Ranian";   HumMan[7] = "Arley";
            HumFem[0] = "Brenhild"; HumFem[1] = "Janiel";   HumFem[2] = "Xerah";    HumFem[3] = "Sparrow";
            HumFem[4] = "Nessie";   HumFem[5] = "Yenn";     HumFem[6] = "Lufi";     HumFem[7] = "Hope";

            ElfMan[0] = "Gaelin";   ElfMan[1] = "Bithar";   ElfMan[2] = "Naewu";    ElfMan[3] = "Tae'il";
            ElfMan[4] = "Ros'il";   ElfMan[5] = "Ayluin";   ElfMan[6] = "Goll";     ElfMan[7] = "Alred";
            ElfFem[0] = "Qounen";   ElfFem[1] = "Ninleyn";  ElfFem[2] = "Nos'el";   ElfFem[3] = "Vys'el";
            ElfFem[4] = "Aerendyl"; ElfFem[5] = "Oacen";    ElfFem[6] = "Edraele";  ElfFem[7] = "Wynnter";

            DwaMan[0] = "Bronn";    DwaMan[1] = "Tin";      DwaMan[2] = "Eld";      DwaMan[3] = "Gerram";
            DwaMan[4] = "Ginec";    DwaMan[5] = "Kumrel";   DwaMan[6] = "Melrum";   DwaMan[7] = "Stronun";
            DwaFem[0] = "Jenros";   DwaFem[1] = "Gwandyl";  DwaFem[2] = "Maskros";  DwaFem[3] = "Sparrow";
            DwaFem[4] = "Jewel";    DwaFem[5] = "Shaffi";   DwaFem[6] = "Tyssora";  DwaFem[7] = "Dearres";

            SauMan[0] = "Fang";     SauMan[1] = "Sand";     SauMan[2] = "Rex";      SauMan[3] = "Draco";
            SauMan[4] = "Root";     SauMan[5] = "Jaw";      SauMan[6] = "Dash";     SauMan[7] = "Fetch";
            SauFem[0] = "Blood";    SauFem[1] = "Tooth";    SauFem[2] = "Sneak";    SauFem[3] = "Hunt";
            SauFem[4] = "Eye";      SauFem[5] = "Claw";     SauFem[6] = "Scale";    SauFem[7] = "Nest";
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            charName = tbxName.Text;
            charRace = cbxRace.Text;
            charSex = cbxSex.Text;
            charOrigin = cbxOrigin.Text;

            Form1 game = new Form1();
            game.playerName = charName;
            game.playerRace = charRace;
            game.playerSex = charSex;
            game.playerOrigin = charOrigin;
            game.loaded = false;

            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenSave = new OpenFileDialog();
            OpenSave.InitialDirectory = "C:\\Users\\Username\\Google Drive\\Visual Studio\\Skoj\\Epic Game\\Epic Game\\bin\\Saves";
            OpenSave.Filter = "Text Files|*.txt";
            OpenSave.Title = "Select Save";
            if (OpenSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(OpenSave.OpenFile()))
                {
                    saveText = reader.ReadToEnd();
                }

                loadLines = saveText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                Form1 game = new Form1();
                this.Hide();
                game.ShowDialog();
                game.loaded = true;
                this.Close();
            }
        }

        public string loadSaveInfo(int i)
        {
            return loadLines[i];
        }

        private void CharCreation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRace.SelectedIndex >= 0 && cbxSex.SelectedIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(tbxName.Text) == false
                && tbxName.Text.Contains(".") == false
                && tbxName.Text.Contains("<") == false
                && tbxName.Text.Contains(">") == false
                && tbxName.Text.Contains(":") == false
                && tbxName.Text.Contains('"') == false
                && tbxName.Text.Contains("/") == false
                && tbxName.Text.Contains("\\") == false
                && tbxName.Text.Contains("|") == false
                && tbxName.Text.Contains("?") == false
                && tbxName.Text.Contains("*") == false)
                //&& cbxOrigin.SelectedItem.ToString() != "")
                {
                    btnCreateChar.Enabled = true;
                }
                else
                {
                    btnCreateChar.Enabled = false;
                }

                btnRandomizeName.Enabled = true;
            }
            else
            {
                btnRandomizeName.Enabled = false;
            }

            if (cbxRace.SelectedIndex >= 0 && cbxRace.SelectedItem.ToString() != tempRace)
            {
                tempRace = cbxRace.SelectedItem.ToString();

                cbxOrigin.Items.Clear();
                if (cbxRace.SelectedItem.ToString() == "Human") //Human (?)
                {
                    originList.Add("Northerner");
                    originList.Add("Southerner");
                    originList.Add("Diplomats");
                }

                if (cbxRace.SelectedItem.ToString() == "Elf") //Elf (?)
                {
                    originList.Add("Wood Elf");
                    originList.Add("Ancient Elf");
                    originList.Add("Cursed Elf");
                }

                if (cbxRace.SelectedItem.ToString() == "Dwarf") //Dwarf (?)
                {
                    originList.Add("Obsidian");
                    originList.Add("Gemstone");
                    originList.Add("Undrowned");
                }

                if (cbxRace.SelectedItem.ToString() == "Saurian") //Saurian (?)
                {
                    originList.Add("Salamander");
                    originList.Add("Gecko");
                    originList.Add("Avian");
                }
                cbxOrigin.Items.Add(originList[0]);
                cbxOrigin.Items.Add(originList[1]);
                cbxOrigin.Items.Add(originList[2]);
                originList.Clear();
                cbxOrigin.SelectedItem = cbxOrigin.Items[0];
                cbxOrigin.Enabled = true;              
            }
        }

        public string loadCreateName()
        {
            return charName;
        }

        public string loadCreateRace()
        {
            return charRace;
        }

        public string loadCreateSex()
        {
            return charSex;
        }

        public string loadCreateOrigin()
        {
            return charOrigin;
        }

        private void btnRandomizeName_Click(object sender, EventArgs e)
        {
            nameGen = rand.Next(0, 8);
            do
            {
                nameGen = rand.Next(0, 8);
            } while (nameGen == nameOld);
            nameOld = nameGen;

            if (cbxRace.SelectedItem.ToString() == "Human")
            {
                if (cbxSex.SelectedItem.ToString() == "Male")
                {
                    tbxName.Text = HumMan[nameGen];
                }
                else
                {
                    tbxName.Text = HumFem[nameGen];
                }
            }

            else if (cbxRace.SelectedItem.ToString() == "Elf")
            {
                if (cbxSex.SelectedItem.ToString() == "Male")
                {
                    tbxName.Text = ElfMan[nameGen];
                }
                else
                {
                    tbxName.Text = ElfFem[nameGen];
                }
            }

            else if (cbxRace.SelectedItem.ToString() == "Dwarf")
            {
                if (cbxSex.SelectedItem.ToString() == "Male")
                {
                    tbxName.Text = DwaMan[nameGen];
                }
                else
                {
                    tbxName.Text = DwaFem[nameGen];
                }
            }

            else
            {
                if (cbxSex.SelectedItem.ToString() == "Male")
                {
                    tbxName.Text = SauMan[nameGen];
                }
                else
                {
                    tbxName.Text = SauFem[nameGen];
                }
            }

        }
    }
}
