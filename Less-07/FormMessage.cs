using System;
using System.Windows.Forms;

namespace Less_07
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
            tbxNum.Text = "0";
            lblText.Text = "Какое число должны оплучить?";
            btnEnter.Text = "ОК";
        }

        private int _requiredNumber;
        public int RequiredNumber
        {
            get { return _requiredNumber; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = tbxNum.Text;
            do
            {
                if (text != null && int.TryParse(text, out _requiredNumber)) Hide();
            } while (false);
        }
    }
}
