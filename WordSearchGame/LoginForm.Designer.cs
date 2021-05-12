
namespace WordSearchGame
{
    partial class LoginForm
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
            this.Button_Login_Back = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_Login_UserName = new System.Windows.Forms.Label();
            this.Label_Login_Password = new System.Windows.Forms.Label();
            this.txt_box_Login_UserName = new System.Windows.Forms.TextBox();
            this.txt_box_Login_Password = new System.Windows.Forms.TextBox();
            this.Login_QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Login_Back
            // 
            this.Button_Login_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.Button_Login_Back.FlatAppearance.BorderSize = 0;
            this.Button_Login_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login_Back.ForeColor = System.Drawing.Color.White;
            this.Button_Login_Back.Location = new System.Drawing.Point(206, 338);
            this.Button_Login_Back.Name = "Button_Login_Back";
            this.Button_Login_Back.Size = new System.Drawing.Size(130, 50);
            this.Button_Login_Back.TabIndex = 5;
            this.Button_Login_Back.Text = "Back";
            this.Button_Login_Back.UseVisualStyleBackColor = false;
            this.Button_Login_Back.Click += new System.EventHandler(this.Button_Login_Back_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(70, 338);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(130, 50);
            this.Button_Login.TabIndex = 6;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_Login_UserName
            // 
            this.Label_Login_UserName.AutoSize = true;
            this.Label_Login_UserName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_UserName.Location = new System.Drawing.Point(126, 73);
            this.Label_Login_UserName.Name = "Label_Login_UserName";
            this.Label_Login_UserName.Size = new System.Drawing.Size(159, 32);
            this.Label_Login_UserName.TabIndex = 7;
            this.Label_Login_UserName.Text = "User Name";
            // 
            // Label_Login_Password
            // 
            this.Label_Login_Password.AutoSize = true;
            this.Label_Login_Password.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_Password.Location = new System.Drawing.Point(135, 192);
            this.Label_Login_Password.Name = "Label_Login_Password";
            this.Label_Login_Password.Size = new System.Drawing.Size(138, 32);
            this.Label_Login_Password.TabIndex = 8;
            this.Label_Login_Password.Text = "Password";
            this.Label_Login_Password.Click += new System.EventHandler(this.Label_Login_Password_Click);
            // 
            // txt_box_Login_UserName
            // 
            this.txt_box_Login_UserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_Login_UserName.Location = new System.Drawing.Point(70, 119);
            this.txt_box_Login_UserName.Name = "txt_box_Login_UserName";
            this.txt_box_Login_UserName.Size = new System.Drawing.Size(266, 33);
            this.txt_box_Login_UserName.TabIndex = 9;
            this.txt_box_Login_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_box_Login_UserName.TextChanged += new System.EventHandler(this.txt_box_Login_UserName_TextChanged);
            // 
            // txt_box_Login_Password
            // 
            this.txt_box_Login_Password.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_Login_Password.Location = new System.Drawing.Point(70, 238);
            this.txt_box_Login_Password.Name = "txt_box_Login_Password";
            this.txt_box_Login_Password.Size = new System.Drawing.Size(266, 33);
            this.txt_box_Login_Password.TabIndex = 10;
            this.txt_box_Login_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_box_Login_Password.TextChanged += new System.EventHandler(this.txt_box_Login_Password_TextChanged);
            // 
            // Login_QuitButton
            // 
            this.Login_QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.Login_QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_QuitButton.FlatAppearance.BorderSize = 0;
            this.Login_QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_QuitButton.Location = new System.Drawing.Point(367, 3);
            this.Login_QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.Login_QuitButton.Name = "Login_QuitButton";
            this.Login_QuitButton.Size = new System.Drawing.Size(30, 30);
            this.Login_QuitButton.TabIndex = 11;
            this.Login_QuitButton.UseVisualStyleBackColor = true;
            this.Login_QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Login_QuitButton);
            this.Controls.Add(this.txt_box_Login_Password);
            this.Controls.Add(this.txt_box_Login_UserName);
            this.Controls.Add(this.Label_Login_Password);
            this.Controls.Add(this.Label_Login_UserName);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Button_Login_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Login_Back;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_Login_UserName;
        private System.Windows.Forms.Label Label_Login_Password;
        private System.Windows.Forms.TextBox txt_box_Login_UserName;
        private System.Windows.Forms.TextBox txt_box_Login_Password;
        private System.Windows.Forms.Button Login_QuitButton;
    }
}