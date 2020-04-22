using System;
using System.Windows.Forms;

namespace Less_08
{
    public partial class fmMain : Form
    {
        // База данных с вопросами
        TrueFalse database;
        fmSimple fm2 = new fmSimple();

        public fmMain()
        {
            InitializeComponent();
            deactivateButton();
        }

        public void deactivateButton()
        {
            miSave.Enabled = false;
            miSaveAs.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveQuest.Enabled = false;
            nudNumber.Enabled = false;
            cboxTrue.Enabled = false;
        }

        public void activateButtoon()
        {
            miSave.Enabled = true;
            miSaveAs.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveQuest.Enabled = true;
            nudNumber.Enabled = true;
            cboxTrue.Enabled = true;
            fm2.Show();
        }

        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if(database != null)
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
                fm2.LabelText = nudNumber.Value.ToString();
            }
            else
            {
                MessageBox.Show("Создайте новую базу данных");
                nudNumber.Value = 0;
            }
        }

        #region Меню
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                activateButtoon();
            };
        }

        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        // Обработчик пункта меню Save As
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != null && database != null)
            {
                database.FileName = saveFileDialog.FileName;
                database.Save();
            }
            else MessageBox.Show("База данных не создана или не введено название файла");
        }

        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                activateButtoon();
            }
        }

        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Кнопки
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fm2.LabelText = "Автор: Васильченко Артем\n" +
                "Версия программы 0.0.1a\n" +
                "Распространяется как есть.";
            fm2.Show();
        }
    }
}
