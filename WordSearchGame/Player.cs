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
    class Player
    {
        private string name;        //Player's Name
        private string password;    //Player's password
        private string[] playTimes; //Play's history
        private int[] numPlays;     //Stores all the play ID's that have been played

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string nome, string password, string[] playTimes, int[] numPlays)
        {
            this.name = nome;
            this.password = password;
            this.playTimes = playTimes;
            this.numPlays = numPlays;
        }

        public string Nome { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string[] PlayTimes { get => playTimes; set => playTimes = value; }
        public int[] NumPlays { get => numPlays; set => numPlays = value; }
    }
}
