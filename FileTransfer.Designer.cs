namespace MagicUpdates
{
    partial class FileTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTransfer));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.currdata = new System.Windows.Forms.Label();
            this.totdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloading updates from Microsoft Update Catalog. Please wait...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(749, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Downloading Update: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(212, 63);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(282, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "FileName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currdata
            // 
            this.currdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currdata.Location = new System.Drawing.Point(13, 156);
            this.currdata.Name = "currdata";
            this.currdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currdata.Size = new System.Drawing.Size(82, 33);
            this.currdata.TabIndex = 7;
            this.currdata.Text = "X MB";
            // 
            // totdata
            // 
            this.totdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totdata.Location = new System.Drawing.Point(107, 156);
            this.totdata.Name = "totdata";
            this.totdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totdata.Size = new System.Drawing.Size(107, 33);
            this.totdata.TabIndex = 8;
            this.totdata.Text = "/ Y MB";
            // 
            // FileTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.totdata);
            this.Controls.Add(this.currdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileTransfer";
            this.Text = "Dowloading Updates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label currdata;
        private System.Windows.Forms.Label totdata;
    }
}