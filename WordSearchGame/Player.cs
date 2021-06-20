/*
    +-------------------------------------------------------+
    |                      PLAYER                           |
    +-------------------------------------------------------+
    |                                                       |
    |   - name              :  string                       |
    |   - password          :  string                       |
    |   - playTimes         :  string[]                     |
    |   - numPlays          :  int[]                        |
    |                                                       |
    +-------------------------------------------------------+
 */

using System;

namespace WordSearchGame
{
    public class Player
    {
        private string name;        //Nome do jogador
        private string playTimes;   //String que guarda o tempo de jogo
        private int playSeconds;    //Integer que guarda os segundo do jogo
        private int game;           //ID do jogo 
        private string category;    //Categoria do jogo
        private string board;     

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, string playTimes)
        {
            this.name = name;
            this.playTimes = playTimes;
        }

        public Player(string nome, string playTimes, int playSeconds, int game, string category, string board)
        {
            this.name = nome;
            this.playTimes = playTimes;
            this.playSeconds = playSeconds;
            this.game = game;
            this.category = category;
            this.board = board;
        }

        public string Nome { get => name; set => name = value; }
        public string PlayTimes { get => playTimes; set => playTimes = value; }
        public int PlaySeconds { get => playSeconds; set => playSeconds = value; }
        public int Game { get => game; set => game = value; }
        public string Category { get => category; set => category = value; }
        public string Board { get => board; set => board = value; }

        public override string ToString()
        {
            return String.Format("   {0,-15} {1,-15} {2,5}", Nome, "ˍˍˍˍˍˍˍˍˍˍˍˍ", playTimes);
        }
    }
}