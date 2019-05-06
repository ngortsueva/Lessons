namespace AutoLotForm2
{
    partial class FormMain
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
            this.gridInventory = new System.Windows.Forms.DataGridView();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonGetOrder = new System.Windows.Forms.Button();
            this.textCustId = new System.Windows.Forms.TextBox();
            this.labelCustId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInventory
            // 
            this.gridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventory.Location = new System.Drawing.Point(12, 12);
            this.gridInventory.Name = "gridInventory";
            this.gridInventory.Size = new System.Drawing.Size(694, 150);
            this.gridInventory.TabIndex = 0;
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(12, 168);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(694, 150);
            this.gridCustomers.TabIndex = 1;
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(12, 324);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(694, 150);
            this.gridOrders.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(631, 489);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonGetOrder
            // 
            this.buttonGetOrder.Location = new System.Drawing.Point(213, 482);
            this.buttonGetOrder.Name = "buttonGetOrder";
            this.buttonGetOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonGetOrder.TabIndex = 4;
            this.buttonGetOrder.Text = "Get Order";
            this.buttonGetOrder.UseVisualStyleBackColor = true;
            this.buttonGetOrder.Click += new System.EventHandler(this.buttonGetOrder_Click);
            // 
            // textCustId
            // 
            this.textCustId.Location = new System.Drawing.Point(107, 484);
            this.textCustId.Name = "textCustId";
            this.textCustId.Size = new System.Drawing.Size(100, 20);
            this.textCustId.TabIndex = 5;
            // 
            // labelCustId
            // 
            this.labelCustId.AutoSize = true;
            this.labelCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustId.Location = new System.Drawing.Point(12, 485);
            this.labelCustId.Name = "labelCustId";
            this.labelCustId.Size = new System.Drawing.Size(89, 17);
            this.labelCustId.TabIndex = 6;
            this.labelCustId.Text = "Customer ID:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 561);
            this.Controls.Add(this.labelCustId);
            this.Controls.Add(this.textCustId);
            this.Controls.Add(this.buttonGetOrder);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.gridInventory);
            this.Name = "FormMain";
            this.Text = "AutoLot Database";
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInventory;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonGetOrder;
        private System.Windows.Forms.TextBox textCustId;
        private System.Windows.Forms.Label labelCustId;
    }
}

