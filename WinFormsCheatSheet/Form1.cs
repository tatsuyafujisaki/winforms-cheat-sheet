using System.Deployment.Application;
using System.Windows.Forms;

namespace WinFormsCheatSheet
{
    partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();

            if (ApplicationDeployment.IsNetworkDeployed
                && ApplicationDeployment.CurrentDeployment.CheckForUpdate()
                && ApplicationDeployment.CurrentDeployment.Update())
            {
                Application.Restart();

                // Exit after constructor there is no way to exit in the constructor.
                Load += (sender, e) => Close();
            }
        }

        void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Close();
        }
    }
}