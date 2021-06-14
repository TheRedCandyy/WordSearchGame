using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class LoginForm : Form
    {
        public String adminUserName;
        public String adminPassword;
        public int numTrys = 3; //Variable that stores the number of attempts left to login (Statrs with 3 attempts)

        public LoginForm(String UserName, String Password)
        {
            InitializeComponent();

            adminUserName = UserName;
            adminPassword = Password;

            Label_Tentativas_Restantes.Text = "Tentativas Restantes: " + numTrys; //Set the label that shows the number of attempts by default
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Label_Login_Password_Click(object sender, EventArgs e)
        {

        }
        /*
         * Top left quit button
         */
        private void QuitButton_Click(object sender, EventArgs e) 
        {
            var quitMsgBox = MessageBox.Show("Are you Sure?", "Cancel Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*
        * "Back" button 
        */
        private void Button_Login_Back_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you Sure?", "Cancel Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*
        * Login Button
        */
        private void Button_Login_Click(object sender, EventArgs e)
        {
            //Check if the login credentials match the ones for admin control
            if ( txt_box_Login_UserName.Text.Equals( adminUserName ) && txt_box_Login_Password.Text.Equals( adminPassword ) )  //Check if the username and password match
            {
                //Success Message
                MessageBox.Show("Login Successful !\n\nBem Vindo " + adminUserName, "Login complete", MessageBoxButtons.OK);
                Form1.adminMode = true;
                this.Close();
            }
            else { numTrys--; } //Decrease the number of attempts left

            //If the credentials dont match, an erro message is displayed
            if ( numTrys < 3 && numTrys > 0)
            {
                var quitMsgBox = MessageBox.Show("\nUnknown UserName or Password ", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); //Error Message
                if ( quitMsgBox == DialogResult.Retry ){ //If there are attemps left and the user wants to retry
                    txt_box_Login_UserName.Text = "";    //Reset textbox text
                    txt_box_Login_Password.Text = "";    //Reset textbox text
                    txt_box_Login_UserName.Focus();      //Focus on username textbox
                    Label_Tentativas_Restantes.Text = "Tentativas Restantes: " + numTrys; //Chanch the label that shows the number of attemps that are left
                }
                else
                {
                    this.Close();
                }
            }
            if ( numTrys <=0 ) //If there are no more attempts left
            {
                MessageBox.Show("\nThere are no more attempts left\n\nLogin Faild", "Too Many Attempts", MessageBoxButtons.OK, MessageBoxIcon.Error); //Erro Message
                this.Close();
            }
        }
    }
}
