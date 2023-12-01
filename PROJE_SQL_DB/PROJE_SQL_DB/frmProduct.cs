using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_SQL_DB
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");

        void Listele()
        {
            SqlCommand list_Prod = new SqlCommand("SELECT * FROM TBLURUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(list_Prod);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void TurDonustur()
        {
            switch (cmb_ProductStatus.Text)
            {
                case "YOK":
                    cmb_ProductStatus.Text = 0.ToString();
                    break;
                case "VAR":
                    cmb_ProductStatus.Text = 1.ToString();
                    break;
            }
            switch (cmb_ProductCategory.Text)
            {
                case "BILGISAYAR":
                    cmb_ProductCategory.Text = 1.ToString(); break;
                case "BEYAZ ESYA":
                    cmb_ProductCategory.Text = 2.ToString(); break;
                case "KÜÇÜK EV ALETI":
                    cmb_ProductCategory.Text = 3.ToString(); break;
                case "TV":
                    cmb_ProductCategory.Text = 4.ToString(); break;
                case "MOBILYA":
                    cmb_ProductCategory.Text = 5.ToString(); break;
            }

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Listele();
            cmb_ProductStatus.Items.Add("VAR");
            cmb_ProductStatus.Items.Add("YOK");


            /* Kategori Combobox'ına kategoriler tablosundaki verileri çeken kod bloğu */
            baglanti.Open();
            SqlCommand kategori_cagir = new SqlCommand("SELECT * FROM TBLKATEGORI", baglanti);
            SqlDataReader dr = kategori_cagir.ExecuteReader();
            while (dr.Read())
            {
                cmb_ProductCategory.Items.Add(dr["KATEGORIAD"]);
            }
            baglanti.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            SqlCommand srch_prod = new SqlCommand("SELECT * FROM TBLURUNLER WHERE URUNAD LIKE ('%' + @p1 + '%')", baglanti);
            srch_prod.Parameters.AddWithValue("@p1", txt_ProductName.Text);
            SqlDataAdapter da = new SqlDataAdapter(srch_prod);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            TurDonustur();
            /* Yukarıdaki Switch-Case yapısında ürünlerde durum sütunu bit olarak kaydedildiği için dönüştürme işlemi yaptık. */
            baglanti.Open();
            SqlCommand save_Prod = new SqlCommand("INSERT INTO TBLURUNLER (URUNAD,URUNMARKA,KATEGORI,URUNALISFIYAT,URUNSATISFIYAT,URUNSTOK,URUNDURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti); /* Ürünler tablomuza veri eklemimizi sağlar. */
            save_Prod.Parameters.AddWithValue("@p1", txt_ProductName.Text.ToUpper());
            save_Prod.Parameters.AddWithValue("@p2", txt_ProductBrand.Text.ToUpper());
            save_Prod.Parameters.AddWithValue("@p3", cmb_ProductCategory.Text.ToUpper());
            save_Prod.Parameters.AddWithValue("@p4", decimal.Parse(txt_ProductBuyPrice.Text));
            save_Prod.Parameters.AddWithValue("@p5", decimal.Parse(txt_ProductSellPrice.Text));
            save_Prod.Parameters.AddWithValue("@p6", txt_ProductStock.Text.ToUpper());
            save_Prod.Parameters.AddWithValue("@p7", cmb_ProductStatus.Text.ToUpper());
            save_Prod.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla listeye eklendi.");
            Listele();

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand del_Prod = new SqlCommand("DELETE FROM TBLURUNLER WHERE URUNID=@p1", baglanti);
            del_Prod.Parameters.AddWithValue("@p1", txt_ProductID.Text);
            del_Prod.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla silindi");
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ProductID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ProductBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_ProductCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ProductBuyPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ProductSellPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_ProductStock.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmb_ProductStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            TurDonustur();
            baglanti.Open();
            SqlCommand updt_Prod = new SqlCommand("UPDATE TBLURUNLER SET URUNAD=@p1,URUNMARKA=@p2,KATEGORI=@p3,URUNALISFIYAT=@p4,URUNSATISFIYAT=@p5,URUNSTOK=@p6,URUNDURUM=@p7 WHERE URUNID=@p8", baglanti);
            updt_Prod.Parameters.AddWithValue("@p1", txt_ProductName.Text.ToUpper());
            updt_Prod.Parameters.AddWithValue("@p2", txt_ProductBrand.Text.ToUpper());
            updt_Prod.Parameters.AddWithValue("@p3", cmb_ProductCategory.Text.ToUpper());
            updt_Prod.Parameters.AddWithValue("@p4", decimal.Parse(txt_ProductBuyPrice.Text));
            updt_Prod.Parameters.AddWithValue("@p5", decimal.Parse(txt_ProductSellPrice.Text));
            updt_Prod.Parameters.AddWithValue("@p6", txt_ProductStock.Text.ToUpper());
            updt_Prod.Parameters.AddWithValue("@p7", cmb_ProductStatus.Text.ToUpper());
            updt_Prod.Parameters.AddWithValue("@p8", txt_ProductID.Text);
            updt_Prod.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla güncellendi.");
            Listele();
        }
    }
}
