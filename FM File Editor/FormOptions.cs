using System.IO;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            textBoxDefaultFilePath.Text = Properties.Settings.Default.DefaultFilePath;
            comboBoxDelimiter.SelectedIndex = Properties.Settings.Default.Delimiter;
        }

        private void buttonDefaultFilePathBrowse_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();

            folderBrowserDialog.SelectedPath = textBoxDefaultFilePath.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDefaultFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(textBoxDefaultFilePath.Text))
            {
                Properties.Settings.Default.DefaultFilePath = textBoxDefaultFilePath.Text;
                Properties.Settings.Default.Delimiter = comboBoxDelimiter.SelectedIndex;

                this.Close();
            }
            else
            {
                MessageBox.Show("The default file path does not exist.", "Invalid default file path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
