namespace Epic_Game
{
    partial class Launcher
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnRandomizeName = new System.Windows.Forms.Button();
            this.lblRace = new System.Windows.Forms.Label();
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Placeholder Title";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(22, 42);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(239, 24);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Placeholder Subtitle";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(23, 211);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(74, 13);
            this.lblCharName.TabIndex = 2;
            this.lblCharName.Text = "Who are you?";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(26, 227);
            this.tbxName.MaxLength = 16;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(154, 20);
            this.tbxName.TabIndex = 3;
            this.tbxName.TextChanged += new System.EventHandler(this.CharCreation_SelectedIndexChanged);
            // 
            // btnRandomizeName
            // 
            this.btnRandomizeName.Enabled = false;
            this.btnRandomizeName.Location = new System.Drawing.Point(186, 225);
            this.btnRandomizeName.Name = "btnRandomizeName";
            this.btnRandomizeName.Size = new System.Drawing.Size(75, 23);
            this.btnRandomizeName.TabIndex = 4;
            this.btnRandomizeName.Text = "Randomize";
            this.btnRandomizeName.UseVisualStyleBackColor = true;
            this.btnRandomizeName.Click += new System.EventHandler(this.btnRandomizeName_Click);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(23, 75);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(36, 13);
            this.lblRace.TabIndex = 5;
            this.lblRace.Text = "Race:";
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.Enabled = false;
            this.btnCreateChar.Location = new System.Drawing.Point(26, 253);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(154, 23);
            this.btnCreateChar.TabIndex = 6;
            this.btnCreateChar.Text = "Finish Character Creation";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(183, 72);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(78, 21);
            this.cbxSex.TabIndex = 7;
            this.cbxSex.SelectedIndexChanged += new System.EventHandler(this.CharCreation_SelectedIndexChanged);
            // 
            // cbxRace
            // 
            this.cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Saurian"});
            this.cbxRace.Location = new System.Drawing.Point(65, 72);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(78, 21);
            this.cbxRace.TabIndex = 9;
            this.cbxRace.SelectedIndexChanged += new System.EventHandler(this.CharCreation_SelectedIndexChanged);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(152, 75);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Sex:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 82);
            this.listBox1.TabIndex = 10;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(186, 254);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigin.Enabled = false;
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(65, 100);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(78, 21);
            this.cbxOrigin.TabIndex = 16;
            this.cbxOrigin.SelectedIndexChanged += new System.EventHandler(this.CharCreation_SelectedIndexChanged);
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(23, 103);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(37, 13);
            this.lblOrigin.TabIndex = 13;
            this.lblOrigin.Text = "Origin:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(158, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Vagabond Start";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(14, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(235, 65);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(14, 106);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(235, 65);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(3, 196);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(129, 14);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "A Game by Alistaric";
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLoad.Controls.Add(this.btnNew);
            this.pnlLoad.Controls.Add(this.pictureBox1);
            this.pnlLoad.Controls.Add(this.lblCredits);
            this.pnlLoad.Controls.Add(this.btnLoad);
            this.pnlLoad.Location = new System.Drawing.Point(12, 72);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(260, 210);
            this.pnlLoad.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Epic_Game.Properties.Resources.line1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 19);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbxRace);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.btnCreateChar);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.btnRandomizeName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbxOrigin);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.checkBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.pnlLoad.ResumeLayout(false);
            this.pnlLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnRandomizeName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLoad;
    }
}