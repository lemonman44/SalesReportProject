using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        
        
        //private bool mouseOver;
        private Button controlMousedOver;
        private int transparency = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        //this section is some code that will run before MainWindow is visible to the user
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //starts the timer used for many functions throughout the program
            timer1.Start();

            //the following code decides which panel is visible on startup and which panels are invisible
            menuPage.Visible = true;
            previewAndSendDataPage.Visible = false;
            settingsPage.Visible = false;

            //the following code sets all the panels to be the same size as the form
            //ClientSize is the size of the form MainWindow
            menuPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            previewAndSendDataPage.Size = new Size(ClientSize.Width, ClientSize.Height);
            settingsPage.Size = new Size(ClientSize.Width, ClientSize.Height);

            //the following code reads the Email_info.txt file to populate the email fields in the settings page
            fillEmailFields();

            //the following code reads the Companies.txt file to populate the accountDisplayBox in the settings page
            fillAndRefreshAccounts();

            //The following code sets the starting locations of the panels in the MainWindow form
            menuPage.Location = new Point(0, 0);
            previewAndSendDataPage.Location = new Point(0, 0);
            settingsPage.Location = new Point(0, 0);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thought out locations
            menuToPreviewButton.Location
                 = new Point(ClientSize.Width - 85, ClientSize.Height - 30);
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
                = new Point(ClientSize.Width - 85, ClientSize.Height - 30);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - menuToSettingsButton.Width, 0);
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

        //changes the currently displayed panel from settings to menu
        private void Settings_Back_Button_Click(object sender, EventArgs e)
        {
            settingsPage.Visible = false;
            menuPage.Visible = true;
        }
        
        //takes every field in the email settings and overwrites the email_info file with it
        private void saveEmailDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter saveNewEmailData = new StreamWriter("..\\..\\Email_info.txt", false))
                {
                    saveNewEmailData.WriteLine(emailAddressField.Text);
                    saveNewEmailData.WriteLine(emailPasswordField.Text);
                    saveNewEmailData.Write(destinationAddressField.Text);
                    saveNewEmailData.Close();
                    saveNewEmailData.Dispose();
                }
            }
            catch
            {

            }
        }

        //adds a company account to Companies.txt
        private void addAccountsButton_Click(object sender, EventArgs e)
        {
            //if there are actual characters in the text field then it'll take those characters and add
            //them to the accounts file
            if (addAccountTextField.Text != "")
            {
                try
                {
                    using (StreamWriter saveNewAccount = new StreamWriter("..\\..\\Companies.txt", true))
                    {
                        //takes the text in the field and writes it into the file
                        saveNewAccount.WriteLine(addAccountTextField.Text);
                        saveNewAccount.Close();
                        saveNewAccount.Dispose();
                    }
                    //refreshes the display box
                    fillAndRefreshAccounts();
                }
                catch
                {

                }
            }
            //clears the text field
            addAccountTextField.Text = null;
        }

        //removes a company account from companies.txt
        private void subtractAccountsButton_Click(object sender, EventArgs e) {
            try
            {
                //clears the file completely
                using (StreamWriter subtractAccount = new StreamWriter("..\\..\\Companies.txt", false))
                {
                    subtractAccount.Write("");
                    subtractAccount.Close();
                    subtractAccount.Dispose();
                }

                //takes everything not selected in the displaybox and writes it back to the file
                using (StreamWriter subtractAccount = new StreamWriter("..\\..\\Companies.txt", true))
                {
                    for (int i = 0; i < accountDisplayBox.Items.Count; i++)
                    {
                        //if the item at index i in the account display box is not checked then the
                        //text at in index i is writen back into the file
                        if (!accountDisplayBox.GetItemChecked(i))
                        {
                            subtractAccount.WriteLine(accountDisplayBox.Items[i].ToString());
                        }
                    }
                    subtractAccount.Close();
                    subtractAccount.Dispose();
                }

                //refreshes the display box
                fillAndRefreshAccounts();
            }
            catch
            {

            }
        }

        //method for populating the email fields in settings panel
        private void fillEmailFields()
        {
            try
            {
                string lineInTheFile;
                using (StreamReader readEmailInfoFile = new StreamReader("..\\..\\Email_info.txt"))
                {
                    for (int i = 0; (lineInTheFile = readEmailInfoFile.ReadLine()) != null; i++)
                    {
                        if (i == 0)
                        {
                            emailAddressField.Text = lineInTheFile;
                        }
                        if (i == 1)
                        {
                            emailPasswordField.Text = lineInTheFile;
                        }
                        if (i == 2)
                        {
                            destinationAddressField.Text = lineInTheFile;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        //method for populating and refreshing the accountDisplayBox
        private void fillAndRefreshAccounts()
        {
            try
            {
                accountDisplayBox.Items.Clear();
                string lineInTheFile;
                using (StreamReader readAccountsFile = new StreamReader("..\\..\\Companies.txt"))
                {
                    while ((lineInTheFile = readAccountsFile.ReadLine()) != null)
                    {
                        accountDisplayBox.Items.Add(lineInTheFile, false);
                    }
                }
            }
            catch
            {

            }
        }

        private void accountsSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            controlMousedOver = accountsSettingsButton;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                Button[] listOfAllButtons = new Button[]
            {
                menuToSettingsButton,
                Preview_Back_Button,
                Settings_Back_Button,
                accountsSettingsButton,
                emailSettingsButton,
                saveEmailDataButton,
                addAccountsButton,
                menuToPreviewButton
            };

            if (transparency != 5)
            {
                transparency++;
                Console.WriteLine(transparency);
            }
            else
            {
                timer1.Stop();
                transparency = 1;
            }
            try
            {
                controlMousedOver.BackColor = Color.FromArgb(transparency * 50, 255, 255, 0);
            }
            catch
            {

            }
            
           
            for (int i = 0; i < listOfAllButtons.Count(); i++)
            {
                if (listOfAllButtons[i] != controlMousedOver)
                {
                    listOfAllButtons[i].BackColor = Color.FromArgb(250 - transparency * 50, 255, 255, 255);
                }
            }
        }

        private void accountsSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            controlMousedOver = null;
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
