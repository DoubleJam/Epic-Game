namespace Epic_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEnemyCoins = new System.Windows.Forms.Label();
            this.lblEnemyLvl = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.lblPlayerCrowns = new System.Windows.Forms.Label();
            this.btnExplore = new System.Windows.Forms.Button();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lbxEvents = new System.Windows.Forms.ListBox();
            this.lblPlayerExperience = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbxCharacter = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpgradeInt = new System.Windows.Forms.Button();
            this.btnUpgradeDex = new System.Windows.Forms.Button();
            this.btnUpgradeCon = new System.Windows.Forms.Button();
            this.btnUpgradeStr = new System.Windows.Forms.Button();
            this.lbxAttributeValues = new System.Windows.Forms.ListBox();
            this.lbxAttributePoints = new System.Windows.Forms.ListBox();
            this.lblCharUnspentAtr = new System.Windows.Forms.Label();
            this.lblCharPlayer = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lbxAttacksDesc = new System.Windows.Forms.ListBox();
            this.btnReplaceAttacks = new System.Windows.Forms.Button();
            this.lblAttacksInactive = new System.Windows.Forms.Label();
            this.lblAttacksActive = new System.Windows.Forms.Label();
            this.lbxAttacksInactive = new System.Windows.Forms.ListBox();
            this.lbxAttacksActive = new System.Windows.Forms.ListBox();
            this.tmrSave = new System.Windows.Forms.Timer(this.components);
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 1500;
            this.tmrTurn.Tick += new System.EventHandler(this.tmrTurn_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEnemyCoins);
            this.tabPage1.Controls.Add(this.lblEnemyLvl);
            this.tabPage1.Controls.Add(this.cbxLocation);
            this.tabPage1.Controls.Add(this.lblPlayerCrowns);
            this.tabPage1.Controls.Add(this.btnExplore);
            this.tabPage1.Controls.Add(this.lblEnemyHP);
            this.tabPage1.Controls.Add(this.lbxEvents);
            this.tabPage1.Controls.Add(this.lblPlayerExperience);
            this.tabPage1.Controls.Add(this.lblPlayer);
            this.tabPage1.Controls.Add(this.lblEnemy);
            this.tabPage1.Controls.Add(this.lblPlayerHP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Explore";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEnemyCoins
            // 
            this.lblEnemyCoins.Location = new System.Drawing.Point(276, 49);
            this.lblEnemyCoins.Name = "lblEnemyCoins";
            this.lblEnemyCoins.Size = new System.Drawing.Size(72, 13);
            this.lblEnemyCoins.TabIndex = 8;
            this.lblEnemyCoins.Text = "(enemy coins)";
            this.lblEnemyCoins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEnemyLvl
            // 
            this.lblEnemyLvl.AutoSize = true;
            this.lblEnemyLvl.Location = new System.Drawing.Point(189, 189);
            this.lblEnemyLvl.Name = "lblEnemyLvl";
            this.lblEnemyLvl.Size = new System.Drawing.Size(78, 13);
            this.lblEnemyLvl.TabIndex = 10;
            this.lblEnemyLvl.Text = "Enemies lvl 5-8";
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Items.AddRange(new object[] {
            "Forest",
            "Mountain"});
            this.cbxLocation.Location = new System.Drawing.Point(12, 185);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(171, 21);
            this.cbxLocation.TabIndex = 7;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // lblPlayerCrowns
            // 
            this.lblPlayerCrowns.AutoSize = true;
            this.lblPlayerCrowns.Location = new System.Drawing.Point(12, 49);
            this.lblPlayerCrowns.Name = "lblPlayerCrowns";
            this.lblPlayerCrowns.Size = new System.Drawing.Size(78, 13);
            this.lblPlayerCrowns.TabIndex = 6;
            this.lblPlayerCrowns.Text = "(player crowns)";
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(273, 184);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 8;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.Location = new System.Drawing.Point(276, 22);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(76, 13);
            this.lblEnemyHP.TabIndex = 2;
            this.lblEnemyHP.Text = "(enemy health)";
            this.lblEnemyHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbxEvents
            // 
            this.lbxEvents.FormattingEnabled = true;
            this.lbxEvents.Location = new System.Drawing.Point(12, 71);
            this.lbxEvents.Name = "lbxEvents";
            this.lbxEvents.Size = new System.Drawing.Size(336, 108);
            this.lbxEvents.TabIndex = 5;
            // 
            // lblPlayerExperience
            // 
            this.lblPlayerExperience.AutoSize = true;
            this.lblPlayerExperience.Location = new System.Drawing.Point(12, 36);
            this.lblPlayerExperience.Name = "lblPlayerExperience";
            this.lblPlayerExperience.Size = new System.Drawing.Size(96, 13);
            this.lblPlayerExperience.TabIndex = 7;
            this.lblPlayerExperience.Text = "(player experience)";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(92, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "(player name + lvl)";
            // 
            // lblEnemy
            // 
            this.lblEnemy.Location = new System.Drawing.Point(276, 9);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(76, 13);
            this.lblEnemy.TabIndex = 1;
            this.lblEnemy.Text = "(enemy name)";
            this.lblEnemy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Location = new System.Drawing.Point(12, 22);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(73, 13);
            this.lblPlayerHP.TabIndex = 3;
            this.lblPlayerHP.Text = "(player health)";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(7, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(369, 238);
            this.tabControl.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbxCharacter);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Controls.Add(this.btnUpgradeInt);
            this.tabPage3.Controls.Add(this.btnUpgradeDex);
            this.tabPage3.Controls.Add(this.btnUpgradeCon);
            this.tabPage3.Controls.Add(this.btnUpgradeStr);
            this.tabPage3.Controls.Add(this.lbxAttributeValues);
            this.tabPage3.Controls.Add(this.lbxAttributePoints);
            this.tabPage3.Controls.Add(this.lblCharUnspentAtr);
            this.tabPage3.Controls.Add(this.lblCharPlayer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(361, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Character";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbxCharacter
            // 
            this.lbxCharacter.FormattingEnabled = true;
            this.lbxCharacter.Location = new System.Drawing.Point(178, 9);
            this.lbxCharacter.Name = "lbxCharacter";
            this.lbxCharacter.Size = new System.Drawing.Size(170, 160);
            this.lbxCharacter.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpgradeInt
            // 
            this.btnUpgradeInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgradeInt.Location = new System.Drawing.Point(131, 76);
            this.btnUpgradeInt.Name = "btnUpgradeInt";
            this.btnUpgradeInt.Size = new System.Drawing.Size(15, 15);
            this.btnUpgradeInt.TabIndex = 3;
            this.btnUpgradeInt.UseVisualStyleBackColor = true;
            this.btnUpgradeInt.Click += new System.EventHandler(this.btnUpgradeInt_Click);
            // 
            // btnUpgradeDex
            // 
            this.btnUpgradeDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgradeDex.Location = new System.Drawing.Point(131, 60);
            this.btnUpgradeDex.Name = "btnUpgradeDex";
            this.btnUpgradeDex.Size = new System.Drawing.Size(15, 15);
            this.btnUpgradeDex.TabIndex = 2;
            this.btnUpgradeDex.UseVisualStyleBackColor = true;
            this.btnUpgradeDex.Click += new System.EventHandler(this.btnUpgradeDex_Click);
            // 
            // btnUpgradeCon
            // 
            this.btnUpgradeCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgradeCon.Location = new System.Drawing.Point(131, 44);
            this.btnUpgradeCon.Name = "btnUpgradeCon";
            this.btnUpgradeCon.Size = new System.Drawing.Size(15, 15);
            this.btnUpgradeCon.TabIndex = 1;
            this.btnUpgradeCon.UseVisualStyleBackColor = true;
            this.btnUpgradeCon.Click += new System.EventHandler(this.btnUpgradeCon_Click);
            // 
            // btnUpgradeStr
            // 
            this.btnUpgradeStr.Location = new System.Drawing.Point(131, 28);
            this.btnUpgradeStr.Name = "btnUpgradeStr";
            this.btnUpgradeStr.Size = new System.Drawing.Size(15, 15);
            this.btnUpgradeStr.TabIndex = 0;
            this.btnUpgradeStr.UseVisualStyleBackColor = true;
            this.btnUpgradeStr.Visible = false;
            this.btnUpgradeStr.Click += new System.EventHandler(this.btnUpgradeStr_Click);
            // 
            // lbxAttributeValues
            // 
            this.lbxAttributeValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAttributeValues.FormattingEnabled = true;
            this.lbxAttributeValues.ItemHeight = 16;
            this.lbxAttributeValues.Location = new System.Drawing.Point(102, 25);
            this.lbxAttributeValues.Name = "lbxAttributeValues";
            this.lbxAttributeValues.Size = new System.Drawing.Size(23, 68);
            this.lbxAttributeValues.TabIndex = 7;
            // 
            // lbxAttributePoints
            // 
            this.lbxAttributePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAttributePoints.FormattingEnabled = true;
            this.lbxAttributePoints.ItemHeight = 16;
            this.lbxAttributePoints.Items.AddRange(new object[] {
            "Strength",
            "Constitution",
            "Dexterity",
            "Intellegence"});
            this.lbxAttributePoints.Location = new System.Drawing.Point(10, 25);
            this.lbxAttributePoints.Name = "lbxAttributePoints";
            this.lbxAttributePoints.Size = new System.Drawing.Size(94, 68);
            this.lbxAttributePoints.TabIndex = 6;
            // 
            // lblCharUnspentAtr
            // 
            this.lblCharUnspentAtr.AutoSize = true;
            this.lblCharUnspentAtr.Location = new System.Drawing.Point(12, 96);
            this.lblCharUnspentAtr.Name = "lblCharUnspentAtr";
            this.lblCharUnspentAtr.Size = new System.Drawing.Size(97, 13);
            this.lblCharUnspentAtr.TabIndex = 9;
            this.lblCharUnspentAtr.Text = "(player unspent atr)";
            // 
            // lblCharPlayer
            // 
            this.lblCharPlayer.AutoSize = true;
            this.lblCharPlayer.Location = new System.Drawing.Point(12, 9);
            this.lblCharPlayer.Name = "lblCharPlayer";
            this.lblCharPlayer.Size = new System.Drawing.Size(92, 13);
            this.lblCharPlayer.TabIndex = 8;
            this.lblCharPlayer.Text = "(player name + lvl)";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblDesc);
            this.tabPage4.Controls.Add(this.lbxAttacksDesc);
            this.tabPage4.Controls.Add(this.btnReplaceAttacks);
            this.tabPage4.Controls.Add(this.lblAttacksInactive);
            this.tabPage4.Controls.Add(this.lblAttacksActive);
            this.tabPage4.Controls.Add(this.lbxAttacksInactive);
            this.tabPage4.Controls.Add(this.lbxAttacksActive);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(361, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Attacks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(94, 13);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Attack Description";
            // 
            // lbxAttacksDesc
            // 
            this.lbxAttacksDesc.FormattingEnabled = true;
            this.lbxAttacksDesc.Location = new System.Drawing.Point(12, 100);
            this.lbxAttacksDesc.Name = "lbxAttacksDesc";
            this.lbxAttacksDesc.Size = new System.Drawing.Size(200, 95);
            this.lbxAttacksDesc.TabIndex = 19;
            // 
            // btnReplaceAttacks
            // 
            this.btnReplaceAttacks.Enabled = false;
            this.btnReplaceAttacks.Location = new System.Drawing.Point(138, 22);
            this.btnReplaceAttacks.Name = "btnReplaceAttacks";
            this.btnReplaceAttacks.Size = new System.Drawing.Size(86, 23);
            this.btnReplaceAttacks.TabIndex = 16;
            this.btnReplaceAttacks.Text = "Replace";
            this.btnReplaceAttacks.UseVisualStyleBackColor = true;
            this.btnReplaceAttacks.Click += new System.EventHandler(this.btnReplaceAttacks_Click);
            // 
            // lblAttacksInactive
            // 
            this.lblAttacksInactive.AutoSize = true;
            this.lblAttacksInactive.Location = new System.Drawing.Point(227, 6);
            this.lblAttacksInactive.Name = "lblAttacksInactive";
            this.lblAttacksInactive.Size = new System.Drawing.Size(55, 13);
            this.lblAttacksInactive.TabIndex = 15;
            this.lblAttacksInactive.Text = "Not in use";
            // 
            // lblAttacksActive
            // 
            this.lblAttacksActive.AutoSize = true;
            this.lblAttacksActive.Location = new System.Drawing.Point(12, 6);
            this.lblAttacksActive.Name = "lblAttacksActive";
            this.lblAttacksActive.Size = new System.Drawing.Size(43, 13);
            this.lblAttacksActive.TabIndex = 14;
            this.lblAttacksActive.Text = "Attacks";
            // 
            // lbxAttacksInactive
            // 
            this.lbxAttacksInactive.FormattingEnabled = true;
            this.lbxAttacksInactive.Location = new System.Drawing.Point(230, 22);
            this.lbxAttacksInactive.Name = "lbxAttacksInactive";
            this.lbxAttacksInactive.Size = new System.Drawing.Size(120, 173);
            this.lbxAttacksInactive.TabIndex = 13;
            this.lbxAttacksInactive.SelectedIndexChanged += new System.EventHandler(this.lbxAttacksInactive_SelectedIndexChanged);
            // 
            // lbxAttacksActive
            // 
            this.lbxAttacksActive.FormattingEnabled = true;
            this.lbxAttacksActive.Location = new System.Drawing.Point(12, 22);
            this.lbxAttacksActive.Name = "lbxAttacksActive";
            this.lbxAttacksActive.Size = new System.Drawing.Size(120, 56);
            this.lbxAttacksActive.TabIndex = 12;
            this.lbxAttacksActive.SelectedIndexChanged += new System.EventHandler(this.lbxAttacksActive_SelectedIndexChanged);
            // 
            // tmrSave
            // 
            this.tmrSave.Enabled = true;
            this.tmrSave.Interval = 2000;
            this.tmrSave.Tick += new System.EventHandler(this.tmrSave_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTurn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblEnemyLvl;
        private System.Windows.Forms.Label lblEnemyCoins;
        private System.Windows.Forms.Label lblPlayerExperience;
        private System.Windows.Forms.ListBox lbxEvents;
        private System.Windows.Forms.Label lblPlayerCrowns;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblAttacksInactive;
        private System.Windows.Forms.Label lblAttacksActive;
        private System.Windows.Forms.ListBox lbxAttacksInactive;
        private System.Windows.Forms.ListBox lbxAttacksActive;
        private System.Windows.Forms.Button btnReplaceAttacks;
        private System.Windows.Forms.ListBox lbxAttacksDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Timer tmrSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbxCharacter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpgradeInt;
        private System.Windows.Forms.Button btnUpgradeDex;
        private System.Windows.Forms.Button btnUpgradeCon;
        private System.Windows.Forms.Button btnUpgradeStr;
        private System.Windows.Forms.ListBox lbxAttributeValues;
        private System.Windows.Forms.ListBox lbxAttributePoints;
        private System.Windows.Forms.Label lblCharUnspentAtr;
        private System.Windows.Forms.Label lblCharPlayer;
    }
}

