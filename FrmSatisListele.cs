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

namespace MarketOtomasyon
{
    public partial class FrmSatisListele : Form
    {
        public FrmSatisListele()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet daset = new DataSet();
        private void satislistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblSatis", bgl.baglanti());
            da.Fill(daset, "tblsatis");
            dataGridView1.DataSource = daset.Tables["TblSatis"];
           
            bgl.baglanti().Close();
        }
        private void FrmSatisListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }
    }
}
