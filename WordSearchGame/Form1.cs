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
        Color[] btnColors = new Color[19]; //Array para guardar as cores que vao ser utilizadas nos butões
        int colorIndex; //Variavel que guarda o index das cores

        //Arrays de objetos dinamicos
        Button[,] gameBtn = new Button[15, 15];
        CheckBox[] wordsCheck = new CheckBox[19];
        Label[] wordsLabel = new Label[19];

        //Instanciador de randoms
        Random rd;

        //Palavra a ser selecionada
        String word = "";

        String[] words =
        {
            "norte",
            "sul",
            "este",
            "oeste",
            "cao",
            "gato",
            "cobra",
            "peixe",
            "ave",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        String[,] board =
        {
            {"a","p","d","e","f","g","t","e","p","t","e","p","t","e","p" },
            {"c","o","e","f","g","l","u","s","t","t","e","p","t","e","p" },
            {"a","r","t","i","s","i","j","t","p","t","e","p","t","e","p" },
            {"v","t","d","a","x","u","l","e","w","t","e","p","t","e","p" },
            {"e","k","z","t","g","e","l","i","s","t","e","p","t","e","p" },
            {"d","z","f","o","h","i","k","t","q","t","e","p","t","e","p" },
            {"c","a","o","f","g","h","u","r","t","t","e","p","t","e","p" },
            {"a","t","d","e","o","e","s","t","e","t","e","p","t","e","p" },
            {"d","c","o","b","r","a","k","t","q","t","e","p","t","e","p" },
            {"c","a","o","f","g","h","u","r","t","t","e","p","t","e","p" },
            {"a","t","d","e","o","e","s","t","e","t","e","p","t","e","p" },
            {"d","c","o","b","r","a","k","t","q","t","e","p","t","e","p" },
            {"c","a","o","f","g","h","u","r","t","t","e","p","t","e","p" },
            {"a","t","d","e","o","e","s","t","e","t","e","p","t","e","p" },
            {"d","c","o","b","r","a","k","t","q","t","e","p","t","e","p" }
        };
        public Form1()
        {
            InitializeComponent();
            menuStrip1.BackColor = backgroundColor; //Colocar a cor de fundo do menu strip com o castanho claro
            drawButtons();
            drawWords();
            generateColors();
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
                    gameBtn[x, y].Text = board[x,y].ToUpper();
                    gameBtn[x, y].FlatStyle = FlatStyle.Flat;
                    gameBtn[x, y].FlatAppearance.BorderSize = 0;
                    gameBtn[x, y].BackColor = Color.Transparent;
                    gameBtn[x, y].Width = 110;
                    gameBtn[x, y].Height = 110;
                    gameBtn[x, y].Enabled = false;
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
                wordsLabel[i].Text = words[i].ToUpper();
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
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = btnColors[colorIndex];

            word += clickedButton.Text;
            for (int i = 0; i < words.Length; i++)
            {
                if (word.Equals(words[i]))
                {
                    wordFound(i);
                    break;
                }
            }
        }

        /**
         * Esta função é acionada quando uma palavra é encontrada
         **/
        public void wordFound(int checkBoxIndex)
        {
            colorIndex++;
            word = "";
            wordsCheck[checkBoxIndex].Checked = true;
        }

        /**
         * Esta função gera as cores a ser utilizadas por cada palavra
         **/
        public void generateColors()
        {
            for (int i = 0; i < words.Length; i++)
            {
                rd = new Random();
                btnColors[i] = new Color();
                int red, blue, green;
                red = rd.Next(255);
                blue = rd.Next(255);
                green = rd.Next(255);
                btnColors[i] = Color.FromArgb(red, green, blue);
            }
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

        private void NewGame_Button_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    gameBtn[x, y].Enabled = true;
                }
            }
        }
    }
}
