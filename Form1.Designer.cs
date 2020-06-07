namespace MagicUpdates
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.osn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winver = new System.Windows.Forms.Label();
            this.buildnum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updavail = new System.Windows.Forms.Label();
            this.yesdownloadbox = new System.Windows.Forms.GroupBox();
            this.msfturl = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.relid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kbid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.magicupdnot = new System.Windows.Forms.NotifyIcon(this.components);
            this.yesdownloadbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Operating System Information-";
            // 
            // osn
            // 
            this.osn.AutoSize = true;
            this.osn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.osn.Location = new System.Drawing.Point(34, 93);
            this.osn.Name = "osn";
            this.osn.Size = new System.Drawing.Size(233, 20);
            this.osn.TabIndex = 1;
            this.osn.Text = "Operating System Version NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Windows Version:";
            // 
            // winver
            // 
            this.winver.AutoSize = true;
            this.winver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.winver.Location = new System.Drawing.Point(184, 123);
            this.winver.Name = "winver";
            this.winver.Size = new System.Drawing.Size(32, 20);
            this.winver.TabIndex = 3;
            this.winver.Text = "NA";
            // 
            // buildnum
            // 
            this.buildnum.AutoSize = true;
            this.buildnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buildnum.Location = new System.Drawing.Point(184, 154);
            this.buildnum.Name = "buildnum";
            this.buildnum.Size = new System.Drawing.Size(32, 20);
            this.buildnum.TabIndex = 5;
            this.buildnum.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(34, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Build Number:";
            // 
            // updavail
            // 
            this.updavail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.updavail.ForeColor = System.Drawing.Color.Red;
            this.updavail.Location = new System.Drawing.Point(33, 197);
            this.updavail.Name = "updavail";
            this.updavail.Size = new System.Drawing.Size(806, 57);
            this.updavail.TabIndex = 6;
            this.updavail.Text = "MagicUpdates couldn\'t determine a suitable update for your OS and configuration.";
            this.updavail.Click += new System.EventHandler(this.label2_Click);
            // 
            // yesdownloadbox
            // 
            this.yesdownloadbox.Controls.Add(this.msfturl);
            this.yesdownloadbox.Controls.Add(this.label9);
            this.yesdownloadbox.Controls.Add(this.relid);
            this.yesdownloadbox.Controls.Add(this.label5);
            this.yesdownloadbox.Controls.Add(this.kbid);
            this.yesdownloadbox.Controls.Add(this.label7);
            this.yesdownloadbox.Location = new System.Drawing.Point(38, 265);
            this.yesdownloadbox.Name = "yesdownloadbox";
            this.yesdownloadbox.Size = new System.Drawing.Size(761, 215);
            this.yesdownloadbox.TabIndex = 7;
            this.yesdownloadbox.TabStop = false;
            // 
            // msfturl
            // 
            this.msfturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msfturl.Location = new System.Drawing.Point(268, 93);
            this.msfturl.Name = "msfturl";
            this.msfturl.Size = new System.Drawing.Size(474, 89);
            this.msfturl.TabIndex = 9;
            this.msfturl.TabStop = true;
            this.msfturl.Text = "NA";
            this.msfturl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.msfturl_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Download URL from Microsoft:";
            // 
            // relid
            // 
            this.relid.AutoSize = true;
            this.relid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.relid.ForeColor = System.Drawing.Color.Green;
            this.relid.Location = new System.Drawing.Point(267, 58);
            this.relid.Name = "relid";
            this.relid.Size = new System.Drawing.Size(32, 20);
            this.relid.TabIndex = 9;
            this.relid.Text = "NA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Release Date by Microsoft:";
            // 
            // kbid
            // 
            this.kbid.AutoSize = true;
            this.kbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kbid.ForeColor = System.Drawing.Color.Green;
            this.kbid.Location = new System.Drawing.Point(267, 27);
            this.kbid.Name = "kbid";
            this.kbid.Size = new System.Drawing.Size(32, 20);
            this.kbid.TabIndex = 7;
            this.kbid.Text = "NA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "KBID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "!";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(66, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(773, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "We recommend that you copy the link and use your browser/download manager for dow" +
    "nloading the update.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(66, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(773, 41);
            this.label8.TabIndex = 11;
            this.label8.Text = "When finished, install the update by double clicking on downloaded file.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "COPY DOWNLOAD LINK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Download and Install Automatically";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(763, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(38, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 2);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // magicupdnot
            // 
            this.magicupdnot.Icon = ((System.Drawing.Icon)(resources.GetObject("magicupdnot.Icon")));
            this.magicupdnot.Text = "Magic Updates";
            this.magicupdnot.Visible = true;
            this.magicupdnot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.magicupdnot_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(891, 662);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yesdownloadbox);
            this.Controls.Add(this.updavail);
            this.Controls.Add(this.buildnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.winver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.osn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.yesdownloadbox.ResumeLayout(false);
            this.yesdownloadbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label osn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label winver;
        private System.Windows.Forms.Label buildnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label updavail;
        private System.Windows.Forms.GroupBox yesdownloadbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label relid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label kbid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel msfturl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon magicupdnot;
    }
}

