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

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, string playTimes)
        {
            this.name = name;
            this.playTimes = playTimes;
        }

        public Player(string nome, string playTimes, int playSeconds)
        {
            this.name = nome;
            this.playTimes = playTimes;
            this.playSeconds = playSeconds;
        }

        public string Nome { get => name; set => name = value; }
        public string PlayTimes { get => playTimes; set => playTimes = value; }
        public int PlaySeconds { get => playSeconds; set => playSeconds = value; }
        public override string ToString()
        {
            return String.Format("    {0,-20} {1,-30} {2,5}", Nome, "..............................", playTimes);
        }
    }
}
