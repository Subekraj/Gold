namespace Jewellery_management_system
{
    partial class Supplier_opening_ballance
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
            this.txt_opening_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_open_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ac_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_dt_cr = new System.Windows.Forms.ComboBox();
            this.dataGridView_alldata = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alldata)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_opening_id
            // 
            this.txt_opening_id.Location = new System.Drawing.Point(129, 48);
            this.txt_opening_id.Name = "txt_opening_id";
            this.txt_opening_id.Size = new System.Drawing.Size(100, 20);
            this.txt_opening_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opening Dt";
            // 
            // dtp_open_date
            // 
            this.dtp_open_date.Location = new System.Drawing.Point(235, 48);
            this.dtp_open_date.Name = "dtp_open_date";
            this.dtp_open_date.Size = new System.Drawing.Size(197, 20);
            this.dtp_open_date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(54, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opening A/c Balances as on:";
            // 
            // txt_ac_name
            // 
            this.txt_ac_name.Location = new System.Drawing.Point(129, 76);
            this.txt_ac_name.Name = "txt_ac_name";
            this.txt_ac_name.Size = new System.Drawing.Size(303, 20);
            this.txt_ac_name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "A/c Name:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(129, 107);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(249, 20);
            this.txt_amount.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount:";
            // 
            // cbo_dt_cr
            // 
            this.cbo_dt_cr.FormattingEnabled = true;
            this.cbo_dt_cr.Items.AddRange(new object[] {
            "debit",
            "credit"});
            this.cbo_dt_cr.Location = new System.Drawing.Point(385, 107);
            this.cbo_dt_cr.Name = "cbo_dt_cr";
            this.cbo_dt_cr.Size = new System.Drawing.Size(47, 21);
            this.cbo_dt_cr.TabIndex = 4;
            // 
            // dataGridView_alldata
            // 
            this.dataGridView_alldata.AllowUserToAddRows = false;
            this.dataGridView_alldata.AllowUserToDeleteRows = false;
            this.dataGridView_alldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alldata.Location = new System.Drawing.Point(36, 150);
            this.dataGridView_alldata.Name = "dataGridView_alldata";
            this.dataGridView_alldata.ReadOnly = true;
            this.dataGridView_alldata.Size = new System.Drawing.Size(634, 179);
            this.dataGridView_alldata.TabIndex = 5;
            this.dataGridView_alldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(472, 335);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(573, 335);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 35);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Supplier_opening_ballance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 382);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView_alldata);
            this.Controls.Add(this.cbo_dt_cr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_open_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ac_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_opening_id);
            this.Name = "Supplier_opening_ballance";
            this.Text = "Supplier_opening_ballance";
            this.Load += new System.EventHandler(this.Supplier_opening_ballance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_opening_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_open_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ac_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_dt_cr;
        private System.Windows.Forms.DataGridView dataGridView_alldata;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
    }
}