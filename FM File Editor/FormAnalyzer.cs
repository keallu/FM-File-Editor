using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormAnalyzer : Form
    {
        private DataTable files;

        public FormAnalyzer()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            files = new();
            files.Columns.Add("File", typeof(string));
            files.Columns.Add("Path", typeof(string));

            dataGridViewFiles.DataSource = files;
        }

        private void toolStripButtonBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        private void toolStripButtonAnalyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }

        private void Browse()
        {
            FolderBrowserDialog folderBrowserDialog = new();

            folderBrowserDialog.SelectedPath = toolStripTextBoxPath.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripTextBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Analyze()
        {
            files.Clear();

            if (Directory.Exists(toolStripTextBoxPath.Text))
            {
                string[] dirs = Directory.GetFiles(toolStripTextBoxPath.Text, "*.lnc", SearchOption.AllDirectories);

                foreach (string dir in dirs)
                {
                    files.Rows.Add(Path.GetFileName(dir), ".." + Path.GetDirectoryName(dir).Substring(toolStripTextBoxPath.Text.Length));
                }
            }
        }
    }
}
