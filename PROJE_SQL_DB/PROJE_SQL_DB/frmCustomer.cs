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
            SqlCommand list_Customer = new SqlCommand("SELECT * FROM TBLMUSTERI", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(list_Customer);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Listele();


            baglanti.Open();
            SqlCommand sehir_cagir = new SqlCommand("SELECT * FROM TBLSEHIR", baglanti); // Sehir tablomuzdaki verileri çağırmak için bir SQL komutu oluşturduk.
            SqlDataReader dr = sehir_cagir.ExecuteReader(); // SQL den gelen verileri okuyabilmesi için dr adında bir SQL veri okuyucu oluşturduk.
            while (dr.Read()) // birden fazla işlem yapılacağı için döngü kurduk.
            {
                cmb_CustomerCity.Items.Add(dr["SEHIRAD"]); // combobox'ın içine item olarak 'dr' değişkeninden gelen SEHIRAD verisini aktardık.
            }
            baglanti.Close();
            /* Yukarıdaki komutlar ile TBLSEHIR tablomuzdan SEHIRAD verilerini combobox'ımıza aktardık */
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
            // Yukarıdaki komutlarda datagridview1 içerisindeki bir hücreye tıkladığımızda o hücrenin verilerini ilgili textboxlara yazdırmamıza yarar.
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Save_customer = new SqlCommand("INSERT INTO TBLMUSTERI(MUSTERIAD,MUSTERISOYAD,MUSTERISEHIR,MUSTERIBAKIYE) VALUES (@p1,@p2,@p3,@p4)", baglanti);
            Save_customer.Parameters.AddWithValue("@p1", txt_CustomerName.Text.ToUpper());
            Save_customer.Parameters.AddWithValue("@p2", txt_CustomerSurname.Text.ToUpper());
            Save_customer.Parameters.AddWithValue("@p3", cmb_CustomerCity.Text.ToUpper());
            Save_customer.Parameters.AddWithValue("@p4", decimal.Parse(txt_CustomerWallet.Text.ToUpper()));
            Save_customer.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla kaydedildi.");
            Listele();
            /* Yukarıdaki kodlarımız müşteri tablosuna girilen yeni veriyi kaydetmemizi sağlamaktadır */
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Delete_customer = new SqlCommand("DELETE FROM TBLMUSTERI WHERE MUSTERIID=@p1", baglanti);
            Delete_customer.Parameters.AddWithValue("@p1", txt_CustomerID.Text);
            Delete_customer.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla silindi.");
            Listele();
            /* Yukarıdaki kodlarımız müşteri tablosundan veri silmeyi sağlamaktadır. */
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Updt_customer = new SqlCommand("UPDATE TBLMUSTERI SET MUSTERIAD=@p1,MUSTERISOYAD=@p2,MUSTERISEHIR=@p3,MUSTERIBAKIYE=@p4 WHERE MUSTERIID=@p5", baglanti);
            Updt_customer.Parameters.AddWithValue("@p1", txt_CustomerName.Text);
            Updt_customer.Parameters.AddWithValue("@p2", txt_CustomerSurname.Text);
            Updt_customer.Parameters.AddWithValue("@p3", cmb_CustomerCity.Text);
            Updt_customer.Parameters.AddWithValue("@p4", decimal.Parse(txt_CustomerWallet.Text));
            Updt_customer.Parameters.AddWithValue("@p5", txt_CustomerID.Text);
            Updt_customer.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla güncellendi");
            Listele();
            /* Yukarıdaki kodlarımız müşteri tablosunda var olan veriyi güncellememizi sağlamaktadır. */
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand Srch_customer = new SqlCommand("SELECT * FROM TBLMUSTERI WHERE MUSTERIAD LIKE ('%' +@p1+ '%')", baglanti); 
            /* Yukarıdaki SQL komutumu, içeriğinde olan harflere göre de arama yapar. Mesela M yazıp arattığımızda ad sütünunda M harfi bulunan tüm veriler listelenir. */
            Srch_customer.Parameters.AddWithValue("@p1", txt_CustomerName.Text);
            SqlDataAdapter da=new SqlDataAdapter(Srch_customer);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /* Yukarıdaki kodlarımız müşteriler tablosu içerisinde arama yapmamızı sağlar */
        }
    }
}
