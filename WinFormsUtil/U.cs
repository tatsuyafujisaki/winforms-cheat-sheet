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
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
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
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                RestoreDirectory = true
            };

            return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
        }

        internal static string FolderBrowserDialog(string defaultFolder)
        {
            // No exception is thrown even if the defaultFolder is null or absent.
            var fbd = new FolderBrowserDialog { SelectedPath = defaultFolder };

            return fbd.ShowDialog() == DialogResult.OK ? fbd.SelectedPath : null;
        }
    }
}
