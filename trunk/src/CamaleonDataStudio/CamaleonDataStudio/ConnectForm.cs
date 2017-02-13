using CamaleonPluginManager;
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
            var plugin = ConnectType.SelectedItem as Plugin;
            if (plugin == null) MessageBox.Show(string.Format("Error: No se puede determinar el plugin de conexión '{0}'", ConnectType.SelectedText));

            var queryForm = new QueryForm();
            queryForm.MdiParent = MdiParent;
            queryForm.Connection = plugin.Load();
            queryForm.Show();
            Close();
        }

        private void ConnectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect.Enabled = ConnectType.SelectedItem != null;
        }

    }
}
