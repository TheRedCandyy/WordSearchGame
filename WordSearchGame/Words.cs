/*
    +-------------------------------------------------------+
    |                       WORDS                           |
    +-------------------------------------------------------+
    |                                                       |
    |   - playID            :  int                          |
    |   - numChar           :  int                          |
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
    class Words
    {
        private int playID;  //Play where the word was used 
        private int numChar; //Number of caracters of the word

        public Words(int playID, int numChar)
        {
            this.playID = playID; //Stores in waht play the word is used
            this.numChar = numChar; //Number of caracters of the word
        }

        public int PlayID { get => playID; set => playID = value; }
        public int NumChar { get => numChar; set => numChar = value; }
    }
}
