namespace AutoLotForm
{
    partial class MainForm
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
            this.carInventory = new System.Windows.Forms.DataGridView();
            this.labelCarID = new System.Windows.Forms.Label();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelMake = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.buttonChangeMake = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.carInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carInventory
            // 
            this.carInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carInventory.Location = new System.Drawing.Point(0, 0);
            this.carInventory.Name = "carInventory";
            this.carInventory.Size = new System.Drawing.Size(649, 239);
            this.carInventory.TabIndex = 0;
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarID.Location = new System.Drawing.Point(9, 23);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(51, 17);
            this.labelCarID.TabIndex = 1;
            this.labelCarID.Text = "Car ID:";
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(154, 21);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCar.TabIndex = 2;
            this.buttonDeleteCar.Text = "Delete";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.Location = new System.Drawing.Point(71, 23);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.Size = new System.Drawing.Size(77, 20);
            this.textBoxCarID.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(154, 19);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMake.Location = new System.Drawing.Point(14, 19);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(46, 17);
            this.labelMake.TabIndex = 5;
            this.labelMake.Text = "Make:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelChange);
            this.groupBox1.Controls.Add(this.buttonChangeMake);
            this.groupBox1.Controls.Add(this.textBoxChange);
            this.groupBox1.Controls.Add(this.textBoxMake);
            this.groupBox1.Controls.Add(this.buttonFilter);
            this.groupBox1.Controls.Add(this.labelMake);
            this.groupBox1.Location = new System.Drawing.Point(655, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(71, 21);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(77, 20);
            this.textBoxMake.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCarID);
            this.groupBox2.Controls.Add(this.labelCarID);
            this.groupBox2.Controls.Add(this.buttonDeleteCar);
            this.groupBox2.Location = new System.Drawing.Point(655, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(71, 56);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(77, 20);
            this.textBoxChange.TabIndex = 7;
            // 
            // buttonChangeMake
            // 
            this.buttonChangeMake.Location = new System.Drawing.Point(154, 54);
            this.buttonChangeMake.Name = "buttonChangeMake";
            this.buttonChangeMake.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeMake.TabIndex = 8;
            this.buttonChangeMake.Text = "Change";
            this.buttonChangeMake.UseVisualStyleBackColor = true;
            this.buttonChangeMake.Click += new System.EventHandler(this.buttonChangeMake_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChange.Location = new System.Drawing.Point(6, 56);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(61, 17);
            this.labelChange.TabIndex = 9;
            this.labelChange.Text = "Change:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 269);
            this.dataGridView1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carInventory);
            this.Name = "MainForm";
            this.Text = "AutoLot Database";
            ((System.ComponentModel.ISupportInitialize)(this.carInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carInventory;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.TextBox textBoxCarID;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button buttonChangeMake;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

