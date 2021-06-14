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
    public class Words
    {
        private string word;
        private string category;
        private int line;
        private int col;
        private int dim;
        private string writingMode;
        private string alignment;

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

        public override string ToString()
        {
            return String.Format("{0,10} | {1, 15} | {2, 5} | {3, 6} | {4, 9} | {5, 15} | {6, 15}", Category, Word, Line, Col, Dim, WritingMode, Alignment);
        }
        public string ToString1()
        {
            return Word + "," + Line + "," + Col + "," + Dim + "," + WritingMode + "," + Alignment + "," + Category;
        }
    }
}
