using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private string emailAddress;
        private string emailPassword;
        private string emailDestination;
        private string emailSubject;
        private string emailBody;

        public MainWindow()
        {
            InitializeComponent();
        }

        //this section is some code that will run before MainWindow is visible to the user
        private void MainWindow_Load(object sender, EventArgs e)
        {
            displayErrorMessage("nice click loser");
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

            //The following code populates the emailpreview information
            previewFromAddress.Text = "From: " + emailAddressField.Text;
            previewToAddress.Text = "To: " + destinationAddressField.Text;

            //The following code sets the starting locations of the panels in the MainWindow form
            menuPage.Location = new Point(0, 0);
            previewAndSendDataPage.Location = new Point(0, 0);
            settingsPage.Location = new Point(0, 0);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thought out locations
            menuToPreviewButton.Location
                 = new Point(ClientSize.Width / 2-menuToPreviewButton.Width/2, menuToPreviewButton.Location.Y);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - 35, 5);
            Preview_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            Settings_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Width / 2, pictureBox1.Location.Y);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thoughtout out locations on the settingsPage panel
            emailSettingsInfo.Width = ClientSize.Width;
            emailSettingsButton.Width = ClientSize.Width;
            accountSettingsInfo.Width = ClientSize.Width;
            accountsSettingsButton.Width = ClientSize.Width;

            addAccountsButton.Location
                = new Point(accountDisplayBox.Location.X,
                accountDisplayBox.Location.Y + accountDisplayBox.Height);

            subtractAccountsButton.Location
                = new Point(accountDisplayBox.Location.X + accountDisplayBox.Width - subtractAccountsButton.Width,
                accountDisplayBox.Location.Y + accountDisplayBox.Height);

            addAccountTextField.Location
                = new Point(accountDisplayBox.Location.X + addAccountsButton.Width,
                accountDisplayBox.Location.Y + accountDisplayBox.Height);

            //The following code sets the locations and size of buttons and other controls to be more centered
            //and looking like they're in thought out locations on the previewAndSendData panel
            dataPreviewWindow.Size = new Size((int)(ClientSize.Width / 1.25), (int)(ClientSize.Height / 1.25));
            dataPreviewWindow.Location = new Point(ClientSize.Width / 2 - dataPreviewWindow.Width / 2,
                ClientSize.Height / 2 - dataPreviewWindow.Height / 2);
            previewEmailInfo.Location = new Point(ClientSize.Width / 2 - previewEmailInfo.Width / 2,
                dataPreviewWindow.Height + dataPreviewWindow.Location.Y);
            

            //calls to populate the dataPreviewWindow
            dataGridFiller();

            dataPreviewWindow.DoubleBuffered(true);
        }

        private void dataGridFiller() {
            String[] dataArray = new String[27];
            try
            {
                //converts the csv file to an array and populates the datagrid with the array
                string[] fileContent = File.ReadAllLines("..\\..\\csvSampleFile.csv");

                if (fileContent.Count() > 0)
                {
                    //Create data table columns
                    string[] columns = fileContent[0].Split(',');
                    //Adds row data
                    for (int i = 1; i < fileContent.Count(); i++)
                    {
                        string[] rowData = fileContent[i].Split(',');
                        dataPreviewWindow.Rows.Add(rowData);
                    }
                }
            }
            catch
            {
                displayErrorMessage("CSV file not found");
            }
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
                = new Point(ClientSize.Width/2-menuToPreviewButton.Width/2, menuToPreviewButton.Location.Y);
            menuToSettingsButton.Location
                = new Point(ClientSize.Width - menuToSettingsButton.Width, 0);
            Preview_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            Settings_Back_Button.Location
                 = new Point(ClientSize.Width - 180, ClientSize.Height - 30);
            pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Width / 2, pictureBox1.Location.Y);
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, label1.Location.Y);

            //the following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thoughtout out locations on the settingsPage panel
            emailSettingsInfo.Width = ClientSize.Width;
            emailSettingsButton.Width = ClientSize.Width;
            accountSettingsInfo.Width = ClientSize.Width;
            accountsSettingsButton.Width = ClientSize.Width;

            //The following code sets the locations of buttons and other controls to be more centered
            //and looking like they're in thought out locations on the previewAndSendData panel
            dataPreviewWindow.Size = new Size((int)(ClientSize.Width / 1.25), (int)(ClientSize.Height / 1.25));
            dataPreviewWindow.Location = new Point(ClientSize.Width / 2 - dataPreviewWindow.Width / 2,
                ClientSize.Height / 2 - dataPreviewWindow.Height / 2);
            previewEmailInfo.Location = new Point(ClientSize.Width / 2 - previewEmailInfo.Width / 2,
                dataPreviewWindow.Height + dataPreviewWindow.Location.Y);
            
        }

        //this section is code that runs when menuToPreviewButtonIsClicked
        private void menuToPreviewButton_Click(object sender, EventArgs e)
        {
            //the following switches the visible panel on the form from menu to preview page
            menuPage.Visible = false;
            previewAndSendDataPage.Visible = true;
        }

        //this section is code that runs when menuToSettingsButton is clicked
        private void menuToSettingsButton_Click(object sender, EventArgs e)
        {
            //the following switches the visible panel on the form from menu to settings page
            menuPage.Visible = false;
            settingsPage.Visible = true;
        }

        //this section is code that runs when emailSettingsButton is clicked
        private void emailSettingsButton_Click(object sender, EventArgs e)
        {
            //makes sure you dont click on a thing twice
            //emailSettingsButton.Enabled = false;
            //accountsSettingsButton.Enabled = true;

            //moves the other locations to where they need to be
            accountSettingsInfo.Size = new Size(accountSettingsInfo.Width, 52);
            accountSettingsInfo.Location = new Point(0, 208 + 104 + 80);
            emailSettingsInfo.Size = new Size(emailSettingsInfo.Width, 104 + 104 + 80);

        }

        private void accountsSettingsButton_Click(object sender, EventArgs e)
        {
            //makes sure you dont click on a thing twice
            //accountsSettingsButton.Enabled = false;
            //emailSettingsButton.Enabled = true;

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
                    saveNewEmailData.WriteLine(destinationAddressField.Text);
                    saveNewEmailData.WriteLine(emailSubjectField.Text);
                    saveNewEmailData.Write(emailBodyField.Text);
                    saveNewEmailData.Close();
                    //saveNewEmailData.Dispose();
                }
            }
            catch
            {
                displayErrorMessage("'Email_info.txt' not found");
            }
            //The following code populates the emailpreview information
            previewFromAddress.Text = "From: " + emailAddressField.Text;
            previewToAddress.Text = "To: " + destinationAddressField.Text;
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
                        //saveNewAccount.Dispose();
                    }
                    //refreshes the display box
                    fillAndRefreshAccounts();
                }
                catch
                {
                    displayErrorMessage("'Companies.txt' not found");
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
                    //subtractAccount.Dispose();
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
                    //subtractAccount.Dispose();
                }

                //refreshes the display box
                fillAndRefreshAccounts();
            }
            catch
            {
                displayErrorMessage("'Companies.txt' not found");
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
                            emailAddress = lineInTheFile;
                            emailAddressField.Text = emailAddress;
                        }
                        else if (i == 1)
                        {
                            emailPassword = lineInTheFile;
                            emailPasswordField.Text = emailPassword;
                        }
                        else if (i == 2)
                        {
                            emailDestination = lineInTheFile;
                            destinationAddressField.Text = emailDestination;
                        }
                        else if (i == 3)
                        {
                            emailSubject = lineInTheFile;
                            emailSubjectField.Text = emailSubject;
                        }
                        else
                        {
                            if (i != 4)
                            {
                                
                                emailBody += "\r\n";
                            }
                            emailBody += lineInTheFile;
                            emailBodyField.Text = emailBody;
                        }
                    }
                }
            }
            catch
            {
                displayErrorMessage("'Email_info.txt' not found");
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
                displayErrorMessage("'Companies.txt' not found");
            }
        }

        //code so that when adding a new account you can press the enter key if not the button
        private void addAccountTextField_KeyDown(object sender, KeyEventArgs e)
        {
            //checks to see if the key pressed was the enter key
            if (e.KeyCode == Keys.Enter)
            {
                //runs the code that would happen if the addAccountsButton was clicked
                addAccountsButton_Click(this, new EventArgs());
            }
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                NetworkCredential basicCredential = new NetworkCredential(emailAddress, emailPassword);
                MailMessage message = new MailMessage();
                MailAddress fromAddress = new MailAddress(emailAddress);
                smtpClient.EnableSsl = true;

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = basicCredential;

                message.From = fromAddress;

                message.Subject = "attach test";
                //Set IsBodyHtml to true means you can send HTML email.
                message.IsBodyHtml = true;
                message.Body = "<h1>your message body</h1>";

                //Attachment salesReport = new Attachment(file);
                //message.Attachments.Add(salesReport);

                message.To.Add(emailDestination);


                try
                {
                    for (int i = 0; i < 1; i++)
                    {
                        smtpClient.Send(message);
                    }
                }
                catch
                {
                    //Error, could not send the message
                    displayErrorMessage("Message not sent");
                }
            }
            catch
            {

            }
        }
        private void displayErrorMessage(string errorMessage){
            ErrorPopup error = new ErrorPopup();
            error.errorText = errorMessage;
            error.ShowDialog();
        }
    }     
}
