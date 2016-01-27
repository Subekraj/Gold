namespace Jewellery_management_system
{
    partial class payment_details
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
            this.txt_pay_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_payments_dates = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_supplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bill_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_modes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_chk_dr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_chk_dr = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bank = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_actual_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pay_amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.dgv_payment_details = new System.Windows.Forms.DataGridView();
            this.calpayment_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpayment_dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calsupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calbillno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calmode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calbank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calchk_dr_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calchk_dr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calactual_pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Details ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment No:";
            // 
            // txt_pay_no
            // 
            this.txt_pay_no.Location = new System.Drawing.Point(110, 63);
            this.txt_pay_no.Name = "txt_pay_no";
            this.txt_pay_no.Size = new System.Drawing.Size(73, 20);
            this.txt_pay_no.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "P.Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MMMM dd yyyy";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(255, 57);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(98, 20);
            this.dtp_date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment Dates:";
            // 
            // dtp_payments_dates
            // 
            this.dtp_payments_dates.CustomFormat = "MMMM dd yyyy";
            this.dtp_payments_dates.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_payments_dates.Location = new System.Drawing.Point(454, 57);
            this.dtp_payments_dates.Name = "dtp_payments_dates";
            this.dtp_payments_dates.Size = new System.Drawing.Size(111, 20);
            this.dtp_payments_dates.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supplier:";
            // 
            // cbo_supplier
            // 
            this.cbo_supplier.FormattingEnabled = true;
            this.cbo_supplier.Location = new System.Drawing.Point(110, 89);
            this.cbo_supplier.Name = "cbo_supplier";
            this.cbo_supplier.Size = new System.Drawing.Size(630, 21);
            this.cbo_supplier.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bill No:";
            // 
            // txt_bill_no
            // 
            this.txt_bill_no.Location = new System.Drawing.Point(110, 117);
            this.txt_bill_no.Name = "txt_bill_no";
            this.txt_bill_no.Size = new System.Drawing.Size(100, 20);
            this.txt_bill_no.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mode";
            // 
            // cbo_modes
            // 
            this.cbo_modes.FormattingEnabled = true;
            this.cbo_modes.Location = new System.Drawing.Point(273, 125);
            this.cbo_modes.Name = "cbo_modes";
            this.cbo_modes.Size = new System.Drawing.Size(121, 21);
            this.cbo_modes.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ch / Dr No:";
            // 
            // txt_chk_dr
            // 
            this.txt_chk_dr.Location = new System.Drawing.Point(528, 118);
            this.txt_chk_dr.Name = "txt_chk_dr";
            this.txt_chk_dr.Size = new System.Drawing.Size(212, 20);
            this.txt_chk_dr.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ch / Dr Date:";
            // 
            // dtp_chk_dr
            // 
            this.dtp_chk_dr.CustomFormat = "MMMM dd yyyy";
            this.dtp_chk_dr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_chk_dr.Location = new System.Drawing.Point(634, 151);
            this.dtp_chk_dr.Name = "dtp_chk_dr";
            this.dtp_chk_dr.Size = new System.Drawing.Size(106, 20);
            this.dtp_chk_dr.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Bank:";
            // 
            // txt_bank
            // 
            this.txt_bank.Location = new System.Drawing.Point(110, 154);
            this.txt_bank.Name = "txt_bank";
            this.txt_bank.Size = new System.Drawing.Size(284, 20);
            this.txt_bank.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Actual Payment:";
            // 
            // txt_actual_amount
            // 
            this.txt_actual_amount.Location = new System.Drawing.Point(110, 184);
            this.txt_actual_amount.Name = "txt_actual_amount";
            this.txt_actual_amount.Size = new System.Drawing.Size(139, 20);
            this.txt_actual_amount.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Pay Amount:";
            // 
            // txt_pay_amount
            // 
            this.txt_pay_amount.Location = new System.Drawing.Point(332, 184);
            this.txt_pay_amount.Name = "txt_pay_amount";
            this.txt_pay_amount.Size = new System.Drawing.Size(135, 20);
            this.txt_pay_amount.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Remarks:";
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(531, 187);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(209, 20);
            this.txt_remarks.TabIndex = 9;
            // 
            // dgv_payment_details
            // 
            this.dgv_payment_details.AllowUserToAddRows = false;
            this.dgv_payment_details.AllowUserToDeleteRows = false;
            this.dgv_payment_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calpayment_no,
            this.calp_date,
            this.calpayment_dates,
            this.calsupplier,
            this.calbillno,
            this.calmode,
            this.calbank,
            this.calchk_dr_no,
            this.calchk_dr_date,
            this.calactual_pay,
            this.calpay_amount,
            this.calremarks});
            this.dgv_payment_details.Location = new System.Drawing.Point(37, 256);
            this.dgv_payment_details.Name = "dgv_payment_details";
            this.dgv_payment_details.ReadOnly = true;
            this.dgv_payment_details.Size = new System.Drawing.Size(703, 150);
            this.dgv_payment_details.TabIndex = 11;
            this.dgv_payment_details.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_payment_details_RowHeaderMouseDoubleClick);
            // 
            // calpayment_no
            // 
            this.calpayment_no.HeaderText = "Payment No";
            this.calpayment_no.Name = "calpayment_no";
            this.calpayment_no.ReadOnly = true;
            // 
            // calp_date
            // 
            this.calp_date.HeaderText = "Payment Date";
            this.calp_date.Name = "calp_date";
            this.calp_date.ReadOnly = true;
            // 
            // calpayment_dates
            // 
            this.calpayment_dates.HeaderText = "Payment Dates";
            this.calpayment_dates.Name = "calpayment_dates";
            this.calpayment_dates.ReadOnly = true;
            this.calpayment_dates.Width = 120;
            // 
            // calsupplier
            // 
            this.calsupplier.HeaderText = "Supplier";
            this.calsupplier.Name = "calsupplier";
            this.calsupplier.ReadOnly = true;
            // 
            // calbillno
            // 
            this.calbillno.HeaderText = "Bill No";
            this.calbillno.Name = "calbillno";
            this.calbillno.ReadOnly = true;
            // 
            // calmode
            // 
            this.calmode.HeaderText = "Mode";
            this.calmode.Name = "calmode";
            this.calmode.ReadOnly = true;
            // 
            // calbank
            // 
            this.calbank.HeaderText = "Bank";
            this.calbank.Name = "calbank";
            this.calbank.ReadOnly = true;
            // 
            // calchk_dr_no
            // 
            this.calchk_dr_no.HeaderText = "Check or Debit no";
            this.calchk_dr_no.Name = "calchk_dr_no";
            this.calchk_dr_no.ReadOnly = true;
            this.calchk_dr_no.Width = 130;
            // 
            // calchk_dr_date
            // 
            this.calchk_dr_date.HeaderText = "Check or Debit Entry Date";
            this.calchk_dr_date.Name = "calchk_dr_date";
            this.calchk_dr_date.ReadOnly = true;
            this.calchk_dr_date.Width = 160;
            // 
            // calactual_pay
            // 
            this.calactual_pay.HeaderText = "Actual Payment";
            this.calactual_pay.Name = "calactual_pay";
            this.calactual_pay.ReadOnly = true;
            this.calactual_pay.Width = 120;
            // 
            // calpay_amount
            // 
            this.calpay_amount.HeaderText = "Pay Amount";
            this.calpay_amount.Name = "calpay_amount";
            this.calpay_amount.ReadOnly = true;
            // 
            // calremarks
            // 
            this.calremarks.HeaderText = "Remarks";
            this.calremarks.Name = "calremarks";
            this.calremarks.ReadOnly = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(622, 213);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 37);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(432, 412);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 28);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(528, 412);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 28);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(627, 412);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 28);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 491);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_payment_details);
            this.Controls.Add(this.cbo_modes);
            this.Controls.Add(this.txt_chk_dr);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.txt_pay_amount);
            this.Controls.Add(this.txt_actual_amount);
            this.Controls.Add(this.txt_bank);
            this.Controls.Add(this.txt_bill_no);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbo_supplier);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_chk_dr);
            this.Controls.Add(this.dtp_payments_dates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pay_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "payment_details";
            this.Text = "Mode:";
            this.Load += new System.EventHandler(this.cbo_mode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pay_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_payments_dates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bill_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_modes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_chk_dr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_chk_dr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_bank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_actual_amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_pay_amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.DataGridView dgv_payment_details;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpayment_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn calp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpayment_dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn calsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn calbillno;
        private System.Windows.Forms.DataGridViewTextBoxColumn calmode;
        private System.Windows.Forms.DataGridViewTextBoxColumn calbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn calchk_dr_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn calchk_dr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn calactual_pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpay_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calremarks;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
    }
}