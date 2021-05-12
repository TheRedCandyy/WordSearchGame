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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Login_Password_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Do you wanto to cancel?", "Cancel Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Back Btn
        private void Button_Login_Back_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Do you wanto to cancel?", "Cancel Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Login Btn
        private void Button_Login_Click(object sender, EventArgs e)
        {

        }
        //Txt Box Username
        private void txt_box_Login_UserName_TextChanged(object sender, EventArgs e)
        {

        }
        //Txt Box Password
        private void txt_box_Login_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
