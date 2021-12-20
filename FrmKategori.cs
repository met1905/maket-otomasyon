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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        bool durum;
        private void kategoriengelle()
        {
            durum = true;
            SqlCommand komuyt = new SqlCommand("select * from TblKategori", bgl.baglanti());
            SqlDataReader da = komuyt.ExecuteReader();
            while (da.Read())
            {
                if (textBox10.Text==da["Kategori"].ToString() || textBox10.Text=="")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into  TblKategori (kategori) values('" + textBox10.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
              
                MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox10.Text = "";
        }
           
      
        }

      

        }
    

