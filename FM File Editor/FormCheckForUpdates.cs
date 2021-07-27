using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormCheckForUpdates : Form
    {
        static readonly HttpClient client = new();

        public FormCheckForUpdates()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            labelUpdateAvailability.Text = IsNewVersionAvailable()
                ? $"A new version is available. Go to your favorite Football Manager fan site and download it now."
                : $"You already have the newest version.";
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private bool IsNewVersionAvailable()
        {
            string runningVersion = Application.ProductVersion;
            string currentVersion = GetCurrentVersion();

            int running = int.Parse(runningVersion.Replace(".", ""));
            int current = int.Parse(currentVersion.Replace(".", ""));

            return current > running;
        }

        private string GetCurrentVersion()
        {
            return client.GetStringAsync("https://gist.githubusercontent.com/keallu/0c30083b18eae92b0be4702b4f157f34/raw/52e7c97dec9c75dcc02b7e6ba62aab47f76dd9cb/fmfileeditorcurrentversion.txt").Result;
        }
    }
}
