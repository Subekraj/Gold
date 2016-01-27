namespace Jewellery_management_system
{
    partial class point_reedem_details
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
            this.txt_point_reedem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_gift = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_redeem = new System.Windows.Forms.ComboBox();
            this.cbo_customer = new System.Windows.Forms.ComboBox();
            this.dgv_redeem = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.calcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calredeemdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calredeempoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calgift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calredeemmode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_redeem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(58, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details of Point Reedem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reedem Point:";
            // 
            // txt_point_reedem
            // 
            this.txt_point_reedem.Location = new System.Drawing.Point(111, 92);
            this.txt_point_reedem.Name = "txt_point_reedem";
            this.txt_point_reedem.Size = new System.Drawing.Size(79, 20);
            this.txt_point_reedem.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(233, 92);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(96, 20);
            this.dtp_date.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gifts:";
            // 
            // cbo_gift
            // 
            this.cbo_gift.FormattingEnabled = true;
            this.cbo_gift.Items.AddRange(new object[] {
            "gifts 1 ",
            "gifts 2",
            "gifts 3",
            "gifts 4"});
            this.cbo_gift.Location = new System.Drawing.Point(372, 91);
            this.cbo_gift.Name = "cbo_gift";
            this.cbo_gift.Size = new System.Drawing.Size(116, 21);
            this.cbo_gift.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Redeem";
            // 
            // cbo_redeem
            // 
            this.cbo_redeem.FormattingEnabled = true;
            this.cbo_redeem.Items.AddRange(new object[] {
            "redeem mode 1",
            "redeem mode 2",
            "redeem mode 3"});
            this.cbo_redeem.Location = new System.Drawing.Point(571, 89);
            this.cbo_redeem.Name = "cbo_redeem";
            this.cbo_redeem.Size = new System.Drawing.Size(116, 21);
            this.cbo_redeem.TabIndex = 4;
            // 
            // cbo_customer
            // 
            this.cbo_customer.FormattingEnabled = true;
            this.cbo_customer.Location = new System.Drawing.Point(116, 60);
            this.cbo_customer.Name = "cbo_customer";
            this.cbo_customer.Size = new System.Drawing.Size(571, 21);
            this.cbo_customer.TabIndex = 5;
            // 
            // dgv_redeem
            // 
            this.dgv_redeem.AllowUserToAddRows = false;
            this.dgv_redeem.AllowUserToDeleteRows = false;
            this.dgv_redeem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_redeem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_redeem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calcustomer,
            this.calredeemdate,
            this.calredeempoint,
            this.calgift,
            this.calredeemmode});
            this.dgv_redeem.Location = new System.Drawing.Point(62, 145);
            this.dgv_redeem.Name = "dgv_redeem";
            this.dgv_redeem.ReadOnly = true;
            this.dgv_redeem.Size = new System.Drawing.Size(625, 150);
            this.dgv_redeem.TabIndex = 6;
            this.dgv_redeem.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_redeem_RowHeaderMouseDoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(372, 311);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 28);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(467, 311);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(89, 28);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(562, 311);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 28);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // calcustomer
            // 
            this.calcustomer.HeaderText = "Customer";
            this.calcustomer.Name = "calcustomer";
            this.calcustomer.ReadOnly = true;
            // 
            // calredeemdate
            // 
            this.calredeemdate.HeaderText = "Redeem Date";
            this.calredeemdate.Name = "calredeemdate";
            this.calredeemdate.ReadOnly = true;
            // 
            // calredeempoint
            // 
            this.calredeempoint.HeaderText = "Redeem Point";
            this.calredeempoint.Name = "calredeempoint";
            this.calredeempoint.ReadOnly = true;
            // 
            // calgift
            // 
            this.calgift.HeaderText = "Gift";
            this.calgift.Name = "calgift";
            this.calgift.ReadOnly = true;
            // 
            // calredeemmode
            // 
            this.calredeemmode.HeaderText = "Redeem Mode";
            this.calredeemmode.Name = "calredeemmode";
            this.calredeemmode.ReadOnly = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(571, 116);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Redeem Point";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // point_reedem_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_redeem);
            this.Controls.Add(this.cbo_customer);
            this.Controls.Add(this.cbo_redeem);
            this.Controls.Add(this.cbo_gift);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_point_reedem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "point_reedem_details";
            this.Text = "point_reedem";
            this.Load += new System.EventHandler(this.point_reedem_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_redeem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_point_reedem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_gift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_redeem;
        private System.Windows.Forms.ComboBox cbo_customer;
        private System.Windows.Forms.DataGridView dgv_redeem;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn calredeemdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calredeempoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn calgift;
        private System.Windows.Forms.DataGridViewTextBoxColumn calredeemmode;
        private System.Windows.Forms.Button btn_add;
    }
}