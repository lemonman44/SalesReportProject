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
    public partial class ErrorPopup : Form
    {
        internal string errorText;

        public ErrorPopup()
        {
            InitializeComponent();
        }
        private void ErrorPopup_Load(object sender, EventArgs e)
        {
            errorLabel.Text = errorText;
            acceptButton.Location
                 = new Point(ClientSize.Width - 80, ClientSize.Height - 30);
            errorLabel.Location
                 = new Point((ClientSize.Width - errorLabel.Width)/2, (ClientSize.Height - errorLabel.Height)/3);
        }

        private void ErrorPopup_SizeChanged(object sender, EventArgs e)
        {
            acceptButton.Location
                 = new Point(ClientSize.Width - 80, ClientSize.Height - 30);
            errorLabel.Location
                 = new Point((ClientSize.Width - errorLabel.Width) / 2, (ClientSize.Height - errorLabel.Height) / 3);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
