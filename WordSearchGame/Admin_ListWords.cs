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
    public partial class Admin_ListWords : UserControl
    {
        public Admin_ListWords()
        {
            InitializeComponent();
            loadWords();
        }
        public void loadWords()
        {
            if (Form1.lw.Count() == 0)
            {
                wordsListBox.Items.Add("There are no words to be listed.");
                return;
            }
            wordsListBox.Items.Add(String.Format("{0,10} | {1, 15} | {2, 5} | {3, 6} | {4, 9} | {5, 15} | {6, 15}", "Category", "Word", "Column", "Line", "Dimension", "W Mode", "Alignment"));
            foreach (Words w in Form1.lw)
            {
                wordsListBox.Items.Add(w);
            }
        }
    }
}
