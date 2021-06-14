using System;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class Admin_NewWord : UserControl
    {
        public string category;
        public Admin_NewWord()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            normalRadioButton.Checked = true;
            disableWord();
        }

        private void confirmCatButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Words word in Form1.lw)
            {
                if (word.Category.Equals(categoryTextBox.Text))
                {
                    count++;
                }
            }
            if (count == 15)
            {
                MessageBox.Show("This category is full, try another category.", "Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            category = categoryTextBox.Text;
            enableWord();
            MessageBox.Show("Using the selected category!", "Success", MessageBoxButtons.OK);
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            string alignment = "";
            string writingMode = "";
            if (radioButton1.Checked)
            {
                alignment = "[Horizontal] L -> R";
            }
            else if (radioButton2.Checked)
            {
                alignment = "[Vertical] U -> D";
            }
            else if (radioButton3.Checked)
            {
                alignment = "[Oblique] U -> D";
            }
            else if (radioButton4.Checked)
            {
                alignment = "[Oblique] D -> U";
            }
            if (normalRadioButton.Checked)
            {
                writingMode = "Normal";
            }
            else
            {
                writingMode = "Reverse";
            }
            foreach (Words w in Form1.lw)
            {
                if (w.Word.Equals(wordTextBox.Text))
                {
                    MessageBox.Show("There already exists an equal word in this category!", "Word Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (w.Line.Equals(lineTextBox.Text) && w.Col.Equals(colTextBox.Text) && w.Alignment.Equals(alignment) && w.Dim.Equals(dimensionTextBox.Text))
                {
                    MessageBox.Show("There already exists a word in this position!", "Word Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Words words;
            words = new Words(wordTextBox.Text, Convert.ToInt32(lineTextBox.Text), Convert.ToInt32(colTextBox.Text), Convert.ToInt32(dimensionTextBox.Text), writingMode, alignment, category);
            Form1.lw.Add(words);
            MessageBox.Show("New word added with success!", "Success", MessageBoxButtons.OK);
        }

        private void previewWordButton_Click(object sender, EventArgs e)
        {

        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            categoryTextBox.Text = "";
            wordTextBox.Text = "";
            dimensionTextBox.Text = "";
            lineTextBox.Text = "";
            colTextBox.Text = "";
            radioButton1.Checked = true;
            normalRadioButton.Checked = true;
            disableWord();
        }
        public void enableWord()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Enabled = true;
            }
        }
        public void disableWord()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
