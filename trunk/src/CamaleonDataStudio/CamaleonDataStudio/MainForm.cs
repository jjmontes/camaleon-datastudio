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
    }
}
