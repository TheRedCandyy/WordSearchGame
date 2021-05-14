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
        Player player = new Player();
        List <Player> PlayersList = new List<Player>(); //List of players 
        string playerName = ""; //String that will keep the name introduced by the user in the TtxBox


        public admit_UserName_Form(List<Player> Players)
        {
            InitializeComponent();
            PlayersList = Players;
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
        /*
        * Apply left quit button
        */
        private void Button_UserName_Apply_Click(object sender, EventArgs e)
        {
            string AuxPlayerName = "";

                playerName = txt_box_UserName.Text;

                foreach (Player Pl in PlayersList)             //Run all the players in class player and see if that username is already in use
                {
                    AuxPlayerName = Pl.Nome;

                    //Check if the name already exists
                    if (AuxPlayerName.Equals(playerName)) //If there is a match
                    {
                        //That name is already taken
                        //Error message
                        var nameAlreadyExists = MessageBox.Show("This name is already in use\nPlease insert another name ?", "UserName already Exists", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        if (nameAlreadyExists == DialogResult.Cancel)// If the user wants to cancel the operation
                        {
                            this.Close(); //Closes the pop up 
                        }
                        if (nameAlreadyExists == DialogResult.Retry) //If the user wants to retray to insert a name
                        {
                            txt_box_UserName.Text = ""; //Clears the textbox
                            txt_box_UserName.Focus();
                            return;
                        }
                    }
                }
            
            //If the name is NOT taken
            //A new player is added to the list
            Player newPL = new Player(playerName); //A new player is created
            PlayersList.Add(newPL); //The new player is addeded to the list

            //Succsses message
            var newPlayerSuccsess = MessageBox.Show("Welcome " + playerName + "\nHave a good Game ", "Succsess", MessageBoxButtons.OK);
            this.Close();
        }

        private void admit_UserName_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
