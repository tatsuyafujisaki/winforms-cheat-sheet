using System.Windows.Forms;

namespace WinFormsUtil
{
    partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Close();
        }
    }
}
