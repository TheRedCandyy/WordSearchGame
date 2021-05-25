
namespace WordSearchGame
{
    partial class AboutForm
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
            this.Title_Label = new System.Windows.Forms.Label();
            this.Text_Label = new System.Windows.Forms.Label();
            this.About_OkayButton = new System.Windows.Forms.Button();
            this.About_QuitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(17, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(66, 33);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Title";
            // 
            // Text_Label
            // 
            this.Text_Label.AutoSize = true;
            this.Text_Label.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Text_Label.Location = new System.Drawing.Point(7, 9);
            this.Text_Label.Name = "Text_Label";
            this.Text_Label.Size = new System.Drawing.Size(36, 20);
            this.Text_Label.TabIndex = 13;
            this.Text_Label.Text = "Text";
            // 
            // About_OkayButton
            // 
            this.About_OkayButton.BackgroundImage = global::WordSearchGame.Properties.Resources.ok_50px;
            this.About_OkayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.About_OkayButton.FlatAppearance.BorderSize = 0;
            this.About_OkayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_OkayButton.Location = new System.Drawing.Point(184, 197);
            this.About_OkayButton.Margin = new System.Windows.Forms.Padding(5);
            this.About_OkayButton.Name = "About_OkayButton";
            this.About_OkayButton.Size = new System.Drawing.Size(40, 39);
            this.About_OkayButton.TabIndex = 14;
            this.About_OkayButton.UseVisualStyleBackColor = true;
            this.About_OkayButton.Click += new System.EventHandler(this.About_OkayButton_Click);
            // 
            // About_QuitButton
            // 
            this.About_QuitButton.BackgroundImage = global::WordSearchGame.Properties.Resources.close_window_50px;
            this.About_QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.About_QuitButton.FlatAppearance.BorderSize = 0;
            this.About_QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_QuitButton.Location = new System.Drawing.Point(366, 3);
            this.About_QuitButton.Margin = new System.Windows.Forms.Padding(5);
            this.About_QuitButton.Name = "About_QuitButton";
            this.About_QuitButton.Size = new System.Drawing.Size(30, 30);
            this.About_QuitButton.TabIndex = 12;
            this.About_QuitButton.UseVisualStyleBackColor = true;
            this.About_QuitButton.Click += new System.EventHandler(this.About_QuitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Text_Label);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 120);
            this.panel1.TabIndex = 15;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.About_OkayButton);
            this.Controls.Add(this.About_QuitButton);
            this.Controls.Add(this.Title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Button About_QuitButton;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.Button About_OkayButton;
        private System.Windows.Forms.Panel panel1;
    }
}