using System.Windows.Forms;

namespace WinFormsUtil
{
    partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();

            //if (SomethingWrong)
            //{
            //    // Exit after constructor.
            //    // Note that there is no way to exit in the constructor.
            //    Load += (sender, e) => Close();
            //}
        }

        void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Close();
        }
    }
}
