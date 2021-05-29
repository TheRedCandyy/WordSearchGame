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
    public partial class AboutForm : Form
    {
        public AboutForm(int option)
        {
            InitializeComponent();
            Title_Label.Text = "Title";
            Text_Label.Text = "Text";
            switch (option)
            {
                case 1:
                    Title_Label.Text = "Development Language";
                    Text_Label.Text = "The language used to develop this software\nwas C#.\n" +
                                      "This software was created as a Windows Form\nApplication.\n" +
                                      "The framework used was .NET Framework 4.7.2.";
                    break;
                case 2:
                    Title_Label.Text = "Software";
                    Text_Label.Text = "This software was created as a school project\nin ATEC.\n" +
                                      "The objective of this software is to simulate\nthe famous word search games found in\nnewspapers.";
                    break;
                case 3:
                    Title_Label.Text = "Authors";
                    Text_Label.Text = "TPSI1020 PL\n" +
                                      "Alexandre Tavares\n" +
                                      "Diogo Guedes";
                    break;
                case 4:
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
