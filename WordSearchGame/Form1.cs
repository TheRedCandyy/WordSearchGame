using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
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
        public static Button[,] gameBtn = new Button[15, 15];
        public static CheckBox[] wordsCheck = new CheckBox[19];
        public static Label[] wordsLabel = new Label[19];

        //Arraylists das classes
        public static List<Moves> lm = new List<Moves>();
        public static List<Player> lp = new List<Player>();
        public static List<Words> lw = new List<Words>();

        //Instanciador de randoms
        Random rd;

        //Palavra a ser selecionada
        String word = "";

        //Letras no jogo
        string[,] board = new string[15, 15];

        //Nome do jogador 
        public static string playerName = "";

        //Contador de jogadas
        int jogadas = 0;

        //Cancel token
        CancellationTokenSource cts;

        //Time data
        private int segundos = 0;
        private int minutos = 0;
        private int pseudoSegundos = 0;
        private int tempoReal = 0;

        //Indicador de jogo Ativo
        private static bool gameState = false;

        //Guarda a direcao que a palavra atual esta a tomar
        String direcaoPalavra = "";

        //Administration credentials
        public string adminUserName = "admin";
        public string adminPassword = "1234";
        public static bool adminMode = true;

        //Tipo de jogo (Normal, replay ou demo)
        public string typeOfGame;
        //Guarda a categoria do jogo atual
        string category;

        public Form1()
        {
            readFromFile(); //Se o ficheiro com as palavras para popular a classe
            InitializeComponent();
            menuStrip1.BackColor = backgroundColor; //Colocar a cor de fundo do menu strip com o castanho claro
            drawButtons(); //Desenha os butoes de jogo no form

            if (adminMode.Equals(true)) //Se o utilizador entrar em modo de administrador ativa todos os botões da aba "Be A Creator"
            {
                creatorToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem item in creatorToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>()) //Corre todos os items dentro do "creatorToolStripMenuItem" e faz o enable deles
                {
                    item.Enabled = true;
                }
            }
        }

        /*
         * Se o ficheiro com as palavras para popular a classe
         */
        public void readFromFile()
        {
            try
            {
                //Pergunta se o utilizador quer fazer o upload de algum ficheiro com palavras
                var msg = MessageBox.Show("Do you want to load any files to populate the words?", "Load Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    var fileContent = string.Empty;
                    var filePath = string.Empty;

                    //Abre um FileDialog para selecionar o ficheiro a ser utilizado
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\"; //Diretorio inicial
                        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //Ficheiros permitidos
                        openFileDialog.FilterIndex = 2; //Index de filtragem
                        openFileDialog.RestoreDirectory = true; //Restauração do ultimo diretorio selecionado

                        //Se for inserido um ficheiro
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Guarda o caminho do ficheiro selecionado
                            filePath = openFileDialog.FileName;

                            //Lê as linhas do ficheiro para um array de strings
                            string[] lines = File.ReadAllLines(filePath);
                            foreach (string line in lines)
                            {
                                string[] col = line.Split(','); //Separa os conteudos desta linha por colunas usando a virgula como separador
                                                                //Faz a população da lista da classe words com os dados da linha
                                Words word = new Words(col[0], Convert.ToInt32(col[1]), Convert.ToInt32(col[2]), Convert.ToInt32(col[3]), col[4], col[5], col[6]);
                                lw.Add(word);
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("There was an error loading the selected file!", "Load Files", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Successfully loaded the file selected into the program!", "Load Files", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        /*
         * Guarda todas as palavras na classe words num ficheiro com o nome WordSearchGame_Words.txt no Desktop do utilizador
         */
        public void saveInFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, "WordSearchGame_Words.txt"), true))
            {
                foreach (Words w in lw)
                {
                    outputFile.WriteLine(w.ToString1());
                }
            }
        }


        /**
         * Função que chama um form que adminte um username
         * Verifica se esse username já se encontra registado ou não
         **/
        private void newUserName()
        {
            string AuxPlayerName = "";

            admit_UserName_Form userNameForm = new admit_UserName_Form();
            userNameForm.ShowDialog();

            while (true)
            {
                if (lp.Count == 0) //If there is no names on the list
                {
                    //A new player is added to the list
                    Player newPLyr = new Player(playerName); //A new player is created
                    lp.Add(newPLyr); //The new player is added to the list

                    //Success Message
                    var newPlayerSuccsess = MessageBox.Show("Welcome " + playerName + "\nHave a good Game ", "Succsess", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    foreach (Player Plyr in lp)  //Runs all the players in class player and see if that username is already in use
                    {
                        AuxPlayerName = Plyr.Nome;

                        //Check if the name already exists
                        if (AuxPlayerName.Equals(playerName)) //If there is a match
                        {
                            //That name is already taken
                            //Error message
                            var nameAlreadyExists = MessageBox.Show("This name is already in use\nPlease insert another name ?", "UserName already Exists", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                            if (nameAlreadyExists == DialogResult.Cancel)// If the user wants to cancel the operation
                            {
                                return;
                            }
                            if (nameAlreadyExists == DialogResult.Retry) //If the user wants to retray to insert a name
                            {
                                userNameForm.ShowDialog();
                            }
                        }//End Main IF
                        else
                        {
                            //If the name is NOT taken
                            //A new player is added to the list
                            Player newPLyr = new Player(playerName); //A new player is created
                            lp.Add(newPLyr); //The new player is added to the list

                            //Success Message
                            var newPlayerSuccsess = MessageBox.Show("Welcome " + playerName + "\nHave a good Game ", "Succsess", MessageBoxButtons.OK);

                            return;
                        }
                    }//End Foreach
                }//End Main ELSE
            }//End While

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
                    board[x, y] = "X";
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
                tempoReal++;

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
        private void drawWords(string category) //Mais tarde vai receber como parametro o array de palavras do tabuleiro selecionado
        {
            foreach (Control c in WordsPanel.Controls)
            {
                WordsPanel.Controls.Remove(c);
            }
            int i = 0;
            foreach (Words w in lw)
            {
                if (w.Category.Equals(category))
                {
                    //Criacao e Customizacao de checkboxes
                    wordsCheck[i] = new CheckBox();
                    wordsCheck[i].Text = "";
                    wordsCheck[i].AutoSize = true;
                    wordsCheck[i].Enabled = false;
                    wordsCheck[i].Dock = DockStyle.Right;
                    wordsCheck[i].Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    WordsPanel.Controls.Add(wordsCheck[i], 0, i);

                    //Criacao e Customizacao de labels com as palavras
                    wordsLabel[i] = new Label();
                    wordsLabel[i].Text = w.Word;
                    wordsLabel[i].TextAlign = ContentAlignment.BottomLeft;
                    wordsLabel[i].Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    WordsPanel.Controls.Add(wordsLabel[i], 1, i);
                    i++;
                }
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
                LastMove_Button.Enabled = true;
                if (x == lm[lm.Count - 1].CoordX && y == lm[lm.Count - 1].CoordY)
                {
                    return;
                }
                if (jogadas == 1)
                {
                    if (x > lm[lm.Count - 1].CoordX + 1 || x < lm[lm.Count - 1].CoordX - 1)
                    {
                        resetWord();
                        return;
                    }
                    else if (y > lm[lm.Count - 1].CoordY + 1 || y < lm[lm.Count - 1].CoordY - 1)
                    {
                        resetWord();
                        return;
                    }
                    if (x - 1 == lm[lm.Count - 1].CoordX && y == lm[lm.Count - 1].CoordY)
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
            move = new Moves(jogadas, playerName, x, y, word);
            lm.Add(move);

            jogadas++;

            //Verifica se a palavra a ser construida é igual a alguma das palavras escolhidas
            int count = 0;
            foreach (Label l in WordsPanel.Controls.OfType<Label>())
            {
                if (word.Equals(l.Text))
                {
                    wordFound(count);
                    break;
                }
                count++;
            }
        }

        /*
         * Se o clico do utilizador nao for correto, a palavra selecionada é anulada
         */
        public void resetWord()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    if (gameBtn[x, y].BackColor == btnColors[colorIndex])
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
            bool allWordsFound = true;
            foreach (CheckBox c in WordsPanel.Controls.OfType<CheckBox>())
            {
                if (c.Checked == false)
                {
                    allWordsFound = false;
                }
            }
            if (allWordsFound == true)
            {
                if (typeOfGame == "Demo")
                {
                    //Reset a thread
                    cts.Cancel();
                    cts.Dispose();

                    string tempoJogada = minutos + ":" + pseudoSegundos + segundos;

                    //Criado um novo registo de jogador
                    Player newPlayer = new Player(playerName, tempoJogada, jogadas);
                    //Adiciona-se o jogador à lista de jogadores 
                    lp.Add(newPlayer);
                    MessageBox.Show("Demonstration finished.", "Demo Ended");
                    //Mostrar os Butões
                    PlayerName_Button.Show();
                    Stats_Button.Show();
                    //Muda o texto do botão de "Sair"
                    Quit_Button_Bottom.Text = "Quit Game";
                    quitGameToolStripMenuItem.Text = "Quit Game";

                    //Ativação da label
                    Label_clock.Text = "";
                    Label_clock.Visible = false;
                    gameState = false;
                }
                else if(typeOfGame == "Normal")
                {
                    //Reset a thread
                    cts.Cancel();
                    cts.Dispose();

                    string tempoJogada = minutos + ":" + pseudoSegundos + segundos;

                    //Criado um novo registo de jogador
                    Player newPlayer = new Player(playerName, tempoJogada, jogadas);
                    //Adiciona-se o jogador à lista de jogadores 
                    lp.Add(newPlayer);
                    MessageBox.Show("Congratulations you finished in: " + tempoJogada, "Game Ended");
                    //Mostrar os Butões
                    PlayerName_Button.Show();
                    Stats_Button.Show();
                    //Muda o texto do botão de "Sair"
                    Quit_Button_Bottom.Text = "Quit Game";
                    quitGameToolStripMenuItem.Text = "Quit Game";

                    //Ativação da label
                    Label_clock.Text = "";
                    Label_clock.Visible = false;
                    gameState = false;
                }
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        gameBtn[x, y].Enabled = false;
                    }
                }
            }
            LastMove_Button.Enabled = false;
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
            int count = 0;
            foreach (Label l in WordsPanel.Controls.OfType<Label>())
            {
                btnColors[count] = colorPallet[count];
                count++;
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
            if (quitMsgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /**
         * Butão do menu sul que tenta sair da aplicação
         **/
        private void Quit_Button_Bottom_Click(object sender, EventArgs e)
        {
            if (gameState == false)
            {
                var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (quitMsgBox == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                //Desativa o botão de last Move
                LastMove_Button.Enabled = false;
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
         * Função que roda a matriz que contem as letras segundo um numero aleatorio
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
            SelectCategory selectCatForm = new SelectCategory();
            selectCatForm.ShowDialog();
            string category = SelectCategory.category;
            typeOfGame = "Normal";
            startGame(category);   
        }
        /**
         * Começa o jogo
         **/
        public void startGame(string category)
        {
            if (typeOfGame.Equals("Demo")) //Se for um pedido de replay
            {
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
                quitGameToolStripMenuItem.Text = "Stop";

                clearGame();
                placeWords(category);
                drawWords(category);
                generateColors();
                fillEmptyButtons();
                jogadas = 0;
                word = "";
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
                foreach (CheckBox c in WordsPanel.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
            }
            else if (typeOfGame.Equals("Normal")) //Se for um pedido de jogo normal
            {
                //Verificar se existe username 
                if (playerName.Equals(""))
                {
                    AboutForm about = new AboutForm(4);
                    about.ShowDialog();
                }
                else
                { //Se existir username 
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
                    quitGameToolStripMenuItem.Text = "Stop";

                    //Ativação da label
                    Label_clock.Text = "";
                    Label_clock.Visible = true;

                    //Instanciacao do Token
                    cts = new CancellationTokenSource();
                    //Inicalizacao da thread
                    ThreadPool.QueueUserWorkItem(new WaitCallback(StartClock), cts.Token);

                    clearGame();
                    placeWords(category);
                    drawWords(category);
                    generateColors();
                    fillEmptyButtons();
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
                    foreach (CheckBox c in WordsPanel.Controls.OfType<CheckBox>())
                    {
                        c.Checked = false;
                    }
                }
            }
        }
        /**
         * Butão do menu sul que faz o rewind da ultima jogada
         **/
        private void LastMove_Button_Click(object sender, EventArgs e)
        {
            if (jogadas != 0)
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
            AboutForm about = new AboutForm(5);
            about.ShowDialog();
            LoginForm LoginFrm = new LoginForm(adminUserName, adminPassword); //Instance Login Form
            LoginFrm.ShowDialog();  //Call Login Form
            if (adminMode.Equals(true)) //Se o utilizador entrar em modo de administrador ativa todos os botões da aba "Be A Creator"
            {
                creatorToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem item in creatorToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>()) //Corre todos os items dentro do "creatorToolStripMenuItem" e faz o enable deles
                {
                    item.Enabled = true;
                }
            }
            //Stop game
            if (gameState == true)
            {
                jogadas = 0;
                //Limpa butões
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        gameBtn[x, y].Enabled = false;
                        gameBtn[x, y].Text = "";
                        gameBtn[x, y].BackColor = Color.Transparent;
                    }
                }
                gameState = false;
                cts.Cancel();
                cts.Dispose();

                //Torna os Botões visiveis e acessiveis
                PlayerName_Button.Visible = true;
                Stats_Button.Visible = true;
                Label_clock.Visible = false;
                Quit_Button_Bottom.Text = "Quit Game";
                quitGameToolStripMenuItem.Text = "Quit Game";
            }
        }

        /**
        * Butão do menu bar que permite inserir um username
        **/
        private void playerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newUserName();
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
         * Botão do menu sul que adiciona um utilizador novo ou faz login como admin
         **/
        private void PlayerName_Button_Click(object sender, EventArgs e)
        {
            newUserName();
        }

        private void Stats_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            statisticsForm stcsForm = new statisticsForm(lp);
            stcsForm.ShowDialog();
            this.Show();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameState == false)
            {
                var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (quitMsgBox == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                gameState = false;
                cts.Cancel();
                cts.Dispose();

                //Torna os Botões visiveis e acessiveis
                PlayerName_Button.Visible = true;
                Stats_Button.Visible = true;
                Label_clock.Visible = false;
                Quit_Button_Bottom.Text = "Quit Game";
                quitGameToolStripMenuItem.Text = "Quit Game";
            }
        }

        /* ------------------------ BE A CREATOR MENU ------------------------ */

        /**
         * Ocupa todos os espaços que nao têm uma letra ainda
         **/
        private void fillEmptySpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    gameBtn[i, j].Text = "";
                }
            }
            fillEmptyButtons();
        }

        /**
         * Limpa todos os botões
         **/
        private void deleteLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearGame();
        }

        /*
         * Ocupa todos os espaços que nao teem palavras
         */
        private void fillEmptyButtons()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char randomChar;
            var random = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (gameBtn[i, j].Text.Equals("") || gameBtn[i, j].Text.Equals(null))
                    {
                        randomChar = chars[random.Next(chars.Length)];
                        gameBtn[i, j].Text = randomChar.ToString();
                        board[i, j] = randomChar.ToString();
                    }
                }
            }
        }

        /*
         * Limpa o jogo, coloca todos os botoes com um "X" e limpa o painel de palavras
         */
        private void clearGame()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    gameBtn[i, j].Text = "X";
                    board[i, j] = "X";
                }
            }
            WordsPanel.Controls.Clear();
        }

        /*
         * Coloca as palavras da classe selecionada
         */
        private void placeWords(string category)
        {
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        gameBtn[i, j].Text = "";
                    }
                }
                int x = 0, y = 0, charCount = 0;
                foreach (Words w in lw)
                {
                    x = 0;
                    y = 0;
                    charCount = 0;
                    if (w.Category.Equals(category))
                    {
                        for (int i = 0; i < w.Word.Length; i++)
                        {
                            board[w.Col + y - 1, w.Line + x - 1] = w.Word.Substring(charCount, 1).ToUpper();
                            gameBtn[w.Col + y - 1, w.Line + x - 1].Text = w.Word.Substring(charCount, 1).ToUpper();
                            charCount++;
                            //Segundo o modo de escrita e a direção da palavra, segue uma determinada direçao
                            switch (w.WritingMode)
                            {
                                case "Normal":
                                    switch (w.Alignment)
                                    {
                                        case "[Horizontal] L -> R":
                                            x++;
                                            break;
                                        case "[Vertical] U -> D":
                                            y++;
                                            break;
                                        case "[Oblique] U -> D":
                                            x++;
                                            y++;
                                            break;
                                        case "[Oblique] D -> U":
                                            x++;
                                            y--;
                                            break;
                                    }
                                    break;
                                case "Reverse":
                                    switch (w.Alignment)
                                    {
                                        case "[Horizontal] L -> R":
                                            x--;
                                            break;
                                        case "[Vertical] U -> D":
                                            y--;
                                            break;
                                        case "[Oblique] U -> D":
                                            x--;
                                            y++;
                                            break;
                                        case "[Oblique] D -> U":
                                            x--;
                                            y--;
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //Mostra o menu de administração para adicionar uma nova palavra
        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm(1);
            admForm.ShowDialog();
        }
        //Coloca as palavras da categoria selecionada no jogo
        private void placeWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm(2);
            admForm.ShowDialog();
            string category = Admin_PlaceWords.category;
            clearGame();
            placeWords(category);
            fillEmptyButtons();
            drawWords(category);
        }

        //Mostra o menu de administração com as palavras listadas
        private void wordsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm(3);
            admForm.ShowDialog();
        }
        //Guarda as palavras da classe Words num ficheiro no Desktop do utilizador
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveInFile();
            MessageBox.Show("All the words where saved in a file at your Desktop.");
        }
        //Popula a classe Words apartir de um ficheiro selecionado 
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readFromFile();
        }
        //Começa a thread de demonstração de conclusão de jogo
        private void StartDemo(object obj)
        {
            int charCount, x, y;
            foreach (Words w in lw) //Percorre as palavras da classe
            {
                charCount = 0;
                x = 0;
                y = 0;
                if (w.Category.Equals(category)) //Se a palavra pertencer a categoria selecionada
                {
                    for (int i = 0; i < w.Word.Length; i++) //Loop por cada caracter da palavra
                    {
                        //A cada tick do relógio (1 segundo)
                        Invoke((MethodInvoker)delegate ()
                        {
                            gameBtn[w.Col + y - 1, w.Line + x - 1].PerformClick(); //Faz o clique do butao em que o caracter atual da palavra está
                            LastMove_Button.Enabled = false;
                        });
                        Thread.Sleep(500); //Espera 500 milesimos...
                        charCount++;
                        //Segundo o modo de escrita e a direção da palavra, segue uma determinada direçao
                        switch (w.WritingMode)
                        {
                            case "Normal":
                                switch (w.Alignment)
                                {
                                    case "[Horizontal] L -> R":
                                        x++;
                                        break;
                                    case "[Vertical] U -> D":
                                        y++;
                                        break;
                                    case "[Oblique] U -> D":
                                        x++;
                                        y++;
                                        break;
                                    case "[Oblique] D -> U":
                                        x++;
                                        y--;
                                        break;
                                }
                                break;
                            case "Reverse":
                                switch (w.Alignment)
                                {
                                    case "[Horizontal] L -> R":
                                        x--;
                                        break;
                                    case "[Vertical] U -> D":
                                        y--;
                                        break;
                                    case "[Oblique] U -> D":
                                        x--;
                                        y++;
                                        break;
                                    case "[Oblique] D -> U":
                                        x--;
                                        y--;
                                        break;
                                }
                                break;
                        }
                    }
                }
            }
        }
        private void playDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SelectCategory selectCatForm = new SelectCategory();
                selectCatForm.ShowDialog();
                category = SelectCategory.category;
                typeOfGame = "Demo";
                startGame(category);
                var msg = MessageBox.Show("Start demonstration?", "Demonstration", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.Yes)
                {
                    //Instanciacao do Token
                    cts = new CancellationTokenSource();
                    //Inicalizacao da thread
                    ThreadPool.QueueUserWorkItem(new WaitCallback(StartDemo), cts.Token);
                }
                else
                {
                    clearGame();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
