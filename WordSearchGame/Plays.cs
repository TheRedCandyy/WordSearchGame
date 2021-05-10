/*
    +-------------------------------------------------------+
    |                       PLAY                            |
    +-------------------------------------------------------+
    |                                                       |
    |   - playerName        :  string                       |
    |   - timeOfPlay        :  string                       |
    |   - usedWords         :  string[]                     |
    |   - playID            :  int                          |
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
    class Plays
    {
        private string playerName; //Name of the player that played 
        private string timeOfPlay; //Time of 1 play
        private string[] usedWords; //Word used in 1 play
        private int playID; //Identifies the play with an int ID


        public Plays(string playerName, string timeOfPlay, string[] usedWords, int playID)
        {
            this.PlayerName = playerName;
            this.TimeOfPlay = timeOfPlay;
            this.usedWords = usedWords;
            this.PlayID = playID;
        }

        public string PlayerName { get => playerName; set => playerName = value; }
        public string TimeOfPlay { get => timeOfPlay; set => timeOfPlay = value; }
        public string[] UsedWords { get => usedWords; set => usedWords = value; }
        public int PlayID { get => playID; set => playID = value; }
    }
}
