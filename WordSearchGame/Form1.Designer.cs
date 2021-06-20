
namespace WordSearchGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beACreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillEmptySpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.GoBack_Button = new System.Windows.Forms.Button();
            this.Quit_Button_Bottom = new System.Windows.Forms.Button();
            this.LastMove_Button = new System.Windows.Forms.Button();
            this.Stats_Button = new System.Windows.Forms.Button();
            this.PlayerName_Button = new System.Windows.Forms.Button();
            this.NewGame_Button = new System.Windows.Forms.Button();
            this.Label_clock = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.WordsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beACreatorToolStripMenuItem,
            this.creatorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1024, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beACreatorToolStripMenuItem
            // 
            this.beACreatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.playerNameToolStripMenuItem,
            this.playerStatisticsToolStripMenuItem,
            this.toolStripSeparator2,
            this.administrationToolStripMenuItem,
            this.playDemoToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitGameToolStripMenuItem});
            this.beACreatorToolStripMenuItem.Name = "beACreatorToolStripMenuItem";
            this.beACreatorToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.beACreatorToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // playerNameToolStripMenuItem
            // 
            this.playerNameToolStripMenuItem.Name = "playerNameToolStripMenuItem";
            this.playerNameToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.playerNameToolStripMenuItem.Text = "Player Name";
            this.playerNameToolStripMenuItem.Click += new System.EventHandler(this.playerNameToolStripMenuItem_Click);
            // 
            // playerStatisticsToolStripMenuItem
            // 
            this.playerStatisticsToolStripMenuItem.Name = "playerStatisticsToolStripMenuItem";
            this.playerStatisticsToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.playerStatisticsToolStripMenuItem.Text = "Player Statistics";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Click += new System.EventHandler(this.administrationToolStripMenuItem_Click);
            // 
            // playDemoToolStripMenuItem
            // 
            this.playDemoToolStripMenuItem.Name = "playDemoToolStripMenuItem";
            this.playDemoToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.playDemoToolStripMenuItem.Text = "Play Demo";
            this.playDemoToolStripMenuItem.Click += new System.EventHandler(this.playDemoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem,
            this.placeWordsToolStripMenuItem,
            this.wordsListToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteLettersToolStripMenuItem,
            this.fillEmptySpacesToolStripMenuItem});
            this.creatorToolStripMenuItem.Enabled = false;
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.creatorToolStripMenuItem.Text = "Be a creator";
            // 
            // newWordToolStripMenuItem
            // 
            this.newWordToolStripMenuItem.Name = "newWordToolStripMenuItem";
            this.newWordToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.newWordToolStripMenuItem.Text = "New Word";
            this.newWordToolStripMenuItem.Click += new System.EventHandler(this.newWordToolStripMenuItem_Click);
            // 
            // placeWordsToolStripMenuItem
            // 
            this.placeWordsToolStripMenuItem.Name = "placeWordsToolStripMenuItem";
            this.placeWordsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.placeWordsToolStripMenuItem.Text = "Place Words";
            this.placeWordsToolStripMenuItem.Click += new System.EventHandler(this.placeWordsToolStripMenuItem_Click);
            // 
            // wordsListToolStripMenuItem
            // 
            this.wordsListToolStripMenuItem.Name = "wordsListToolStripMenuItem";
            this.wordsListToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.wordsListToolStripMenuItem.Text = "Words List";
            this.wordsListToolStripMenuItem.Click += new System.EventHandler(this.wordsListToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // deleteLettersToolStripMenuItem
            // 
            this.deleteLettersToolStripMenuItem.Name = "deleteLettersToolStripMenuItem";
            this.deleteLettersToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.deleteLettersToolStripMenuItem.Text = "Delete Letters";
            this.deleteLettersToolStripMenuItem.Click += new System.EventHandler(this.deleteLettersToolStripMenuItem_Click);
            // 
            // fillEmptySpacesToolStripMenuItem
            // 
            this.fillEmptySpacesToolStripMenuItem.Name = "fillEmptySpacesToolStripMenuItem";
            this.fillEmptySpacesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.fillEmptySpacesToolStripMenuItem.Text = "Fill Empty Spaces";
            this.fillEmptySpacesToolStripMenuItem.Click += new System.EventHandler(this.fillEmptySpacesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devLanguageToolStripMenuItem,
            this.softwareToolStripMenuItem,
            this.toolStripSeparator7,
            this.authorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // devLanguageToolStripMenuItem
            // 
            this.devLanguageToolStripMenuItem.Name = "devLanguageToolStripMenuItem";
            this.devLanguageToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.devLanguageToolStripMenuItem.Text = "Dev Language";
            this.devLanguageToolStripMenuItem.Click += new System.EventHandler(this.devLanguageToolStripMenuItem_Click);
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(179, 6);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.GoBack_Button);
            this.ButtonsPanel.Controls.Add(this.Quit_Button_Bottom);
            this.ButtonsPanel.Controls.Add(this.LastMove_Button);
            this.ButtonsPanel.Controls.Add(this.Stats_Button);
            this.ButtonsPanel.Controls.Add(this.PlayerName_Button);
            this.ButtonsPanel.Controls.Add(this.NewGame_Button);
            this.ButtonsPanel.Controls.Add(this.Label_clock);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 724);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(1024, 94);
            this.ButtonsPanel.TabIndex = 5;
            // 
            // GoBack_Button
            // 
            this.GoBack_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.GoBack_Button.FlatAppearance.BorderSize = 0;
            this.GoBack_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack_Button.ForeColor = System.Drawing.Color.White;
            this.GoBack_Button.Location = new System.Drawing.Point(30, 24);
            this.GoBack_Button.Name = "GoBack_Button";
            this.GoBack_Button.Size = new System.Drawing.Size(150, 50);
            this.GoBack_Button.TabIndex = 6;
            this.GoBack_Button.Text = "Go Back";
            this.GoBack_Button.UseVisualStyleBackColor = false;
            this.GoBack_Button.Visible = false;
            this.GoBack_Button.Click += new System.EventHandler(this.GoBack_Button_Click);
            // 
            // Quit_Button_Bottom
            // 
            this.Quit_Button_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.Quit_Button_Bottom.FlatAppearance.BorderSize = 0;
            this.Quit_Button_Bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_Button_Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_Button_Bottom.ForeColor = System.Drawing.Color.White;
            this.Quit_Button_Bottom.Location = new System.Drawing.Point(840, 24);
            this.Quit_Button_Bottom.Name = "Quit_Button_Bottom";
            this.Quit_Button_Bottom.Size = new System.Drawing.Size(150, 50);
            this.Quit_Button_Bottom.TabIndex = 4;
            this.Quit_Button_Bottom.Text = "Quit Game";
            this.Quit_Button_Bottom.UseVisualStyleBackColor = false;
            this.Quit_Button_Bottom.Click += new System.EventHandler(this.Quit_Button_Bottom_Click);
            // 
            // LastMove_Button
            // 
            this.LastMove_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.LastMove_Button.Enabled = false;
            this.LastMove_Button.FlatAppearance.BorderSize = 0;
            this.LastMove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastMove_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastMove_Button.ForeColor = System.Drawing.Color.White;
            this.LastMove_Button.Location = new System.Drawing.Point(640, 24);
            this.LastMove_Button.Name = "LastMove_Button";
            this.LastMove_Button.Size = new System.Drawing.Size(150, 50);
            this.LastMove_Button.TabIndex = 3;
            this.LastMove_Button.Text = "Last Move";
            this.LastMove_Button.UseVisualStyleBackColor = false;
            this.LastMove_Button.Click += new System.EventHandler(this.LastMove_Button_Click);
            // 
            // Stats_Button
            // 
            this.Stats_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.Stats_Button.FlatAppearance.BorderSize = 0;
            this.Stats_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stats_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stats_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Stats_Button.Location = new System.Drawing.Point(440, 24);
            this.Stats_Button.Name = "Stats_Button";
            this.Stats_Button.Size = new System.Drawing.Size(150, 50);
            this.Stats_Button.TabIndex = 2;
            this.Stats_Button.Text = "Statistics";
            this.Stats_Button.UseVisualStyleBackColor = false;
            this.Stats_Button.Click += new System.EventHandler(this.Stats_Button_Click);
            // 
            // PlayerName_Button
            // 
            this.PlayerName_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.PlayerName_Button.FlatAppearance.BorderSize = 0;
            this.PlayerName_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerName_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName_Button.ForeColor = System.Drawing.Color.White;
            this.PlayerName_Button.Location = new System.Drawing.Point(240, 24);
            this.PlayerName_Button.Name = "PlayerName_Button";
            this.PlayerName_Button.Size = new System.Drawing.Size(150, 50);
            this.PlayerName_Button.TabIndex = 1;
            this.PlayerName_Button.Text = "Player Name";
            this.PlayerName_Button.UseVisualStyleBackColor = false;
            this.PlayerName_Button.Click += new System.EventHandler(this.PlayerName_Button_Click);
            // 
            // NewGame_Button
            // 
            this.NewGame_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.NewGame_Button.FlatAppearance.BorderSize = 0;
            this.NewGame_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame_Button.ForeColor = System.Drawing.Color.White;
            this.NewGame_Button.Location = new System.Drawing.Point(30, 24);
            this.NewGame_Button.Name = "NewGame_Button";
            this.NewGame_Button.Size = new System.Drawing.Size(150, 50);
            this.NewGame_Button.TabIndex = 0;
            this.NewGame_Button.Text = "New Game";
            this.NewGame_Button.UseVisualStyleBackColor = false;
            this.NewGame_Button.Click += new System.EventHandler(this.NewGame_Button_Click);
            // 
            // Label_clock
            // 
            this.Label_clock.AutoSize = true;
            this.Label_clock.Enabled = false;
            this.Label_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.Label_clock.Location = new System.Drawing.Point(250, 24);
            this.Label_clock.Name = "Label_clock";
            this.Label_clock.Size = new System.Drawing.Size(158, 55);
            this.Label_clock.TabIndex = 5;
            this.Label_clock.Text = "label1";
            this.Label_clock.Visible = false;
            // 
            // GamePanel
            // 
            this.GamePanel.ColumnCount = 15;
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.Location = new System.Drawing.Point(0, 34);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.RowCount = 15;
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.GamePanel.Size = new System.Drawing.Size(756, 684);
            this.GamePanel.TabIndex = 6;
            // 
            // WordsPanel
            // 
            this.WordsPanel.ColumnCount = 2;
            this.WordsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81992F));
            this.WordsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.18008F));
            this.WordsPanel.Location = new System.Drawing.Point(763, 34);
            this.WordsPanel.Name = "WordsPanel";
            this.WordsPanel.RowCount = 19;
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.WordsPanel.Size = new System.Drawing.Size(261, 684);
            this.WordsPanel.TabIndex = 7;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::WordSearchGame.Properties.Resources.minimize_window_50px;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(954, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(994, 0);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 30);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.WordsPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beACreatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem playerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem deleteLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillEmptySpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button Quit_Button_Bottom;
        private System.Windows.Forms.Button LastMove_Button;
        private System.Windows.Forms.Button Stats_Button;
        private System.Windows.Forms.Button PlayerName_Button;
        private System.Windows.Forms.Button NewGame_Button;
        private System.Windows.Forms.TableLayoutPanel GamePanel;
        private System.Windows.Forms.TableLayoutPanel WordsPanel;
        private System.Windows.Forms.Label Label_clock;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.Button GoBack_Button;
    }
}

