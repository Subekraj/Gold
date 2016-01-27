namespace Jewellery_management_system
{
    partial class SellsBook
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
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpbilldate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbocustomerno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocustomername = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calitem_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpymenttype = new System.Windows.Forms.TextBox();
            this.txtpaymentrecive = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcardamount = new System.Windows.Forms.TextBox();
            this.txtcashamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer No";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(110, 23);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(157, 20);
            this.txtbillno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Date";
            // 
            // dtpbilldate
            // 
            this.dtpbilldate.Location = new System.Drawing.Point(383, 26);
            this.dtpbilldate.Name = "dtpbilldate";
            this.dtpbilldate.Size = new System.Drawing.Size(200, 20);
            this.dtpbilldate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bill No";
            // 
            // cbocustomerno
            // 
            this.cbocustomerno.FormattingEnabled = true;
            this.cbocustomerno.Location = new System.Drawing.Point(110, 53);
            this.cbocustomerno.Name = "cbocustomerno";
            this.cbocustomerno.Size = new System.Drawing.Size(157, 21);
            this.cbocustomerno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer Name";
            // 
            // cbocustomername
            // 
            this.cbocustomername.FormattingEnabled = true;
            this.cbocustomername.Location = new System.Drawing.Point(383, 56);
            this.cbocustomername.Name = "cbocustomername";
            this.cbocustomername.Size = new System.Drawing.Size(200, 21);
            this.cbocustomername.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ItemCode/Barcode";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(144, 100);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(123, 20);
            this.txtcode.TabIndex = 9;
            this.txtcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calitem_name,
            this.calweight,
            this.calqty,
            this.calrate,
            this.caltotal});
            this.dataGridView1.Location = new System.Drawing.Point(37, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calitem_name
            // 
            this.calitem_name.HeaderText = "Item Name";
            this.calitem_name.Name = "calitem_name";
            this.calitem_name.ReadOnly = true;
            // 
            // calweight
            // 
            this.calweight.HeaderText = "Weight";
            this.calweight.Name = "calweight";
            this.calweight.ReadOnly = true;
            // 
            // calqty
            // 
            this.calqty.HeaderText = "QTY";
            this.calqty.Name = "calqty";
            this.calqty.ReadOnly = true;
            // 
            // calrate
            // 
            this.calrate.HeaderText = "Rate";
            this.calrate.Name = "calrate";
            this.calrate.ReadOnly = true;
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "Total";
            this.caltotal.Name = "caltotal";
            this.caltotal.ReadOnly = true;
            // 
            // atnadd
            // 
            this.atnadd.Location = new System.Drawing.Point(383, 99);
            this.atnadd.Name = "atnadd";
            this.atnadd.Size = new System.Drawing.Size(200, 23);
            this.atnadd.TabIndex = 12;
            this.atnadd.Text = "Add";
            this.atnadd.UseVisualStyleBackColor = true;
            this.atnadd.Click += new System.EventHandler(this.atnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payment Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Payment Recive";
            // 
            // txtpymenttype
            // 
            this.txtpymenttype.Location = new System.Drawing.Point(135, 295);
            this.txtpymenttype.Name = "txtpymenttype";
            this.txtpymenttype.Size = new System.Drawing.Size(137, 20);
            this.txtpymenttype.TabIndex = 15;
            // 
            // txtpaymentrecive
            // 
            this.txtpaymentrecive.Location = new System.Drawing.Point(135, 322);
            this.txtpaymentrecive.Name = "txtpaymentrecive";
            this.txtpaymentrecive.Size = new System.Drawing.Size(137, 20);
            this.txtpaymentrecive.TabIndex = 16;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(425, 317);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(137, 20);
            this.txtdiscount.TabIndex = 20;
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(425, 290);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(137, 20);
            this.txtsubtotal.TabIndex = 19;
            this.txtsubtotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sub Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(425, 343);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(137, 20);
            this.txtgrandtotal.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Grand Total";
            // 
            // txtcardamount
            // 
            this.txtcardamount.Location = new System.Drawing.Point(135, 375);
            this.txtcardamount.Name = "txtcardamount";
            this.txtcardamount.Size = new System.Drawing.Size(137, 20);
            this.txtcardamount.TabIndex = 27;
            this.txtcardamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcardamount_KeyDown);
            // 
            // txtcashamount
            // 
            this.txtcashamount.Location = new System.Drawing.Point(135, 348);
            this.txtcashamount.Name = "txtcashamount";
            this.txtcashamount.Size = new System.Drawing.Size(137, 20);
            this.txtcashamount.TabIndex = 26;
            this.txtcashamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcashamount_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Card Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cash Amount";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(425, 377);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // SellsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 417);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcardamount);
            this.Controls.Add(this.txtcashamount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpaymentrecive);
            this.Controls.Add(this.txtpymenttype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.atnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbocustomername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbocustomerno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpbilldate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label1);
            this.Name = "SellsBook";
            this.Text = "SellsBook";
            this.Load += new System.EventHandler(this.SellsBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpbilldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbocustomerno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocustomername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button atnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn calitem_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn calweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn calqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn calrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpymenttype;
        private System.Windows.Forms.TextBox txtpaymentrecive;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcardamount;
        private System.Windows.Forms.TextBox txtcashamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnsave;
    }
}