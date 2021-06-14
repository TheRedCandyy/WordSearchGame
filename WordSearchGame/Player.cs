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

namespace WordSearchGame
{
    public class Player
    {
        private string name;        //Player's Name
        private string playTimes;   //String with the time of the play
        private int playSeconds;

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
    }
}
