using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormError : Form
    {
        private List<string> list;

        public FormError(List<string> list)
        {
            this.list = list;

            InitializeComponent();

            Init();
        }

        private void Init()
        {
            labelError.Text = $"The following {list.Count} lines was not imported because they contained either unknown/invalid commands or arguments:";

            foreach (string line in list)
            {
                listBoxError.Items.Add(line);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
