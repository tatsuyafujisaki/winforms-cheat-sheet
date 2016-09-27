using System;
using System.Windows.Forms;

namespace WinFormsUtil
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fbd = U.FolderBrowserDialog(null);

            Application.Run(new Form1());
        }
    }
}