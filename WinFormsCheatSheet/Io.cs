using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsCheatSheet
{
    static class Io
    {
        static string GetTextFromClipboard() => Clipboard.GetText().Trim();

        // Explanatory wrapper
        static void SetTextToClipboard(string s) => Clipboard.SetText(s);

        // Mark Main method with STAThread or ThreadStateException will be thrown.
        static string OpenFileDialog(string initialDirectory = null)
        {
            var ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.Exists(initialDirectory)
                                   ? initialDirectory
                                   : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true
            };

            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        // Mark Main method with STAThread or ThreadStateException will be thrown.
        static string SaveFileDialog(string initialDirectory = null)
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"All files (*.*)|*.*",
                InitialDirectory = Directory.Exists(initialDirectory)
                                   ? initialDirectory
                                   : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
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


    }
}
