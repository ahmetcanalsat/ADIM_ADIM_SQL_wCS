namespace PROJE_SQL_DB
{
    partial class frmProduct
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_ProductCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductBuyPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductBrand = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ProductSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ProductStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_ProductStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(12, 398);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(201, 40);
            this.btn_Search.TabIndex = 42;
            this.btn_Search.Text = "ARA";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(840, 398);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(201, 40);
            this.btn_Update.TabIndex = 41;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(633, 398);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(201, 40);
            this.btn_Del.TabIndex = 40;
            this.btn_Del.Text = "SİL";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(426, 398);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(201, 40);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_List
            // 
            this.btn_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(219, 398);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(201, 40);
            this.btn_List.TabIndex = 38;
            this.btn_List.Text = "LİSTELE";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 379);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmb_ProductCategory
            // 
            this.cmb_ProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductCategory.FormattingEnabled = true;
            this.cmb_ProductCategory.Location = new System.Drawing.Point(1198, 155);
            this.cmb_ProductCategory.Name = "cmb_ProductCategory";
            this.cmb_ProductCategory.Size = new System.Drawing.Size(161, 33);
            this.cmb_ProductCategory.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1083, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // txt_ProductBuyPrice
            // 
            this.txt_ProductBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductBuyPrice.Location = new System.Drawing.Point(1198, 206);
            this.txt_ProductBuyPrice.Name = "txt_ProductBuyPrice";
            this.txt_ProductBuyPrice.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductBuyPrice.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1093, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1111, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Marka:";
            // 
            // txt_ProductBrand
            // 
            this.txt_ProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductBrand.Location = new System.Drawing.Point(1198, 105);
            this.txt_ProductBrand.Name = "txt_ProductBrand";
            this.txt_ProductBrand.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductBrand.TabIndex = 49;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.Location = new System.Drawing.Point(1198, 12);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductID.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1099, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ürün ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1094, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ürün Ad:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(1198, 57);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductName.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1072, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // txt_ProductSellPrice
            // 
            this.txt_ProductSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductSellPrice.Location = new System.Drawing.Point(1198, 258);
            this.txt_ProductSellPrice.Name = "txt_ProductSellPrice";
            this.txt_ProductSellPrice.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductSellPrice.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1124, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Stok:";
            // 
            // txt_ProductStock
            // 
            this.txt_ProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductStock.Location = new System.Drawing.Point(1198, 306);
            this.txt_ProductStock.Name = "txt_ProductStock";
            this.txt_ProductStock.Size = new System.Drawing.Size(161, 28);
            this.txt_ProductStock.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1107, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Durum:";
            // 
            // cmb_ProductStatus
            // 
            this.cmb_ProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductStatus.FormattingEnabled = true;
            this.cmb_ProductStatus.Location = new System.Drawing.Point(1198, 352);
            this.cmb_ProductStatus.Name = "cmb_ProductStatus";
            this.cmb_ProductStatus.Size = new System.Drawing.Size(161, 33);
            this.cmb_ProductStatus.TabIndex = 59;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 449);
            this.Controls.Add(this.cmb_ProductStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ProductStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ProductSellPrice);
            this.Controls.Add(this.cmb_ProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductBuyPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductBrand);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_List);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_ProductCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductBuyPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductBrand;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ProductSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ProductStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_ProductStatus;
    }
}