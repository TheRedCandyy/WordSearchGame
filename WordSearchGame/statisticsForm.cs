using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class statisticsForm : Form
    {

        List<Player> lp2;
        string[] nome = new string[] { };


        public statisticsForm(List<Player> lp)
        {
            InitializeComponent();

            lp2 = lp;
            comboBxStatsOrderBy.Text = "Name";

            //Ordenar a lista de jogadores por ordem alfabetica (Default)
            lp2.Sort((x, y) => string.Compare(x.Nome, y.Nome));
            //Carregar o record do jogo
            loadRecord();
            //Carregar todos os jogadores
            loadListBox("All");
            //Carregar todas as categorias
            loadCategorys();    

        }
        public void loadCategorys()
        {
            comboBox_category.Items.Add("All");
            foreach (Player pl in lp2)
            {
                if (!comboBox_category.Items.Contains(pl.Category))
                {
                    comboBox_category.Items.Add(pl.Category);
                }
            }
            comboBox_category.SelectedIndex = 0;
        }
        /**
         * Funcao que corre a lista de jogadores e guarda a melhor jogada para record
         **/
        public void loadRecord()
        {
            string recordName = "";
            string recordTime = "";
            int timeAux = 0;

            foreach (Player p in lp2)
            {
                if (timeAux < p.PlaySeconds)
                {
                    timeAux = p.PlaySeconds;
                    recordName = p.Nome;
                    recordTime = p.PlayTimes;
                }
            }
            //Preencher o texto da Label de Record
            label_record_Player.Text = recordName + "   -   " + recordTime;
        }

        /**
         * Carrega a listbox com o nome de todos os jogadores e respetivas jogadas
         **/
        public void loadListBox(string categoria)
        {
            //Limpar os items da listBox
            listBox_players_times.Items.Clear();

            if (categoria.Equals("All"))
            {
                try
                {
                    listBox_players_times.Items.Add("\n");
                    foreach (Player p in lp2)
                    {
                        listBox_players_times.Items.Add(p);
                        listBox_players_times.Items.Add("\n");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    listBox_players_times.Items.Add("\n");
                    foreach (Player p in lp2)
                    {
                        if (p.Category.Equals(categoria))
                        {
                            listBox_players_times.Items.Add(p);
                            listBox_players_times.Items.Add("\n");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /**
        * Corre a lista de jogadores e encontra qual o jogador pretendido para efetuar o replay
        * Devolve o indice desse mesmo jogador na lista de jogadores
        **/
        private int findPlrIndex()
        {
            int plyrIndex = new int();
            string player = listBox_players_times.SelectedItem.ToString();

            string auxPlayerName = "";
            string auxPlayerTime = "";
            int ct = 0;

            string[] playerInfo = player.Split('ˍ'); //Separa os conteudos desta linha por colunas usando a virgula como separador

            auxPlayerName = playerInfo[0];
            auxPlayerTime = playerInfo[playerInfo.Length - 1];


            auxPlayerName = auxPlayerName.TrimStart();
            auxPlayerName = auxPlayerName.TrimEnd();
            auxPlayerTime = auxPlayerTime.TrimEnd();
            auxPlayerTime = auxPlayerTime.TrimStart();

            foreach (Player pl in lp2)
            {
                if (pl.Nome.Equals(auxPlayerName) && pl.PlayTimes.Equals(auxPlayerTime))
                {
                    plyrIndex = ct;
                }
                ct++;
            }
            return plyrIndex;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_players_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ativar o botão de replay quando um registo é selecionado
            if (listBox_players_times.SelectedIndex % 2 == 0)
            {
                bt_replay.Enabled = false;
                bt_replay.Visible = false;

            }
            else
            {
                bt_replay.Enabled = true;
                bt_replay.Visible = true;
            }
            
        }
        private void comboBxStatsOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = "";
            if (comboBox_category.Text.Equals(""))
            {
                categoria = "All";
            }
            else
            {
                categoria = comboBox_category.Text;
            }
     
            if (comboBxStatsOrderBy.Text.Equals("Name"))//Ordenar por ordem alfabética
            {
                //Ordenar a lista de jogadores por nome
                lp2.Sort((x, y) => string.Compare(x.Nome, y.Nome));
                //Carregar os Items da listbox
                loadListBox(categoria);
            }
            if (comboBxStatsOrderBy.Text.Equals("Time"))//Ordenar por tempos(Crescete)
            {
                //Ordenar a lista de jogadores por tempo
                lp2.Sort((x, y) => x.PlaySeconds.CompareTo(y.PlaySeconds));
                //Carregar os Items da listbox
                loadListBox(categoria);
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_replay_Click(object sender, EventArgs e)
        {
            int plrIndex = new int();
            plrIndex = findPlrIndex();

            Form1.replayToken = true;
            Form1.replayPlayerIndex = plrIndex;
            this.Close();

        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = comboBox_category.Text;
            loadListBox(categoria);
        }
    }
}
