using System;
using System.Windows.Forms;

namespace Less_07
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lblTry.Text = "";
            lblTask.Text = "Выберете в Меню \"Играть\"";
            this.Text = "Удвоитель";
        }

        // 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        int _countTry = 0;
        int _minCount = 0;
        int _requiredNumber;
        private void UpdateTryText()
        {
            lblTry.Text = $"Количество попыток - {_countTry}";
        }
        private void UpdateTaskText()
        {
            lblTask.Text = $"Минимально возможное количество шагов - {GetMinCountTry()}";
        }

        private int GetMinCountTry()    // не нашел легкого способа найти минимальное кол-во шагов
        {
            int residue = _requiredNumber;
            do
            {
                if (residue / 2 != 0 && residue / 2 > 1)
                    residue /= 2;
                else
                    residue -= 1;

                _minCount++;
            } while (residue != 0);
            return _minCount;
        }

        private bool CheckCountTry()
        {
            bool check = _countTry <= _minCount ? true : false;
            if (!check)
            {
                UpdateTryText();
                UpdateTaskText();
            }
            else UpdateTryText();
            return check;
        }

        private void Reset()
        {
            lblNumber.Text = "1";
            lblTask.Text = "Выберете в Меню \"Играть\"";
            lblTry.Text = "";
            _countTry = 0;
            _minCount = 999;
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            ++_countTry;
            CheckCountTry();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            ++_countTry;
            CheckCountTry();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            CheckCountTry();
        }

        // б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        // Игрок должен получить это число за минимальное количество ходов.
        private void gameTSM_Click(object sender, EventArgs e)
        {
            Reset();
            FormMessage fm2Msg = new FormMessage();
            fm2Msg.ShowDialog();                    // Мучился с Show пока не ввел ShowDialog. Show не передавал значение
            _requiredNumber = fm2Msg.RequiredNumber;
            GetMinCountTry();
            lblTask.Text = $"Получите число {_requiredNumber} за минимум ходов";
            UpdateTryText();
        }

        private void exitTSM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
        // а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
        // a) Для ввода данных от человека используется элемент TextBox;
        // б) **Реализовать отдельную форму c TextBox для ввода числа.
        private void guessNumTSM_Click(object sender, EventArgs e)
        {
            FormGuess fmGues = new FormGuess();
            fmGues.ShowDialog();
        }
    }
}
