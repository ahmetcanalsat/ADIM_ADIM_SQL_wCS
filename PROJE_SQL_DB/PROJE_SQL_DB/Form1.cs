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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            frmCategories frm_cat = new frmCategories(); // frmCategories isimli formumuzu çağırabilmek için form1 içinde fr ismiyle tanımladık.
            frm_cat.Show(); // fr isimli değişkeni göstertmek için kullanılır.
            
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            frmCustomer frm_cust = new frmCustomer();
            frm_cust.Show();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // ÜRÜNLERİN DURUM SEVİYESİ
            SqlCommand kritikSeviye = new SqlCommand("EXECUTE TEST4",baglanti);
            SqlDataAdapter da=new SqlDataAdapter(kritikSeviye);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // GRAFİĞE VERİ ÇEKME İŞLEMİ
            //chart1.Series["Akdeniz"].Points.AddXY("Adana", 24);
            //chart1.Series["Akdeniz"].Points.AddXY("Isparta", 21);
            baglanti.Open();
            SqlCommand grafikVeri = new SqlCommand("SELECT KATEGORIAD,COUNT(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID=TBLURUNLER.KATEGORI GROUP BY KATEGORIAD", baglanti);
            SqlDataReader dr = grafikVeri.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Kategoriler"].Points.AddXY(dr[0], dr[1]);
                /* dr[0] yukarıdaki komutta KATEGORIAD sütununu verir, dr[1] ise kategoride kaç değer olduğunu verir. */
            }
            baglanti.Close();
            // Yukarıdaki kod bloğumuz kategoriler tablosunda her kategori isminden kaç tane veri olduğunu yazdırır.

            
            
            
            // GRAFİĞE VERİ ÇEKME İŞLEMİ 2
            baglanti.Open();
            SqlCommand grafikVeri2 = new SqlCommand("SELECT MUSTERISEHIR, COUNT(*) FROM TBLMUSTERI GROUP BY MUSTERISEHIR", baglanti);
            SqlDataReader dr2 = grafikVeri2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Şehirler"].Points.AddXY(dr2[0], dr2[1]);
                /* dr[0] yukarıdaki komutta MUSTERISEHIR sütununu verir, dr[1] ise her şehirde kaç müşteri olduğunu verir. */
            }
            baglanti.Close();
            // Yukarıdaki kod bloğumuz müşteri tablosundaki değerlere göre her şehirde kaç müşteri olduğunu grafiğe aktarır.

        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            frmProduct frm_prod = new frmProduct();
            frm_prod.Show();
        }
    }
}
