
namespace WordSearchGame
{
    partial class AdminForm
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
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillEmptySpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.createAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem,
            this.placeWordsToolStripMenuItem,
            this.wordsListToolStripMenuItem,
            this.toolStripSeparator4,
            this.fileNameToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteLettersToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.fillEmptySpacesToolStripMenuItem,
            this.toolStripSeparator6,
            this.createAnimationToolStripMenuItem});
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.creatorToolStripMenuItem.Text = "Be a creator";
            // 
            // newWordToolStripMenuItem
            // 
            this.newWordToolStripMenuItem.Name = "newWordToolStripMenuItem";
            this.newWordToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.newWordToolStripMenuItem.Text = "New Word";
            this.newWordToolStripMenuItem.Click += new System.EventHandler(this.newWordToolStripMenuItem_Click);
            // 
            // placeWordsToolStripMenuItem
            // 
            this.placeWordsToolStripMenuItem.Name = "placeWordsToolStripMenuItem";
            this.placeWordsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.placeWordsToolStripMenuItem.Text = "Place Words";
            this.placeWordsToolStripMenuItem.Click += new System.EventHandler(this.placeWordsToolStripMenuItem_Click);
            // 
            // wordsListToolStripMenuItem
            // 
            this.wordsListToolStripMenuItem.Name = "wordsListToolStripMenuItem";
            this.wordsListToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.wordsListToolStripMenuItem.Text = "Words List";
            this.wordsListToolStripMenuItem.Click += new System.EventHandler(this.wordsListToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // fileNameToolStripMenuItem
            // 
            this.fileNameToolStripMenuItem.Name = "fileNameToolStripMenuItem";
            this.fileNameToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.fileNameToolStripMenuItem.Text = "File Name";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // deleteLettersToolStripMenuItem
            // 
            this.deleteLettersToolStripMenuItem.Enabled = false;
            this.deleteLettersToolStripMenuItem.Name = "deleteLettersToolStripMenuItem";
            this.deleteLettersToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.deleteLettersToolStripMenuItem.Text = "Delete Letters";
            this.deleteLettersToolStripMenuItem.Click += new System.EventHandler(this.deleteLettersToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Enabled = false;
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            // 
            // fillEmptySpacesToolStripMenuItem
            // 
            this.fillEmptySpacesToolStripMenuItem.Enabled = false;
            this.fillEmptySpacesToolStripMenuItem.Name = "fillEmptySpacesToolStripMenuItem";
            this.fillEmptySpacesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.fillEmptySpacesToolStripMenuItem.Text = "Fill Empty Spaces";
            this.fillEmptySpacesToolStripMenuItem.Click += new System.EventHandler(this.fillEmptySpacesToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(219, 6);
            // 
            // createAnimationToolStripMenuItem
            // 
            this.createAnimationToolStripMenuItem.Enabled = false;
            this.createAnimationToolStripMenuItem.Name = "createAnimationToolStripMenuItem";
            this.createAnimationToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.createAnimationToolStripMenuItem.Text = "Create Animation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devLanguageToolStripMenuItem,
            this.softwareToolStripMenuItem,
            this.toolStripSeparator7,
            this.authorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // devLanguageToolStripMenuItem
            // 
            this.devLanguageToolStripMenuItem.Name = "devLanguageToolStripMenuItem";
            this.devLanguageToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.devLanguageToolStripMenuItem.Text = "Dev Language";
            this.devLanguageToolStripMenuItem.Click += new System.EventHandler(this.devLanguageToolStripMenuItem_Click);
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(194, 6);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 404);
            this.panel1.TabIndex = 3;
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(770, 0);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 30);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem deleteLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillEmptySpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem createAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Panel panel1;
    }
}