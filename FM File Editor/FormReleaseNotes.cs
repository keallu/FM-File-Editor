using System.Net.Http;
using System.Windows.Forms;


namespace FMFileEditor
{
    public partial class FormReleaseNotes : Form
    {
        static readonly HttpClient client = new();

        public FormReleaseNotes()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string releaseNotes = GetReleaseNotes();

            textBoxReleaseNotes.Text = releaseNotes.Replace("\n", "\r\n"); ;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private string GetReleaseNotes()
        {
            return client.GetStringAsync("https://gist.githubusercontent.com/keallu/69879d1d2e4b5aa4b768a665c2194bb0/raw/fmfileeditorreleasenotes.txt").Result;
        }
    }
}
