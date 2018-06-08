namespace eLuno
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectHTMLDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSiteToolStripMenuItem,
            this.displayPageToolStripMenuItem,
            this.selectHTMLDocToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadSiteToolStripMenuItem
            // 
            this.loadSiteToolStripMenuItem.Name = "loadSiteToolStripMenuItem";
            this.loadSiteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.loadSiteToolStripMenuItem.Text = "Load Site";
            this.loadSiteToolStripMenuItem.Click += new System.EventHandler(this.loadSiteToolStripMenuItem_Click);
            // 
            // displayPageToolStripMenuItem
            // 
            this.displayPageToolStripMenuItem.Name = "displayPageToolStripMenuItem";
            this.displayPageToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.displayPageToolStripMenuItem.Text = "Display Page";
            this.displayPageToolStripMenuItem.Click += new System.EventHandler(this.displayPageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectHTMLDocToolStripMenuItem
            // 
            this.selectHTMLDocToolStripMenuItem.Name = "selectHTMLDocToolStripMenuItem";
            this.selectHTMLDocToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.selectHTMLDocToolStripMenuItem.Text = "Select HTML Doc";
            this.selectHTMLDocToolStripMenuItem.Click += new System.EventHandler(this.selectHTMLDocToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 529);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectHTMLDocToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

