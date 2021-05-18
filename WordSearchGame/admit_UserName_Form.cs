using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WordSearchGame
{
    public partial class admit_UserName_Form : Form
    {
        public admit_UserName_Form()
        {
            InitializeComponent();
            txt_box_UserName.Text = ""; //Clears the textbox
            txt_box_UserName.Focus();   //Focus on the textbox
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

        }

        private void Button_UserName_Apply_Click_1(object sender, EventArgs e)
        {
            Form1.playerName = txt_box_UserName.Text;
            this.Close();
        }
    }
}
