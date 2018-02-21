using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FW_SteamGameHosterThing
{
    public partial class Main : Form
    {
        private ServerConfigManager _configmanager;
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
            _configmanager = new ServerConfigManager();
        }

        void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Check if servers are actually running
            if (MessageBox.Show("Running servers will be closed!", "Are you sure you want to exit?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newpage = new TabPage("New Server Instance");
            newpage.Controls.Add(new GameserverControlPanel() { Dock = DockStyle.Fill });

            tabControl1.TabPages.Add(newpage);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: implement loading tabs
        }
    }
}
