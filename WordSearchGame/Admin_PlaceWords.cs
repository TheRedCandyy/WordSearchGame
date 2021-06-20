using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordSearchGame
{
    public partial class Admin_PlaceWords : UserControl
    {
        public static string category;
        public Admin_PlaceWords()
        {
            InitializeComponent();
            label2.Text = "Words will be place as soon as you leave this window!";
            label2.ForeColor = Color.Green;
            label2.Visible = false;
            loadCategorys();//Carrega as categorias apartir da classe para a combobox
        }
        /*
         * Carrega as categorias apartir da classe para a combobox
         */
        public void loadCategorys()
        {
            foreach (Words word in Form1.lw) //Percorre todas as palavras na classe Words
            {
                bool exists = false; //Variavel para determinar se a categoria ja foi adicionada à combobox
                for (int i = 0; i < comboBox1.Items.Count; i++) //Percorre todos os items da combobox da categoria
                {
                    //Se a categoria for igual a categoria na combobox a variavel para a true e faz com que esta categoria que vem da classe ja nao seja adicionada.
                    if (word.Category.Equals(comboBox1.Items[i]))
                    {
                        exists = true;
                    }
                }
                if (!exists) //Se a variavel for false, significa que a categoria ainda nao foi adicionada à combobox
                {
                    //Adiciona a categoria à combobox
                    comboBox1.Items.Add(word.Category);
                }
            }
            //Seleciona o primeiro elemento da combobox como default
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Enabled = false;
                label2.Text = "There are no categories to be loaded!";
                label2.ForeColor = Color.Red;
                label2.Visible = true;
                PlaceWordsButton.Enabled = false;
            }
        }
        private void PlaceWordsButton_Click(object sender, EventArgs e)
        {
            category = comboBox1.SelectedItem.ToString();
            label2.Visible = true;
        }
    }
}
