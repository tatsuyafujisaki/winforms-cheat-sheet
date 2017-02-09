using System;
using System.Windows.Forms;

namespace WinFormsCheatSheet
{
    public partial class ToastForm : Form
    {
        public ToastForm(string s)
        {
            InitializeComponent();

            label1.Text = s;
        }

        public void CloseForm()
        {
            if (InvokeRequired)
            {
                Invoke((Action)Close);
            }
            else
            {
                Close();
            }
        }
    }
}