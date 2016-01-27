using System;
using System.Windows.Forms;

namespace Jewellery_management_system
{
    partial class add_update
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
            this.sno = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sell_price = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ADU_dataGridView = new System.Windows.Forms.DataGridView();
            this.calitem_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calbar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callabour_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calselling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_item_code = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_labour = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_lc = new System.Windows.Forms.Label();
            this.lbl_sp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ADU_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add,Update and Delete Items";
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Location = new System.Drawing.Point(154, 47);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(57, 13);
            this.sno.TabIndex = 2;
            this.sno.Text = "Item code:";
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Location = new System.Drawing.Point(327, 47);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(49, 13);
            this.barcode.TabIndex = 2;
            this.barcode.Text = "barcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selling Price:";
            // 
            // txt_sell_price
            // 
            this.txt_sell_price.Location = new System.Drawing.Point(226, 201);
            this.txt_sell_price.Name = "txt_sell_price";
            this.txt_sell_price.Size = new System.Drawing.Size(256, 20);
            this.txt_sell_price.TabIndex = 7;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(159, 72);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "Category:";
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(226, 72);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(257, 21);
            this.cbo_category.TabIndex = 2;
            this.cbo_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Item/Product :";
            // 
            // ADU_dataGridView
            // 
            this.ADU_dataGridView.AllowUserToAddRows = false;
            this.ADU_dataGridView.AllowUserToDeleteRows = false;
            this.ADU_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADU_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calitem_code,
            this.calbar_code,
            this.calcategory,
            this.calitem,
            this.calweight,
            this.calquantity,
            this.callabour_charge,
            this.calselling_price});
            this.ADU_dataGridView.Location = new System.Drawing.Point(12, 294);
            this.ADU_dataGridView.Name = "ADU_dataGridView";
            this.ADU_dataGridView.ReadOnly = true;
            this.ADU_dataGridView.Size = new System.Drawing.Size(790, 163);
            this.ADU_dataGridView.TabIndex = 0;
            this.ADU_dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ADU_dataGridView_RowHeaderMouseDoubleClick);
            // 
            // calitem_code
            // 
            this.calitem_code.HeaderText = "Item Code";
            this.calitem_code.Name = "calitem_code";
            this.calitem_code.ReadOnly = true;
            // 
            // calbar_code
            // 
            this.calbar_code.HeaderText = "Barcode";
            this.calbar_code.Name = "calbar_code";
            this.calbar_code.ReadOnly = true;
            // 
            // calcategory
            // 
            this.calcategory.HeaderText = "Category";
            this.calcategory.Name = "calcategory";
            this.calcategory.ReadOnly = true;
            // 
            // calitem
            // 
            this.calitem.HeaderText = "Item/product";
            this.calitem.Name = "calitem";
            this.calitem.ReadOnly = true;
            // 
            // calweight
            // 
            this.calweight.HeaderText = "Weight";
            this.calweight.Name = "calweight";
            this.calweight.ReadOnly = true;
            // 
            // calquantity
            // 
            this.calquantity.HeaderText = "Quantity";
            this.calquantity.Name = "calquantity";
            this.calquantity.ReadOnly = true;
            // 
            // callabour_charge
            // 
            this.callabour_charge.HeaderText = "Labour Charge";
            this.callabour_charge.Name = "callabour_charge";
            this.callabour_charge.ReadOnly = true;
            // 
            // calselling_price
            // 
            this.calselling_price.HeaderText = "Selling Price";
            this.calselling_price.Name = "calselling_price";
            this.calselling_price.ReadOnly = true;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(127, 271);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(93, 13);
            this.lbl_search.TabIndex = 8;
            this.lbl_search.Text = "Search item code:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(226, 268);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(436, 20);
            this.txt_search.TabIndex = 9;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(626, 486);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 31);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(719, 486);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 31);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(533, 486);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 31);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(382, 44);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_barcode.TabIndex = 1;
            // 
            // txt_item_code
            // 
            this.txt_item_code.Location = new System.Drawing.Point(226, 46);
            this.txt_item_code.Name = "txt_item_code";
            this.txt_item_code.Size = new System.Drawing.Size(85, 20);
            this.txt_item_code.TabIndex = 0;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(226, 99);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(257, 20);
            this.txt_item.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(226, 151);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(257, 20);
            this.txt_quantity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Labour Charge:";
            // 
            // txt_labour
            // 
            this.txt_labour.Location = new System.Drawing.Point(226, 175);
            this.txt_labour.Name = "txt_labour";
            this.txt_labour.Size = new System.Drawing.Size(257, 20);
            this.txt_labour.TabIndex = 6;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(226, 125);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(257, 20);
            this.txt_weight.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(382, 227);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Red;
            this.lbl_code.Location = new System.Drawing.Point(492, 46);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(11, 13);
            this.lbl_code.TabIndex = 15;
            this.lbl_code.Text = "*";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.Color.Red;
            this.lbl_item.Location = new System.Drawing.Point(492, 128);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(11, 13);
            this.lbl_item.TabIndex = 15;
            this.lbl_item.Text = "*";
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q.ForeColor = System.Drawing.Color.Red;
            this.lbl_q.Location = new System.Drawing.Point(492, 158);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(11, 13);
            this.lbl_q.TabIndex = 15;
            this.lbl_q.Text = "*";
            // 
            // lbl_lc
            // 
            this.lbl_lc.AutoSize = true;
            this.lbl_lc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lc.ForeColor = System.Drawing.Color.Red;
            this.lbl_lc.Location = new System.Drawing.Point(492, 182);
            this.lbl_lc.Name = "lbl_lc";
            this.lbl_lc.Size = new System.Drawing.Size(11, 13);
            this.lbl_lc.TabIndex = 15;
            this.lbl_lc.Text = "*";
            // 
            // lbl_sp
            // 
            this.lbl_sp.AutoSize = true;
            this.lbl_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sp.ForeColor = System.Drawing.Color.Red;
            this.lbl_sp.Location = new System.Drawing.Point(492, 208);
            this.lbl_sp.Name = "lbl_sp";
            this.lbl_sp.Size = new System.Drawing.Size(11, 13);
            this.lbl_sp.TabIndex = 15;
            this.lbl_sp.Text = "*";
            // 
            // add_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 545);
            this.Controls.Add(this.lbl_sp);
            this.Controls.Add(this.lbl_lc);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.ADU_dataGridView);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_item_code);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.txt_labour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sell_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.label1);
            this.Name = "add_update";
            this.Text = "Add_Update_Delete_Items";
            this.Load += new System.EventHandler(this.Add_Update_Delete_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ADU_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ADU_dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_item_code.Text = ADU_dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_barcode.Text = ADU_dataGridView.CurrentRow.Cells[1].Value.ToString();
            cbo_category.Text = ADU_dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_item.Text = ADU_dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_weight.Text = ADU_dataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_quantity.Text = ADU_dataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_labour.Text = ADU_dataGridView.CurrentRow.Cells[6].Value.ToString();
            txt_sell_price.Text = ADU_dataGridView.CurrentRow.Cells[7].Value.ToString();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sell_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ADU_dataGridView;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_item_code;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_labour;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_lc;
        private System.Windows.Forms.Label lbl_sp;
        private DataGridViewTextBoxColumn calitem_code;
        private DataGridViewTextBoxColumn calbar_code;
        private DataGridViewTextBoxColumn calcategory;
        private DataGridViewTextBoxColumn calitem;
        private DataGridViewTextBoxColumn calweight;
        private DataGridViewTextBoxColumn calquantity;
        private DataGridViewTextBoxColumn callabour_charge;
        private DataGridViewTextBoxColumn calselling_price;
    }
}