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
    public partial class FrmUrunisteleme : Form
    {
        public FrmUrunisteleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmUrunisteleme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblUrun ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
             barkod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Kategori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            miktar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            alis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            satis.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnvarolan_Click(object sender, EventArgs e)
        {
            if (barkod.Text!="")
            {
                
                SqlCommand komut = new SqlCommand("update Tblurun set Urunad=@p1,UrunMiktar=@p2,UrunAlis=@p3,UrunSatis=@p4,UrunKategori=@p5,UrunMarka=@p6  where BarkodNo=@p7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", ad.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(miktar.Text));
                komut.Parameters.AddWithValue("@p3",Convert.ToDecimal( alis.Text));
                komut.Parameters.AddWithValue("@p4",Convert.ToDecimal( satis.Text));
               komut.Parameters.AddWithValue("@p5", Kategori.Text);
                komut.Parameters.AddWithValue("@p6", Marka.Text);
                komut.Parameters.AddWithValue("@p7", barkod.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Product Information Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Barkod Number is Not Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marka.Items.Clear();
            Marka.Text = "";
            SqlCommand komut = new SqlCommand("select * from TblMarka Where Kategori= '" + Kategori.SelectedItem + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Marka.Items.Add(dr["Kategori"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblUrun where BarkodNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", barkod.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblUrun where BarkodNo like '%" + textBox1.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
