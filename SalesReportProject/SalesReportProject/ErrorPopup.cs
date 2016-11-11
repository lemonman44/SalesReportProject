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
        public ErrorPopup()
        {
            InitializeComponent();
        }
        private void ErrorPopup_Load(object sender, EventArgs e)
        {
            acceptButton.Location
                 = new Point(ClientSize.Width - 80, ClientSize.Height - 30);
            errorLabel.Location
                 = new Point((ClientSize.Width / 2) - (errorLabel.Width / 2), (ClientSize.Height / 2) - (errorLabel.Width / 2));
        }
    }
}
