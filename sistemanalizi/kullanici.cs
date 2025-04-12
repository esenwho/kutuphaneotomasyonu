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
using System.Data.Sql;
using System.Data.Entity;
using System.Globalization;
using System.Threading;

namespace sistemanalizi
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicikayit kullanicikayitformu = new kullanicikayit();
            if (label1.Text == Localization_EN.label3)
            {
                kullanicikayitformu.label5.Text = Localization_EN.label3;
                kullanicikayitformu.label1.Text = Localization_EN.label5;
                kullanicikayitformu.label2.Text= Localization_EN.label6;
                kullanicikayitformu.label3.Text = Localization_EN.label7;
                kullanicikayitformu.label6.Text = Localization_EN.label4;
                kullanicikayitformu.label7.Text = Localization_EN.label8;
                kullanicikayitformu.button2.Text=Localization_EN.button18;
                kullanicikayitformu.Show();
                this.Hide();
            }
            else
            {
                kullanicikayitformu.Show();
                this.Hide();
            }
        }
        SqlConnection db=new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from uye where uyeID=@a and uyesifre=@b";
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                if(button1.Text==Localization_EN.button17)
                {
                    MessageBox.Show("You did not enter YU or password.", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                { 
                MessageBox.Show("TC veya şifrenizi girmediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                db.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    kullaniciarayüzü k = new kullaniciarayüzü();
                    if (button1.Text == Localization_EN.button17)
                    {
                        k.label1.Text = Localization_EN.label2;
                        k.button1.Text = Localization_EN.button1;
                        k.button2.Text = Localization_EN.button2;
                        k.button3.Text = Localization_EN.button3;
                        k.button4.Text = Localization_EN.button4;
                        k.button5.Text = Localization_EN.button5;
                        k.button8.Text = Localization_EN.button11;
                        k.Show();
                        this.Hide();
                    }
                    else
                    {
                        k.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (button1.Text == Localization_EN.button17)
                    {
                        MessageBox.Show("You entered wrong YU or password.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("TC veya şifrenizi yanlış girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                db.Close();
            }
        }

        public void kullanici_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris geridon = new giris();
            if (button1.Text==Localization_EN.button17)
            {
                geridon.label1.Text = Localization_EN.label1;
                geridon.button1.Text = Localization_EN.button12;
                geridon.button2.Text = Localization_EN.button13;
                geridon.button3.Text = Localization_EN.button14;
                geridon.button5.Text = Localization_EN.button15;
                geridon.Show();
                this.Hide();
            }
            else
            {
                geridon.Show();
                this.Hide();
            }
            
        }
    }
}
