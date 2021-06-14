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
    public partial class statisticsForm : Form
    {
        UserControlPlayer ctrlPlayer;
        List<Player> lp2;
        string[] nome = new string[] { };
        string separador = "  ............................................  ";

        public statisticsForm(List<Player> lp)
        {
            InitializeComponent();

            lp2 = lp;

            comboBxStatsOrderBy.Items.Add("Name");
            comboBxStatsOrderBy.Items.Add("Time");


            Player pl1 = new Player("Diogo", "2:34", 20);
            lp2.Add(pl1);
            Player pl2 = new Player("Alex", "2:36",  30);
            lp2.Add(pl2);
            Player pl3 = new Player("Joao", "1:34",15);
            lp2.Add(pl3);
            Player pl4 = new Player("Ana", "2:34",60);
            lp2.Add(pl4);

            Player pl5 = new Player("Mario", "2:36",55);
            lp2.Add(pl5);
            Player pl6 = new Player("Antonio", "1:34");
            lp2.Add(pl6);
            Player pl7 = new Player("Bruna", "2:34",27);
            lp2.Add(pl7);


            //Ordenar a lista de jogadores por ordem alfabetica (Default)
            lp2.Sort((x, y) => string.Compare(x.Nome, y.Nome));
            //Carregar todos os jogadores
            loadListBox();
            //Carregar o record do jogo
            loadRecord();

        }
        public void loadControlPlayer(string playerName)
        {

            ctrlPlayer = new UserControlPlayer();
            ctrlPlayer.Visible = true;
            statisticsMainPanel.Visible = false;
        }

        /**
         * Funcao que corre a lista de jogadores e guarda a melhor jogada para record
         **/
        public void loadRecord()
        {
            string recordName = "";
            string recordTime = "";
            int timeAux = 0;

            foreach(Player p in lp2)
            {
                if (timeAux < p.PlaySeconds) 
                { 
                    timeAux = p.PlaySeconds;
                    recordName = p.Nome;
                    recordTime = p.PlayTimes;
                }
            }

            //Preencher o texto dos botões
            bt_record_Name.Text = recordName;
            bt_record_time.Text = recordTime;

        }
        /**
         * Carrega a listbox com o nome de todos os jogadores e respetivas jogadas
         **/
        public void loadListBox()
        {
            string espaco = "\n";

            listBox_players_times.ResetText();

            try
            {
                foreach (Player p in lp2)
                {
                    listBox_players_times.Items.Add(espaco);
                    listBox_players_times.Items.Add(" " + p.Nome + separador + p.PlayTimes);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            var quitMsgBox = MessageBox.Show("Are you sure you want to leave?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitMsgBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listBox_players_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeAux;
            Int32 count = 2;

            nomeAux = listBox_players_times.SelectedIndex.ToString();


            //nome[] = nomeAux.Split(separador, count, StringSplitOptions.RemoveEmptyEntries);
            //nomeAux.Split(nome[],"  ............................................  ");

            loadControlPlayer("Diogo");
        }
        private void comboBxStatsOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBxStatsOrderBy.Text.Equals("Name"))//Ordenar por ordem alfabética
            {
                //Ordenar a lista de jogadores por nome
                lp2.Sort((x, y) => string.Compare(x.Nome, y.Nome));
                //Limpar os items da listbox
                listBox_players_times.Items.Clear();
                //Carregar os Items da listbox
                loadListBox();
            }
            if (comboBxStatsOrderBy.Text.Equals("Time"))//Ordenar por tempos(Crescete)
            {
                //Ordenar a lista de jogadores por tempo
                lp2.Sort((x, y) => x.PlaySeconds.CompareTo(y.PlaySeconds));
                //Limpar os items da listbox
                listBox_players_times.Items.Clear();
                //Carregar os Items da listbox
                loadListBox();
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
