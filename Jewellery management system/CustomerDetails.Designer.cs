namespace Jewellery_management_system
{
    partial class CustomerDetails
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
            this.lbl_newCustomerId = new System.Windows.Forms.Label();
            this.txt_newCustomerID = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cbo_title = new System.Windows.Forms.ComboBox();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_spouse = new System.Windows.Forms.TextBox();
            this.temp_adress = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_anniversary = new System.Windows.Forms.DateTimePicker();
            this.lbl_anniversary = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.cumpulsory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cusdetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_customerdetails = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.calid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calspouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caladress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calbthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calanniversary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calfax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_newCustomerId
            // 
            this.lbl_newCustomerId.AutoSize = true;
            this.lbl_newCustomerId.Location = new System.Drawing.Point(65, 42);
            this.lbl_newCustomerId.Name = "lbl_newCustomerId";
            this.lbl_newCustomerId.Size = new System.Drawing.Size(88, 13);
            this.lbl_newCustomerId.TabIndex = 2;
            this.lbl_newCustomerId.Text = "New Customer Id";
            // 
            // txt_newCustomerID
            // 
            this.txt_newCustomerID.Location = new System.Drawing.Point(168, 39);
            this.txt_newCustomerID.Name = "txt_newCustomerID";
            this.txt_newCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txt_newCustomerID.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(88, 69);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Title";
            // 
            // cbo_title
            // 
            this.cbo_title.FormattingEnabled = true;
            this.cbo_title.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Dr",
            "Stu"});
            this.cbo_title.Location = new System.Drawing.Point(130, 65);
            this.cbo_title.Name = "cbo_title";
            this.cbo_title.Size = new System.Drawing.Size(121, 21);
            this.cbo_title.TabIndex = 0;
            // 
            // cbo_name
            // 
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(416, 68);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(400, 21);
            this.cbo_name.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(347, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spouse";
            // 
            // txt_spouse
            // 
            this.txt_spouse.Location = new System.Drawing.Point(130, 131);
            this.txt_spouse.Name = "txt_spouse";
            this.txt_spouse.Size = new System.Drawing.Size(200, 20);
            this.txt_spouse.TabIndex = 5;
            // 
            // temp_adress
            // 
            this.temp_adress.AutoSize = true;
            this.temp_adress.Location = new System.Drawing.Point(76, 155);
            this.temp_adress.Name = "temp_adress";
            this.temp_adress.Size = new System.Drawing.Size(39, 13);
            this.temp_adress.TabIndex = 4;
            this.temp_adress.Text = "Adress";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(130, 154);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(200, 20);
            this.txt_adress.TabIndex = 5;
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(476, 101);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(52, 13);
            this.lbl_birthdate.TabIndex = 8;
            this.lbl_birthdate.Text = "Birth date";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(545, 95);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(270, 20);
            this.dtp_birthdate.TabIndex = 9;
            // 
            // dtp_anniversary
            // 
            this.dtp_anniversary.Location = new System.Drawing.Point(545, 119);
            this.dtp_anniversary.Name = "dtp_anniversary";
            this.dtp_anniversary.Size = new System.Drawing.Size(270, 20);
            this.dtp_anniversary.TabIndex = 11;
            // 
            // lbl_anniversary
            // 
            this.lbl_anniversary.AutoSize = true;
            this.lbl_anniversary.Location = new System.Drawing.Point(466, 122);
            this.lbl_anniversary.Name = "lbl_anniversary";
            this.lbl_anniversary.Size = new System.Drawing.Size(62, 13);
            this.lbl_anniversary.TabIndex = 10;
            this.lbl_anniversary.Text = "Anniversary";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(545, 141);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(270, 20);
            this.txt_phone.TabIndex = 13;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(491, 140);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(37, 13);
            this.lbl_phone.TabIndex = 12;
            this.lbl_phone.Text = "phone";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(545, 163);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(270, 20);
            this.txt_mobile.TabIndex = 15;
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Location = new System.Drawing.Point(491, 169);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(37, 13);
            this.lbl_mobile.TabIndex = 14;
            this.lbl_mobile.Text = "mobile";
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(545, 186);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(270, 20);
            this.txt_fax.TabIndex = 17;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(504, 189);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(24, 13);
            this.lbl_fax.TabIndex = 16;
            this.lbl_fax.Text = "Fax";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(508, 466);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(71, 26);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(588, 466);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(71, 26);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(665, 466);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(71, 26);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(742, 466);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(71, 26);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(819, 466);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(71, 26);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(504, 208);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(545, 209);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(270, 20);
            this.txt_email.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(130, 177);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(200, 20);
            this.txt_city.TabIndex = 5;
            // 
            // cumpulsory
            // 
            this.cumpulsory.AutoSize = true;
            this.cumpulsory.Location = new System.Drawing.Point(257, 71);
            this.cumpulsory.Name = "cumpulsory";
            this.cumpulsory.Size = new System.Drawing.Size(11, 13);
            this.cumpulsory.TabIndex = 19;
            this.cumpulsory.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(824, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(822, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(822, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(822, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // cusdetails
            // 
            this.cusdetails.AutoSize = true;
            this.cusdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusdetails.ForeColor = System.Drawing.Color.Maroon;
            this.cusdetails.Location = new System.Drawing.Point(58, 9);
            this.cusdetails.Name = "cusdetails";
            this.cusdetails.Size = new System.Drawing.Size(222, 20);
            this.cusdetails.TabIndex = 20;
            this.cusdetails.Text = "Customer\'s or Dealer\'s Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_customerdetails);
            this.panel1.Location = new System.Drawing.Point(21, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 196);
            this.panel1.TabIndex = 21;
            // 
            // dgv_customerdetails
            // 
            this.dgv_customerdetails.AllowUserToAddRows = false;
            this.dgv_customerdetails.AllowUserToDeleteRows = false;
            this.dgv_customerdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calid,
            this.caltitle,
            this.calname,
            this.calspouse,
            this.caladress,
            this.calcity,
            this.calbthdate,
            this.calanniversary,
            this.calphone,
            this.calmobile,
            this.calfax,
            this.calemail});
            this.dgv_customerdetails.Location = new System.Drawing.Point(3, 3);
            this.dgv_customerdetails.Name = "dgv_customerdetails";
            this.dgv_customerdetails.ReadOnly = true;
            this.dgv_customerdetails.Size = new System.Drawing.Size(866, 190);
            this.dgv_customerdetails.TabIndex = 0;
            this.dgv_customerdetails.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerData_RowHeaderMouseDoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(721, 230);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // calid
            // 
            this.calid.HeaderText = "Customer Id";
            this.calid.Name = "calid";
            this.calid.ReadOnly = true;
            // 
            // caltitle
            // 
            this.caltitle.HeaderText = "Title";
            this.caltitle.Name = "caltitle";
            this.caltitle.ReadOnly = true;
            // 
            // calname
            // 
            this.calname.HeaderText = "Name";
            this.calname.Name = "calname";
            this.calname.ReadOnly = true;
            // 
            // calspouse
            // 
            this.calspouse.HeaderText = "Spouse";
            this.calspouse.Name = "calspouse";
            this.calspouse.ReadOnly = true;
            // 
            // caladress
            // 
            this.caladress.HeaderText = "Adress";
            this.caladress.Name = "caladress";
            this.caladress.ReadOnly = true;
            // 
            // calcity
            // 
            this.calcity.HeaderText = "City";
            this.calcity.Name = "calcity";
            this.calcity.ReadOnly = true;
            // 
            // calbthdate
            // 
            this.calbthdate.HeaderText = "Birth Date";
            this.calbthdate.Name = "calbthdate";
            this.calbthdate.ReadOnly = true;
            // 
            // calanniversary
            // 
            this.calanniversary.HeaderText = "Anniversary";
            this.calanniversary.Name = "calanniversary";
            this.calanniversary.ReadOnly = true;
            // 
            // calphone
            // 
            this.calphone.HeaderText = "Phone";
            this.calphone.Name = "calphone";
            this.calphone.ReadOnly = true;
            // 
            // calmobile
            // 
            this.calmobile.HeaderText = "Mobile";
            this.calmobile.Name = "calmobile";
            this.calmobile.ReadOnly = true;
            // 
            // calfax
            // 
            this.calfax.HeaderText = "Fax No.";
            this.calfax.Name = "calfax";
            this.calfax.ReadOnly = true;
            // 
            // calemail
            // 
            this.calemail.HeaderText = "Email";
            this.calemail.Name = "calemail";
            this.calemail.ReadOnly = true;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 505);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cusdetails);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cumpulsory);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_fax);
            this.Controls.Add(this.lbl_fax);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.dtp_anniversary);
            this.Controls.Add(this.lbl_anniversary);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_spouse);
            this.Controls.Add(this.temp_adress);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_newCustomerID);
            this.Controls.Add(this.lbl_newCustomerId);
            this.Controls.Add(this.cbo_name);
            this.Controls.Add(this.cbo_title);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_newCustomerId;
        private System.Windows.Forms.TextBox txt_newCustomerID;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbo_title;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_spouse;
        private System.Windows.Forms.Label temp_adress;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.DateTimePicker dtp_anniversary;
        private System.Windows.Forms.Label lbl_anniversary;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label cumpulsory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cusdetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_customerdetails;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn calid;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn calname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calspouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn caladress;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn calbthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calanniversary;
        private System.Windows.Forms.DataGridViewTextBoxColumn calphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn calmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn calfax;
        private System.Windows.Forms.DataGridViewTextBoxColumn calemail;
    }
}