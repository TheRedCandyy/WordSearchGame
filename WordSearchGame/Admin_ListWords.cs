using System;
using System.Linq;
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
        /**
         * Carrega as palavras da classe para a listBox
         **/
        public void loadWords()
        {
            if (Form1.lw.Count() == 0) // Se a classe estiver vazia
            {
                wordsListBox.Items.Add("There are no words to be listed.");
            }
            else //Se não estiver vazia
            {
                //Cabeçalho da listbox
                wordsListBox.Items.Add(String.Format("{0,10} | {1, 15} | {2, 5} | {3, 6} | {4, 9} | {5, 15} | {6, 15}", "Category", "Word", "Column", "Line", "Dimension", "W Mode", "Alignment"));
                foreach (Words w in Form1.lw) //Preenche a listbox com as palavras usando o ToString predefenido na classe
                {
                    wordsListBox.Items.Add(w);
                }
            }
        }
    }
}
