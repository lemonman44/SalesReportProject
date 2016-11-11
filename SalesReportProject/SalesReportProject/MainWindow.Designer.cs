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
            this.menuPage = new System.Windows.Forms.Panel();
            this.menuToSettingsButton = new System.Windows.Forms.Button();
            this.menuToPreviewButton = new System.Windows.Forms.Button();
            this.previewAndSendDataPage = new System.Windows.Forms.Panel();
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
            this.accountDisplayBox = new System.Windows.Forms.ListBox();
            this.accountsSettingsButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.menuPage.SuspendLayout();
            this.previewAndSendDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreviewWindow)).BeginInit();
            this.settingsPage.SuspendLayout();
            this.emailSettingsInfo.SuspendLayout();
            this.accountSettingsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPage
            // 
            this.menuPage.Controls.Add(this.menuToSettingsButton);
            this.menuPage.Controls.Add(this.menuToPreviewButton);
            this.menuPage.Location = new System.Drawing.Point(2, 1);
            this.menuPage.Margin = new System.Windows.Forms.Padding(2);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(738, 511);
            this.menuPage.TabIndex = 0;
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
            this.menuToPreviewButton.Location = new System.Drawing.Point(307, 267);
            this.menuToPreviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuToPreviewButton.Name = "menuToPreviewButton";
            this.menuToPreviewButton.Size = new System.Drawing.Size(49, 21);
            this.menuToPreviewButton.TabIndex = 0;
            this.menuToPreviewButton.Text = "Click Here";
            this.menuToPreviewButton.UseVisualStyleBackColor = true;
            this.menuToPreviewButton.Click += new System.EventHandler(this.menuToPreviewButton_Click);
            // 
            // previewAndSendDataPage
            // 
            this.previewAndSendDataPage.Controls.Add(this.Preview_Back_Button);
            this.previewAndSendDataPage.Controls.Add(this.dataPreviewWindow);
            this.previewAndSendDataPage.Location = new System.Drawing.Point(2, 513);
            this.previewAndSendDataPage.Margin = new System.Windows.Forms.Padding(2);
            this.previewAndSendDataPage.Name = "previewAndSendDataPage";
            this.previewAndSendDataPage.Size = new System.Drawing.Size(738, 399);
            this.previewAndSendDataPage.TabIndex = 0;
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
            this.dataPreviewWindow.Size = new System.Drawing.Size(240, 150);
            this.dataPreviewWindow.TabIndex = 0;
            // 
            // Distributor_ID_Number
            // 
            this.Distributor_ID_Number.HeaderText = "Distributor_ID_Number.";
            this.Distributor_ID_Number.Name = "Distributor_ID_Number";
            // 
            // Distributor_Customer_Number
            // 
            this.Distributor_Customer_Number.HeaderText = "Distributor_Customer_Number";
            this.Distributor_Customer_Number.Name = "Distributor_Customer_Number";
            // 
            // Distributor_Customer_Name
            // 
            this.Distributor_Customer_Name.HeaderText = "Distributor_Customer_Name";
            this.Distributor_Customer_Name.Name = "Distributor_Customer_Name";
            // 
            // Customer_Street_Address
            // 
            this.Customer_Street_Address.HeaderText = "Customer_Street_Address";
            this.Customer_Street_Address.Name = "Customer_Street_Address";
            // 
            // Customer_Zip
            // 
            this.Customer_Zip.HeaderText = "Customer_Zip";
            this.Customer_Zip.Name = "Customer_Zip";
            // 
            // Transaction_Date
            // 
            this.Transaction_Date.HeaderText = "Transaction_Date";
            this.Transaction_Date.Name = "Transaction_Date";
            // 
            // Distributor_Item_Number
            // 
            this.Distributor_Item_Number.HeaderText = "Distributor_Item_Number";
            this.Distributor_Item_Number.Name = "Distributor_Item_Number";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Pack_Size
            // 
            this.Pack_Size.HeaderText = "Pack_Size";
            this.Pack_Size.Name = "Pack_Size";
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            // 
            // ReDistributor_Number
            // 
            this.ReDistributor_Number.HeaderText = "ReDistributor_Number";
            this.ReDistributor_Number.Name = "ReDistributor_Number";
            // 
            // Manufacturer_Number
            // 
            this.Manufacturer_Number.HeaderText = "Manufacturer_Number";
            this.Manufacturer_Number.Name = "Manufacturer_Number";
            // 
            // Transaction_Quantity
            // 
            this.Transaction_Quantity.HeaderText = "Transaction_Quantity";
            this.Transaction_Quantity.Name = "Transaction_Quantity";
            // 
            // Transaction_Volume
            // 
            this.Transaction_Volume.HeaderText = "Transaction_Volume";
            this.Transaction_Volume.Name = "Transaction_Volume";
            // 
            // Transaction_Currency
            // 
            this.Transaction_Currency.HeaderText = "Transaction_Currency";
            this.Transaction_Currency.Name = "Transaction_Currency";
            // 
            // ReDistributor_Name
            // 
            this.ReDistributor_Name.HeaderText = "ReDistributor_Name";
            this.ReDistributor_Name.Name = "ReDistributor_Name";
            // 
            // Manufacturer_Name
            // 
            this.Manufacturer_Name.HeaderText = "Manufacturer_Name";
            this.Manufacturer_Name.Name = "Manufacturer_Name";
            // 
            // SCC_Code
            // 
            this.SCC_Code.HeaderText = "SCC_Code";
            this.SCC_Code.Name = "SCC_Code";
            // 
            // UPC
            // 
            this.UPC.HeaderText = "UPC";
            this.UPC.Name = "UPC";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Subcategory
            // 
            this.Subcategory.HeaderText = "Subcategory";
            this.Subcategory.Name = "Subcategory";
            // 
            // Invoice_Number
            // 
            this.Invoice_Number.HeaderText = "Invoice_Number";
            this.Invoice_Number.Name = "Invoice_Number";
            // 
            // Category_Code
            // 
            this.Category_Code.HeaderText = "Category_Code";
            this.Category_Code.Name = "Category_Code";
            // 
            // Distribution_Center_ID
            // 
            this.Distribution_Center_ID.HeaderText = "Distribution_Center_ID";
            this.Distribution_Center_ID.Name = "Distribution_Center_ID";
            // 
            // Substitution_Indicator
            // 
            this.Substitution_Indicator.HeaderText = "Substitution_Indicator";
            this.Substitution_Indicator.Name = "Substitution_Indicator";
            // 
            // GTIN
            // 
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            // 
            // settingsPage
            // 
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
            this.emailPasswordField.PasswordChar = '*';
            this.emailPasswordField.Size = new System.Drawing.Size(232, 20);
            this.emailPasswordField.TabIndex = 6;
            // 
            // emailSettingsButton
            // 
            this.emailSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.emailSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.emailSettingsButton.Name = "emailSettingsButton";
            this.emailSettingsButton.Size = new System.Drawing.Size(736, 52);
            this.emailSettingsButton.TabIndex = 2;
            this.emailSettingsButton.Text = "Email";
            this.emailSettingsButton.UseVisualStyleBackColor = true;
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
            this.subtractAccountsButton.Location = new System.Drawing.Point(244, 187);
            this.subtractAccountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.subtractAccountsButton.Name = "subtractAccountsButton";
            this.subtractAccountsButton.Size = new System.Drawing.Size(38, 16);
            this.subtractAccountsButton.TabIndex = 6;
            this.subtractAccountsButton.Text = "--";
            this.subtractAccountsButton.UseVisualStyleBackColor = true;
            this.subtractAccountsButton.Click += new System.EventHandler(this.subtractAccountsButton_Click);
            // 
            // addAccountTextField
            // 
            this.addAccountTextField.Location = new System.Drawing.Point(41, 187);
            this.addAccountTextField.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountTextField.Name = "addAccountTextField";
            this.addAccountTextField.Size = new System.Drawing.Size(164, 20);
            this.addAccountTextField.TabIndex = 5;
            // 
            // addAccountsButton
            // 
            this.addAccountsButton.Location = new System.Drawing.Point(4, 187);
            this.addAccountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountsButton.Name = "addAccountsButton";
            this.addAccountsButton.Size = new System.Drawing.Size(38, 16);
            this.addAccountsButton.TabIndex = 4;
            this.addAccountsButton.Text = "+";
            this.addAccountsButton.UseVisualStyleBackColor = true;
            this.addAccountsButton.Click += new System.EventHandler(this.addAccountsButton_Click);
            // 
            // accountDisplayBox
            // 
            this.accountDisplayBox.FormattingEnabled = true;
            this.accountDisplayBox.Location = new System.Drawing.Point(4, 56);
            this.accountDisplayBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountDisplayBox.Name = "accountDisplayBox";
            this.accountDisplayBox.Size = new System.Drawing.Size(280, 134);
            this.accountDisplayBox.TabIndex = 3;
            // 
            // accountsSettingsButton
            // 
            this.accountsSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.accountsSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.accountsSettingsButton.Name = "accountsSettingsButton";
            this.accountsSettingsButton.Size = new System.Drawing.Size(736, 52);
            this.accountsSettingsButton.TabIndex = 2;
            this.accountsSettingsButton.Text = "Accounts";
            this.accountsSettingsButton.UseVisualStyleBackColor = true;
            this.accountsSettingsButton.Click += new System.EventHandler(this.accountsSettingsButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(225, 0);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(45, 13);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 548);
            this.Controls.Add(this.settingsPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.previewAndSendDataPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Sales Report App";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.menuPage.ResumeLayout(false);
            this.previewAndSendDataPage.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox accountDisplayBox;
    }
}

