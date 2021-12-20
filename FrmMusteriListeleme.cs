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
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        
        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.Turquoise;
            //this.BackColor = Color.Turquoise;

            KayitGoster();
        }

        private void KayitGoster()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from MusteriEkleme", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MskTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MskTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update MusteriEkleme set   MusteriAd=@p1,MusteriSoyad=@p2,MusteriTelefon=@p3 where MusteriTC=@p4",bgl.baglanti());
            bgl.baglanti().Close();

            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            
            MessageBox.Show("Müşteri Bilgileri Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from MusteriEkleme where MusteriTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TxtmaAr_TextChanged(object sender, EventArgs e)
        {
         
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from MusteriEkleme where MusteriTC like '%" + TxtmaAr.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
