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
    public partial class FrmSatisSayfasi : Form
    {
        public FrmSatisSayfasi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblSepet", bgl.baglanti());
            da.Fill(daset,"tblsepet");
            dataGridView1.DataSource = daset.Tables["TblSepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            bgl.baglanti().Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FrmMusteriEkleme fr = new FrmMusteriEkleme();
            fr.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme fr = new FrmMusteriListeleme();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmMarka fr = new FrmMarka();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmKategori fr = new FrmKategori();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunisteleme fr = new FrmUrunisteleme();
            fr.Show();
        }
        private void hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("select sum (toplamfiyat) from tblsepet ", bgl.baglanti());
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }

        }
        private void FrmSatisSayfasi_Load(object sender, EventArgs e)
        {
            sepetlistele();

         
        }

      

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text=="")
            {
                foreach (Control item in groupBox2.Controls)
                {

                    if (item is TextBox)
                    {
                        if (item!=txtmiktar)
                        {
                            item.Text="";
                        }
                    }
                    
                }
            }
            SqlCommand komut = new SqlCommand("select * from TblUrun where BarkodNo like '" + textBox6.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunad.Text = dr[3].ToString();
                txtsatis.Text = dr[6].ToString();
               
            }
            bgl.baglanti().Close();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (MskTC.Text == "")
            {
                txtad.Text = "";
                txtsoyad.Text = "";
                msktelefon.Text = "";
            }
            SqlCommand komut = new SqlCommand("select * from MusteriEkleme  where MusteriTC like '" + MskTC.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[2].ToString();
                txtsoyad.Text = dr[3].ToString();
                msktelefon.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }
        bool durum;
        
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from tblsepet", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (textBox6.Text==dr["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into  TblSepet (TC,BarkodNo,SepetAd,SepetSoyad,SepetUrunAd,SepetMiktar,SatisFiyati,ToplamFiyat,SepetTarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.Parameters.AddWithValue("@p2", textBox6.Text);
                komut.Parameters.AddWithValue("@p3", txtad.Text);
                komut.Parameters.AddWithValue("@p4", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p5", txturunad.Text);
                komut.Parameters.AddWithValue("@p6", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@p7", double.Parse(txtsatis.Text));
                komut.Parameters.AddWithValue("@p8", double.Parse(txttoplam.Text));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("sepete eklendi");
             
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update tblsepet set  sepetmiktar = sepetmiktar+'"+int.Parse(txtmiktar.Text)+ "' where barkodno='" + textBox6.Text + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update tblsepet set  toplamfiyat=sepetmiktar*satisfiyati where barkodno='"+textBox6.Text+"'", bgl.baglanti());

                komut3.ExecuteNonQuery();

                MessageBox.Show("sepete eklendi");
            }
            daset.Tables["tblsepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {

                if (item is TextBox)
                {
                    if (item != txtmiktar)
                    {
                        item.Text = "";
                    }
                }

            }
            bgl.baglanti().Close();





        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplam.Text =( double.Parse(txtmiktar.Text) * double.Parse(txtsatis.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtsatis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplam.Text = (double.Parse(txtmiktar.Text) * double.Parse(txtsatis.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tblsepet where barkodno='"+dataGridView1.CurrentRow.Cells[1].Value.ToString()+"'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün silindi");
            daset.Tables["tblsepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tblsepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün silindi");
            daset.Tables["tblsepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSatisListele fr = new FrmSatisListele();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                SqlCommand komut = new SqlCommand("insert into  TblSatis (TC,BarkodNo,SepetAd,SepetSoyad,SepetUrunAd,SepetMiktar,SatisFiyati,ToplamFiyat,SepetTarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.Parameters.AddWithValue("@p2",dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@p3",txtad.Text );
                komut.Parameters.AddWithValue("@p4", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells[5].Value.ToString());
                komut.Parameters.AddWithValue("@p6", int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                komut.Parameters.AddWithValue("@p7", double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()));
                komut.Parameters.AddWithValue("@p8", double.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update TblUrun set UrunMiktar=UrunMiktar-'" + int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) + "' where BarkodNo='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            SqlCommand komut3 = new SqlCommand("delete from tblsepet ", bgl.baglanti());
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["tblsepet"].Clear();
            sepetlistele();
            hesapla();
        }

       
    }
}
