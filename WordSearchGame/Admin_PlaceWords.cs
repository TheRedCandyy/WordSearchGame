using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class Admin_PlaceWords : UserControl
    {
        public static string category;
        public Admin_PlaceWords()
        {
            InitializeComponent();
            loadCategorys();
            PlaceWordsButton.Enabled = false;
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
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            category = comboBox1.SelectedItem.ToString();
            label2.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaceWordsButton.Enabled = true;
        }
    }
}
