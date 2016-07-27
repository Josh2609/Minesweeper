namespace Minesweeper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnExpert = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnBeg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHighScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetHighScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBegHS = new System.Windows.Forms.Label();
            this.lblIntHS = new System.Windows.Forms.Label();
            this.lblExpHS = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFlgRem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblBegHSTime = new System.Windows.Forms.Label();
            this.lblIntHSTime = new System.Windows.Forms.Label();
            this.lblExpHSTime = new System.Windows.Forms.Label();
            this.lblExpHSName = new System.Windows.Forms.Label();
            this.lblIntHSName = new System.Windows.Forms.Label();
            this.lblBegHSName = new System.Windows.Forms.Label();
            this.customPlay = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblAskUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(217, 230);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.Location = new System.Drawing.Point(217, 170);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(167, 52);
            this.btnHighScore.TabIndex = 10;
            this.btnHighScore.Text = "High Scores";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(217, 110);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(167, 52);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.Location = new System.Drawing.Point(217, 290);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(167, 52);
            this.btnCustom.TabIndex = 15;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Visible = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpert.Location = new System.Drawing.Point(217, 230);
            this.btnExpert.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(167, 52);
            this.btnExpert.TabIndex = 14;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = true;
            this.btnExpert.Visible = false;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(217, 171);
            this.btnInt.Margin = new System.Windows.Forms.Padding(4);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(167, 52);
            this.btnInt.TabIndex = 13;
            this.btnInt.Text = "Intermediate";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Visible = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnBeg
            // 
            this.btnBeg.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeg.Location = new System.Drawing.Point(217, 109);
            this.btnBeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeg.Name = "btnBeg";
            this.btnBeg.Size = new System.Drawing.Size(167, 52);
            this.btnBeg.TabIndex = 12;
            this.btnBeg.Text = "Beginner";
            this.btnBeg.UseVisualStyleBackColor = true;
            this.btnBeg.Visible = false;
            this.btnBeg.Click += new System.EventHandler(this.btnBeg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.viewHighScoresToolStripMenuItem,
            this.resetHighScoresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerToolStripMenuItem,
            this.intermediateToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.customToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.beginnerToolStripMenuItem.Text = "Beginner";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.beginnerToolStripMenuItem_Click);
            // 
            // intermediateToolStripMenuItem
            // 
            this.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem";
            this.intermediateToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.intermediateToolStripMenuItem.Text = "Intermediate";
            this.intermediateToolStripMenuItem.Click += new System.EventHandler(this.intermediateToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // viewHighScoresToolStripMenuItem
            // 
            this.viewHighScoresToolStripMenuItem.Name = "viewHighScoresToolStripMenuItem";
            this.viewHighScoresToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.viewHighScoresToolStripMenuItem.Text = "View High Scores";
            this.viewHighScoresToolStripMenuItem.Click += new System.EventHandler(this.viewHighScoresToolStripMenuItem_Click);
            // 
            // resetHighScoresToolStripMenuItem
            // 
            this.resetHighScoresToolStripMenuItem.Name = "resetHighScoresToolStripMenuItem";
            this.resetHighScoresToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.resetHighScoresToolStripMenuItem.Text = "Reset High Scores";
            this.resetHighScoresToolStripMenuItem.Click += new System.EventHandler(this.resetHighScoresToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // lblBegHS
            // 
            this.lblBegHS.AutoSize = true;
            this.lblBegHS.Location = new System.Drawing.Point(125, 110);
            this.lblBegHS.Name = "lblBegHS";
            this.lblBegHS.Size = new System.Drawing.Size(69, 17);
            this.lblBegHS.TabIndex = 18;
            this.lblBegHS.Text = "Beginner:";
            this.lblBegHS.Visible = false;
            // 
            // lblIntHS
            // 
            this.lblIntHS.AutoSize = true;
            this.lblIntHS.Location = new System.Drawing.Point(125, 169);
            this.lblIntHS.Name = "lblIntHS";
            this.lblIntHS.Size = new System.Drawing.Size(90, 17);
            this.lblIntHS.TabIndex = 19;
            this.lblIntHS.Text = "Intermediate:";
            this.lblIntHS.Visible = false;
            // 
            // lblExpHS
            // 
            this.lblExpHS.AutoSize = true;
            this.lblExpHS.Location = new System.Drawing.Point(125, 229);
            this.lblExpHS.Name = "lblExpHS";
            this.lblExpHS.Size = new System.Drawing.Size(52, 17);
            this.lblExpHS.TabIndex = 20;
            this.lblExpHS.Text = "Expert:";
            this.lblExpHS.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(167, 33);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(41, 40);
            this.lblTimer.TabIndex = 21;
            this.lblTimer.Text = "0";
            this.lblTimer.Visible = false;
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 1000;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // lblFlgRem
            // 
            this.lblFlgRem.AutoSize = true;
            this.lblFlgRem.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlgRem.Location = new System.Drawing.Point(10, 35);
            this.lblFlgRem.Name = "lblFlgRem";
            this.lblFlgRem.Size = new System.Drawing.Size(41, 40);
            this.lblFlgRem.TabIndex = 22;
            this.lblFlgRem.Text = "0";
            this.lblFlgRem.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Minesweeper.Properties.Resources.happyFace;
            this.btnReset.Location = new System.Drawing.Point(84, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(217, 291);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 52);
            this.btnMenu.TabIndex = 28;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblBegHSTime
            // 
            this.lblBegHSTime.AutoSize = true;
            this.lblBegHSTime.Location = new System.Drawing.Point(251, 110);
            this.lblBegHSTime.Name = "lblBegHSTime";
            this.lblBegHSTime.Size = new System.Drawing.Size(69, 17);
            this.lblBegHSTime.TabIndex = 29;
            this.lblBegHSTime.Text = "Beginner:";
            this.lblBegHSTime.Visible = false;
            // 
            // lblIntHSTime
            // 
            this.lblIntHSTime.AutoSize = true;
            this.lblIntHSTime.Location = new System.Drawing.Point(251, 169);
            this.lblIntHSTime.Name = "lblIntHSTime";
            this.lblIntHSTime.Size = new System.Drawing.Size(90, 17);
            this.lblIntHSTime.TabIndex = 30;
            this.lblIntHSTime.Text = "Intermediate:";
            this.lblIntHSTime.Visible = false;
            // 
            // lblExpHSTime
            // 
            this.lblExpHSTime.AutoSize = true;
            this.lblExpHSTime.Location = new System.Drawing.Point(251, 229);
            this.lblExpHSTime.Name = "lblExpHSTime";
            this.lblExpHSTime.Size = new System.Drawing.Size(52, 17);
            this.lblExpHSTime.TabIndex = 31;
            this.lblExpHSTime.Text = "Expert:";
            this.lblExpHSTime.Visible = false;
            // 
            // lblExpHSName
            // 
            this.lblExpHSName.AutoSize = true;
            this.lblExpHSName.Location = new System.Drawing.Point(365, 229);
            this.lblExpHSName.Name = "lblExpHSName";
            this.lblExpHSName.Size = new System.Drawing.Size(52, 17);
            this.lblExpHSName.TabIndex = 34;
            this.lblExpHSName.Text = "Expert:";
            this.lblExpHSName.Visible = false;
            // 
            // lblIntHSName
            // 
            this.lblIntHSName.AutoSize = true;
            this.lblIntHSName.Location = new System.Drawing.Point(365, 169);
            this.lblIntHSName.Name = "lblIntHSName";
            this.lblIntHSName.Size = new System.Drawing.Size(90, 17);
            this.lblIntHSName.TabIndex = 33;
            this.lblIntHSName.Text = "Intermediate:";
            this.lblIntHSName.Visible = false;
            // 
            // lblBegHSName
            // 
            this.lblBegHSName.AutoSize = true;
            this.lblBegHSName.Location = new System.Drawing.Point(365, 110);
            this.lblBegHSName.Name = "lblBegHSName";
            this.lblBegHSName.Size = new System.Drawing.Size(69, 17);
            this.lblBegHSName.TabIndex = 32;
            this.lblBegHSName.Text = "Beginner:";
            this.lblBegHSName.Visible = false;
            // 
            // customPlay
            // 
            this.customPlay.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPlay.Location = new System.Drawing.Point(217, 291);
            this.customPlay.Margin = new System.Windows.Forms.Padding(4);
            this.customPlay.Name = "customPlay";
            this.customPlay.Size = new System.Drawing.Size(167, 52);
            this.customPlay.TabIndex = 35;
            this.customPlay.Text = "Play";
            this.customPlay.UseVisualStyleBackColor = true;
            this.customPlay.Visible = false;
            this.customPlay.Click += new System.EventHandler(this.customPlay_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(197, 265);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 36;
            this.lblX.Text = "x:";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(322, 265);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 17);
            this.lblY.TabIndex = 37;
            this.lblY.Text = "y:";
            this.lblY.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(221, 265);
            this.txtX.MaxLength = 2;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(35, 22);
            this.txtX.TabIndex = 38;
            this.txtX.Text = "20";
            this.txtX.Visible = false;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(349, 265);
            this.txtY.MaxLength = 2;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(35, 22);
            this.txtY.TabIndex = 39;
            this.txtY.Text = "20";
            this.txtY.Visible = false;
            // 
            // lblAskUser
            // 
            this.lblAskUser.AutoSize = true;
            this.lblAskUser.Location = new System.Drawing.Point(197, 230);
            this.lblAskUser.Name = "lblAskUser";
            this.lblAskUser.Size = new System.Drawing.Size(208, 17);
            this.lblAskUser.TabIndex = 40;
            this.lblAskUser.Text = "Enter x and y between 2 and 30";
            this.lblAskUser.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lblAskUser);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.customPlay);
            this.Controls.Add(this.lblExpHSName);
            this.Controls.Add(this.lblIntHSName);
            this.Controls.Add(this.lblBegHSName);
            this.Controls.Add(this.lblExpHSTime);
            this.Controls.Add(this.lblIntHSTime);
            this.Controls.Add(this.lblBegHSTime);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFlgRem);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblExpHS);
            this.Controls.Add(this.lblIntHS);
            this.Controls.Add(this.lblBegHS);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnExpert);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnBeg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnBeg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.Label lblBegHS;
        private System.Windows.Forms.Label lblIntHS;
        private System.Windows.Forms.Label lblExpHS;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label lblFlgRem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripMenuItem viewHighScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetHighScoresToolStripMenuItem;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblBegHSTime;
        private System.Windows.Forms.Label lblIntHSTime;
        private System.Windows.Forms.Label lblExpHSTime;
        private System.Windows.Forms.Label lblExpHSName;
        private System.Windows.Forms.Label lblIntHSName;
        private System.Windows.Forms.Label lblBegHSName;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Button customPlay;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblAskUser;
    }
}