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

namespace WordSearchGame
{
    public class Moves
    {
        private int moveId;         //Guarda o id da jogada
        private int coordX;         //Coordenada X
        private int coordY;         //Coordenada Y
        private string word;        //Palavra a ser criada no momento da jogada
        private int game;           //ID do jogo 

        public Moves(int moveId, int coordX, int coordY, string word, int game)
        {
            this.moveId = moveId;
            this.coordX = coordX;
            this.coordY = coordY;
            this.word = word;
            this.game = game;
        }

        public int MoveId { get => moveId; set => moveId = value; }
        public int CoordX { get => coordX; set => coordX = value; }
        public int CoordY { get => coordY; set => coordY = value; }
        public string Word { get => word; set => word = value; }
        public int Game { get => game; set => game = value; }
    }
}
