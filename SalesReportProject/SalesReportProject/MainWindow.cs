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

            //The following code sets the starting locations of the panels in the MainWindow form
            menuPage.Location = new Point(0, 0);
            previewAndSendDataPage.Location = new Point(0, 0);
            settingsPage.Location = new Point(0, 0);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thought out locations
            menuToPreviewButton.Location
                 = new Point(ClientSize.Width - 80, ClientSize.Height - 30);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - 35, 5);
            Preview_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            Settings_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thoughtout out locations on the settingsPage panel
            emailSettingsInfo.Width = ClientSize.Width;
            emailSettingsButton.Width = ClientSize.Width;
            accountSettingsInfo.Width = ClientSize.Width;
            accountsSettingsButton.Width = ClientSize.Width;
            
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
                = new Point(ClientSize.Width - 80, ClientSize.Height - 30);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - 35, 5);
            Preview_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            Settings_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thoughtout out locations on the settingsPage panel
            emailSettingsInfo.Width = ClientSize.Width;
            emailSettingsButton.Width = ClientSize.Width;
            accountSettingsInfo.Width = ClientSize.Width;
            accountsSettingsButton.Width = ClientSize.Width;
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

        private void emailSettingsButton_Click(object sender, EventArgs e)
        {
            //makes sure you dont click on a thing twice
            emailSettingsButton.Enabled = false;
            accountsSettingsButton.Enabled = true;

            //moves the other locations to where they need to be
            accountSettingsInfo.Size = new Size(accountSettingsInfo.Width, 52);
            accountSettingsInfo.Location = new Point(0, 208 + 104);
            emailSettingsInfo.Size = new Size(emailSettingsInfo.Width, 104 + 104);

        }

        private void accountsSettingsButton_Click(object sender, EventArgs e)
        {
            //makes sure you dont click on a thing twice
            accountsSettingsButton.Enabled = false;
            emailSettingsButton.Enabled = true;

            //moves the other locations to where they need to be
            emailSettingsInfo.Size = new Size(emailSettingsInfo.Width, 52);
            accountSettingsInfo.Location = new Point(0, 156);
            accountSettingsInfo.Size = new Size(accountSettingsInfo.Width, 104 + 104);
        }

        private void Preview_Back_Button_Click(object sender, EventArgs e)
        {
            previewAndSendDataPage.Visible = false;
            menuPage.Visible = true;
        }

        private void Settings_Back_Button_Click(object sender, EventArgs e)
        {
            settingsPage.Visible = false;
            menuPage.Visible = true;
        }

        /*
        private void Images(object sender, EventArgs e)
        {
            PictureBox logo = new PictureBox();
            logo.Image = Image.FromFile("SOR-logo2.png");
            logo.Location = new Point(360, 100);
            logo.Size = new Size(385, 110);
            this.Controls.Add(logo);
        }
        */
    }     
}
