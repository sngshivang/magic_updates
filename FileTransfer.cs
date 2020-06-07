
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicUpdates
{
    public partial class FileTransfer : Form
    {
        private string univurl = null;
        private WebClient wc;
        private Uri SomeBaseUri = new Uri("http://blankurl");
        public FileTransfer()
        {
            InitializeComponent();
        }
        public FileTransfer(string kbid, string url)
        {
            InitializeComponent();
            univurl = url;
            //Console.WriteLine(inp);
            label3.Text = kbid;
            downloadFile(url);
        }

        private void downloadFile(string url)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string crp = Path.Combine(desktopPath, "Magic_Updates");
            Directory.CreateDirectory(crp);
            Console.WriteLine(desktopPath);
            // This will download a large image from the web, you can change the value
            // i.e a textbox : textBox1.Text
            string filename = GetFileNameFromUrl(url);
            Console.WriteLine(filename);
            using (wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(url), crp + "/" + filename);
            }
        }

        private string getFilename(string url)
        {
            throw new NotImplementedException();
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // In case you don't have a progressBar Log the value instead 
            // Console.WriteLine(e.ProgressPercentage);
            double bytesIn = Math.Round(((double.Parse(e.BytesReceived.ToString()))/1024)/1024, 2);
            currdata.Text = Convert.ToString(bytesIn) + " MB";

            double totalBytes = Math.Round
                (((double.Parse(e.TotalBytesToReceive.ToString()))/1024)/1024,2); 
            totdata.Text = "/" + Convert.ToString(totalBytes) + " MB";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wc.CancelAsync();
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            if (e.Cancelled)
            {
                DialogResult dr = MessageBox.Show("The downlaod has been cancelled by the user.", "Download Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
                return;
            }

            else if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                DialogResult dr = MessageBox.Show("An error has occurred while attempting to download the update. Please try again.", "Download failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("This update has successfully been downloaded. Do you want Magic Updates to install the app itself?", "Download successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string crp = Path.Combine(desktopPath, "Magic_Updates"); ;
                    Console.WriteLine(desktopPath);
                    string fln = GetFileNameFromUrl(univurl);
                    if (fln!=null)
                    {
                        System.Diagnostics.Process.Start(crp + "/" + fln);
                    }
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        private string GetFileNameFromUrl(string url)
        {
            Uri uri;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri))
                uri = new Uri(SomeBaseUri, url);

            return Path.GetFileName(uri.LocalPath);
        }
    }
}
