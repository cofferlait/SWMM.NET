using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWMM.NET
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Text = "EPA SWMM.NET 5";
        }

        private void tActionOpen_Execute(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------------------
            // Opens a project file when File|Open selected from main menu.
            //
            // Revised for release 5.1.008.                                                //(5.1.008)
            //-----------------------------------------------------------------------------

            //// Prompt the user to either save the current project data or to cancel
            //if SaveFileDlg(Sender) = mrCancel then Exit;

            // Execute the Open File dialog
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                // Set options for the Open File dialog control
                dlg.Title = ConstClass.TXT_OPEN_PROJECT_TITLE;
                dlg.Filter = ConstClass.TXT_OPEN_PROJECT_FILTER;
                dlg.InitialDirectory = Application.StartupPath;
                dlg.FileName = "";
                dlg.CheckFileExists = true;dlg.ShowReadOnly = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
