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
    public partial class Form1 : Form
    {
        /**
         * Variáveis Globais
         **/

        //Cores utilizadas
        Color backgroundColor = Color.FromArgb(237, 224, 212); //Castanho claro
        Color buttonColorNormal = Color.FromArgb(127, 85, 57); //Castanho escuro
        Color buttonColorRed = Color.FromArgb(174, 32, 18); //Vermelho

        Button[,] gameBtn = new Button[15, 15];
        CheckBox[] wordsCheck = new CheckBox[19];
        Label[] wordsLabel = new Label[19];
        public Form1()
        {
            InitializeComponent();
            menuStrip1.BackColor = backgroundColor; //Colocar a cor de fundo do menu strip com o castanho claro
            drawButtons();
            drawWords();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**
         * Função que desenha os butões inicialmente
         **/
        private void drawButtons()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    gameBtn[x, y] = new Button();
                    gameBtn[x, y].Text = "X";
                    gameBtn[x, y].FlatStyle = FlatStyle.Flat;
                    gameBtn[x, y].FlatAppearance.BorderSize = 0;
                    gameBtn[x, y].BackColor = Color.Transparent;
                    gameBtn[x, y].Width = 110;
                    gameBtn[x, y].Height = 110;
                    gameBtn[x, y].Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    gameBtn[x, y].Click += new EventHandler(this.btnClick);
                    this.GamePanel.Controls.Add(gameBtn[x, y], y, x);
                }
            }
        }

        /**
         * Função que desenha as palavras no painel da direita
         * checkboxes e labels com as palavras
         **/
        private void drawWords() //Mais tarde vai receber como parametro o array de palavras do tabuleiro selecionado
        {
            for (int i = 0; i < wordsLabel.Length; i++)
            {
                //Criacao e Customizacao de checkboxes
                wordsCheck[i] = new CheckBox();
                wordsCheck[i].Text = "";
                wordsCheck[i].AutoSize = true;
                wordsCheck[i].Enabled = false;
                wordsCheck[i].Dock = DockStyle.Right;
                wordsCheck[i].Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.WordsPanel.Controls.Add(wordsCheck[i], 0, i);

                //Criacao e Customizacao de labels com as palavras
                wordsLabel[i] = new Label();
                wordsLabel[i].Text = "Testing";
                wordsLabel[i].TextAlign = ContentAlignment.BottomLeft;
                wordsLabel[i].Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.WordsPanel.Controls.Add(wordsLabel[i], 1, i);
            }
        }

        /**
         * Ao clicar num butao esta função corre
         **/
        private void btnClick(object sender, EventArgs e)
        {

        }

        /**
         * Butão do menu superior direito que minimiza a janela
         **/
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * Butao do menu superior direito que tenta sair da aplicação
         **/
        private void QuitButton_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(quitMsgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /**
         * Butão do menu sul que tenta sair da aplicação
         **/
        private void Quit_Button_Bottom_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm LoginFrm = new LoginForm(); //Instance Login Form
            LoginFrm.ShowDialog();  //Call Login Form
        }
    }
}
