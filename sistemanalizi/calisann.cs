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
    public partial class calisann : Form
    {
        public calisann()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from calisan where calisanID=@a and calisansifre=@b";
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
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    calisanarayüzü k = new calisanarayüzü();
                    if(button1.Text==Localization_EN.button17)
                    {
                        k.groupBox1.Text = Localization_EN.label9;
                        k.groupBox2.Text = Localization_EN.label12;
                        k.groupBox3.Text = Localization_EN.label11;
                        k.groupBox4.Text = Localization_EN.label13;
                        k.groupBox5.Text = Localization_EN.label10;
                        k.button1.Text = Localization_EN.label14;
                        k.button2.Text = Localization_EN.label15;
                        k.button3.Text = Localization_EN.label16;
                        k.button12.Text = Localization_EN.label14;
                        k.button11.Text = Localization_EN.label15;
                        k.button10.Text = Localization_EN.label16;
                        k.button5.Text = Localization_EN.label14;
                        k.button13.Text = Localization_EN.label15;
                        k.button14.Text = Localization_EN.label16;
                        k.button8.Text = Localization_EN.label14;
                        k.button7.Text = Localization_EN.label15;
                        k.button9.Text = Localization_EN.label16;
                        k.button15.Text = Localization_EN.label14;
                        k.button4.Text = Localization_EN.label15;
                        k.button6.Text = Localization_EN.label16;
                        k.button18.Text = Localization_EN.label17;
                        k.Show();
                    }
                    else
                    {
                        k.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            giris geridon=new giris();
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

        private void calisann_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }
    }
}
