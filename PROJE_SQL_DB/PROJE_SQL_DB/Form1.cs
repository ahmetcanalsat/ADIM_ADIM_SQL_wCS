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
            
        }
    }
}
