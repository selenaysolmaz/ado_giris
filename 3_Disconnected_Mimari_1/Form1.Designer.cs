namespace _3_Disconnected_Mimari_1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCategories = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(66, 45);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(72, 20);
            this.tbProductName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProductID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudUnitsInStock);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.nudUnitPrice);
            this.groupBox1.Controls.Add(this.btnCategories);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // nudUnitsInStock
            // 
            this.nudUnitsInStock.Location = new System.Drawing.Point(226, 46);
            this.nudUnitsInStock.Name = "nudUnitsInStock";
            this.nudUnitsInStock.Size = new System.Drawing.Size(71, 20);
            this.nudUnitsInStock.TabIndex = 9;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(149, 46);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(71, 20);
            this.nudUnitPrice.TabIndex = 8;
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(366, 19);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(73, 29);
            this.btnCategories.TabIndex = 7;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Units In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Price";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 92);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(576, 190);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProducts);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(445, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(55, 29);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(6, 45);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(54, 20);
            this.tbProductID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(86, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 308);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudUnitsInStock;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

