using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MagicUpdates
{
    public partial class Form1 : Form
    {
        private string pkbid;
        private string purl;
        public Form1()
        {
            InitializeComponent();
            populatefields();
            TrayMenuContext();
        }
        private void TrayMenuContext()
        {
            this.magicupdnot.Text = "Magic Updates";
            this.magicupdnot.ContextMenu = new ContextMenu();
            this.magicupdnot.ContextMenu.MenuItems.Add(new MenuItem("Show", new EventHandler(showmenu)));
            this.magicupdnot.ContextMenu.MenuItems.Add(new MenuItem("Exit", new EventHandler(exitapp)));
        }
        private void showmenu(Object ob, EventArgs e)
        {
            this.Activate();
        }
        private void exitapp(Object ob, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void populatefields()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
                if (key!=null)
                {
                    Object osver = key.GetValue("ReleaseId");
                    Object osnm = key.GetValue("ProductName");
                    Object pbuildnum = key.GetValue("UBR");
                    Object cbuildnum = key.GetValue("CurrentBuildNumber");
                    string nbuildnum = cbuildnum.ToString() + "." + pbuildnum.ToString();
                    osn.Text = osnm.ToString();
                    winver.Text = osver.ToString();
                    buildnum.Text = nbuildnum;
                    JArray ja = JArray.Parse(universals.repodat);
                    int sze = ja.Count;
                    for (int i = 0; i < sze; i++)
                    {
                        string ext = (string)ja[i];
                        JObject jo = JObject.Parse(ext);
                        string osid = (string)jo["osid"];
                        string osverf = (string)jo["osver"];
                        string osvers = (string)jo["osversub"];
                        string kbidr = (string)jo["kbid"];
                        string ldat = (string)jo["msdat"];
                        string mslnk = (string)jo["mslnk"];
                        string arch = (string)jo["arch"];
                        Console.WriteLine(arch);
                        bool temp = false;
                        if (arch == "x86_64")
                            temp = true;
                        if (osver != null && osver.ToString() == osid && temp == universals.bit64)
                        {
                           if (osverf == (string)cbuildnum)
                            {
                                int rem = Int32.Parse(osvers);
                                int loc = Int32.Parse(pbuildnum.ToString());
                                if (loc< rem)
                                {
                                    updavail.Text = "MagicUpdates have fetched the following latest updates for your Windows";
                                    updavail.ForeColor = Color.Green;
                                    kbid.Text = kbidr;
                                    pkbid = kbidr;
                                    relid.Text = ldat;
                                    msfturl.Text = mslnk;
                                    purl = mslnk;
                                    yesdownloadbox.Visible = true;
                                    ctrlpanel.Visible = true;

                                }
                                else
                                {
                                    updavail.Text = "Your Windows is already up to date as per the update list of MagicUpdates";
                                    updavail.ForeColor = Color.Green;
                                    yesdownloadbox.Visible = false;
                                    ctrlpanel.Visible = false;
                                }

                            }
                           else
                            {
                                updavail.Text = "MagicUpdates cannot continue due to a Windows version mismatch!";
                                updavail.ForeColor = Color.Red;
                                yesdownloadbox.Visible = false;
                                ctrlpanel.Visible = false;
                            }
                        }
                    }


                    }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void msfturl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string lnk = msfturl.Text;
            System.Diagnostics.Process.Start(lnk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileTransfer ft = new FileTransfer(pkbid, purl);
            ft.Show();
        }

        private void magicupdnot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copied to Clipboard", "Magic Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(purl);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }
    }
}
