using System;
using System.Linq;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class AdminForm : Form
    {
        public AdminForm(int option)
        {
            InitializeComponent();
            switch (option)
            {
                //Nova palavra
                case 1:
                    newWordToolStripMenuItem.PerformClick();
                    break;
                case 2:
                    placeWordsToolStripMenuItem.PerformClick();
                    break;
                case 3:
                    wordsListToolStripMenuItem.PerformClick();
                    break;
                default:
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                    break;
            }
        }

        /**
         * Abre o form about com os dados da linguagem de desenvolvimento
         **/
        private void devLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(1);
            about.ShowDialog();
        }

        /**
         * Abre o form about com os dados do software
         **/
        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(2);
            about.ShowDialog();
        }

        /**
         * Abre o form about com os dados sobre os autores do programa
         **/
        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(3);
            about.ShowDialog();
        }

        /**
         * Ocupa todos os espaços que nao têm uma letra ainda
         **/
        private void fillEmptySpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char randomChar;
            var random = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (Form1.gameBtn[i, j].Text.Equals("") || Form1.gameBtn[i, j].Text.Equals(null))
                    {
                        randomChar = chars[random.Next(chars.Length)];
                        Form1.gameBtn[i, j].Text = randomChar.ToString();
                    }
                }
            }
        }

        /**
         * Limpa todos os botões
         **/
        private void deleteLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Form1.gameBtn[i, j].Text = "";
                }
            }
        }

        /**
         * Botao para fechar esta janela
         **/
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Mostra o usercontrol para inserção de nova palavra
         */
        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_NewWord newWord = new Admin_NewWord();
            newWord.Visible = false;
            panel1.Controls.Add(newWord);
            foreach (UserControl userControl in panel1.Controls.OfType<UserControl>())
            {
                userControl.Visible = false;
            }
            newWord.Visible = true;
        }
        /*
         * Mostra o usercontrol para listagem de todas as palavras
         */
        private void wordsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_ListWords listWords = new Admin_ListWords();
            listWords.Visible = false;
            panel1.Controls.Add(listWords);
            foreach (UserControl userControl in panel1.Controls.OfType<UserControl>())
            {
                userControl.Visible = false;
            }
            listWords.Visible = true;
        }
        /*
         * Mostra o usercontrol para colocar as palavras no jogo
         */
        private void placeWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_PlaceWords placeWords = new Admin_PlaceWords();
            placeWords.Visible = false;
            panel1.Controls.Add(placeWords);
            foreach (UserControl userControl in panel1.Controls.OfType<UserControl>())
            {
                userControl.Visible = false;
            }
            placeWords.Visible = true;
        }
    }
}
