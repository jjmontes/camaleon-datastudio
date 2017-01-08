using System;
using System.Windows.Forms;

namespace CamaleonDataStudio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm();
            queryForm.MdiParent = this;
            queryForm.Show();
        }
    }
}
