﻿
namespace WordSearchGame
{
    partial class statisticsForm
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
            this.statisticsMainPanel = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label_player = new System.Windows.Forms.Label();
            this.comboBxStatsOrderBy = new System.Windows.Forms.ComboBox();
            this.label_orderBy = new System.Windows.Forms.Label();
            this.bt_record_time = new System.Windows.Forms.Button();
            this.bt_record_Name = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.listBox_players_times = new System.Windows.Forms.ListBox();
            this.label_record_time = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.statisticsMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statisticsMainPanel
            // 
            this.statisticsMainPanel.Controls.Add(this.Button_Back);
            this.statisticsMainPanel.Controls.Add(this.label_time);
            this.statisticsMainPanel.Controls.Add(this.label_player);
            this.statisticsMainPanel.Controls.Add(this.comboBxStatsOrderBy);
            this.statisticsMainPanel.Controls.Add(this.label_orderBy);
            this.statisticsMainPanel.Controls.Add(this.bt_record_time);
            this.statisticsMainPanel.Controls.Add(this.bt_record_Name);
            this.statisticsMainPanel.Controls.Add(this.MinimizeButton);
            this.statisticsMainPanel.Controls.Add(this.QuitButton);
            this.statisticsMainPanel.Controls.Add(this.listBox_players_times);
            this.statisticsMainPanel.Controls.Add(this.label_record_time);
            this.statisticsMainPanel.Controls.Add(this.labelStatistics);
            this.statisticsMainPanel.Location = new System.Drawing.Point(2, 5);
            this.statisticsMainPanel.Name = "statisticsMainPanel";
            this.statisticsMainPanel.Size = new System.Drawing.Size(966, 660);
            this.statisticsMainPanel.TabIndex = 0;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_time.Location = new System.Drawing.Point(460, 192);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(99, 39);
            this.label_time.TabIndex = 10;
            this.label_time.Text = "Time";
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_player.Location = new System.Drawing.Point(14, 192);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(122, 39);
            this.label_player.TabIndex = 9;
            this.label_player.Text = "Player";
            // 
            // comboBxStatsOrderBy
            // 
            this.comboBxStatsOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.comboBxStatsOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBxStatsOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxStatsOrderBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.comboBxStatsOrderBy.FormattingEnabled = true;
            this.comboBxStatsOrderBy.Location = new System.Drawing.Point(713, 300);
            this.comboBxStatsOrderBy.Name = "comboBxStatsOrderBy";
            this.comboBxStatsOrderBy.Size = new System.Drawing.Size(225, 45);
            this.comboBxStatsOrderBy.TabIndex = 8;
            this.comboBxStatsOrderBy.Text = "Name";
            this.comboBxStatsOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBxStatsOrderBy_SelectedIndexChanged);
            // 
            // label_orderBy
            // 
            this.label_orderBy.AutoSize = true;
            this.label_orderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_orderBy.Location = new System.Drawing.Point(706, 244);
            this.label_orderBy.Name = "label_orderBy";
            this.label_orderBy.Size = new System.Drawing.Size(175, 39);
            this.label_orderBy.TabIndex = 7;
            this.label_orderBy.Text = "Order By:";
            // 
            // bt_record_time
            // 
            this.bt_record_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.bt_record_time.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.bt_record_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_record_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_record_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.bt_record_time.Location = new System.Drawing.Point(526, 91);
            this.bt_record_time.Name = "bt_record_time";
            this.bt_record_time.Size = new System.Drawing.Size(317, 47);
            this.bt_record_time.TabIndex = 6;
            this.bt_record_time.Text = "Player Name";
            this.bt_record_time.UseVisualStyleBackColor = false;
            // 
            // bt_record_Name
            // 
            this.bt_record_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.bt_record_Name.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.bt_record_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_record_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_record_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.bt_record_Name.Location = new System.Drawing.Point(323, 92);
            this.bt_record_Name.Name = "bt_record_Name";
            this.bt_record_Name.Size = new System.Drawing.Size(199, 46);
            this.bt_record_Name.TabIndex = 5;
            this.bt_record_Name.Text = "Record Time";
            this.bt_record_Name.UseVisualStyleBackColor = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::WordSearchGame.Properties.Resources.minimize_window_50px;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(894, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(934, 0);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 30);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // listBox_players_times
            // 
            this.listBox_players_times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.listBox_players_times.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_players_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_players_times.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox_players_times.FormattingEnabled = true;
            this.listBox_players_times.ItemHeight = 33;
            this.listBox_players_times.Location = new System.Drawing.Point(21, 244);
            this.listBox_players_times.Name = "listBox_players_times";
            this.listBox_players_times.Size = new System.Drawing.Size(664, 363);
            this.listBox_players_times.TabIndex = 2;
            this.listBox_players_times.SelectedIndexChanged += new System.EventHandler(this.listBox_players_times_SelectedIndexChanged);
            // 
            // label_record_time
            // 
            this.label_record_time.AutoSize = true;
            this.label_record_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_record_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_record_time.Location = new System.Drawing.Point(161, 99);
            this.label_record_time.Name = "label_record_time";
            this.label_record_time.Size = new System.Drawing.Size(156, 39);
            this.label_record_time.TabIndex = 1;
            this.label_record_time.Text = "Record :";
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.labelStatistics.Location = new System.Drawing.Point(312, 4);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(373, 55);
            this.labelStatistics.TabIndex = 0;
            this.labelStatistics.Text = "Game Statistics";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.Button_Back.FlatAppearance.BorderSize = 0;
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.ForeColor = System.Drawing.Color.White;
            this.Button_Back.Location = new System.Drawing.Point(713, 537);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(225, 70);
            this.Button_Back.TabIndex = 25;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // statisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(974, 675);
            this.Controls.Add(this.statisticsMainPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "statisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Statistics";
            this.statisticsMainPanel.ResumeLayout(false);
            this.statisticsMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statisticsMainPanel;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.ListBox listBox_players_times;
        private System.Windows.Forms.Label label_record_time;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label_orderBy;
        private System.Windows.Forms.Button bt_record_time;
        private System.Windows.Forms.Button bt_record_Name;
        private System.Windows.Forms.ComboBox comboBxStatsOrderBy;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Button Button_Back;
    }
}