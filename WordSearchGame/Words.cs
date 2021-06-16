/*
    +-------------------------------------------------------+
    |                       WORDS                           |
    +-------------------------------------------------------+
    |                                                       |
    |   - word              :  string                       |
    |   - category          :  string                       |
    |   - line              :  int                          |
    |   - col               :  int                          |
    |   - dim               :  int                          |
    |   - writingMode       :  string                       |
    |   - alignment         :  string                       |
    |                                                       |
    +-------------------------------------------------------+
 */

using System;

namespace WordSearchGame
{
    public class Words
    {
        private string word; //Guarda a palavra
        private string category; //Guarda a categoria da palavra
        private int line; //Guarda a coordenada Y
        private int col; //Guarda a coordenada X
        private int dim; //Guarda a dimensao da palavra
        private string writingMode; //Guarda o modo de escrita (Normal ou de trás para a frente)
        private string alignment; //Guarda o alinhamento (Ex.: horizontal, vertical, obliquo)

        public Words(string word, int line, int col, int dim, string writingMode, string alignment, string category)
        {
            this.word = word;
            this.category = category;
            this.line = line;
            this.col = col;
            this.dim = dim;
            this.writingMode = writingMode;
            this.alignment = alignment;
        }

        public string Word { get => word; set => word = value; }
        public int Line { get => line; set => line = value; }
        public int Col { get => col; set => col = value; }
        public int Dim { get => dim; set => dim = value; }
        public string WritingMode { get => writingMode; set => writingMode = value; }
        public string Alignment { get => alignment; set => alignment = value; }
        public string Category { get => category; set => category = value; }

        //Usado para escrever em listbox
        public override string ToString()
        {
            return String.Format("{0,10} | {1, 15} | {2, 5} | {3, 6} | {4, 9} | {5, 15} | {6, 15}", Category, Word, Line, Col, Dim, WritingMode, Alignment);
        }
        //Usado para escrever no ficheiro que guarda as palavras
        public string ToString1()
        {
            return Word + "," + Line + "," + Col + "," + Dim + "," + WritingMode + "," + Alignment + "," + Category;
        }
    }
}
