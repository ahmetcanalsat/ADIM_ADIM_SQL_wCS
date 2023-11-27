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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        // Baglanti adında oluşturduğumuz değişken sql ile bağlantı kuracağımız durumlarda baglanti yazarak ulaşabilmemizi sağlar.


        // Aşağıda Listele() paragrafı ile metot oluşturduk. Listeleme işlemlerinde bu metodu çağırmamız yeterli olacak sürekli yazmak zorunda kalmıyacağız.
        void Listele()
        {
            SqlCommand list_Customer = new SqlCommand("SELECT * FROM TBLMUSTERI",baglanti);
            SqlDataAdapter da= new SqlDataAdapter(list_Customer);
            DataTable dt= new DataTable();  
            da.Fill(dt);
            dataGridView1.DataSource=dt;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_CustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_CustomerSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_CustomerCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_CustomerWallet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
