using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class admit_UserName_Form : Form
    {
        bool checkForUser;
        public admit_UserName_Form()
        {
            InitializeComponent();
        }
        /*
        * "Back" button 
        */
        private void Button_UserName_Back_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you Sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*
        * Top left quit button
        */
        private void UserName_QuitButton_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you Sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void admit_UserName_Form_Load(object sender, EventArgs e)
        {
            if (Form1.playerName.Equals(""))
            {
                checkForUser = false;

                txt_box_UserName.Enabled = true;
                txt_box_UserName.Text = "";
                txt_box_UserName.BackColor = Color.White;

                Button_UserName_Apply.Text = "Apply";
            }

            else
            {
                checkForUser = true;

                txt_box_UserName.BackColor = Form1.backgroundColor;
                txt_box_UserName.Enabled = false;
                txt_box_UserName.Text = Form1.playerName;

                Button_UserName_Apply.Text = "Change Name";
            }
        }

        private void Button_UserName_Apply_Click_1(object sender, EventArgs e)
        {
            if (checkForUser == false)
            {
                Form1.playerName = txt_box_UserName.Text;
                checkForUser = true;
                this.Close();
            }
            else
            {
                checkForUser = false;
                this.Controls.Clear();
                this.InitializeComponent();

            }
        }
    }
}
