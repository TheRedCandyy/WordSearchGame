using System;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class Admin_NewWord : UserControl
    {
        public string category;//Guarda a categoria escolhida
        public Admin_NewWord()
        {
            InitializeComponent();
            loadCategorys(); //Carrega as categorias apartir da classe para a combobox
            //Dados selecionados por default...
            radioButton1.Checked = true;
            normalRadioButton.Checked = true;
            disableWord(); //Desativa todos os elementos dentro do panel1
        }

        /*
         * Carrega as categorias apartir da classe para a combobox
         */
        public void loadCategorys()
        {
            foreach (Words word in Form1.lw) //Percorre todas as palavras na classe Words
            {
                bool exists = false; //Variavel para determinar se a categoria ja foi adicionada à combobox
                for (int i = 0; i < categoryTextBox.Items.Count; i++) //Percorre todos os items da combobox da categoria
                {
                    //Se a categoria for igual a categoria na combobox a variavel para a true e faz com que esta categoria que vem da classe ja nao seja adicionada.
                    if (word.Category.Equals(categoryTextBox.Items[i])) 
                    {
                        exists = true;
                    }
                }
                if (!exists) //Se a variavel for false, significa que a categoria ainda nao foi adicionada à combobox
                {
                    //Adiciona a categoria à combobox
                    categoryTextBox.Items.Add(word.Category);
                }
            }
            //Seleciona o primeiro elemento da combobox como default
            categoryTextBox.SelectedIndex = 0;
        }
        /*
         * Verifica se a categoria selecionada não está completa
         */
        private void confirmCatButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Words word in Form1.lw) //Percorre a classe Words para saber se a categoria inserida já está cheia
            {
                if (word.Category.Equals(categoryTextBox.Text))
                {
                    count++; //Vai incrementando ao encontrar...
                }
            }
            if (count == 19)//Se for igual ao máximo possivel nao permite continuar
            {
                MessageBox.Show("This category is full, try another category.", "Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Se nao estiver cheia continua com o programa...
            category = categoryTextBox.SelectedItem.ToString();
            enableWord();//Ativa todos os elementos dentro do panel1
            MessageBox.Show("Using the selected category!", "Success", MessageBoxButtons.OK); //Mesnage de sucesso
        }
        /*
         * Tenta adicionar a palavra inserida, com os respetivos dados, à classe
         */
        private void addWordButton_Click(object sender, EventArgs e)
        {
            string alignment = "";
            string writingMode = "";
            //Verifica qual o radiobutton selecionado para o alinhamento da palavra
            if (radioButton1.Checked)
            {
                alignment = "[Horizontal] L -> R";
            }
            else if (radioButton2.Checked)
            {
                alignment = "[Vertical] U -> D";
            }
            else if (radioButton3.Checked)
            {
                alignment = "[Oblique] U -> D";
            }
            else if (radioButton4.Checked)
            {
                alignment = "[Oblique] D -> U";
            }
            //Verifica qual o radiobutton selecionado para o modo de escrita da palavra
            if (normalRadioButton.Checked)
            {
                writingMode = "Normal";
            }
            else
            {
                writingMode = "Reverse";
            }
            //Percorre a classe para verificar se a palavra ja existe na categoria selecionada ou na posição inserida
            foreach (Words w in Form1.lw)
            {
                if (w.Word.Equals(wordTextBox.Text) && w.Category.Equals(categoryTextBox.SelectedItem))
                {
                    MessageBox.Show("There already exists an equal word in this category!", "Word Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (w.Line.Equals(lineTextBox.Text) && w.Col.Equals(colTextBox.Text) && w.Alignment.Equals(alignment) && w.Dim.Equals(dimensionTextBox.Text) && w.Category.Equals(categoryTextBox.SelectedItem))
                {
                    MessageBox.Show("There already exists a word in this position!", "Word Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Words words;
            //Cria uma nova classe words populada com os dados inseridos
            words = new Words(wordTextBox.Text, Convert.ToInt32(lineTextBox.Text), Convert.ToInt32(colTextBox.Text), Convert.ToInt32(dimensionTextBox.Text), writingMode, alignment, category);
            //Adiciona esta classe à lista
            Form1.lw.Add(words);
            //Mensagem de sucesso
            MessageBox.Show("New word added with success!", "Success", MessageBoxButtons.OK);
        }

        /*
         * Faz uma demonstração da palavra inserida no jogo antes de ser adicionada 
         */
        private void previewWordButton_Click(object sender, EventArgs e)
        {

        }
        /*
         * Faz o reset de todos os campos do formulario
         */
        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            categoryTextBox.SelectedIndex = 0;
            wordTextBox.Text = "";
            dimensionTextBox.Text = "";
            lineTextBox.Text = "";
            colTextBox.Text = "";
            radioButton1.Checked = true;
            normalRadioButton.Checked = true;
            disableWord();
        }
        /*
         * Ativa todos os elementos do panel1
         */
        public void enableWord()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Enabled = true;
            }
        }
        /*
         * Desativa todos os elementos do panel1
         */
        public void disableWord()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
