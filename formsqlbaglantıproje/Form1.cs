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

namespace formsqlbaglantıproje
{
    public partial class formsqlproje : Form
    {
        public formsqlproje()
        {
            InitializeComponent();
        }




        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OG60RR8;Initial Catalog=kutuphane;Integrated Security=True");

        public void Listele()
        {
            Veriler("select *from yazar");
        }
        public void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }

            }
        }
        public void Veriler(string veriler)
        {
            SqlDataAdapter sda = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void verigtrbutton_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void kydtbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into yazar values(@y_adi,@y_soyadi)", baglanti);

          
            komut.Parameters.AddWithValue("@y_adi", yzraditextbox.Text);
            komut.Parameters.AddWithValue("@y_soyadi", yzrsyditextbox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            Temizle();
        }

        private void cikisbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            SqlCommand kmt = new SqlCommand("delete from yazar where yazarno=@y_no" , baglanti);
            kmt.Parameters.AddWithValue("@y_no", yzrNoTextboX.Text);


            kmt.ExecuteNonQuery();
            baglanti.Close();

            Temizle();
            Listele();



        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            yzrNoTextboX.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            yzraditextbox.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            yzrsyditextbox.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();


        }



        private void güncellebutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kmt = new SqlCommand("update yazar set yazarad=@y_adi, yazarsoyad=@y_soyadi where yazarno=@y_no", baglanti);
            kmt.Parameters.AddWithValue("@y_no",yzrNoTextboX.Text);
            kmt.Parameters.AddWithValue("@y_adi", yzraditextbox.Text);
            kmt.Parameters.AddWithValue("@y_soyadi", yzrsyditextbox.Text);
            
           
           
            kmt.ExecuteNonQuery();

            baglanti.Close();

            Temizle();
            Listele();
        }

      
    }
} 
