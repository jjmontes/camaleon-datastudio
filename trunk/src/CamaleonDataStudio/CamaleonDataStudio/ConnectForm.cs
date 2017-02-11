using CamaleonPluginManager;
using ConnectionCamaleonDataStudio;
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

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            ConnectType.Items.AddRange(PluginManager.Instance.Plugins);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (ConnectType.SelectedItem == null) return;
            IConnection connection = null;

            var queryForm = new QueryForm();
            queryForm.MdiParent = MdiParent;
            queryForm.Connection = connection;
            queryForm.Show();
            Close();
        }

        private void ConnectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect.Enabled = ConnectType.SelectedItem != null;
        }

    }
}
