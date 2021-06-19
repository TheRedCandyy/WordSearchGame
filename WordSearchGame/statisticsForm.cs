using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class statisticsForm : Form
    {

        List<Player> lp2;
        List<String> lstCategory;
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
            loadListBox();
            //Carregar todas as categorias
            loadCategorys();    

        }
        public void loadCategorys()
        {
            lstCategory = new List<string>();


            foreach (Player pl in lp2)
            {
                string categoria = pl.Category;
                lstCategory.Add(categoria);
            }
            MessageBox.Show(lstCategory.Count.ToString());
            foreach (Player pl2 in lp2)
            {
                for (int i = 0; i < lstCategory.Count; i++)
                {
                    if (i == 0)
                    {
                        comboBox_category.Items.Add(pl2.Category);
                    }
                    else
                    {
                        if (pl2.Category.Equals(lstCategory[i]))
                        {

                        }
                        else
                        {
                            comboBox_category.Items.Add(pl2.Category);
                        }
                    }

                }
            }
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
        public void loadListBox()
        {
            //Limpar os items da listBox
            listBox_players_times.Items.Clear(); 

            try
            {
                listBox_players_times.Items.Add("\n");
                foreach (Player p in lp2)
                {
                    listBox_players_times.Items.Add("﹥" + p);
                    listBox_players_times.Items.Add("\n");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            if (comboBxStatsOrderBy.Text.Equals("Name"))//Ordenar por ordem alfabética
            {
                //Ordenar a lista de jogadores por nome
                lp2.Sort((x, y) => string.Compare(x.Nome, y.Nome));
                //Carregar os Items da listbox
                loadListBox();
            }
            if (comboBxStatsOrderBy.Text.Equals("Time"))//Ordenar por tempos(Crescete)
            {
                //Ordenar a lista de jogadores por tempo
                lp2.Sort((x, y) => x.PlaySeconds.CompareTo(y.PlaySeconds));
                //Carregar os Items da listbox
                loadListBox();
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_replay_Click(object sender, EventArgs e)
        {
            string playerName;

            Form1.replayToken = true;
            Form1.replayPlayerName = listBox_players_times.SelectedItem.ToString();
        }
    }
}
