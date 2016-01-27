namespace Jewellery_management_system
{
    partial class purchase_order_booking
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
            this.dtp_pod_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_new_pod_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_existing_pod_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_supplier_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_item_name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_pob = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.calpobdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calsupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calnewpodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calexpodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Order Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Order Date:";
            // 
            // dtp_pod_date
            // 
            this.dtp_pod_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_pod_date.Location = new System.Drawing.Point(143, 64);
            this.dtp_pod_date.Name = "dtp_pod_date";
            this.dtp_pod_date.Size = new System.Drawing.Size(99, 20);
            this.dtp_pod_date.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New PoD Id:";
            // 
            // txt_new_pod_id
            // 
            this.txt_new_pod_id.Location = new System.Drawing.Point(337, 70);
            this.txt_new_pod_id.Name = "txt_new_pod_id";
            this.txt_new_pod_id.Size = new System.Drawing.Size(100, 20);
            this.txt_new_pod_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existing PoD Id:";
            // 
            // txt_existing_pod_id
            // 
            this.txt_existing_pod_id.Location = new System.Drawing.Point(545, 70);
            this.txt_existing_pod_id.Name = "txt_existing_pod_id";
            this.txt_existing_pod_id.Size = new System.Drawing.Size(100, 20);
            this.txt_existing_pod_id.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Supplier\'s Name:";
            // 
            // cbo_supplier_name
            // 
            this.cbo_supplier_name.FormattingEnabled = true;
            this.cbo_supplier_name.Location = new System.Drawing.Point(127, 98);
            this.cbo_supplier_name.Name = "cbo_supplier_name";
            this.cbo_supplier_name.Size = new System.Drawing.Size(518, 21);
            this.cbo_supplier_name.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item Name:";
            // 
            // cbo_item_name
            // 
            this.cbo_item_name.FormattingEnabled = true;
            this.cbo_item_name.Location = new System.Drawing.Point(127, 125);
            this.cbo_item_name.Name = "cbo_item_name";
            this.cbo_item_name.Size = new System.Drawing.Size(518, 21);
            this.cbo_item_name.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(127, 157);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(545, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_pob
            // 
            this.dgv_pob.AllowUserToAddRows = false;
            this.dgv_pob.AllowUserToDeleteRows = false;
            this.dgv_pob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_pob.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_pob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calpobdate,
            this.calsupplier,
            this.calitemname,
            this.calquantity,
            this.calnewpodid,
            this.calexpodid});
            this.dgv_pob.Location = new System.Drawing.Point(41, 183);
            this.dgv_pob.Name = "dgv_pob";
            this.dgv_pob.ReadOnly = true;
            this.dgv_pob.Size = new System.Drawing.Size(604, 138);
            this.dgv_pob.TabIndex = 9;
            this.dgv_pob.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_pob_RowHeaderMouseDoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(384, 345);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(465, 344);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(546, 345);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(41, 327);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(113, 44);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print Purchase Order";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // calpobdate
            // 
            this.calpobdate.FillWeight = 9.459274F;
            this.calpobdate.HeaderText = "Purchase Order Date";
            this.calpobdate.Name = "calpobdate";
            this.calpobdate.ReadOnly = true;
            this.calpobdate.ToolTipText = "Date of Purchse Order";
            // 
            // calsupplier
            // 
            this.calsupplier.FillWeight = 16.84628F;
            this.calsupplier.HeaderText = "Supplier\'s Name";
            this.calsupplier.Name = "calsupplier";
            this.calsupplier.ReadOnly = true;
            this.calsupplier.ToolTipText = "Name of the Supplier";
            this.calsupplier.Width = 99;
            // 
            // calitemname
            // 
            this.calitemname.FillWeight = 62.31773F;
            this.calitemname.HeaderText = "Item Name";
            this.calitemname.Name = "calitemname";
            this.calitemname.ReadOnly = true;
            this.calitemname.ToolTipText = "Item Name";
            this.calitemname.Width = 77;
            // 
            // calquantity
            // 
            this.calquantity.FillWeight = 124.198F;
            this.calquantity.HeaderText = "Quantity";
            this.calquantity.Name = "calquantity";
            this.calquantity.ReadOnly = true;
            this.calquantity.ToolTipText = "No of Quantity";
            this.calquantity.Width = 71;
            // 
            // calnewpodid
            // 
            this.calnewpodid.HeaderText = "New POB  Id";
            this.calnewpodid.Name = "calnewpodid";
            this.calnewpodid.ReadOnly = true;
            this.calnewpodid.Visible = false;
            this.calnewpodid.Width = 78;
            // 
            // calexpodid
            // 
            this.calexpodid.HeaderText = "Existiing POB ID";
            this.calexpodid.Name = "calexpodid";
            this.calexpodid.ReadOnly = true;
            this.calexpodid.Visible = false;
            this.calexpodid.Width = 90;
            // 
            // purchase_order_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 383);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_pob);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_item_name);
            this.Controls.Add(this.cbo_supplier_name);
            this.Controls.Add(this.txt_existing_pod_id);
            this.Controls.Add(this.txt_new_pod_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_pod_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "purchase_order_booking";
            this.Text = "purchase_order_booking";
            this.Load += new System.EventHandler(this.purchase_order_booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_pod_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_new_pod_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_existing_pod_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_supplier_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_item_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_pob;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpobdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn calitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn calnewpodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calexpodid;
    }
}