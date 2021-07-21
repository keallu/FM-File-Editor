using System;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            labelVersion.Text = "Version " + Application.ProductVersion;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
