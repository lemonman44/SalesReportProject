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
            this.accountDisplayBox = new System.Windows.Forms.CheckedListBox();
            this.accountsSettingsButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.menuPage.Location = new System.Drawing.Point(4, 2);
            this.menuPage.Margin = new System.Windows.Forms.Padding(4);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(1476, 983);
            this.menuPage.TabIndex = 0;
            // 
            // menuToSettingsButton
            // 
            this.menuToSettingsButton.Image = global::SalesReportProject.Properties.Resources._1;
            this.menuToSettingsButton.Location = new System.Drawing.Point(1386, 4);
            this.menuToSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuToSettingsButton.Name = "menuToSettingsButton";
            this.menuToSettingsButton.Size = new System.Drawing.Size(54, 50);
            this.menuToSettingsButton.TabIndex = 1;
            this.menuToSettingsButton.UseVisualStyleBackColor = true;
            this.menuToSettingsButton.Click += new System.EventHandler(this.menuToSettingsButton_Click);
            // 
            // menuToPreviewButton
            // 
            this.menuToPreviewButton.Location = new System.Drawing.Point(614, 513);
            this.menuToPreviewButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuToPreviewButton.Name = "menuToPreviewButton";
            this.menuToPreviewButton.Size = new System.Drawing.Size(98, 40);
            this.menuToPreviewButton.TabIndex = 0;
            this.menuToPreviewButton.Text = "Click Here";
            this.menuToPreviewButton.UseVisualStyleBackColor = true;
            this.menuToPreviewButton.Click += new System.EventHandler(this.menuToPreviewButton_Click);
            // 
            // previewAndSendDataPage
            // 
            this.previewAndSendDataPage.Controls.Add(this.Preview_Back_Button);
            this.previewAndSendDataPage.Controls.Add(this.dataPreviewWindow);
            this.previewAndSendDataPage.Location = new System.Drawing.Point(4, 987);
            this.previewAndSendDataPage.Margin = new System.Windows.Forms.Padding(4);
            this.previewAndSendDataPage.Name = "previewAndSendDataPage";
            this.previewAndSendDataPage.Size = new System.Drawing.Size(1476, 767);
            this.previewAndSendDataPage.TabIndex = 0;
            // 
            // Preview_Back_Button
            // 
            this.Preview_Back_Button.Location = new System.Drawing.Point(8, 8);
            this.Preview_Back_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Preview_Back_Button.Name = "Preview_Back_Button";
            this.Preview_Back_Button.Size = new System.Drawing.Size(150, 44);
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
            this.dataPreviewWindow.Location = new System.Drawing.Point(116, 92);
            this.dataPreviewWindow.Margin = new System.Windows.Forms.Padding(6);
            this.dataPreviewWindow.Name = "dataPreviewWindow";
            this.dataPreviewWindow.Size = new System.Drawing.Size(1000, 700);
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
            this.settingsPage.Location = new System.Drawing.Point(1488, 987);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(4);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1476, 767);
            this.settingsPage.TabIndex = 0;
            // 
            // Settings_Back_Button
            // 
            this.Settings_Back_Button.Location = new System.Drawing.Point(0, 0);
            this.Settings_Back_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Settings_Back_Button.Name = "Settings_Back_Button";
            this.Settings_Back_Button.Size = new System.Drawing.Size(150, 44);
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
            this.emailSettingsInfo.Location = new System.Drawing.Point(0, 200);
            this.emailSettingsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.emailSettingsInfo.Name = "emailSettingsInfo";
            this.emailSettingsInfo.Size = new System.Drawing.Size(1472, 100);
            this.emailSettingsInfo.TabIndex = 1;
            // 
            // saveEmailDataButton
            // 
            this.saveEmailDataButton.Location = new System.Drawing.Point(8, 273);
            this.saveEmailDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveEmailDataButton.Name = "saveEmailDataButton";
            this.saveEmailDataButton.Size = new System.Drawing.Size(90, 40);
            this.saveEmailDataButton.TabIndex = 11;
            this.saveEmailDataButton.Text = "Save";
            this.saveEmailDataButton.UseVisualStyleBackColor = true;
            this.saveEmailDataButton.Click += new System.EventHandler(this.saveEmailDataButton_Click);
            // 
            // destinationAddressField
            // 
            this.destinationAddressField.Location = new System.Drawing.Point(220, 204);
            this.destinationAddressField.Margin = new System.Windows.Forms.Padding(4);
            this.destinationAddressField.Name = "destinationAddressField";
            this.destinationAddressField.Size = new System.Drawing.Size(460, 31);
            this.destinationAddressField.TabIndex = 7;
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(4, 208);
            this.destinationAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(211, 25);
            this.destinationAddressLabel.TabIndex = 10;
            this.destinationAddressLabel.Text = "Destination Address:";
            // 
            // emailAddressField
            // 
            this.emailAddressField.Location = new System.Drawing.Point(220, 104);
            this.emailAddressField.Margin = new System.Windows.Forms.Padding(4);
            this.emailAddressField.Name = "emailAddressField";
            this.emailAddressField.Size = new System.Drawing.Size(460, 31);
            this.emailAddressField.TabIndex = 5;
            // 
            // emailPasswordField
            // 
            this.emailPasswordField.Location = new System.Drawing.Point(220, 152);
            this.emailPasswordField.Margin = new System.Windows.Forms.Padding(4);
            this.emailPasswordField.Name = "emailPasswordField";
            this.emailPasswordField.PasswordChar = '$';
            this.emailPasswordField.Size = new System.Drawing.Size(460, 31);
            this.emailPasswordField.TabIndex = 6;
            // 
            // emailSettingsButton
            // 
            this.emailSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.emailSettingsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.emailSettingsButton.FlatAppearance.BorderSize = 0;
            this.emailSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailSettingsButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.emailSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.emailSettingsButton.Name = "emailSettingsButton";
            this.emailSettingsButton.Size = new System.Drawing.Size(1472, 100);
            this.emailSettingsButton.TabIndex = 2;
            this.emailSettingsButton.Text = "Email";
            this.emailSettingsButton.UseVisualStyleBackColor = false;
            this.emailSettingsButton.Click += new System.EventHandler(this.emailSettingsButton_Click);
            // 
            // emailPasswordLabel
            // 
            this.emailPasswordLabel.AutoSize = true;
            this.emailPasswordLabel.Location = new System.Drawing.Point(4, 156);
            this.emailPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailPasswordLabel.Name = "emailPasswordLabel";
            this.emailPasswordLabel.Size = new System.Drawing.Size(186, 25);
            this.emailPasswordLabel.TabIndex = 9;
            this.emailPasswordLabel.Text = "Email\'s Password:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(4, 104);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(211, 25);
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
            this.accountSettingsInfo.Location = new System.Drawing.Point(0, 300);
            this.accountSettingsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.accountSettingsInfo.Name = "accountSettingsInfo";
            this.accountSettingsInfo.Size = new System.Drawing.Size(1472, 100);
            this.accountSettingsInfo.TabIndex = 3;
            // 
            // subtractAccountsButton
            // 
            this.subtractAccountsButton.Location = new System.Drawing.Point(488, 360);
            this.subtractAccountsButton.Margin = new System.Windows.Forms.Padding(4);
            this.subtractAccountsButton.Name = "subtractAccountsButton";
            this.subtractAccountsButton.Size = new System.Drawing.Size(76, 31);
            this.subtractAccountsButton.TabIndex = 6;
            this.subtractAccountsButton.Text = "--";
            this.subtractAccountsButton.UseVisualStyleBackColor = true;
            this.subtractAccountsButton.Click += new System.EventHandler(this.subtractAccountsButton_Click);
            // 
            // addAccountTextField
            // 
            this.addAccountTextField.Location = new System.Drawing.Point(82, 360);
            this.addAccountTextField.Margin = new System.Windows.Forms.Padding(4);
            this.addAccountTextField.Name = "addAccountTextField";
            this.addAccountTextField.Size = new System.Drawing.Size(324, 31);
            this.addAccountTextField.TabIndex = 5;
            // 
            // addAccountsButton
            // 
            this.addAccountsButton.Location = new System.Drawing.Point(8, 360);
            this.addAccountsButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAccountsButton.Name = "addAccountsButton";
            this.addAccountsButton.Size = new System.Drawing.Size(76, 31);
            this.addAccountsButton.TabIndex = 4;
            this.addAccountsButton.Text = "+";
            this.addAccountsButton.UseVisualStyleBackColor = true;
            this.addAccountsButton.Click += new System.EventHandler(this.addAccountsButton_Click);
            // 
            // accountDisplayBox
            // 
            this.accountDisplayBox.BackColor = System.Drawing.SystemColors.Control;
            this.accountDisplayBox.CheckOnClick = true;
            this.accountDisplayBox.Font = new System.Drawing.Font("Arial", 10F);
            this.accountDisplayBox.FormattingEnabled = true;
            this.accountDisplayBox.Location = new System.Drawing.Point(8, 108);
            this.accountDisplayBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountDisplayBox.Name = "accountDisplayBox";
            this.accountDisplayBox.Size = new System.Drawing.Size(556, 235);
            this.accountDisplayBox.Sorted = true;
            this.accountDisplayBox.TabIndex = 3;
            // 
            // accountsSettingsButton
            // 
            this.accountsSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.accountsSettingsButton.FlatAppearance.BorderSize = 0;
            this.accountsSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsSettingsButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.accountsSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.accountsSettingsButton.Name = "accountsSettingsButton";
            this.accountsSettingsButton.Size = new System.Drawing.Size(1472, 100);
            this.accountsSettingsButton.TabIndex = 2;
            this.accountsSettingsButton.Text = "Accounts";
            this.accountsSettingsButton.UseVisualStyleBackColor = false;
            this.accountsSettingsButton.Click += new System.EventHandler(this.accountsSettingsButton_Click);
            this.accountsSettingsButton.MouseEnter += new System.EventHandler(this.accountsSettingsButton_MouseEnter);
            this.accountsSettingsButton.MouseLeave += new System.EventHandler(this.accountsSettingsButton_MouseLeave);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(450, 0);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(90, 25);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Settings";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1474);
            this.Controls.Add(this.settingsPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.previewAndSendDataPage);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckedListBox accountDisplayBox;
        private System.Windows.Forms.Timer timer1;
    }
}

