using System.Windows.Forms;

namespace Less_08
{
    public partial class fmSimple : Form
    {
        public fmSimple()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            set { lblText.Text = value; }
        }
    }
}
