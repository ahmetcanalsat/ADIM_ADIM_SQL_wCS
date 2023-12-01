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
    public partial class frmCase : Form
    {
        public frmCase()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9V0QTA2\MSSQL2022;Initial Catalog=SatisVT;Integrated Security=True");
        private void frmCase_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ciro_goster= new SqlCommand("SELECT * FROM TBLKASA",baglanti);
            SqlDataReader dr = ciro_goster.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = (dr["TOPLAM"].ToString());
            }
            baglanti.Close();
        }
    }
}
