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
            files.Columns.Add("Directory", typeof(string));
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

        private void toolStripMenuItemFilesDelete_Click(object sender, EventArgs e)
        {
            Delete();
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
                foreach (string file in Directory.GetFiles(toolStripTextBoxPath.Text, "*.lnc", SearchOption.AllDirectories))
                {
                    files.Rows.Add(Path.GetFileName(file), ".." + Path.GetDirectoryName(file).Substring(toolStripTextBoxPath.Text.Length), Path.GetFullPath(file));
                }
            }
        }

        private void Delete()
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"Are you sure you want to delete the selected {dataGridViewFiles.SelectedRows.Count} files?", $"Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewFiles.SelectedRows)
                    {
                        File.Delete(row.Cells["Path"].Value.ToString());

                        dataGridViewFiles.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }
    }
}
