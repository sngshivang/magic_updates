using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace MagicUpdates
{
    public partial class initializer : Form
    {
        private Object osver,cbuildnum;
        public initializer()
        {
            InitializeComponent();
            startcompcheck();
        }
        private void startcompcheck()
        {
            try
            {
                bool errortrip = false;
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
                if (key != null)
                {
                    osver = key.GetValue("ReleaseId");
                    Object osnm = key.GetValue("ProductName");
                    cbuildnum = key.GetValue("CurrentBuildNumber");
                    Object buildnum = key.GetValue("UBR");
                    Console.WriteLine(buildnum.ToString());
                    if (osver != null)
                    {
                        Dictionary<string, string> dct = new Dictionary<string, string> { { "typ", "1" } };
                        network nt = new network();
                        nt.it = this;
                        inistat.Text = "Connecting to the Servers...";
                        nt.internetAsync_rst(1, dct);

                    }
                    else
                        errortrip = true;

                }
                else
                    errortrip = true;
                if (errortrip)
                {

                    DialogResult dr = MessageBox.Show("This app cannot run on this operating system due to a technical error.", "Unsupported Operating System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void retcall(int opt, string resp)
        {
            if (opt == 1)
            {
                if (resp != "ERR") { 
                bool trip = false;
                universals.repodat = resp;
                JArray ja = JArray.Parse(resp);
                int sze = ja.Count;
                for (int i = 0; i < sze; i++)
                {
                    string ext = (string)ja[i];
                    JObject jo = JObject.Parse(ext);
                    string oover = (string)jo["osver"];
                    string arch = (string)jo["arch"];
                    if (Environment.Is64BitOperatingSystem)
                        universals.bit64 = true;
                    if (osver != null && cbuildnum.ToString() == oover)
                    {
                        if ((universals.bit64 == true && arch == "x86_64") || (universals.bit64 == false && arch == "x86"))
                            trip = true;
                        break;
                    }
                }
                if (trip)
                {
                    this.Hide();
                    inistat.Text = "SIGNATURE MATCHED!";
                    Form1 fm = new Form1();
                    fm.Text = "Magic Updates";
                    fm.Closed += (s, args) => this.Close();
                    fm.Show();
                }

                else
                {

                    DialogResult dr = MessageBox.Show("This version of Windows is not supported by this application. MagicUpdates will exit now", "Unsupported Operating System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }

                }
            }
                else
                {
                    DialogResult dr = MessageBox.Show("Magic Updates was unable to reach it's servers. Please try again or file a bug report.", "Failed to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
        }
        }
    }
}
