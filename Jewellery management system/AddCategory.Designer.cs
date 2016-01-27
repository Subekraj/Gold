namespace Jewellery_management_system
{
    partial class AddCategory
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
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddcategory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(144, 124);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(154, 20);
            this.txtcategoryname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catagory Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Category";
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Location = new System.Drawing.Point(179, 159);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(75, 23);
            this.btnaddcategory.TabIndex = 6;
            this.btnaddcategory.Text = "ADD";
            this.btnaddcategory.UseVisualStyleBackColor = true;
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddcategory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}