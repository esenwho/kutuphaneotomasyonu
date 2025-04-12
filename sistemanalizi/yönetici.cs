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
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }

        
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from yonetici where yoneticiID=@a and yoneticisifre=@b";
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                if(button1.Text==Localization_EN.button17)
                {
                    MessageBox.Show("You did not enter YU or password.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                rd=cmd.ExecuteReader();
                if (rd.Read())
                {
                    yöneticiarayüzü y = new yöneticiarayüzü();
                    if(button1.Text == Localization_EN.button17)
                    {
                        y.groupBox1.Text=Localization_EN.label21;
                        y.groupBox2.Text=Localization_EN.label22;
                        y.button1.Text = Localization_EN.label18;
                        y.button8.Text = Localization_EN.label18;
                        y.button2.Text = Localization_EN.label19;
                        y.button7.Text = Localization_EN.label19;
                        y.button5.Text= Localization_EN.label20;
                        y.button6.Text = Localization_EN.label20;
                        y.Show();
                        this.Hide();
                    }
                    else
                    {
                        y.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    if(button1.Text==Localization_EN.button17)
                    {
                        MessageBox.Show("You entered wrong YU or password.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("TC'nizi veya şifrenizi yanlış girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                db.Close();
            }
            
            
        }

        private void yönetici_Load(object sender, EventArgs e)
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
            if(button1.Text==Localization_EN.button17)
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
