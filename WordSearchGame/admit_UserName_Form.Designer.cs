
namespace WordSearchGame
{
    partial class admit_UserName_Form
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
            this.Button_UserName_Apply = new System.Windows.Forms.Button();
            this.Button_UserName_Back = new System.Windows.Forms.Button();
            this.UserName_QuitButton = new System.Windows.Forms.Button();
            this.txt_box_UserName = new System.Windows.Forms.TextBox();
            this.Label_Login_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_UserName_Apply
            // 
            this.Button_UserName_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.Button_UserName_Apply.FlatAppearance.BorderSize = 0;
            this.Button_UserName_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UserName_Apply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UserName_Apply.ForeColor = System.Drawing.Color.White;
            this.Button_UserName_Apply.Location = new System.Drawing.Point(30, 170);
            this.Button_UserName_Apply.Name = "Button_UserName_Apply";
            this.Button_UserName_Apply.Size = new System.Drawing.Size(136, 32);
            this.Button_UserName_Apply.TabIndex = 8;
            this.Button_UserName_Apply.Text = "Apply";
            this.Button_UserName_Apply.UseVisualStyleBackColor = false;
            this.Button_UserName_Apply.Click += new System.EventHandler(this.Button_UserName_Apply_Click_1);
            // 
            // Button_UserName_Back
            // 
            this.Button_UserName_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.Button_UserName_Back.FlatAppearance.BorderSize = 0;
            this.Button_UserName_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UserName_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UserName_Back.ForeColor = System.Drawing.Color.White;
            this.Button_UserName_Back.Location = new System.Drawing.Point(172, 170);
            this.Button_UserName_Back.Name = "Button_UserName_Back";
            this.Button_UserName_Back.Size = new System.Drawing.Size(136, 32);
            this.Button_UserName_Back.TabIndex = 7;
            this.Button_UserName_Back.Text = "Back";
            this.Button_UserName_Back.UseVisualStyleBackColor = false;
            this.Button_UserName_Back.Click += new System.EventHandler(this.Button_UserName_Back_Click);
            // 
            // UserName_QuitButton
            // 
            this.UserName_QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.UserName_QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserName_QuitButton.FlatAppearance.BorderSize = 0;
            this.UserName_QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserName_QuitButton.Location = new System.Drawing.Point(306, 2);
            this.UserName_QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.UserName_QuitButton.Name = "UserName_QuitButton";
            this.UserName_QuitButton.Size = new System.Drawing.Size(30, 30);
            this.UserName_QuitButton.TabIndex = 9;
            this.UserName_QuitButton.UseVisualStyleBackColor = true;
            this.UserName_QuitButton.Click += new System.EventHandler(this.UserName_QuitButton_Click);
            // 
            // txt_box_UserName
            // 
            this.txt_box_UserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_UserName.Location = new System.Drawing.Point(30, 106);
            this.txt_box_UserName.Name = "txt_box_UserName";
            this.txt_box_UserName.Size = new System.Drawing.Size(278, 33);
            this.txt_box_UserName.TabIndex = 11;
            this.txt_box_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Login_UserName
            // 
            this.Label_Login_UserName.AutoSize = true;
            this.Label_Login_UserName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_UserName.Location = new System.Drawing.Point(91, 54);
            this.Label_Login_UserName.Name = "Label_Login_UserName";
            this.Label_Login_UserName.Size = new System.Drawing.Size(169, 36);
            this.Label_Login_UserName.TabIndex = 10;
            this.Label_Login_UserName.Text = "User Name";
            // 
            // admit_UserName_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(338, 222);
            this.Controls.Add(this.txt_box_UserName);
            this.Controls.Add(this.Label_Login_UserName);
            this.Controls.Add(this.UserName_QuitButton);
            this.Controls.Add(this.Button_UserName_Apply);
            this.Controls.Add(this.Button_UserName_Back);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admit_UserName_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Username";
            this.Load += new System.EventHandler(this.admit_UserName_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_UserName_Apply;
        private System.Windows.Forms.Button Button_UserName_Back;
        private System.Windows.Forms.Button UserName_QuitButton;
        private System.Windows.Forms.TextBox txt_box_UserName;
        private System.Windows.Forms.Label Label_Login_UserName;
    }
}