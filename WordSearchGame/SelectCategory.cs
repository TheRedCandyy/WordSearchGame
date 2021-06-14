using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSearchGame
{

    public partial class SelectCategory : Form
    {
        public static string category;
        public SelectCategory()
        {
            InitializeComponent();
            loadCategorys();
            //StartGameButton.Enabled = false;
        }
        public void loadCategorys()
        {
            var listOfCategory = new List<string>();
            int count = 0;
            bool exists = false;
            foreach (Words w in Form1.lw)
            {
                if (count == 0)
                {
                    listOfCategory.Add(w.Category);
                    count++;
                }
                exists = false;
                foreach (var c in listOfCategory)
                {
                    if (c.Equals(w.Category))
                    {
                        exists = true;
                    }
                }
                if (exists == false)
                {
                    listOfCategory.Add(w.Category);
                    count++;
                }
            }
            foreach (var c in listOfCategory)
            {
                comboBox1.Items.Add(c);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartGameButton.Enabled = true;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            category = comboBox1.SelectedItem.ToString();
            this.Close();
        }
    }
}
