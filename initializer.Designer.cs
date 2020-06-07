namespace MagicUpdates
{
    partial class initializer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initializer));
            this.label1 = new System.Windows.Forms.Label();
            this.inistat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait while we determine the compatibility of your system with MagicUpdates" +
    "...";
            // 
            // inistat
            // 
            this.inistat.AutoSize = true;
            this.inistat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inistat.Location = new System.Drawing.Point(22, 124);
            this.inistat.Name = "inistat";
            this.inistat.Size = new System.Drawing.Size(296, 20);
            this.inistat.TabIndex = 2;
            this.inistat.Text = "CURRENT STATUS NOT AVAILABLE";
            // 
            // initializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.inistat);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "initializer";
            this.Text = "Magic Updates :: Initializing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inistat;
    }
}