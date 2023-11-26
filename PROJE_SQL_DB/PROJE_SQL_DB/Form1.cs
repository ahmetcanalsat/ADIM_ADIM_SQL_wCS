using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmCategories fr = new frmCategories(); // frmCategories isimli formumuzu çağırabilmek için form1 içinde fr ismiyle tanımladık.
            fr.Show(); // fr isimli değişkeni göstertmek için kullanılır.
            
        }
    }
}
