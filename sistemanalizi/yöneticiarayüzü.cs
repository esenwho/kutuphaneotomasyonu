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
    public partial class yöneticiarayüzü : Form
    {
        public yöneticiarayüzü()
        {
            InitializeComponent();
        }
        

        private void yöneticikayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yönetici geridon = new yönetici();
            if(button1.Text==Localization_EN.label18)
            {
                geridon.label1.Text = Localization_EN.label3;
                geridon.label2.Text = Localization_EN.label4;
                geridon.button1.Text = Localization_EN.button17;
                geridon.Show();
                this.Hide();
            }
            else
            {
                geridon.Show();
                this.Hide();
            }
            
        }
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;
        private void button1_Click(object sender, EventArgs e)
        {
            cykayit ckayitformu=new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                ckayitformu.label5.Text = Localization_EN.label3;
                ckayitformu.label1.Text = Localization_EN.label5;
                ckayitformu.label2.Text = Localization_EN.label6;
                ckayitformu.label3.Text=Localization_EN.label7;
                ckayitformu.label6.Text = Localization_EN.label4;
                ckayitformu.label7.Text = Localization_EN.label21;
                ckayitformu.button2.Text = Localization_EN.label18;
                ckayitformu.Show();
                this.Hide();
            }
            else
            {
                ckayitformu.label7.Text = Localization_TR.label17;
                ckayitformu.button2.Text = Localization_TR.label18;
                ckayitformu.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cykayit csilmeformu = new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                csilmeformu.label5.Text = Localization_EN.label3;
                csilmeformu.label1.Text = Localization_EN.label5;
                csilmeformu.label2.Text = Localization_EN.label6;
                csilmeformu.label3.Text = Localization_EN.label7;
                csilmeformu.label6.Text = Localization_EN.label4;
                csilmeformu.label7.Text = Localization_EN.label21;
                csilmeformu.button2.Text = Localization_EN.label19;
                csilmeformu.Show();
                this.Hide();
            }
            else
            {
                csilmeformu.label7.Text = Localization_TR.label17;
                csilmeformu.button2.Text = Localization_TR.label19;
                csilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cykayit cguncelformu = new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                cguncelformu.label5.Text = Localization_EN.label3;
                cguncelformu.label1.Text = Localization_EN.label5;
                cguncelformu.label2.Text = Localization_EN.label6;
                cguncelformu.label3.Text = Localization_EN.label7;
                cguncelformu.label6.Text = Localization_EN.label4;
                cguncelformu.label7.Text = Localization_EN.label21;
                cguncelformu.button2.Text = Localization_EN.label20;
                cguncelformu.Show();
                this.Hide();
            }
            else
            {
                cguncelformu.label7.Text = Localization_TR.label17;
                cguncelformu.button2.Text = Localization_TR.label20;
                cguncelformu.Show();
                this.Hide();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cykayit ykayitformu = new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                ykayitformu.label5.Text = Localization_EN.label3;
                ykayitformu.label1.Text = Localization_EN.label5;
                ykayitformu.label2.Text = Localization_EN.label6;
                ykayitformu.label3.Text = Localization_EN.label7;
                ykayitformu.label6.Text = Localization_EN.label4;
                ykayitformu.label7.Text = Localization_EN.label22;
                ykayitformu.button2.Text = Localization_EN.label18;
                ykayitformu.Show();
                this.Hide();
            }
            else
            {
                ykayitformu.label7.Text = Localization_TR.label21;
                ykayitformu.button2.Text = Localization_TR.label18;
                ykayitformu.Show();
                this.Hide();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cykayit ysilmeformu = new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                ysilmeformu.label5.Text = Localization_EN.label3;
                ysilmeformu.label1.Text = Localization_EN.label5;
                ysilmeformu.label2.Text = Localization_EN.label6;
                ysilmeformu.label3.Text = Localization_EN.label7;
                ysilmeformu.label6.Text = Localization_EN.label4;
                ysilmeformu.label7.Text = Localization_EN.label22;
                ysilmeformu.button2.Text = Localization_EN.label19;
                ysilmeformu.Show();
                this.Hide();
            }
            else
            {
                ysilmeformu.label7.Text = Localization_TR.label21;
                ysilmeformu.button2.Text = Localization_TR.label19;
                ysilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cykayit yguncelformu = new cykayit();
            if(button1.Text==Localization_EN.label18)
            {
                yguncelformu.label5.Text = Localization_EN.label3;
                yguncelformu.label1.Text = Localization_EN.label5;
                yguncelformu.label2.Text = Localization_EN.label6;
                yguncelformu.label3.Text = Localization_EN.label7;
                yguncelformu.label6.Text = Localization_EN.label4;
                yguncelformu.label7.Text = Localization_EN.label22;
                yguncelformu.button2.Text = Localization_EN.label20;
                yguncelformu.Show();
                this.Hide();
            }
            else
            {
                yguncelformu.label7.Text = Localization_TR.label21;
                yguncelformu.button2.Text = Localization_TR.label20;
                yguncelformu.Show();
                this.Hide();
            }
            
        }
    }
}
