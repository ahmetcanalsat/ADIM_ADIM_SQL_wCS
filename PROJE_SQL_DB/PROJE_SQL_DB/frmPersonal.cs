using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_SQL_DB
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        // Baglanti adında oluşturduğumuz değişken sql ile bağlantı kuracağımız durumlarda baglanti yazarak ulaşabilmemizi sağlar.


        // Aşağıda Listele() paragrafı ile metot oluşturduk. Listeleme işlemlerinde bu metodu çağırmamız yeterli olacak sürekli yazmak zorunda kalmıyacağız.
        void Listele()
        {
            SqlCommand list_Personal = new SqlCommand("SELECT * FROM TBLPERSONEL", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(list_Personal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_PersonalID.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_PersonalFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand srch_Personal = new SqlCommand("SELECT * FROM TBLPERSONEL WHERE PERSONELADSOYAD LIKE('%' + @p1 + '%')", baglanti);
            srch_Personal.Parameters.AddWithValue("@p1", txt_PersonalFullName.Text.ToUpper());
            SqlDataAdapter da= new SqlDataAdapter(srch_Personal);
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
            baglanti.Open();
            SqlCommand save_Pers = new SqlCommand("INSERT INTO TBLPERSONEL (PERSONELADSOYAD) VALUES (@p1)", baglanti);
            save_Pers.Parameters.AddWithValue("@p1", txt_PersonalFullName.Text.ToUpper());
            save_Pers.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel başarıyla kaydedildi.");
            Listele();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand del_Pers = new SqlCommand("DELETE FROM TBLPERSONEL WHERE PERSONELID=@p1", baglanti);
            del_Pers.Parameters.AddWithValue("@p1", txt_PersonalID.Text);
            del_Pers.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel başarıyla silindi.");
            Listele();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand updt_Pers = new SqlCommand("UPDATE TBLPERSONEL SET PERSONELADSOYAD=@p1 WHERE PERSONELID=@p2", baglanti);
            updt_Pers.Parameters.AddWithValue("@p1", txt_PersonalFullName.Text.ToUpper());
            updt_Pers.Parameters.AddWithValue("@p2", txt_PersonalID.Text);
            updt_Pers.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel başarıyla güncellendi.");
            Listele();
        }
    }
}
