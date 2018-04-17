using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300960704_DaSilva_ASS07
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private async void DownloadPagesButton_Click(object sender, EventArgs e)
        {
            StatusTextBox.Text = "";
            await DownloadPages(new List<string>()
            {
                "http://www.globo.com",
                "http://www.uol.com.br",
                "http://www.centennialcollege.ca",
                "https://docs.microsoft.com",
                "https://www.xbox.com",
                "https://github.com/",
                "http://www.ttc.ca/",
                "https://www.google.ca/",
                "https://www.apple.com/ca/",
                "https://www.youtube.com/",
                "https://www.facebook.com/",
                "https://unity.com/madewith",
                "https://www.unrealengine.com/en-US/blog",
            });
            MessageBox.Show("All pages downloaded successfully!", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
        private Task DownloadPages(List<string> pageList)
        {
            return Task.WhenAll(pageList.Select(page => DownloadPage(page)));
        }

        private async Task DownloadPage(string page)
        {
            DateTime startTime = DateTime.Now;
            StatusTextBox.Text += "Downloading from: " + page + "\r\n";
            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync(page);
            DateTime endTime = DateTime.Now;
            double elapsedMillisecs = ((TimeSpan)(endTime - startTime)).TotalMilliseconds;
            StatusTextBox.Text += string.Format("Finished from: {0} in {1} ms\r\n", page, elapsedMillisecs.ToString("F2"));
        }
    }
}
