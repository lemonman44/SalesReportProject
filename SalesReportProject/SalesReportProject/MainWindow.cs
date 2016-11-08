using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesReportProject
{
    public partial class MainWindow : Form
    {
        //The following is a description of our layout.

        //We have one main form called MainWindow
        //We have three (as of right now) panels that are shown on the MainWindow
        //Only one of these panels is visible at a time on the MainWindow
        //Each panel has its own groupings of controls on each.
        //The menuPage panel has a "Click Here" button and a settings button
        //Each of those buttons causes the menuPage panel to become invisible and another panel to become visible
        //etc. etc. you probably get the gist

        public MainWindow()
        {
            InitializeComponent();
        }

        //this section is some code that will run before MainWindow is visible to the user
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //the following code decides which panel is visible on startup and which panels are invisible
            menuPage.Visible = true;
            previewAndSendDataPage.Visible = false;
            settingsPage.Visible = false;

            //the following code sets all the panels to be the same size as the form
            //ClientSize is the size of the form MainWindow
            menuPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            previewAndSendDataPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            settingsPage.Size = new Size(ClientSize.Width, ClientSize.Height);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in throughout out locations
            menuToPreviewButton.Location
                = new Point(ClientSize.Width / 2 - menuToPreviewButton.Width / 2, ClientSize.Height / 2);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - menuToSettingsButton.Width, 0);

        }

        //this section is some code that will run whenever the size of the form is changed
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            //the following code keeps all the panels to be the same size as the form
            //ClientSize is the size of the form MainWindow
            menuPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            previewAndSendDataPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            settingsPage.Size = new Size(ClientSize.Width, ClientSize.Height);

            //the following code keeps the locations of buttons and other controls where they were
            //relative to where they started
            menuToPreviewButton.Location
                = new Point(ClientSize.Width / 2 - menuToPreviewButton.Width / 2, ClientSize.Height / 2);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - menuToSettingsButton.Width, 0);
        }

        //this section is code that runs when menuToPreviewButtonIsClicked
        private void menuToPreviewButton_Click(object sender, EventArgs e)
        {
            //the following switches the visible panel on the form from menu to preview page
            menuPage.Visible = false;
            previewAndSendDataPage.Visible = true;
        }

        //this section is code that runs when menuToSettingsButton is cliccked
        private void menuToSettingsButton_Click(object sender, EventArgs e)
        {
            //the following switches the visible panel on the form from menu to settings page
            menuPage.Visible = false;
            settingsPage.Visible = true;
        }
    }     
}
