namespace SalesReportProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuToSettingsButton = new System.Windows.Forms.Button();
            this.menuToPreviewButton = new System.Windows.Forms.Button();
            this.previewAndSendDataPage = new System.Windows.Forms.Panel();
            this.previewEmailInfo = new System.Windows.Forms.Panel();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.previewFromAddress = new System.Windows.Forms.Label();
            this.previewToAddress = new System.Windows.Forms.Label();
            this.Preview_Back_Button = new System.Windows.Forms.Button();
            this.dataPreviewWindow = new System.Windows.Forms.DataGridView();
            this.Distributor_ID_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distributor_Customer_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distributor_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Street_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distributor_Item_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReDistributor_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReDistributor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCC_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribution_Center_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Substitution_Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsPage = new System.Windows.Forms.Panel();
            this.Settings_Back_Button = new System.Windows.Forms.Button();
            this.emailSettingsInfo = new System.Windows.Forms.Panel();
            this.saveEmailDataButton = new System.Windows.Forms.Button();
            this.destinationAddressField = new System.Windows.Forms.TextBox();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressField = new System.Windows.Forms.TextBox();
            this.emailPasswordField = new System.Windows.Forms.TextBox();
            this.emailSettingsButton = new System.Windows.Forms.Button();
            this.emailPasswordLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.accountSettingsInfo = new System.Windows.Forms.Panel();
            this.subtractAccountsButton = new System.Windows.Forms.Button();
            this.addAccountTextField = new System.Windows.Forms.TextBox();
            this.addAccountsButton = new System.Windows.Forms.Button();
            this.accountDisplayBox = new System.Windows.Forms.CheckedListBox();
            this.accountsSettingsButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.previewAndSendDataPage.SuspendLayout();
            this.previewEmailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreviewWindow)).BeginInit();
            this.settingsPage.SuspendLayout();
            this.emailSettingsInfo.SuspendLayout();
            this.accountSettingsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPage
            // 
            this.menuPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuPage.Controls.Add(this.pictureBox1);
            this.menuPage.Controls.Add(this.menuToSettingsButton);
            this.menuPage.Controls.Add(this.menuToPreviewButton);
            this.menuPage.Location = new System.Drawing.Point(2, 1);
            this.menuPage.Margin = new System.Windows.Forms.Padding(2);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(738, 511);
            this.menuPage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesReportProject.Properties.Resources.l;
            this.pictureBox1.Location = new System.Drawing.Point(224, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 174);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuToSettingsButton
            // 
            this.menuToSettingsButton.Image = global::SalesReportProject.Properties.Resources._1;
            this.menuToSettingsButton.Location = new System.Drawing.Point(693, 2);
            this.menuToSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuToSettingsButton.Name = "menuToSettingsButton";
            this.menuToSettingsButton.Size = new System.Drawing.Size(27, 26);
            this.menuToSettingsButton.TabIndex = 1;
            this.menuToSettingsButton.UseVisualStyleBackColor = true;
            this.menuToSettingsButton.Click += new System.EventHandler(this.menuToSettingsButton_Click);
            // 
            // menuToPreviewButton
            // 
            this.menuToPreviewButton.Location = new System.Drawing.Point(306, 286);
            this.menuToPreviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuToPreviewButton.Name = "menuToPreviewButton";
            this.menuToPreviewButton.Size = new System.Drawing.Size(65, 21);
            this.menuToPreviewButton.TabIndex = 0;
            this.menuToPreviewButton.Text = "Click Here";
            this.menuToPreviewButton.UseVisualStyleBackColor = true;
            this.menuToPreviewButton.Click += new System.EventHandler(this.menuToPreviewButton_Click);
            // 
            // previewAndSendDataPage
            // 
            this.previewAndSendDataPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previewAndSendDataPage.Controls.Add(this.previewEmailInfo);
            this.previewAndSendDataPage.Controls.Add(this.Preview_Back_Button);
            this.previewAndSendDataPage.Controls.Add(this.dataPreviewWindow);
            this.previewAndSendDataPage.Location = new System.Drawing.Point(2, 513);
            this.previewAndSendDataPage.Margin = new System.Windows.Forms.Padding(2);
            this.previewAndSendDataPage.Name = "previewAndSendDataPage";
            this.previewAndSendDataPage.Size = new System.Drawing.Size(738, 399);
            this.previewAndSendDataPage.TabIndex = 0;
            // 
            // previewEmailInfo
            // 
            this.previewEmailInfo.Controls.Add(this.sendEmailButton);
            this.previewEmailInfo.Controls.Add(this.previewFromAddress);
            this.previewEmailInfo.Controls.Add(this.previewToAddress);
            this.previewEmailInfo.Location = new System.Drawing.Point(653, 146);
            this.previewEmailInfo.Margin = new System.Windows.Forms.Padding(2);
            this.previewEmailInfo.Name = "previewEmailInfo";
            this.previewEmailInfo.Size = new System.Drawing.Size(299, 32);
            this.previewEmailInfo.TabIndex = 1;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(6, 2);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(80, 26);
            this.sendEmailButton.TabIndex = 2;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // previewFromAddress
            // 
            this.previewFromAddress.AutoSize = true;
            this.previewFromAddress.Location = new System.Drawing.Point(96, 2);
            this.previewFromAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewFromAddress.Name = "previewFromAddress";
            this.previewFromAddress.Size = new System.Drawing.Size(35, 13);
            this.previewFromAddress.TabIndex = 3;
            this.previewFromAddress.Text = "label1";
            // 
            // previewToAddress
            // 
            this.previewToAddress.AutoSize = true;
            this.previewToAddress.Location = new System.Drawing.Point(96, 15);
            this.previewToAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewToAddress.Name = "previewToAddress";
            this.previewToAddress.Size = new System.Drawing.Size(35, 13);
            this.previewToAddress.TabIndex = 1;
            this.previewToAddress.Text = "label2";
            // 
            // Preview_Back_Button
            // 
            this.Preview_Back_Button.Location = new System.Drawing.Point(4, 4);
            this.Preview_Back_Button.Name = "Preview_Back_Button";
            this.Preview_Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Preview_Back_Button.TabIndex = 1;
            this.Preview_Back_Button.Text = "Back";
            this.Preview_Back_Button.UseVisualStyleBackColor = true;
            this.Preview_Back_Button.Click += new System.EventHandler(this.Preview_Back_Button_Click);
            // 
            // dataPreviewWindow
            // 
            this.dataPreviewWindow.AllowUserToAddRows = false;
            this.dataPreviewWindow.AllowUserToDeleteRows = false;
            this.dataPreviewWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPreviewWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreviewWindow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Distributor_ID_Number,
            this.Distributor_Customer_Number,
            this.Distributor_Customer_Name,
            this.Customer_Street_Address,
            this.Customer_Zip,
            this.Transaction_Date,
            this.Distributor_Item_Number,
            this.Brand,
            this.Description,
            this.Pack_Size,
            this.UOM,
            this.ReDistributor_Number,
            this.Manufacturer_Number,
            this.Transaction_Quantity,
            this.Transaction_Volume,
            this.Transaction_Currency,
            this.ReDistributor_Name,
            this.Manufacturer_Name,
            this.SCC_Code,
            this.UPC,
            this.Category,
            this.Subcategory,
            this.Invoice_Number,
            this.Category_Code,
            this.Distribution_Center_ID,
            this.Substitution_Indicator,
            this.GTIN});
            this.dataPreviewWindow.Location = new System.Drawing.Point(58, 48);
            this.dataPreviewWindow.Name = "dataPreviewWindow";
            this.dataPreviewWindow.ReadOnly = true;
            this.dataPreviewWindow.Size = new System.Drawing.Size(500, 364);
            this.dataPreviewWindow.TabIndex = 0;
            // 
            // Distributor_ID_Number
            // 
            this.Distributor_ID_Number.HeaderText = "Distributor_ID_Number.";
            this.Distributor_ID_Number.Name = "Distributor_ID_Number";
            this.Distributor_ID_Number.ReadOnly = true;
            // 
            // Distributor_Customer_Number
            // 
            this.Distributor_Customer_Number.HeaderText = "Distributor_Customer_Number";
            this.Distributor_Customer_Number.Name = "Distributor_Customer_Number";
            this.Distributor_Customer_Number.ReadOnly = true;
            // 
            // Distributor_Customer_Name
            // 
            this.Distributor_Customer_Name.HeaderText = "Distributor_Customer_Name";
            this.Distributor_Customer_Name.Name = "Distributor_Customer_Name";
            this.Distributor_Customer_Name.ReadOnly = true;
            // 
            // Customer_Street_Address
            // 
            this.Customer_Street_Address.HeaderText = "Customer_Street_Address";
            this.Customer_Street_Address.Name = "Customer_Street_Address";
            this.Customer_Street_Address.ReadOnly = true;
            // 
            // Customer_Zip
            // 
            this.Customer_Zip.HeaderText = "Customer_Zip";
            this.Customer_Zip.Name = "Customer_Zip";
            this.Customer_Zip.ReadOnly = true;
            // 
            // Transaction_Date
            // 
            this.Transaction_Date.HeaderText = "Transaction_Date";
            this.Transaction_Date.Name = "Transaction_Date";
            this.Transaction_Date.ReadOnly = true;
            // 
            // Distributor_Item_Number
            // 
            this.Distributor_Item_Number.HeaderText = "Distributor_Item_Number";
            this.Distributor_Item_Number.Name = "Distributor_Item_Number";
            this.Distributor_Item_Number.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Pack_Size
            // 
            this.Pack_Size.HeaderText = "Pack_Size";
            this.Pack_Size.Name = "Pack_Size";
            this.Pack_Size.ReadOnly = true;
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            // 
            // ReDistributor_Number
            // 
            this.ReDistributor_Number.HeaderText = "ReDistributor_Number";
            this.ReDistributor_Number.Name = "ReDistributor_Number";
            this.ReDistributor_Number.ReadOnly = true;
            // 
            // Manufacturer_Number
            // 
            this.Manufacturer_Number.HeaderText = "Manufacturer_Number";
            this.Manufacturer_Number.Name = "Manufacturer_Number";
            this.Manufacturer_Number.ReadOnly = true;
            // 
            // Transaction_Quantity
            // 
            this.Transaction_Quantity.HeaderText = "Transaction_Quantity";
            this.Transaction_Quantity.Name = "Transaction_Quantity";
            this.Transaction_Quantity.ReadOnly = true;
            // 
            // Transaction_Volume
            // 
            this.Transaction_Volume.HeaderText = "Transaction_Volume";
            this.Transaction_Volume.Name = "Transaction_Volume";
            this.Transaction_Volume.ReadOnly = true;
            // 
            // Transaction_Currency
            // 
            this.Transaction_Currency.HeaderText = "Transaction_Currency";
            this.Transaction_Currency.Name = "Transaction_Currency";
            this.Transaction_Currency.ReadOnly = true;
            // 
            // ReDistributor_Name
            // 
            this.ReDistributor_Name.HeaderText = "ReDistributor_Name";
            this.ReDistributor_Name.Name = "ReDistributor_Name";
            this.ReDistributor_Name.ReadOnly = true;
            // 
            // Manufacturer_Name
            // 
            this.Manufacturer_Name.HeaderText = "Manufacturer_Name";
            this.Manufacturer_Name.Name = "Manufacturer_Name";
            this.Manufacturer_Name.ReadOnly = true;
            // 
            // SCC_Code
            // 
            this.SCC_Code.HeaderText = "SCC_Code";
            this.SCC_Code.Name = "SCC_Code";
            this.SCC_Code.ReadOnly = true;
            // 
            // UPC
            // 
            this.UPC.HeaderText = "UPC";
            this.UPC.Name = "UPC";
            this.UPC.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Subcategory
            // 
            this.Subcategory.HeaderText = "Subcategory";
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.ReadOnly = true;
            // 
            // Invoice_Number
            // 
            this.Invoice_Number.HeaderText = "Invoice_Number";
            this.Invoice_Number.Name = "Invoice_Number";
            this.Invoice_Number.ReadOnly = true;
            // 
            // Category_Code
            // 
            this.Category_Code.HeaderText = "Category_Code";
            this.Category_Code.Name = "Category_Code";
            this.Category_Code.ReadOnly = true;
            // 
            // Distribution_Center_ID
            // 
            this.Distribution_Center_ID.HeaderText = "Distribution_Center_ID";
            this.Distribution_Center_ID.Name = "Distribution_Center_ID";
            this.Distribution_Center_ID.ReadOnly = true;
            // 
            // Substitution_Indicator
            // 
            this.Substitution_Indicator.HeaderText = "Substitution_Indicator";
            this.Substitution_Indicator.Name = "Substitution_Indicator";
            this.Substitution_Indicator.ReadOnly = true;
            // 
            // GTIN
            // 
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            this.GTIN.ReadOnly = true;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsPage.Controls.Add(this.label1);
            this.settingsPage.Controls.Add(this.Settings_Back_Button);
            this.settingsPage.Controls.Add(this.emailSettingsInfo);
            this.settingsPage.Controls.Add(this.accountSettingsInfo);
            this.settingsPage.Controls.Add(this.settingsLabel);
            this.settingsPage.Location = new System.Drawing.Point(744, 513);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(738, 399);
            this.settingsPage.TabIndex = 0;
            // 
            // Settings_Back_Button
            // 
            this.Settings_Back_Button.Location = new System.Drawing.Point(0, 0);
            this.Settings_Back_Button.Name = "Settings_Back_Button";
            this.Settings_Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Settings_Back_Button.TabIndex = 4;
            this.Settings_Back_Button.Text = "Back";
            this.Settings_Back_Button.UseVisualStyleBackColor = true;
            this.Settings_Back_Button.Click += new System.EventHandler(this.Settings_Back_Button_Click);
            // 
            // emailSettingsInfo
            // 
            this.emailSettingsInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailSettingsInfo.Controls.Add(this.saveEmailDataButton);
            this.emailSettingsInfo.Controls.Add(this.destinationAddressField);
            this.emailSettingsInfo.Controls.Add(this.destinationAddressLabel);
            this.emailSettingsInfo.Controls.Add(this.emailAddressField);
            this.emailSettingsInfo.Controls.Add(this.emailPasswordField);
            this.emailSettingsInfo.Controls.Add(this.emailSettingsButton);
            this.emailSettingsInfo.Controls.Add(this.emailPasswordLabel);
            this.emailSettingsInfo.Controls.Add(this.emailAddressLabel);
            this.emailSettingsInfo.Location = new System.Drawing.Point(0, 104);
            this.emailSettingsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.emailSettingsInfo.Name = "emailSettingsInfo";
            this.emailSettingsInfo.Size = new System.Drawing.Size(736, 52);
            this.emailSettingsInfo.TabIndex = 1;
            // 
            // saveEmailDataButton
            // 
            this.saveEmailDataButton.Location = new System.Drawing.Point(4, 142);
            this.saveEmailDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveEmailDataButton.Name = "saveEmailDataButton";
            this.saveEmailDataButton.Size = new System.Drawing.Size(45, 21);
            this.saveEmailDataButton.TabIndex = 11;
            this.saveEmailDataButton.Text = "Save";
            this.saveEmailDataButton.UseVisualStyleBackColor = true;
            this.saveEmailDataButton.Click += new System.EventHandler(this.saveEmailDataButton_Click);
            // 
            // destinationAddressField
            // 
            this.destinationAddressField.Location = new System.Drawing.Point(110, 106);
            this.destinationAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.destinationAddressField.Name = "destinationAddressField";
            this.destinationAddressField.Size = new System.Drawing.Size(232, 20);
            this.destinationAddressField.TabIndex = 7;
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(2, 108);
            this.destinationAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationAddressLabel.TabIndex = 10;
            this.destinationAddressLabel.Text = "Destination Address:";
            // 
            // emailAddressField
            // 
            this.emailAddressField.Location = new System.Drawing.Point(110, 54);
            this.emailAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.emailAddressField.Name = "emailAddressField";
            this.emailAddressField.Size = new System.Drawing.Size(232, 20);
            this.emailAddressField.TabIndex = 5;
            // 
            // emailPasswordField
            // 
            this.emailPasswordField.Location = new System.Drawing.Point(110, 79);
            this.emailPasswordField.Margin = new System.Windows.Forms.Padding(2);
            this.emailPasswordField.Name = "emailPasswordField";
            this.emailPasswordField.PasswordChar = '$';
            this.emailPasswordField.Size = new System.Drawing.Size(232, 20);
            this.emailPasswordField.TabIndex = 6;
            // 
            // emailSettingsButton
            // 
            this.emailSettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.emailSettingsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.emailSettingsButton.FlatAppearance.BorderSize = 0;
            this.emailSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailSettingsButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.emailSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.emailSettingsButton.Name = "emailSettingsButton";
            this.emailSettingsButton.Size = new System.Drawing.Size(736, 52);
            this.emailSettingsButton.TabIndex = 2;
            this.emailSettingsButton.Text = "Email";
            this.emailSettingsButton.UseVisualStyleBackColor = false;
            this.emailSettingsButton.Click += new System.EventHandler(this.emailSettingsButton_Click);
            // 
            // emailPasswordLabel
            // 
            this.emailPasswordLabel.AutoSize = true;
            this.emailPasswordLabel.Location = new System.Drawing.Point(2, 81);
            this.emailPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailPasswordLabel.Name = "emailPasswordLabel";
            this.emailPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.emailPasswordLabel.TabIndex = 9;
            this.emailPasswordLabel.Text = "Email\'s Password:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(2, 54);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(102, 13);
            this.emailAddressLabel.TabIndex = 8;
            this.emailAddressLabel.Text = "From Email Address:";
            // 
            // accountSettingsInfo
            // 
            this.accountSettingsInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.accountSettingsInfo.Controls.Add(this.subtractAccountsButton);
            this.accountSettingsInfo.Controls.Add(this.addAccountTextField);
            this.accountSettingsInfo.Controls.Add(this.addAccountsButton);
            this.accountSettingsInfo.Controls.Add(this.accountDisplayBox);
            this.accountSettingsInfo.Controls.Add(this.accountsSettingsButton);
            this.accountSettingsInfo.Location = new System.Drawing.Point(0, 156);
            this.accountSettingsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.accountSettingsInfo.Name = "accountSettingsInfo";
            this.accountSettingsInfo.Size = new System.Drawing.Size(736, 52);
            this.accountSettingsInfo.TabIndex = 3;
            // 
            // subtractAccountsButton
            // 
            this.subtractAccountsButton.BackColor = System.Drawing.SystemColors.Control;
            this.subtractAccountsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.subtractAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractAccountsButton.Location = new System.Drawing.Point(244, 187);
            this.subtractAccountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.subtractAccountsButton.Name = "subtractAccountsButton";
            this.subtractAccountsButton.Size = new System.Drawing.Size(38, 20);
            this.subtractAccountsButton.TabIndex = 6;
            this.subtractAccountsButton.Text = "--";
            this.subtractAccountsButton.UseVisualStyleBackColor = false;
            this.subtractAccountsButton.Click += new System.EventHandler(this.subtractAccountsButton_Click);
            // 
            // addAccountTextField
            // 
            this.addAccountTextField.Location = new System.Drawing.Point(41, 187);
            this.addAccountTextField.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountTextField.Name = "addAccountTextField";
            this.addAccountTextField.Size = new System.Drawing.Size(164, 20);
            this.addAccountTextField.TabIndex = 5;
            this.addAccountTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addAccountTextField_KeyDown);
            // 
            // addAccountsButton
            // 
            this.addAccountsButton.BackColor = System.Drawing.SystemColors.Control;
            this.addAccountsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountsButton.Location = new System.Drawing.Point(4, 187);
            this.addAccountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountsButton.Name = "addAccountsButton";
            this.addAccountsButton.Size = new System.Drawing.Size(38, 20);
            this.addAccountsButton.TabIndex = 4;
            this.addAccountsButton.Text = "+";
            this.addAccountsButton.UseVisualStyleBackColor = false;
            this.addAccountsButton.Click += new System.EventHandler(this.addAccountsButton_Click);
            // 
            // accountDisplayBox
            // 
            this.accountDisplayBox.BackColor = System.Drawing.SystemColors.Control;
            this.accountDisplayBox.CheckOnClick = true;
            this.accountDisplayBox.Font = new System.Drawing.Font("Arial", 10F);
            this.accountDisplayBox.FormattingEnabled = true;
            this.accountDisplayBox.Location = new System.Drawing.Point(4, 56);
            this.accountDisplayBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountDisplayBox.Name = "accountDisplayBox";
            this.accountDisplayBox.Size = new System.Drawing.Size(280, 112);
            this.accountDisplayBox.Sorted = true;
            this.accountDisplayBox.TabIndex = 3;
            // 
            // accountsSettingsButton
            // 
            this.accountsSettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.accountsSettingsButton.FlatAppearance.BorderSize = 0;
            this.accountsSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.accountsSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsSettingsButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.accountsSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.accountsSettingsButton.Name = "accountsSettingsButton";
            this.accountsSettingsButton.Size = new System.Drawing.Size(736, 52);
            this.accountsSettingsButton.TabIndex = 2;
            this.accountsSettingsButton.Text = "Accounts";
            this.accountsSettingsButton.UseVisualStyleBackColor = false;
            this.accountsSettingsButton.Click += new System.EventHandler(this.accountsSettingsButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(225, 0);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(0, 13);
            this.settingsLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 404);
            this.Controls.Add(this.settingsPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.previewAndSendDataPage);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Sales Report App";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.menuPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.previewAndSendDataPage.ResumeLayout(false);
            this.previewEmailInfo.ResumeLayout(false);
            this.previewEmailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreviewWindow)).EndInit();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.emailSettingsInfo.ResumeLayout(false);
            this.emailSettingsInfo.PerformLayout();
            this.accountSettingsInfo.ResumeLayout(false);
            this.accountSettingsInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPage;
        private System.Windows.Forms.Panel previewAndSendDataPage;
        private System.Windows.Forms.Panel settingsPage;
        private System.Windows.Forms.Button menuToSettingsButton;
        private System.Windows.Forms.Button menuToPreviewButton;
        private System.Windows.Forms.Button emailSettingsButton;
        private System.Windows.Forms.Button accountsSettingsButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel emailSettingsInfo;
        private System.Windows.Forms.Panel accountSettingsInfo;
        private System.Windows.Forms.DataGridView dataPreviewWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distributor_ID_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distributor_Customer_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distributor_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Street_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distributor_Item_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReDistributor_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReDistributor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCC_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distribution_Center_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Substitution_Indicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.Button Preview_Back_Button;
        private System.Windows.Forms.Button Settings_Back_Button;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox destinationAddressField;
        private System.Windows.Forms.TextBox emailPasswordField;
        private System.Windows.Forms.TextBox emailAddressField;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.Label emailPasswordLabel;
        private System.Windows.Forms.Button saveEmailDataButton;
        private System.Windows.Forms.Button subtractAccountsButton;
        private System.Windows.Forms.TextBox addAccountTextField;
        private System.Windows.Forms.Button addAccountsButton;
        private System.Windows.Forms.CheckedListBox accountDisplayBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Panel previewEmailInfo;
        private System.Windows.Forms.Label previewFromAddress;
        private System.Windows.Forms.Label previewToAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

