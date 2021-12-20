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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        bool durum;
        private void markaengelle()
        {
            durum = true;
            SqlCommand komuyt = new SqlCommand("select * from TblMarka", bgl.baglanti());
            SqlDataReader da = komuyt.ExecuteReader();
            while (da.Read())
            {
                if (CmbKategori.Text==da["kategori"].ToString() && TxtMarka.Text == da["Marka"].ToString() || CmbKategori.Text=="" || TxtMarka.Text == "")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            markaengelle();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into  TblMarka (kategori,marka) values('" + CmbKategori.Text + "','" + TxtMarka.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori ve Marka mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TxtMarka.Text = "";
            CmbKategori.Text = "";
           
        }

        private void FrmMarka_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblKategori", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbKategori.Items.Add(dr["Kategori"].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
