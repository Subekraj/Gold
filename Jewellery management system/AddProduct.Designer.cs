namespace Jewellery_management_system
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.btnadditem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edititem = new System.Windows.Forms.Label();
            this.txtedititem = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item name";
            // 
            // cbocategory
            // 
            this.cbocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(129, 62);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(160, 21);
            this.cbocategory.TabIndex = 4;
            // 
            // btnadditem
            // 
            this.btnadditem.Location = new System.Drawing.Point(133, 174);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(75, 23);
            this.btnadditem.TabIndex = 5;
            this.btnadditem.Text = "Add";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 164);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick_1);
            // 
            // edititem
            // 
            this.edititem.AutoSize = true;
            this.edititem.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edititem.Location = new System.Drawing.Point(76, 6);
            this.edititem.Name = "edititem";
            this.edititem.Size = new System.Drawing.Size(160, 39);
            this.edititem.TabIndex = 7;
            this.edititem.Text = "Edit Item";
            // 
            // txtedititem
            // 
            this.txtedititem.Location = new System.Drawing.Point(129, 97);
            this.txtedititem.Name = "txtedititem";
            this.txtedititem.Size = new System.Drawing.Size(160, 20);
            this.txtedititem.TabIndex = 20;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(214, 174);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 21;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item Code";
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(130, 131);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(156, 20);
            this.txtitemcode.TabIndex = 23;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 396);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtedititem);
            this.Controls.Add(this.edititem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label edititem;
        private System.Windows.Forms.TextBox txtedititem;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtitemcode;
    }
}