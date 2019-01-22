namespace _3_Disconnected_Mimari_1
{
    partial class Categories
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
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCategoriesName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(38, 76);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(100, 20);
            this.txtCatName.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(222, 76);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(479, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCategoriesName
            // 
            this.lblCategoriesName.AutoSize = true;
            this.lblCategoriesName.Location = new System.Drawing.Point(35, 30);
            this.lblCategoriesName.Name = "lblCategoriesName";
            this.lblCategoriesName.Size = new System.Drawing.Size(88, 13);
            this.lblCategoriesName.TabIndex = 2;
            this.lblCategoriesName.Text = "Categories Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(219, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategoriesName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCatName);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCategoriesName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}