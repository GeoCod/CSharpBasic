using System;
using System.Windows.Forms;

namespace Less_07
{
    public partial class FormGuess : Form
    {
        public FormGuess()
        {
            InitializeComponent();
            lblPrompt.Text = "";
            btnAnswer.Text = "Угадал?";
            num = rnd.Next(100);
        }
        private int num;
        Random rnd = new Random();

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string _text;
            if (tbxAnswer == null) lblPrompt.Text = "Введите число";
            if (int.TryParse(tbxAnswer.Text, out int result) && result == num)
            {
                _text = "Вы угадали!";
                btnAnswer.Text = "Теперь угадал =)";
            }
            else
            {
                _text = result < num ? "Загаданное число больше" : "Загаданное число меньше";
            }
            lblPrompt.Text = _text;
        }
    }
}
