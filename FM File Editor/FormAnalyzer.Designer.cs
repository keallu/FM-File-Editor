
namespace FMFileEditor
{
    partial class FormAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalyzer));
            this.toolStripAnalyzer = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxPath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnalyze = new System.Windows.Forms.ToolStripButton();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAnalyzer = new System.Windows.Forms.TabControl();
            this.toolStripAnalyzer.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.tabControlAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripAnalyzer
            // 
            this.toolStripAnalyzer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAnalyzer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripAnalyzer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxPath,
            this.toolStripButtonBrowse,
            this.toolStripButtonAnalyze});
            this.toolStripAnalyzer.Location = new System.Drawing.Point(0, 0);
            this.toolStripAnalyzer.Name = "toolStripAnalyzer";
            this.toolStripAnalyzer.Size = new System.Drawing.Size(1154, 27);
            this.toolStripAnalyzer.TabIndex = 4;
            this.toolStripAnalyzer.Text = "toolStrip1";
            // 
            // toolStripTextBoxPath
            // 
            this.toolStripTextBoxPath.Name = "toolStripTextBoxPath";
            this.toolStripTextBoxPath.Size = new System.Drawing.Size(800, 27);
            this.toolStripTextBoxPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Football Manager 2021\\data\\database" +
    "\\db";
            // 
            // toolStripButtonBrowse
            // 
            this.toolStripButtonBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrowse.Image")));
            this.toolStripButtonBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrowse.Name = "toolStripButtonBrowse";
            this.toolStripButtonBrowse.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonBrowse.Text = "Browse...";
            this.toolStripButtonBrowse.Click += new System.EventHandler(this.toolStripButtonBrowse_Click);
            // 
            // toolStripButtonAnalyze
            // 
            this.toolStripButtonAnalyze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAnalyze.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnalyze.Image")));
            this.toolStripButtonAnalyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnalyze.Name = "toolStripButtonAnalyze";
            this.toolStripButtonAnalyze.Size = new System.Drawing.Size(65, 24);
            this.toolStripButtonAnalyze.Text = "Analyze";
            this.toolStripButtonAnalyze.Click += new System.EventHandler(this.toolStripButtonAnalyze_Click);
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.dataGridViewFiles);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 29);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(1146, 442);
            this.tabPageFiles.TabIndex = 0;
            this.tabPageFiles.Text = "Files";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFile,
            this.ColumnPath});
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersWidth = 51;
            this.dataGridViewFiles.RowTemplate.Height = 29;
            this.dataGridViewFiles.Size = new System.Drawing.Size(1140, 436);
            this.dataGridViewFiles.TabIndex = 0;
            // 
            // ColumnFile
            // 
            this.ColumnFile.DataPropertyName = "File";
            this.ColumnFile.HeaderText = "File";
            this.ColumnFile.MinimumWidth = 6;
            this.ColumnFile.Name = "ColumnFile";
            this.ColumnFile.ReadOnly = true;
            // 
            // ColumnPath
            // 
            this.ColumnPath.DataPropertyName = "Path";
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.MinimumWidth = 6;
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.ReadOnly = true;
            // 
            // tabControlAnalyzer
            // 
            this.tabControlAnalyzer.Controls.Add(this.tabPageFiles);
            this.tabControlAnalyzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAnalyzer.Location = new System.Drawing.Point(0, 27);
            this.tabControlAnalyzer.Name = "tabControlAnalyzer";
            this.tabControlAnalyzer.SelectedIndex = 0;
            this.tabControlAnalyzer.Size = new System.Drawing.Size(1154, 475);
            this.tabControlAnalyzer.TabIndex = 5;
            // 
            // FormAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 502);
            this.Controls.Add(this.tabControlAnalyzer);
            this.Controls.Add(this.toolStripAnalyzer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyzer";
            this.toolStripAnalyzer.ResumeLayout(false);
            this.toolStripAnalyzer.PerformLayout();
            this.tabPageFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.tabControlAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripAnalyzer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrowse;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnalyze;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.TabControl tabControlAnalyzer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
    }
}