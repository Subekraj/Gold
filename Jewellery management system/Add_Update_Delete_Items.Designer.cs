namespace Jewellery_management_system
{
    partial class Add_Update_Delete_Items
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
            this.cbo_syn = new System.Windows.Forms.ComboBox();
            this.sno = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cost_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sell_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_martket_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.cbo_unit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.cbo_item = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ADU_dataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pbx_barcode = new System.Windows.Forms.PictureBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADU_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add,Update and Delete Items";
            // 
            // cbo_syn
            // 
            this.cbo_syn.FormattingEnabled = true;
            this.cbo_syn.Location = new System.Drawing.Point(107, 46);
            this.cbo_syn.Name = "cbo_syn";
            this.cbo_syn.Size = new System.Drawing.Size(67, 21);
            this.cbo_syn.TabIndex = 1;
            this.cbo_syn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Location = new System.Drawing.Point(67, 49);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(34, 13);
            this.sno.TabIndex = 2;
            this.sno.Text = "S.No.";
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Location = new System.Drawing.Point(198, 50);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(49, 13);
            this.barcode.TabIndex = 2;
            this.barcode.Text = "barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CP:";
            // 
            // txt_cost_price
            // 
            this.txt_cost_price.Location = new System.Drawing.Point(541, 52);
            this.txt_cost_price.Name = "txt_cost_price";
            this.txt_cost_price.Size = new System.Drawing.Size(89, 20);
            this.txt_cost_price.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SP:";
            // 
            // txt_sell_price
            // 
            this.txt_sell_price.Location = new System.Drawing.Point(541, 78);
            this.txt_sell_price.Name = "txt_sell_price";
            this.txt_sell_price.Size = new System.Drawing.Size(89, 20);
            this.txt_sell_price.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MRP:";
            // 
            // txt_martket_price
            // 
            this.txt_martket_price.Location = new System.Drawing.Point(541, 104);
            this.txt_martket_price.Name = "txt_martket_price";
            this.txt_martket_price.Size = new System.Drawing.Size(89, 20);
            this.txt_martket_price.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stock:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(676, 79);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(89, 20);
            this.txt_stock.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Min:";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(676, 105);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(89, 20);
            this.txt_min.TabIndex = 5;
            // 
            // cbo_unit
            // 
            this.cbo_unit.FormattingEnabled = true;
            this.cbo_unit.Location = new System.Drawing.Point(676, 50);
            this.cbo_unit.Name = "cbo_unit";
            this.cbo_unit.Size = new System.Drawing.Size(89, 21);
            this.cbo_unit.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max:";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(677, 132);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(89, 20);
            this.txt_max.TabIndex = 5;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(49, 86);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "Category:";
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(107, 86);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(227, 21);
            this.cbo_category.TabIndex = 1;
            this.cbo_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbo_item
            // 
            this.cbo_item.FormattingEnabled = true;
            this.cbo_item.Location = new System.Drawing.Point(107, 113);
            this.cbo_item.Name = "cbo_item";
            this.cbo_item.Size = new System.Drawing.Size(227, 21);
            this.cbo_item.TabIndex = 1;
            this.cbo_item.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Item/Product :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ADU_dataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 169);
            this.panel1.TabIndex = 7;
            // 
            // ADU_dataGridView
            // 
            this.ADU_dataGridView.AllowUserToAddRows = false;
            this.ADU_dataGridView.AllowUserToDeleteRows = false;
            this.ADU_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADU_dataGridView.Location = new System.Drawing.Point(3, 6);
            this.ADU_dataGridView.Name = "ADU_dataGridView";
            this.ADU_dataGridView.ReadOnly = true;
            this.ADU_dataGridView.Size = new System.Drawing.Size(790, 163);
            this.ADU_dataGridView.TabIndex = 0;
            this.ADU_dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ADU_dataGridView_RowHeaderMouseDoubleClick);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(57, 244);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 8;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(104, 241);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(231, 20);
            this.txt_search.TabIndex = 9;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(533, 460);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 31);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(626, 460);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 31);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(719, 460);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 31);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(440, 460);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 31);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pbx_barcode
            // 
            this.pbx_barcode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbx_barcode.Location = new System.Drawing.Point(446, 179);
            this.pbx_barcode.Name = "pbx_barcode";
            this.pbx_barcode.Size = new System.Drawing.Size(184, 78);
            this.pbx_barcode.TabIndex = 11;
            this.pbx_barcode.TabStop = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(253, 47);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_barcode.TabIndex = 12;
            // 
            // Add_Update_Delete_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 503);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.pbx_barcode);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbo_unit);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_martket_price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sell_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cost_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.cbo_item);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.cbo_syn);
            this.Controls.Add(this.label1);
            this.Name = "Add_Update_Delete_Items";
            this.Text = "Add_Update_Delete_Items";
            this.Load += new System.EventHandler(this.Add_Update_Delete_Items_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADU_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_syn;
        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cost_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sell_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_martket_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.ComboBox cbo_unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.ComboBox cbo_item;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ADU_dataGridView;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pbx_barcode;
        private System.Windows.Forms.TextBox txt_barcode;
    }
}