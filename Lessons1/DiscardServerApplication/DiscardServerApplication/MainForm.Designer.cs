namespace DiscardServerApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Clients");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Threads");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Memory");
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTreeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverStatus = new System.Windows.Forms.StatusStrip();
            this.clientListView = new System.Windows.Forms.ListView();
            this.clients = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.clientdata = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.diagramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.btnViewClients = new System.Windows.Forms.ToolStripButton();
            this.btnDiagram = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitterLeft = new System.Windows.Forms.Splitter();
            this.panelData = new System.Windows.Forms.Panel();
            this.splitterRight = new System.Windows.Forms.Splitter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.paramListView = new System.Windows.Forms.ListView();
            this.paramColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.valueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewMenuItem,
            this.toolsMenuItem,
            this.helpMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(888, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.disconnectMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientTreeMenuItem,
            this.statusMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewMenuItem.Text = "View";
            // 
            // clientTreeMenuItem
            // 
            this.clientTreeMenuItem.Checked = true;
            this.clientTreeMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientTreeMenuItem.Name = "clientTreeMenuItem";
            this.clientTreeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientTreeMenuItem.Text = "Client Tree";
            this.clientTreeMenuItem.Click += new System.EventHandler(this.clientTreeMenuItem_Click);
            // 
            // statusMenuItem
            // 
            this.statusMenuItem.Checked = true;
            this.statusMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusMenuItem.Name = "statusMenuItem";
            this.statusMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusMenuItem.Text = "Status Bar";
            this.statusMenuItem.Click += new System.EventHandler(this.statusMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // serverStatus
            // 
            this.serverStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.serverStatus.Location = new System.Drawing.Point(0, 565);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(888, 22);
            this.serverStatus.TabIndex = 1;
            this.serverStatus.Text = "statusStrip1";
            // 
            // clientListView
            // 
            this.clientListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clients,
            this.status});
            this.clientListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientListView.GridLines = true;
            this.clientListView.Location = new System.Drawing.Point(0, 0);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(283, 516);
            this.clientListView.TabIndex = 3;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.View = System.Windows.Forms.View.Details;
            // 
            // clients
            // 
            this.clients.Text = "clients";
            this.clients.Width = 144;
            // 
            // status
            // 
            this.status.Text = "status";
            this.status.Width = 131;
            // 
            // clientdata
            // 
            this.clientdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientdata.Location = new System.Drawing.Point(0, 0);
            this.clientdata.Name = "clientdata";
            this.clientdata.Size = new System.Drawing.Size(393, 514);
            this.clientdata.TabIndex = 4;
            this.clientdata.Text = "";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnDisconnect,
            this.toolStripSeparator2,
            this.btnViewClients,
            this.toolStripSeparator3,
            this.btnDiagram,
            this.btnOptions,
            this.btnAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(888, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // diagramsToolStripMenuItem
            // 
            this.diagramsToolStripMenuItem.Name = "diagramsToolStripMenuItem";
            this.diagramsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.diagramsToolStripMenuItem.Text = "Diagrams";
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect.Image = global::DiscardServerApplication.Properties.Resources.plus;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(23, 22);
            this.btnConnect.Text = "Connect";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDisconnect.Image = global::DiscardServerApplication.Properties.Resources.minus;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(23, 22);
            this.btnDisconnect.Text = "Disconnect";
            // 
            // btnViewClients
            // 
            this.btnViewClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewClients.Image = global::DiscardServerApplication.Properties.Resources.tree24;
            this.btnViewClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(23, 22);
            this.btnViewClients.Text = "View Client Tree";
            this.btnViewClients.Click += new System.EventHandler(this.clientTreeMenuItem_Click);
            // 
            // btnDiagram
            // 
            this.btnDiagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDiagram.Image = global::DiscardServerApplication.Properties.Resources.graph_bar16;
            this.btnDiagram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiagram.Name = "btnDiagram";
            this.btnDiagram.Size = new System.Drawing.Size(23, 22);
            this.btnDiagram.Text = "Diagrams";
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = global::DiscardServerApplication.Properties.Resources.views24;
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 22);
            this.btnOptions.Text = "Options";
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = global::DiscardServerApplication.Properties.Resources.help;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "About";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Image = global::DiscardServerApplication.Properties.Resources.plus;
            this.connectMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(137, 22);
            this.connectMenuItem.Text = "Connect";
            // 
            // disconnectMenuItem
            // 
            this.disconnectMenuItem.Image = global::DiscardServerApplication.Properties.Resources.minus;
            this.disconnectMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disconnectMenuItem.Name = "disconnectMenuItem";
            this.disconnectMenuItem.Size = new System.Drawing.Size(137, 22);
            this.disconnectMenuItem.Text = "Disconnect";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::DiscardServerApplication.Properties.Resources.exit;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelData);
            this.panelMain.Controls.Add(this.splitterLeft);
            this.panelMain.Controls.Add(this.clientListView);
            this.panelMain.Controls.Add(this.splitterRight);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(888, 516);
            this.panelMain.TabIndex = 7;
            // 
            // splitterLeft
            // 
            this.splitterLeft.Location = new System.Drawing.Point(283, 0);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(5, 516);
            this.splitterLeft.TabIndex = 7;
            this.splitterLeft.TabStop = false;
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.clientdata);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(288, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(395, 516);
            this.panelData.TabIndex = 8;
            // 
            // splitterRight
            // 
            this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight.Location = new System.Drawing.Point(683, 0);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(5, 516);
            this.splitterRight.TabIndex = 9;
            this.splitterRight.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 516);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.paramListView);
            this.panelRight.Controls.Add(this.pictureBox);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(688, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 516);
            this.panelRight.TabIndex = 10;
            // 
            // paramListView
            // 
            this.paramListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paramListView.CheckBoxes = true;
            this.paramListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paramColumnHeader,
            this.valueColumnHeader});
            this.paramListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paramListView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.paramListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.paramListView.Location = new System.Drawing.Point(0, 288);
            this.paramListView.Name = "paramListView";
            this.paramListView.Size = new System.Drawing.Size(200, 228);
            this.paramListView.TabIndex = 11;
            this.paramListView.UseCompatibleStateImageBehavior = false;
            this.paramListView.View = System.Windows.Forms.View.Details;
            // 
            // paramColumnHeader
            // 
            this.paramColumnHeader.Text = "Parameters";
            this.paramColumnHeader.Width = 100;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 587);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.serverStatus);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "DiscardServer";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientTreeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMenuItem;
        private System.Windows.Forms.StatusStrip serverStatus;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.ColumnHeader clients;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.RichTextBox clientdata;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripButton btnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnViewClients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripMenuItem diagramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnDiagram;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Splitter splitterLeft;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Splitter splitterRight;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView paramListView;
        private System.Windows.Forms.ColumnHeader paramColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
    }
}

