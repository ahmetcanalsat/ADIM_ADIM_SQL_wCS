using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        void Listele()
        {
            SqlCommand List_process= new SqlCommand("SELECT * FROM TBLHAREKET",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(List_process);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand srch_Process = new SqlCommand("SELECT * FROM TBLHAREKET WHERE HAREKETID=@p1", baglanti);
            srch_Process.Parameters.AddWithValue("@p1", txt_ProcessID.Text);
            SqlDataAdapter da=new SqlDataAdapter(srch_Process);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ProcessID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ProductID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_CustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_PersonalID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_QuantitySold.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_ProcessDate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Save_process = new SqlCommand("INSERT INTO TBLHAREKET (URUN,MUSTERI,PERSONEL,ADET,TUTAR,TARIH) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            Save_process.Parameters.AddWithValue("@p1", txt_ProductID.Text);
            Save_process.Parameters.AddWithValue("@p2", txt_CustomerID.Text);
            Save_process.Parameters.AddWithValue("@p3", txt_PersonalID.Text);
            Save_process.Parameters.AddWithValue("@p4", txt_QuantitySold.Text);
            Save_process.Parameters.AddWithValue("@p5", decimal.Parse(txt_Price.Text));
            Save_process.Parameters.AddWithValue("@p6", DateTime.Parse(txt_ProcessDate.Text));
            Save_process.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarıyla kaydedildi.");
            Listele();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Del_process = new SqlCommand("DELETE FROM TBLHAREKET WHERE HAREKETID=@p1", baglanti);
            Del_process.Parameters.AddWithValue("@p1", txt_ProcessID.Text);
            Del_process.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
            Listele();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand updt_Process = new SqlCommand("UPDATE TBLHAREKET SET URUN=@p1,MUSTERI=@p2,PERSONEL=@p3,ADET=@p4,TUTAR=@p5,TARIH=@p6 WHERE HAREKETID=@p7", baglanti);
            updt_Process.Parameters.AddWithValue("@p1", txt_ProductID.Text);
            updt_Process.Parameters.AddWithValue("@p2", txt_CustomerID.Text);
            updt_Process.Parameters.AddWithValue("@p3", txt_PersonalID.Text);
            updt_Process.Parameters.AddWithValue("@p4", txt_QuantitySold.Text);
            updt_Process.Parameters.AddWithValue("@p5", decimal.Parse(txt_Price.Text));
            updt_Process.Parameters.AddWithValue("@p6", DateTime.Parse(txt_ProcessDate.Text));
            updt_Process.Parameters.AddWithValue("@p7", txt_ProcessID.Text);
            updt_Process.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hareket değerleri başarıyla güncellendi.");
            Listele();
        }
    }
}
