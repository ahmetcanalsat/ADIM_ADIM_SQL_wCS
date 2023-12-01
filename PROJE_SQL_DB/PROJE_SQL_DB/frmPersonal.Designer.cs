namespace PROJE_SQL_DB
{
    partial class frmPersonal
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
            this.txt_PersonalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PersonalFullName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(2, 474);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(201, 40);
            this.btn_Search.TabIndex = 47;
            this.btn_Search.Text = "ARA";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(830, 474);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(201, 40);
            this.btn_Update.TabIndex = 46;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(623, 474);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(201, 40);
            this.btn_Del.TabIndex = 45;
            this.btn_Del.Text = "SİL";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(416, 474);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(201, 40);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_List
            // 
            this.btn_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(209, 474);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(201, 40);
            this.btn_List.TabIndex = 43;
            this.btn_List.Text = "LİSTELE";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 468);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_PersonalID
            // 
            this.txt_PersonalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonalID.Location = new System.Drawing.Point(830, 184);
            this.txt_PersonalID.Name = "txt_PersonalID";
            this.txt_PersonalID.Size = new System.Drawing.Size(161, 28);
            this.txt_PersonalID.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Personel Ad Soyad:";
            // 
            // txt_PersonalFullName
            // 
            this.txt_PersonalFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonalFullName.Location = new System.Drawing.Point(830, 229);
            this.txt_PersonalFullName.Name = "txt_PersonalFullName";
            this.txt_PersonalFullName.Size = new System.Drawing.Size(161, 28);
            this.txt_PersonalFullName.TabIndex = 52;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 526);
            this.Controls.Add(this.txt_PersonalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PersonalFullName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_List);
            this.Name = "frmPersonal";
            this.Text = "frmPersonal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
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
        private System.Windows.Forms.TextBox txt_PersonalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PersonalFullName;
    }
}