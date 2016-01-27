namespace Jewellery_management_system
{
    partial class EditCategory
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
            this.btneditcategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txteditcategoryname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Category";
            // 
            // btneditcategory
            // 
            this.btneditcategory.Location = new System.Drawing.Point(127, 99);
            this.btneditcategory.Name = "btneditcategory";
            this.btneditcategory.Size = new System.Drawing.Size(75, 23);
            this.btneditcategory.TabIndex = 1;
            this.btneditcategory.Text = "Update";
            this.btneditcategory.UseVisualStyleBackColor = true;
            this.btneditcategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Name";
            // 
            // txteditcategoryname
            // 
            this.txteditcategoryname.Location = new System.Drawing.Point(111, 64);
            this.txteditcategoryname.Name = "txteditcategoryname";
            this.txteditcategoryname.Size = new System.Drawing.Size(131, 20);
            this.txteditcategoryname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txteditcategoryname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneditcategory);
            this.Controls.Add(this.label1);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditcategory;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txteditcategoryname;
        public System.Windows.Forms.Label label3;
    }
}