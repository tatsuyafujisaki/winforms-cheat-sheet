using System.Windows.Forms;

namespace WinFormsCheatSheet
{
    static class U
    {
        static Screen GetMouseScreen()
        {
            return Screen.FromPoint(Control.MousePosition);
        }
    }
}
