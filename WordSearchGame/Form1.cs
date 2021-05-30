using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public static Color backgroundColor = Color.FromArgb(237, 224, 212); //Castanho claro
        Color buttonColorNormal = Color.FromArgb(127, 85, 57); //Castanho escuro
        Color buttonColorRed = Color.FromArgb(174, 32, 18); //Vermelho
        Color[] btnColors = new Color[19]; //Array para guardar as cores que vao ser utilizadas nos butões
        static int colorIndex = 0; //Variavel que guarda o index das cores

        //Arrays de objetos dinamicos
        Button[,] gameBtn = new Button[15, 15];
        CheckBox[] wordsCheck = new CheckBox[19];
        Label[] wordsLabel = new Label[19];

        //Arraylists das classes
        List<Moves> lm = new List<Moves>();
        List<Player> lp = new List<Player>();
        List<Words> lw = new List<Words>();

        //Instanciador de randoms
        Random rd;

        //Palavra a ser selecionada
        String word = "";

        //Nome do jogador 
        public static string playerName = "";

        //Contador de jogadas
        int jogadas = 0;

        //Thread 
        Thread trhd;

        //Cancel token
        CancellationTokenSource cts;

        //Timer
        System.Timers.Timer timer2;

        //Time data
        private int segundos = 0;
        private int minutos = 0;
        private int pseudoSegundos = 0;

        //Indicador de jogo Ativo
        private static bool gameState = false;

        //Guarda a direcao que a palavra atual esta a tomar
        String direcaoPalavra = "";

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

        Color cor = Color.FromArgb(100, 100, 100);
        
        //Administration credentials
        public string adminUserName = "admin";
        public string adminPassword = "1234";

        public Form1()
        {
            InitializeComponent();
            menuStrip1.BackColor = backgroundColor; //Colocar a cor de fundo do menu strip com o castanho claro
            generateColors();
            drawWords();
            drawButtons();
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
                    gameBtn[x, y].Name = x + "," + y;
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
        * Função que escreve o tempo decorrida na label 
        **/
        private void StartClock(object obj)
        {
            while (true)
            {
                CancellationToken token = (CancellationToken)obj;
                if (token.IsCancellationRequested)
                {
                    segundos = 0;
                    pseudoSegundos = 0;
                    minutos = 0;
                    return;
                }
                segundos++;

                if (segundos % 10 == 0)
                {
                    pseudoSegundos++;
                    segundos = 0;
                }


                if (pseudoSegundos > 5)
                {
                    segundos = 0;
                    pseudoSegundos = 0;
                    minutos++;

                }

                //A cada tick do relógio (1 segundo)
                Invoke((MethodInvoker)delegate ()
                {
                    Label_clock.Text = "Tempo: " + minutos.ToString() + ":" + pseudoSegundos.ToString() + segundos.ToString();
                });
                Thread.Sleep(1000);
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
            Moves move;
            Button clickedButton = (Button)sender;
            //Receber as coordenadas do butao clicado
            int x = Convert.ToInt32(clickedButton.Name.Split(',')[1]);
            int y = Convert.ToInt32(clickedButton.Name.Split(',')[0]);
            
            if (jogadas != 0)
            {
                if (x == lm[lm.Count - 1].CoordX && y == lm[lm.Count - 1].CoordY)
                {
                    return;
                }
                if (jogadas == 1)
                {
                    if (x > lm[lm.Count-1].CoordX + 1 || x < lm[lm.Count-1].CoordX -1)
                    {
                        resetWord();
                        return;
                    }else if(y > lm[lm.Count - 1].CoordY + 1 || y < lm[lm.Count - 1].CoordY - 1)
                    {
                        resetWord();
                        return;
                    }
                    if(x - 1 == lm[lm.Count - 1].CoordX && y == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "Direita";
                    }
                    else if (x + 1 == lm[lm.Count - 1].CoordX && y == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "Esquerda";
                    }
                    else if (x == lm[lm.Count - 1].CoordX && y - 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "Baixo";
                    }
                    else if (x == lm[lm.Count - 1].CoordX && y + 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "Cima";
                    }
                    else if (x + 1 == lm[lm.Count - 1].CoordX && y + 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "CimaEsquerda";
                    }
                    else if (x + 1 == lm[lm.Count - 1].CoordX && y - 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "BaixoEsquerda";
                    }
                    else if (x - 1 == lm[lm.Count - 1].CoordX && y + 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "CimaDireita";
                    }
                    else if (x - 1 == lm[lm.Count - 1].CoordX && y - 1 == lm[lm.Count - 1].CoordY)
                    {
                        direcaoPalavra = "BaixoDireita";
                    }
                }
                else
                {
                    if (direcaoPalavra.Equals("Baixo") && (x != lm[lm.Count - 1].CoordX || y - 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("Cima") && (x != lm[lm.Count - 1].CoordX || y + 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("Esquerda") && (x + 1 != lm[lm.Count - 1].CoordX || y != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("Direita") && (x - 1 != lm[lm.Count - 1].CoordX || y != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("CimaEsquerda") && (x + 1 != lm[lm.Count - 1].CoordX || y + 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("BaixoEsquerda") && (x + 1 != lm[lm.Count - 1].CoordX || y - 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("CimaDireita") && (x - 1 != lm[lm.Count - 1].CoordX || y + 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                    if (direcaoPalavra.Equals("BaixoDireita") && (x - 1 != lm[lm.Count - 1].CoordX || y - 1 != lm[lm.Count - 1].CoordY))
                    {
                        resetWord();
                        return;
                    }
                }
            }
            clickedButton.BackColor = btnColors[colorIndex];
            word += clickedButton.Text.ToLower(); //Adiciona o texto do botao à palavra a ser construida
            //Adiciona esta jogada à classe `moves` que guarda todas as jogadas
            move = new Moves(jogadas, "PLAYER", x, y, word);
            lm.Add(move);

            jogadas++;

            //Verifica se a palavra a ser construida é igual a alguma das palavras escolhidas
            for (int i = 0; i < words.Length; i++)
            {
                if (word.Equals(words[i]))
                {
                    wordFound(i);
                    break;
                }
            }
        }

        public void resetWord()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    if(gameBtn[x,y].BackColor == btnColors[colorIndex])
                    {
                        jogadas--;
                        gameBtn[x, y].BackColor = Color.Transparent;
                    }
                }
            }
            word = "";
        }

        /**
         * Esta função é acionada quando uma palavra é encontrada
         **/
        public void wordFound(int checkBoxIndex)
        {
            colorIndex++;
            word = "";
            wordsCheck[checkBoxIndex].Checked = true;
            jogadas = 0;
            string tempoJogada = "";

            for(int ct = 0; ct<wordsCheck.Length; ct++)
            {
                if(wordsCheck[ct].Checked == true) //Verifica se ainda há palavras por concluir 
                    return;

                else //Se as palavras estiverem todas concluidas
                {
                    //Reset a thread
                    cts.Cancel();
                    cts.Dispose();

                    tempoJogada = minutos + ":" + pseudoSegundos + segundos;

                    //Criado um novo registo de jogador
                    Player newPlayer = new Player(playerName, tempoJogada, jogadas);
                    //Adiciona-se o jogador à lista de jogadores 
                    lp.Add(newPlayer);
                }
            }
        }

        /**
         * Esta função gera as cores a ser utilizadas por cada palavra
         **/
        public void generateColors()
        {
            Color[] colorPallet =
            {
                Color.FromArgb(255, 173, 173),
                Color.FromArgb(255, 214, 165),
                Color.FromArgb(253, 255, 182),
                Color.FromArgb(202, 255, 191),
                Color.FromArgb(155, 246, 255),
                Color.FromArgb(160, 196, 255),
                Color.FromArgb(189, 178, 255),
                Color.FromArgb(255, 198, 255),
                Color.FromArgb(255, 255, 252),
                Color.FromArgb(38, 70, 83),
                Color.FromArgb(42, 157, 143),
                Color.FromArgb(233, 196, 106),
                Color.FromArgb(244, 162, 97),
                Color.FromArgb(231, 111, 81),
                Color.FromArgb(149, 213, 178),
                Color.FromArgb(27, 67, 50),
                Color.FromArgb(199, 125, 255),
                Color.FromArgb(36, 0, 70),
                Color.FromArgb(247, 209, 205)
            };
            for (int i = 0; i < words.Length; i++)
            {
                btnColors[i] = colorPallet[i];
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
            if(gameState == false)
            {
                var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (quitMsgBox == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                //Limpa os butões
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        gameBtn[x, y].Enabled = false;
                    }
                }
                gameState = false;
                //timer2.Stop();
                cts.Cancel();
                cts.Dispose();

                //Torna os Botões visiveis e acessiveis
                PlayerName_Button.Visible = true;
                Stats_Button.Visible = true;
                Label_clock.Visible = false;
                Quit_Button_Bottom.Text = "Quit Game";

            }
        }

        /**
         * Função que roda a matriz que contem as letras 
         **/
        private string[,] rotateBoard(int randNum, string[,] board)
        {
            string[,] newBoard = new string[15, 15];
            int k, j, l;
            switch (randNum)
            {
                case 1:
                    for (j = 0; j < 15; j++)
                    {
                        for (k = 0, l = 14; k < 15; k++, l--)
                        {
                            newBoard[l, j] = board[k, j];
                        }
                    }
                    break;
                case 2:
                    for (j = 0; j < 15; j++)
                    {
                        for (k = 0, l = 14; k < 15; k++, l--)
                        {
                            newBoard[j, k] = board[j, l];
                        }
                    }
                    break;
                case 3:
                    for (j = 0; j < 15; j++)
                    {
                        for (k = 0, l = 14; k < 15; k++, l--)
                        {
                            newBoard[k, j] = board[j, l];
                        }
                    }
                    break;
                default:
                    break;
            }
            return newBoard;
        }

        /**
         * Botão do menu sul que inicia um novo jogo
         **/
        private void NewGame_Button_Click(object sender, EventArgs e)
        {
            //Verificar se existe username 
            if (playerName.Equals(""))
            {
                AboutForm about = new AboutForm(4);
                about.ShowDialog();
            }
            else { //Se existir username 
                //Se a thread ainda estiver a correr
                if (gameState == true)
                {
                    //Stop a thread
                    cts.Cancel();
                    cts.Dispose();
                }

                //Modo de jogo passa a ser true = Em jogo
                gameState = true;

                //Esconder os Butões
                PlayerName_Button.Hide();
                Stats_Button.Hide();
                //Muda o texto do botão de "Sair"
                Quit_Button_Bottom.Text = "Stop";

                //Ativação da label
                Label_clock.Text = "";
                Label_clock.Visible = true;

                //Instanciacao do Token
                cts = new CancellationTokenSource();
                //Inicalizacao da thread
                ThreadPool.QueueUserWorkItem(new WaitCallback(StartClock), cts.Token);


                jogadas = 0;
                word = "";
                //Gera um número random de 0 a 3 inclusive
                rd = new Random();
                int randNum = rd.Next(4);
                if (randNum != 0) //Se o número for diferente de 0 vai rodar para um dos lados, se for igual a 0 fica igual
                {
                    board = rotateBoard(randNum, board);
                }
                //Limpa os butões
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        gameBtn[x, y].Enabled = true;
                        gameBtn[x, y].Text = board[x, y].ToUpper();
                        gameBtn[x, y].BackColor = Color.Transparent;
                    }
                }
                //Limpa as palavras
                for (int i = 0; i < words.Length; i++)
                {
                    wordsCheck[i].Checked = false;
                }
                lm.Clear();
            }
        }

        /**
         * Butão do menu sul que faz o rewind da ultima jogada
         **/
        private void LastMove_Button_Click(object sender, EventArgs e)
        {
            if(jogadas != 0)
            {
                jogadas--;
                word = word.Substring(0, word.Length - 1);
                gameBtn[lm[lm.Count - 1].CoordY, lm[lm.Count - 1].CoordX].BackColor = Color.Transparent;
                lm.RemoveAt(lm.Count - 1);
            }
        }

        /**
        * Butão do menu bar que permite fazer login como administrador
        **/
        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm LoginFrm = new LoginForm(adminUserName, adminPassword); //Instance Login Form
            LoginFrm.ShowDialog();  //Call Login Form
        }

       

        /**
        * Butão do menu bar que permite inserir um username
        **/
        private void playerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admit_UserName_Form userNameForm = new admit_UserName_Form();
            userNameForm.ShowDialog();
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

        private void PlayerName_Button_Click(object sender, EventArgs e)
        {
            admit_UserName_Form userNameForm = new admit_UserName_Form();
            userNameForm.ShowDialog();
        }
    }
}
