using ConnectionCamaleonDataStudio;
using System;
using System.IO;
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
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var directoryPlugins = string.Format("{0}/Plugins/", currentDirectory);
            Directory.CreateDirectory(directoryPlugins);
            var files = Directory.GetFiles(string.Format("{0}/Plugins/", currentDirectory), "*CamaleonDataStudio.dll");

            foreach (var file in files)
            {
                var info = new FileInfo(file);
                ConnectType.Items.Add(info.Name.Replace("CamaleonDataStudio.dll", string.Empty));
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            IConnection connection = null;

            var queryForm = new QueryForm();
            queryForm.MdiParent = MdiParent;
            queryForm.Connection = connection;
            queryForm.Show();
            Close();
        }

    }
}
