using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiscardServerApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();

            about.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions options = new FormOptions();

            options.Show();
        }

        private void clientTreeMenuItem_Click(object sender, EventArgs e)
        {
            clientTreeMenuItem.Checked = !clientTreeMenuItem.Checked;

            clientListView.Visible = clientTreeMenuItem.Checked;
        }

        private void statusMenuItem_Click(object sender, EventArgs e)
        {
            statusMenuItem.Checked = !statusMenuItem.Checked;

            serverStatus.Visible = statusMenuItem.Checked;
        }
    }
}
