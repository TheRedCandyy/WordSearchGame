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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchGame
{
    public class Player
    {
        private string name;        //Player's Name
        private string playTimes;   //Play's history
        private int numPlays;       //Stores all the play ID's that have been played

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string nome, string playTimes, int numPlays)
        {
            this.name = nome;
            this.playTimes = playTimes;
            this.numPlays = numPlays;
        }

        public string Nome { get => name; set => name = value; }
        public string PlayTimes { get => playTimes; set => playTimes = value; }
        public int NumPlays { get => numPlays; set => numPlays = value; }
    }
}
