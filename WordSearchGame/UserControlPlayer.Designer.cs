
namespace WordSearchGame
{
    partial class UserControlPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_time = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.listBox_Times = new System.Windows.Forms.ListBox();
            this.label_title_record = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.label_record_time = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.label_title_num_Plays = new System.Windows.Forms.Label();
            this.label_numPlays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_time.Location = new System.Drawing.Point(8, 295);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(118, 39);
            this.label_time.TabIndex = 21;
            this.label_time.Text = "Times";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::WordSearchGame.Properties.Resources.minimize_window_50px;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(888, 5);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 15;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(928, 5);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 30);
            this.QuitButton.TabIndex = 14;
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // listBox_Times
            // 
            this.listBox_Times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.listBox_Times.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Times.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Times.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox_Times.FormattingEnabled = true;
            this.listBox_Times.ItemHeight = 33;
            this.listBox_Times.Location = new System.Drawing.Point(15, 337);
            this.listBox_Times.Name = "listBox_Times";
            this.listBox_Times.Size = new System.Drawing.Size(680, 297);
            this.listBox_Times.TabIndex = 13;
            // 
            // label_title_record
            // 
            this.label_title_record.AutoSize = true;
            this.label_title_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_title_record.Location = new System.Drawing.Point(322, 127);
            this.label_title_record.Name = "label_title_record";
            this.label_title_record.Size = new System.Drawing.Size(214, 55);
            this.label_title_record.TabIndex = 12;
            this.label_title_record.Text = "Record :";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.labelPlayerName.Location = new System.Drawing.Point(297, 5);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(413, 73);
            this.labelPlayerName.TabIndex = 11;
            this.labelPlayerName.Text = "Player Name";
            // 
            // label_record_time
            // 
            this.label_record_time.AutoSize = true;
            this.label_record_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_record_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.label_record_time.Location = new System.Drawing.Point(542, 127);
            this.label_record_time.Name = "label_record_time";
            this.label_record_time.Size = new System.Drawing.Size(134, 55);
            this.label_record_time.TabIndex = 22;
            this.label_record_time.Text = "Time";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.Button_Back.FlatAppearance.BorderSize = 0;
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.ForeColor = System.Drawing.Color.White;
            this.Button_Back.Location = new System.Drawing.Point(718, 574);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(230, 60);
            this.Button_Back.TabIndex = 24;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // label_title_num_Plays
            // 
            this.label_title_num_Plays.AutoSize = true;
            this.label_title_num_Plays.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_num_Plays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label_title_num_Plays.Location = new System.Drawing.Point(168, 208);
            this.label_title_num_Plays.Name = "label_title_num_Plays";
            this.label_title_num_Plays.Size = new System.Drawing.Size(368, 51);
            this.label_title_num_Plays.TabIndex = 25;
            this.label_title_num_Plays.Text = "Number of Plays:";
            // 
            // label_numPlays
            // 
            this.label_numPlays.AutoSize = true;
            this.label_numPlays.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numPlays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.label_numPlays.Location = new System.Drawing.Point(542, 208);
            this.label_numPlays.Name = "label_numPlays";
            this.label_numPlays.Size = new System.Drawing.Size(129, 55);
            this.label_numPlays.TabIndex = 26;
            this.label_numPlays.Text = "Num";
            // 
            // UserControlPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.label_numPlays);
            this.Controls.Add(this.label_title_num_Plays);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.label_record_time);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.listBox_Times);
            this.Controls.Add(this.label_title_record);
            this.Controls.Add(this.labelPlayerName);
            this.Name = "UserControlPlayer";
            this.Size = new System.Drawing.Size(966, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ListBox listBox_Times;
        private System.Windows.Forms.Label label_title_record;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label label_record_time;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label label_title_num_Plays;
        private System.Windows.Forms.Label label_numPlays;
    }
}
