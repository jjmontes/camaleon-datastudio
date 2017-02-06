using System.Windows.Forms;

namespace CamaleonDataStudio
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        public string ConnectionString { get; set; }
    }
}
