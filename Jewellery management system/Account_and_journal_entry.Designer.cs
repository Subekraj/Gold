namespace Jewellery_management_system
{
    partial class Account_and_journal_entry
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_voucher_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_new_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_ac_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_dr_cr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_narration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView_adddata = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_debit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_credit = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbo_existing_vid = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dr_cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calnewid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calexid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adddata)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(73, 55);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Voucher Type:";
            // 
            // cbo_voucher_type
            // 
            this.cbo_voucher_type.FormattingEnabled = true;
            this.cbo_voucher_type.Location = new System.Drawing.Point(362, 53);
            this.cbo_voucher_type.Name = "cbo_voucher_type";
            this.cbo_voucher_type.Size = new System.Drawing.Size(121, 21);
            this.cbo_voucher_type.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "New ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_new_id
            // 
            this.txt_new_id.Location = new System.Drawing.Point(559, 53);
            this.txt_new_id.Name = "txt_new_id";
            this.txt_new_id.Size = new System.Drawing.Size(54, 20);
            this.txt_new_id.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Existing V.ID:";
            // 
            // cbo_ac_name
            // 
            this.cbo_ac_name.FormattingEnabled = true;
            this.cbo_ac_name.Location = new System.Drawing.Point(104, 93);
            this.cbo_ac_name.Name = "cbo_ac_name";
            this.cbo_ac_name.Size = new System.Drawing.Size(685, 21);
            this.cbo_ac_name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A/c Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dr/Cr";
            // 
            // cbo_dr_cr
            // 
            this.cbo_dr_cr.FormattingEnabled = true;
            this.cbo_dr_cr.Items.AddRange(new object[] {
            "debit",
            "credit\t"});
            this.cbo_dr_cr.Location = new System.Drawing.Point(377, 123);
            this.cbo_dr_cr.Name = "cbo_dr_cr";
            this.cbo_dr_cr.Size = new System.Drawing.Size(121, 21);
            this.cbo_dr_cr.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Amount:";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(104, 126);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(183, 20);
            this.txt_amount.TabIndex = 6;
            // 
            // txt_narration
            // 
            this.txt_narration.Location = new System.Drawing.Point(104, 161);
            this.txt_narration.Name = "txt_narration";
            this.txt_narration.Size = new System.Drawing.Size(585, 20);
            this.txt_narration.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Narration:";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(714, 159);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView_adddata
            // 
            this.dataGridView_adddata.AllowUserToDeleteRows = false;
            this.dataGridView_adddata.AllowUserToOrderColumns = true;
            this.dataGridView_adddata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_adddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.voucher_type,
            this.account_name,
            this.dr_cr,
            this.amount,
            this.narration,
            this.calnewid,
            this.calexid});
            this.dataGridView_adddata.Location = new System.Drawing.Point(42, 218);
            this.dataGridView_adddata.Name = "dataGridView_adddata";
            this.dataGridView_adddata.ReadOnly = true;
            this.dataGridView_adddata.Size = new System.Drawing.Size(747, 137);
            this.dataGridView_adddata.TabIndex = 8;
            this.dataGridView_adddata.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_adddata_RowHeaderMouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Debit Amount:";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_debit
            // 
            this.txt_debit.Location = new System.Drawing.Point(475, 403);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(119, 20);
            this.txt_debit.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Credit Amount:";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_credit
            // 
            this.txt_credit.Location = new System.Drawing.Point(682, 404);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(107, 20);
            this.txt_credit.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(486, 451);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(584, 451);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(92, 32);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(697, 451);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(92, 32);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "A/c  and Journal Entries";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create New A/c";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Search By";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(487, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(795, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(795, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(504, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(695, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "*";
            // 
            // cbo_existing_vid
            // 
            this.cbo_existing_vid.FormattingEnabled = true;
            this.cbo_existing_vid.Location = new System.Drawing.Point(696, 52);
            this.cbo_existing_vid.Name = "cbo_existing_vid";
            this.cbo_existing_vid.Size = new System.Drawing.Size(121, 21);
            this.cbo_existing_vid.TabIndex = 13;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // voucher_type
            // 
            this.voucher_type.HeaderText = "Voucher Type";
            this.voucher_type.Name = "voucher_type";
            this.voucher_type.ReadOnly = true;
            // 
            // account_name
            // 
            this.account_name.HeaderText = "Account Name";
            this.account_name.Name = "account_name";
            this.account_name.ReadOnly = true;
            // 
            // dr_cr
            // 
            this.dr_cr.HeaderText = "Debit/Credit";
            this.dr_cr.Name = "dr_cr";
            this.dr_cr.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // narration
            // 
            this.narration.HeaderText = "Narration";
            this.narration.Name = "narration";
            this.narration.ReadOnly = true;
            // 
            // calnewid
            // 
            this.calnewid.HeaderText = "New Id";
            this.calnewid.Name = "calnewid";
            this.calnewid.ReadOnly = true;
            this.calnewid.Visible = false;
            // 
            // calexid
            // 
            this.calexid.HeaderText = "Existing ID";
            this.calexid.Name = "calexid";
            this.calexid.ReadOnly = true;
            this.calexid.Visible = false;
            // 
            // Account_and_journal_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 495);
            this.Controls.Add(this.cbo_existing_vid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView_adddata);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_narration);
            this.Controls.Add(this.txt_credit);
            this.Controls.Add(this.txt_debit);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_new_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_ac_name);
            this.Controls.Add(this.cbo_dr_cr);
            this.Controls.Add(this.cbo_voucher_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Name = "Account_and_journal_entry";
            this.Text = "Account_and_journal_entries";
            this.Load += new System.EventHandler(this.txt_new_id_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adddata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_voucher_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_new_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_ac_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_dr_cr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_narration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView_adddata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_debit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_credit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbo_existing_vid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dr_cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn calnewid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calexid;
    }
}