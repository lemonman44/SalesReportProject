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
            this.settingsPage = new System.Windows.Forms.Panel();
            this.emailSettingsInfo = new System.Windows.Forms.Panel();
            this.emailSettingsButton = new System.Windows.Forms.Button();
            this.accountSettingsInfo = new System.Windows.Forms.Panel();
            this.accountsSettingsButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.menuPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.emailSettingsInfo.SuspendLayout();
            this.accountSettingsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPage
            // 
            this.menuPage.Controls.Add(this.menuToSettingsButton);
            this.menuPage.Controls.Add(this.menuToPreviewButton);
            this.menuPage.Location = new System.Drawing.Point(3, 0);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(741, 453);
            this.menuPage.TabIndex = 0;
            // 
            // menuToSettingsButton
            // 
            this.menuToSettingsButton.Location = new System.Drawing.Point(1410, 3);
            this.menuToSettingsButton.Name = "menuToSettingsButton";
            this.menuToSettingsButton.Size = new System.Drawing.Size(60, 60);
            this.menuToSettingsButton.TabIndex = 1;
            this.menuToSettingsButton.UseVisualStyleBackColor = true;
            this.menuToSettingsButton.Click += new System.EventHandler(this.menuToSettingsButton_Click);
            // 
            // menuToPreviewButton
            // 
            this.menuToPreviewButton.Location = new System.Drawing.Point(636, 551);
            this.menuToPreviewButton.Name = "menuToPreviewButton";
            this.menuToPreviewButton.Size = new System.Drawing.Size(200, 100);
            this.menuToPreviewButton.TabIndex = 0;
            this.menuToPreviewButton.Text = "Click Here";
            this.menuToPreviewButton.UseVisualStyleBackColor = true;
            this.menuToPreviewButton.Click += new System.EventHandler(this.menuToPreviewButton_Click);
            // 
            // previewAndSendDataPage
            // 
            this.previewAndSendDataPage.Location = new System.Drawing.Point(3, 459);
            this.previewAndSendDataPage.Name = "previewAndSendDataPage";
            this.previewAndSendDataPage.Size = new System.Drawing.Size(741, 453);
            this.previewAndSendDataPage.TabIndex = 0;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.emailSettingsInfo);
            this.settingsPage.Controls.Add(this.accountSettingsInfo);
            this.settingsPage.Controls.Add(this.settingsLabel);
            this.settingsPage.Location = new System.Drawing.Point(750, 3);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(744, 453);
            this.settingsPage.TabIndex = 0;
            // 
            // emailSettingsInfo
            // 
            this.emailSettingsInfo.Controls.Add(this.emailSettingsButton);
            this.emailSettingsInfo.Location = new System.Drawing.Point(0, 200);
            this.emailSettingsInfo.Name = "emailSettingsInfo";
            this.emailSettingsInfo.Size = new System.Drawing.Size(1473, 100);
            this.emailSettingsInfo.TabIndex = 1;
            // 
            // emailSettingsButton
            // 
            this.emailSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.emailSettingsButton.Name = "emailSettingsButton";
            this.emailSettingsButton.Size = new System.Drawing.Size(1473, 100);
            this.emailSettingsButton.TabIndex = 2;
            this.emailSettingsButton.Text = "Email";
            this.emailSettingsButton.UseVisualStyleBackColor = true;
            this.emailSettingsButton.Click += new System.EventHandler(this.emailSettingsButton_Click);
            // 
            // accountSettingsInfo
            // 
            this.accountSettingsInfo.Controls.Add(this.accountsSettingsButton);
            this.accountSettingsInfo.Location = new System.Drawing.Point(0, 300);
            this.accountSettingsInfo.Name = "accountSettingsInfo";
            this.accountSettingsInfo.Size = new System.Drawing.Size(1473, 100);
            this.accountSettingsInfo.TabIndex = 3;
            // 
            // accountsSettingsButton
            // 
            this.accountsSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.accountsSettingsButton.Name = "accountsSettingsButton";
            this.accountsSettingsButton.Size = new System.Drawing.Size(1473, 100);
            this.accountsSettingsButton.TabIndex = 2;
            this.accountsSettingsButton.Text = "Accounts";
            this.accountsSettingsButton.UseVisualStyleBackColor = true;
            this.accountsSettingsButton.Click += new System.EventHandler(this.accountsSettingsButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(90, 25);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 929);
            this.Controls.Add(this.settingsPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.previewAndSendDataPage);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.menuPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
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
    }
}

