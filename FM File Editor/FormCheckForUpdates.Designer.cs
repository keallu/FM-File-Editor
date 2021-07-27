
namespace FMFileEditor
{
    partial class FormCheckForUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckForUpdates));
            this.labelUpdateAvailability = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUpdateAvailability
            // 
            this.labelUpdateAvailability.Location = new System.Drawing.Point(12, 9);
            this.labelUpdateAvailability.Name = "labelUpdateAvailability";
            this.labelUpdateAvailability.Size = new System.Drawing.Size(594, 82);
            this.labelUpdateAvailability.TabIndex = 0;
            this.labelUpdateAvailability.Text = "Checking for Updates...";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(512, 132);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCheckForUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 173);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelUpdateAvailability);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCheckForUpdates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check for Updates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateAvailability;
        private System.Windows.Forms.Button buttonOK;
    }
}