namespace FW_SteamGameHosterThing
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton_Views = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_Views_ServerInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_Settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveOpenTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSavedTabsresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(844, 853);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(844, 878);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_Views,
            this.toolStripDropDownButton_Settings});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(155, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton_Views
            // 
            this.toolStripDropDownButton_Views.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Views.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Views_ServerInstance});
            this.toolStripDropDownButton_Views.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Views.Image")));
            this.toolStripDropDownButton_Views.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Views.Name = "toolStripDropDownButton_Views";
            this.toolStripDropDownButton_Views.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownButton_Views.Text = "Views";
            // 
            // toolStripMenuItem_Views_ServerInstance
            // 
            this.toolStripMenuItem_Views_ServerInstance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.toolStripMenuItem_Views_ServerInstance.Name = "toolStripMenuItem_Views_ServerInstance";
            this.toolStripMenuItem_Views_ServerInstance.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem_Views_ServerInstance.Text = "Server Instance";
            // 
            // toolStripDropDownButton_Settings
            // 
            this.toolStripDropDownButton_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOpenTabsToolStripMenuItem,
            this.loadSavedTabsresetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton_Settings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Settings.Image")));
            this.toolStripDropDownButton_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Settings.Name = "toolStripDropDownButton_Settings";
            this.toolStripDropDownButton_Settings.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton_Settings.Text = "Settings";
            // 
            // saveOpenTabsToolStripMenuItem
            // 
            this.saveOpenTabsToolStripMenuItem.Name = "saveOpenTabsToolStripMenuItem";
            this.saveOpenTabsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveOpenTabsToolStripMenuItem.Text = "Save open tabs";
            // 
            // loadSavedTabsresetToolStripMenuItem
            // 
            this.loadSavedTabsresetToolStripMenuItem.Name = "loadSavedTabsresetToolStripMenuItem";
            this.loadSavedTabsresetToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadSavedTabsresetToolStripMenuItem.Text = "Load saved tabs (reset)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 878);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Main";
            this.Text = "FW-SGHT v0.1 Bogus";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Views;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Views_ServerInstance;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Settings;
        private System.Windows.Forms.ToolStripMenuItem saveOpenTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSavedTabsresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;


    }
}

