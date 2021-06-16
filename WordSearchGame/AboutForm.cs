using System;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class AboutForm : Form
    {
        /*
         * Form dinamico para as opções na barra de menu sobre as informações do programa e outros
         */
        public AboutForm(int option)
        {
            InitializeComponent();
            Title_Label.Text = "Title";
            Text_Label.Text = "Text";
            switch (option)
            {
                case 1: //Mostra texto da development language
                    Title_Label.Text = "Development Language";
                    Text_Label.Text = "The language used to develop this software\nwas C#.\n" +
                                      "This software was created as a Windows Form\nApplication.\n" +
                                      "The framework used was .NET Framework 4.7.2.";
                    break;
                case 2: //Mostra texto do software utilizado
                    Title_Label.Text = "Software";
                    Text_Label.Text = "This software was created as a school project\nin ATEC.\n" +
                                      "The objective of this software is to simulate\nthe famous word search games found in\nnewspapers.";
                    break;
                case 3: //Mostra texto sobre os autores
                    Title_Label.Text = "Authors";
                    Text_Label.Text = "TPSI1020 PL\n" +
                                      "Alexandre Tavares\n" +
                                      "Diogo Guedes";
                    break;
                case 4: //Mostra erro de falha de username
                    Title_Label.Text = "Missing UserName";
                    Text_Label.Text = "Please insert a userName";

                    break;
                default:
                    Title_Label.Text = "Title";
                    Text_Label.Text = "Text";
                    break;
            }
        }

        private void About_QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_OkayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
