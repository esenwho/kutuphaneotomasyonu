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

namespace sistemanalizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            adapter = new SqlDataAdapter("select calisanadi AS [AD], calisansoyadi AS [SOYADI] from calisan",con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource=dt;
            con.Close();
        }
        void tablo()
        {
            con.Open();
            adapter = new SqlDataAdapter("select * from calisan", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sil = "insert into calisan(calisanID,calisanadi,calisansoyadi,calisanmail,calisantel,calisansifre) values(@a,@b,@c,@d,@e,@f)";

            cmd= new SqlCommand(sil,con);
            cmd.Parameters.AddWithValue("@a",textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@d", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@e", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@f", textBox6.Text.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            tablo();
        }
    }
}
