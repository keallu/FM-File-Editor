
namespace FMFileEditor
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.buttonDefaultFilePathBrowse = new System.Windows.Forms.Button();
            this.labelDefaultFilePath = new System.Windows.Forms.Label();
            this.textBoxDefaultFilePath = new System.Windows.Forms.TextBox();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(857, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(757, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.buttonDefaultFilePathBrowse);
            this.groupBoxGeneral.Controls.Add(this.labelDefaultFilePath);
            this.groupBoxGeneral.Controls.Add(this.textBoxDefaultFilePath);
            this.groupBoxGeneral.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(939, 262);
            this.groupBoxGeneral.TabIndex = 2;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // buttonDefaultFilePathBrowse
            // 
            this.buttonDefaultFilePathBrowse.Location = new System.Drawing.Point(828, 45);
            this.buttonDefaultFilePathBrowse.Name = "buttonDefaultFilePathBrowse";
            this.buttonDefaultFilePathBrowse.Size = new System.Drawing.Size(94, 29);
            this.buttonDefaultFilePathBrowse.TabIndex = 2;
            this.buttonDefaultFilePathBrowse.Text = "Browse...";
            this.buttonDefaultFilePathBrowse.UseVisualStyleBackColor = true;
            this.buttonDefaultFilePathBrowse.Click += new System.EventHandler(this.buttonDefaultFilePathBrowse_Click);
            // 
            // labelDefaultFilePath
            // 
            this.labelDefaultFilePath.AutoSize = true;
            this.labelDefaultFilePath.Location = new System.Drawing.Point(17, 23);
            this.labelDefaultFilePath.Name = "labelDefaultFilePath";
            this.labelDefaultFilePath.Size = new System.Drawing.Size(117, 20);
            this.labelDefaultFilePath.TabIndex = 1;
            this.labelDefaultFilePath.Text = "Default file path";
            // 
            // textBoxDefaultFilePath
            // 
            this.textBoxDefaultFilePath.Location = new System.Drawing.Point(17, 45);
            this.textBoxDefaultFilePath.Name = "textBoxDefaultFilePath";
            this.textBoxDefaultFilePath.Size = new System.Drawing.Size(805, 27);
            this.textBoxDefaultFilePath.TabIndex = 0;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 321);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Button buttonDefaultFilePathBrowse;
        private System.Windows.Forms.Label labelDefaultFilePath;
        private System.Windows.Forms.TextBox textBoxDefaultFilePath;
    }
}