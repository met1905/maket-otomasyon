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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from TblUrun", bgl.baglanti());
            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                if (txtbarkodno.Text==da["BarkodNo"].ToString()  || txtbarkodno.Text=="")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblKategori", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbkategori.Items.Add(dr["Kategori"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMarka.Items.Clear();
            CmbMarka.Text = "";
            SqlCommand komut = new SqlCommand("select * from TblMarka Where Kategori= '"+cmbkategori.SelectedItem +"'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbMarka.Items.Add(dr["Marka"].ToString());
            }
            bgl.baglanti().Close();
        }
        
        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into TblUrun(BarkodNo,UrunKategori,UrunMarka,UrunAd,UrunMiktar,UrunAlis,UrunSatis,UrunTarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@p2", cmbkategori.Text);
                komut.Parameters.AddWithValue("@p3", CmbMarka.Text);
                komut.Parameters.AddWithValue("@p4", txtad.Text);
                komut.Parameters.AddWithValue("@p5", txtmiktar.Text);
                komut.Parameters.AddWithValue("@p6", txtalis.Text);
                komut.Parameters.AddWithValue("@p7", txtsatis.Text);
                komut.Parameters.AddWithValue("@p8", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Barkod numarası mevcut","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
            CmbMarka.Items.Clear();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                 if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void barkod_TextChanged(object sender, EventArgs e)
        {
            if (barkod.Text=="")
            {
                LblMiktar.Text = "";
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
          
            SqlCommand komut = new SqlCommand("select * from TblUrun where BarkodNo like '" + barkod.Text + "'", bgl.baglanti());
            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                kategori.Text = da[1].ToString();
                marka.Text = da[2].ToString();
                ad.Text = da[3].ToString();
                LblMiktar.Text = da[4].ToString();
                alis.Text = da[5].ToString();
                satis.Text = da[6].ToString();

            }
            bgl.baglanti().Close();

        }

        private void btnvarolan_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblUrun set UrunMiktar=UrunMiktar+'" +miktar.Text + "' where BarkodNo='" + barkod.Text + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Ürün Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

      
    }
}
