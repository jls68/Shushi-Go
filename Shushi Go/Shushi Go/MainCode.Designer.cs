namespace Shushi_Go
{
    partial class MainCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCode));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickOpponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameYourselfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlayCard = new System.Windows.Forms.Button();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonChopsticks = new System.Windows.Forms.Button();
            this.pictureBoxPlayArea = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxOp1 = new System.Windows.Forms.ComboBox();
            this.groupBoxPickOp = new System.Windows.Forms.GroupBox();
            this.comboBoxOp4 = new System.Windows.Forms.ComboBox();
            this.comboBoxOp3 = new System.Windows.Forms.ComboBox();
            this.comboBoxOp2 = new System.Windows.Forms.ComboBox();
            this.groupBoxNamer = new System.Windows.Forms.GroupBox();
            this.buttonCancelName = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonEnteredName = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayArea)).BeginInit();
            this.groupBoxPickOp.SuspendLayout();
            this.groupBoxNamer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.ruleBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickOpponentToolStripMenuItem,
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "&New Game";
            // 
            // pickOpponentToolStripMenuItem
            // 
            this.pickOpponentToolStripMenuItem.Name = "pickOpponentToolStripMenuItem";
            this.pickOpponentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pickOpponentToolStripMenuItem.Text = "&Pick Opponent(s)";
            this.pickOpponentToolStripMenuItem.Click += new System.EventHandler(this.pickOpponentToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.startToolStripMenuItem.Text = "Quick &Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.QuickStartToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Visible = false;
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameYourselfToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // nameYourselfToolStripMenuItem
            // 
            this.nameYourselfToolStripMenuItem.Name = "nameYourselfToolStripMenuItem";
            this.nameYourselfToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.nameYourselfToolStripMenuItem.Text = "&Name Yourself";
            this.nameYourselfToolStripMenuItem.Click += new System.EventHandler(this.nameYourselfToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ruleBookToolStripMenuItem
            // 
            this.ruleBookToolStripMenuItem.Name = "ruleBookToolStripMenuItem";
            this.ruleBookToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ruleBookToolStripMenuItem.Text = "Rule &Book";
            this.ruleBookToolStripMenuItem.Click += new System.EventHandler(this.ruleBookToolStripMenuItem_Click);
            // 
            // buttonPlayCard
            // 
            this.buttonPlayCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayCard.BackColor = System.Drawing.Color.Salmon;
            this.buttonPlayCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayCard.Location = new System.Drawing.Point(824, 36);
            this.buttonPlayCard.Name = "buttonPlayCard";
            this.buttonPlayCard.Size = new System.Drawing.Size(131, 141);
            this.buttonPlayCard.TabIndex = 1;
            this.buttonPlayCard.Text = "Quick Start";
            this.buttonPlayCard.UseVisualStyleBackColor = false;
            this.buttonPlayCard.Click += new System.EventHandler(this.buttonPlayCard_Click);
            // 
            // listBoxScores
            // 
            this.listBoxScores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxScores.BackColor = System.Drawing.Color.Salmon;
            this.listBoxScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.Location = new System.Drawing.Point(12, 36);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(93, 340);
            this.listBoxScores.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(12, 388);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(943, 67);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // buttonChopsticks
            // 
            this.buttonChopsticks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChopsticks.BackColor = System.Drawing.Color.Lime;
            this.buttonChopsticks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChopsticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChopsticks.Location = new System.Drawing.Point(824, 183);
            this.buttonChopsticks.Name = "buttonChopsticks";
            this.buttonChopsticks.Size = new System.Drawing.Size(131, 199);
            this.buttonChopsticks.TabIndex = 5;
            this.buttonChopsticks.Text = "Select Card and Click Here Before Hitting Play Card to\r\n Activate Chopsticks";
            this.buttonChopsticks.UseVisualStyleBackColor = false;
            this.buttonChopsticks.Visible = false;
            this.buttonChopsticks.Click += new System.EventHandler(this.buttonChopsticks_Click);
            // 
            // pictureBoxPlayArea
            // 
            this.pictureBoxPlayArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlayArea.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxPlayArea.Location = new System.Drawing.Point(111, 36);
            this.pictureBoxPlayArea.Name = "pictureBoxPlayArea";
            this.pictureBoxPlayArea.Size = new System.Drawing.Size(710, 346);
            this.pictureBoxPlayArea.TabIndex = 6;
            this.pictureBoxPlayArea.TabStop = false;
            this.pictureBoxPlayArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlayArea_MouseClick);
            this.pictureBoxPlayArea.Resize += new System.EventHandler(this.pictureBoxPlayArea_Resize);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Salmon;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(527, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(111, 297);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxOp1
            // 
            this.comboBoxOp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOp1.FormattingEnabled = true;
            this.comboBoxOp1.Items.AddRange(new object[] {
            "Random",
            "Todd the Blind",
            "Spez the Quick",
            "Makky the Bull",
            "Emily the Gambler",
            "Sophie the Wise",
            "Ypoc the Cat",
            "Frank the Fisher",
            "David the Meak"});
            this.comboBoxOp1.Location = new System.Drawing.Point(31, 34);
            this.comboBoxOp1.Name = "comboBoxOp1";
            this.comboBoxOp1.Size = new System.Drawing.Size(464, 24);
            this.comboBoxOp1.TabIndex = 9;
            this.comboBoxOp1.Text = "Random";
            // 
            // groupBoxPickOp
            // 
            this.groupBoxPickOp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPickOp.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxPickOp.Controls.Add(this.comboBoxOp4);
            this.groupBoxPickOp.Controls.Add(this.buttonStart);
            this.groupBoxPickOp.Controls.Add(this.comboBoxOp3);
            this.groupBoxPickOp.Controls.Add(this.comboBoxOp2);
            this.groupBoxPickOp.Controls.Add(this.comboBoxOp1);
            this.groupBoxPickOp.Location = new System.Drawing.Point(137, 46);
            this.groupBoxPickOp.Name = "groupBoxPickOp";
            this.groupBoxPickOp.Size = new System.Drawing.Size(659, 332);
            this.groupBoxPickOp.TabIndex = 11;
            this.groupBoxPickOp.TabStop = false;
            this.groupBoxPickOp.Text = "Pick your opponents";
            this.groupBoxPickOp.Visible = false;
            // 
            // comboBoxOp4
            // 
            this.comboBoxOp4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOp4.FormattingEnabled = true;
            this.comboBoxOp4.Items.AddRange(new object[] {
            "No Opponent",
            "Random",
            "Todd the Blind",
            "Spez the Quick",
            "Makky the Bull",
            "Emily the Gambler",
            "Sophie the Wise",
            "Ypoc the Cat",
            "Frank the Fisher",
            "David the Meak"});
            this.comboBoxOp4.Location = new System.Drawing.Point(31, 175);
            this.comboBoxOp4.Name = "comboBoxOp4";
            this.comboBoxOp4.Size = new System.Drawing.Size(464, 24);
            this.comboBoxOp4.TabIndex = 12;
            this.comboBoxOp4.Text = "No Opponent";
            // 
            // comboBoxOp3
            // 
            this.comboBoxOp3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOp3.FormattingEnabled = true;
            this.comboBoxOp3.Items.AddRange(new object[] {
            "No Opponent",
            "Random",
            "Todd the Blind",
            "Spez the Quick",
            "Makky the Bull",
            "Emily the Gambler",
            "Sophie the Wise",
            "Ypoc the Cat",
            "Frank the Fisher",
            "David the Meak"});
            this.comboBoxOp3.Location = new System.Drawing.Point(31, 126);
            this.comboBoxOp3.Name = "comboBoxOp3";
            this.comboBoxOp3.Size = new System.Drawing.Size(464, 24);
            this.comboBoxOp3.TabIndex = 11;
            this.comboBoxOp3.Text = "No Opponent";
            // 
            // comboBoxOp2
            // 
            this.comboBoxOp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOp2.FormattingEnabled = true;
            this.comboBoxOp2.Items.AddRange(new object[] {
            "No Opponent",
            "Random",
            "Todd the Blind",
            "Spez the Quick",
            "Makky the Bull",
            "Emily the Gambler",
            "Sophie the Wise",
            "Ypoc the Cat",
            "Frank the Fisher",
            "David the Meak"});
            this.comboBoxOp2.Location = new System.Drawing.Point(31, 78);
            this.comboBoxOp2.Name = "comboBoxOp2";
            this.comboBoxOp2.Size = new System.Drawing.Size(464, 24);
            this.comboBoxOp2.TabIndex = 10;
            this.comboBoxOp2.Text = "No Opponent";
            // 
            // groupBoxNamer
            // 
            this.groupBoxNamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNamer.Controls.Add(this.buttonCancelName);
            this.groupBoxNamer.Controls.Add(this.textBoxPlayerName);
            this.groupBoxNamer.Controls.Add(this.buttonEnteredName);
            this.groupBoxNamer.Enabled = false;
            this.groupBoxNamer.Location = new System.Drawing.Point(111, 27);
            this.groupBoxNamer.Name = "groupBoxNamer";
            this.groupBoxNamer.Size = new System.Drawing.Size(710, 83);
            this.groupBoxNamer.TabIndex = 12;
            this.groupBoxNamer.TabStop = false;
            this.groupBoxNamer.Text = "Name yourself";
            this.groupBoxNamer.Visible = false;
            // 
            // buttonCancelName
            // 
            this.buttonCancelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelName.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancelName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelName.Location = new System.Drawing.Point(527, 53);
            this.buttonCancelName.Name = "buttonCancelName";
            this.buttonCancelName.Size = new System.Drawing.Size(177, 24);
            this.buttonCancelName.TabIndex = 15;
            this.buttonCancelName.Text = "Cancel Naming";
            this.buttonCancelName.UseVisualStyleBackColor = false;
            this.buttonCancelName.Click += new System.EventHandler(this.buttonCancelName_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(6, 19);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(697, 20);
            this.textBoxPlayerName.TabIndex = 14;
            // 
            // buttonEnteredName
            // 
            this.buttonEnteredName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnteredName.BackColor = System.Drawing.Color.Salmon;
            this.buttonEnteredName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnteredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnteredName.Location = new System.Drawing.Point(6, 53);
            this.buttonEnteredName.Name = "buttonEnteredName";
            this.buttonEnteredName.Size = new System.Drawing.Size(402, 24);
            this.buttonEnteredName.TabIndex = 13;
            this.buttonEnteredName.Text = "Enter Your New Name";
            this.buttonEnteredName.UseVisualStyleBackColor = false;
            this.buttonEnteredName.Click += new System.EventHandler(this.buttonEnteredName_Click);
            // 
            // MainCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(967, 467);
            this.Controls.Add(this.groupBoxNamer);
            this.Controls.Add(this.groupBoxPickOp);
            this.Controls.Add(this.pictureBoxPlayArea);
            this.Controls.Add(this.buttonChopsticks);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.buttonPlayCard);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainCode";
            this.Text = "Sushi Go!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayArea)).EndInit();
            this.groupBoxPickOp.ResumeLayout(false);
            this.groupBoxNamer.ResumeLayout(false);
            this.groupBoxNamer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickOpponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlayCard;
        private System.Windows.Forms.ListBox listBoxScores;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonChopsticks;
        private System.Windows.Forms.PictureBox pictureBoxPlayArea;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxOp1;
        private System.Windows.Forms.GroupBox groupBoxPickOp;
        private System.Windows.Forms.ComboBox comboBoxOp2;
        private System.Windows.Forms.ComboBox comboBoxOp4;
        private System.Windows.Forms.ComboBox comboBoxOp3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameYourselfToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxNamer;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonEnteredName;
        private System.Windows.Forms.Button buttonCancelName;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleBookToolStripMenuItem;
    }
}

