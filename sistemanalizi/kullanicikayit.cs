using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemanalizi
{
    public partial class kullanicikayit : Form
    {
        public kullanicikayit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into uye(uyeID,uyeadi,uyesoyadi,uyemail,uyetel,uyesifre) values(@a,@b,@c,@d,@e,@f)";
            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                if(button2.Text==Localization_EN.button18)
                {
                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (textBox7.Text != textBox6.Text)
                {
                    if(button2.Text==Localization_EN.button18)
                    {
                        MessageBox.Show("Passwords are not the same.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Aynı Değil!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    kullanici k = new kullanici();
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@d", textBox4.Text.ToString());
                    cmd.Parameters.AddWithValue("@e", textBox5.Text.ToString());
                    cmd.Parameters.AddWithValue("@f", textBox6.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    if(button2.Text==Localization_EN.button18)
                    {
                        MessageBox.Show("Your registration has been created successfully!");
                        k.label1.Text = Localization_EN.label3;
                        k.label2.Text = Localization_EN.label4;
                        k.button1.Text = Localization_EN.button17;
                        k.button2.Text = Localization_EN.button18;
                        k.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                        k.Show();
                        this.Hide();
                    }
                   
                }
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanicikayit_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
            textBox5.MaxLength = 11;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanici geridon = new kullanici();
            if (button2.Text == Localization_EN.button18)
            {
                geridon.label1.Text = Localization_EN.label3;
                geridon.label2.Text = Localization_EN.label4;
                geridon.button1.Text = Localization_EN.button17;
                geridon.button2.Text = Localization_EN.button18;
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
