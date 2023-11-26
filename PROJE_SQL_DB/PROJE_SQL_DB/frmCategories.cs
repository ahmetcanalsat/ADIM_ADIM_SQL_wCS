using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE_SQL_DB
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        // Baglanti adında oluşturduğumuz değişken sql ile bağlantı kuracağımız durumlarda baglanti yazarak ulaşabilmemizi sağlar.
        private void btn_List_Click(object sender, EventArgs e)
        {
            SqlCommand listele_komut=new SqlCommand("SELECT * FROM TBLKATEGORI",baglanti); // SQL SORGUMUZU YAZABİLMEK İÇİN KULLANILIR
            // ("....",baglantı) ile hangi adresten veriyi çekeceğimizi belirtiriz.
            SqlDataAdapter da=new SqlDataAdapter(listele_komut); // Verileri bellek tarafına bağlamak için kullanılır
            DataTable dt = new DataTable(); // dt isimli bir veri tablosu oluşturduk.
            da.Fill(dt); // da isimli dataadapter'i dt isimli tablolar ile doldur.
            dataGridView1.DataSource = dt; // dataGridView1 isimli veri kaynağını dt den gelen değerler ile dolduruyoruz.
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // SQL tarafına erişimi açar.
            SqlCommand kaydet_komut = new SqlCommand("INSERT INTO TBLKATEGORI (KATEGORIAD) VALUES (@p1)",baglanti); // parametre1 den gelen değeri kategoriad olarak tablomuza ekler.
            kaydet_komut.Parameters.AddWithValue("@p1", txt_CatName.Text); // komut2'nin parametresi txt_CatName isimli txtbox'ın text değeri olmasını sağlar.
            kaydet_komut.ExecuteNonQuery(); // Sorguyu çalıştırıp sorgudaki değişiklikleri veritabanına yansıtmak için kullanılır.
            baglanti.Close();
            MessageBox.Show("Kategori başarıyla kaydedildi");
            /* Yukarıdaki satırları kullanarak formumuz üzerinden veritabanına bir adet kategori kaydedebiliriz. */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CatID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();// datagrid içindeki hücrelerden 0 nolu hücredeki(ID değerleri tutulan hücre) değeri string olarak yazdırmamıza yarar.  
            txt_CatName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();// 1 nolu hücredeki değeri string olarak yazdırır.
            /* Yukarıdaki kodlarımız ile listelediğimiz vt'den gelen değerlere tıkladığımızda textboxlara aktarır. */
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil_komut = new SqlCommand("DELETE FROM TBLKATEGORI WHERE KATEGORIID=@p1",baglanti);
            sil_komut.Parameters.AddWithValue("@p1", txt_CatID.Text);
            sil_komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçilen kategori başarıyla silindi.");
            /* Yukarıdaki komutlarımız ile kategoriler tablomuzdan istediğimiz verimizi silebiliyoruz */

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle_komut = new SqlCommand("UPDATE TBLKATEGORI SET KATEGORIAD=@p1 WHERE KATEGORIID=@p2",baglanti);
            guncelle_komut.Parameters.AddWithValue("@p1", txt_CatName.Text);
            guncelle_komut.Parameters.AddWithValue("@p2", txt_CatID.Text);
            guncelle_komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarıyla gerçekleşti.");
            /* Yukarıdaki komutlarımız ile kategoriler tablomuzdaki herhangi bir verimizi güncelleyebiliriz. */

        }
    }
}