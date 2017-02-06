using System;
using System.Windows.Forms;

namespace CamaleonDataStudio
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm();
            queryForm.MdiParent = MdiParent;
            queryForm.ConnectionString = ConnectionString.Text;
            queryForm.Show();
            Close();
        }
    }
}
