namespace PROJE_SQL_DB
{
    partial class frmCategories
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CatID = new System.Windows.Forms.TextBox();
            this.txt_CatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori ID:";
            // 
            // txt_CatID
            // 
            this.txt_CatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CatID.Location = new System.Drawing.Point(115, 78);
            this.txt_CatID.Name = "txt_CatID";
            this.txt_CatID.Size = new System.Drawing.Size(161, 28);
            this.txt_CatID.TabIndex = 2;
            // 
            // txt_CatName
            // 
            this.txt_CatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CatName.Location = new System.Drawing.Point(115, 123);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.Size = new System.Drawing.Size(161, 28);
            this.txt_CatName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Ad:";
            // 
            // btn_List
            // 
            this.btn_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(282, 12);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(201, 40);
            this.btn_List.TabIndex = 21;
            this.btn_List.Text = "LİSTELE";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(282, 63);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(201, 40);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(282, 116);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(201, 40);
            this.btn_Del.TabIndex = 23;
            this.btn_Del.Text = "SİL";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(282, 166);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(201, 40);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(495, 560);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txt_CatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CatID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCategories";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CatID;
        private System.Windows.Forms.TextBox txt_CatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Update;
    }
}