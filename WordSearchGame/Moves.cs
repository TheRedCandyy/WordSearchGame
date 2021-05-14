/*
    +-------------------------------------------------------+
    |                       Moves                           |
    +-------------------------------------------------------+
    |                                                       |
    |   - moveId            :  int                          |
    |   - playerName        :  string                       |
    |   - coordX            :  int                          |
    |   - coordY            :  int                          |
    |   - word              :  string                       |
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
    class Moves
    {
        private int moveId;         //Guarda o id da jogada
        private string playerName;  //Nome do jogador
        private int coordX;         //Coordenada X
        private int coordY;         //Coordenada Y
        private string word;        //Palavra a ser criada no momento da jogada

        public Moves(int moveId, string playerName, int coordX, int coordY, string word)
        {
            this.moveId = moveId;
            this.playerName = playerName;
            this.coordX = coordX;
            this.coordY = coordY;
            this.word = word;
        }

        public int MoveId { get => moveId; set => moveId = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public int CoordX { get => coordX; set => coordX = value; }
        public int CoordY { get => coordY; set => coordY = value; }
        public string Word { get => word; set => word = value; }
    }
}
