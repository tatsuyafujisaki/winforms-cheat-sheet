using System;
using System.Windows.Forms;

namespace WinFormsUtil
{
    static class U
    {
        // Explanatory wrapper
        static void SetTextToClipboard(string s)
        {
            Clipboard.SetText(s);
        }

        // Mark Main method with STAThread or ThreadStateException will be thrown.
        static string OpenFileDialog()
        {
            var ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true
            };

            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        // Mark Main method with STAThread or ThreadStateException will be thrown.
        static string SaveFileDialog()
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true
            };

            return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
        }

        internal static string FolderBrowserDialog()
        {
            var fbd = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            return fbd.ShowDialog() == DialogResult.OK ? fbd.SelectedPath : null;
        }

        static Screen GetMouseScreen()
        {
            return Screen.FromPoint(Control.MousePosition);
        }
    }
}
