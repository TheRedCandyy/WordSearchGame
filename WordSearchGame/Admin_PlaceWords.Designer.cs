
namespace WordSearchGame
{
    partial class Admin_PlaceWords
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PlaceWordsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a category:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(361, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // PlaceWordsButton
            // 
            this.PlaceWordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.PlaceWordsButton.FlatAppearance.BorderSize = 0;
            this.PlaceWordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceWordsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceWordsButton.ForeColor = System.Drawing.Color.White;
            this.PlaceWordsButton.Location = new System.Drawing.Point(303, 229);
            this.PlaceWordsButton.Name = "PlaceWordsButton";
            this.PlaceWordsButton.Size = new System.Drawing.Size(150, 50);
            this.PlaceWordsButton.TabIndex = 5;
            this.PlaceWordsButton.Text = "Place Words";
            this.PlaceWordsButton.UseVisualStyleBackColor = false;
            this.PlaceWordsButton.Click += new System.EventHandler(this.PlaceWordsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(175, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Words will be place as soon as you leave this window!";
            this.label2.Visible = false;
            // 
            // Admin_PlaceWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceWordsButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_PlaceWords";
            this.Size = new System.Drawing.Size(800, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button PlaceWordsButton;
        private System.Windows.Forms.Label label2;
    }
}
