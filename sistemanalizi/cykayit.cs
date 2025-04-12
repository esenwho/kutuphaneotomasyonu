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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemanalizi
{
    public partial class cykayit : Form
    {
        public cykayit()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yöneticiarayüzü geridon = new yöneticiarayüzü();
            if(button2.Text==Localization_EN.label18 || button2.Text == Localization_EN.label19 || button2.Text == Localization_EN.label20)
            {
                geridon.groupBox1.Text = Localization_EN.label21;
                geridon.groupBox2.Text = Localization_EN.label22;
                geridon.button1.Text = Localization_EN.label18;
                geridon.button8.Text = Localization_EN.label18;
                geridon.button2.Text = Localization_EN.label19;
                geridon.button7.Text = Localization_EN.label19;
                geridon.button5.Text = Localization_EN.label20;
                geridon.button6.Text = Localization_EN.label20;
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
        SqlDataAdapter adapter;
        void calisangetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select calisanID AS [ÇALIŞAN ID], calisanadi AS [AD], calisansoyadi AS [SOYAD], calisanmail AS [MAİL],calisantel AS [TELEFON NO],calisansifre AS [ŞİFRE] From calisan", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void workercome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select calisanID AS [WORKER ID], calisanadi AS [NAME], calisansoyadi AS [SURNAME], calisanmail AS [MAİL],calisantel AS [TELEPHONE],calisansifre AS [PASSWORD] From calisan", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void yoneticigetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select yoneticiID AS [YÖNETİCİ ID], yoneticiadi AS [AD], yoneticisoyadi AS [SOYAD], yoneticimail AS [MAİL],yoneticitel AS [TELEFON NO],yoneticisifre AS [ŞİFRE] From yonetici", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void admincome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select yoneticiID AS [ADMIN ID], yoneticiadi AS [NAME], yoneticisoyadi AS [SURNAME], yoneticimail AS [MAİL],yoneticitel AS [TELEPHONE],yoneticisifre AS [PASSWORD] From yonetici", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label7.Text == Localization_TR.label17 && button2.Text == Localization_TR.label18)
            {
                string sorgu = "insert into calisan(calisanID,calisanadi,calisansoyadi,calisanmail,calisantel,calisansifre) values(@a,@b,@c,@d,@e,@f)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {

                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
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
                    calisangetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Oluşturuldu!");
                    


                }
            }
            else if (label7.Text == Localization_TR.label17 && button2.Text == Localization_TR.label19)
            {
                string sorgu = "delete from calisan where calisanID=@a";
                if (textBox1.Text == "")
                {
                    
                        MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text);
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    calisangetir();
                    Temizle();
                    
                        MessageBox.Show("Kaydınız Başarıyla Silindi!");
                    


                }
            }
            else if (label7.Text == Localization_TR.label17 && button2.Text == Localization_TR.label20)
            {
                string sorgu = "update calisan set calisanadi=@b,calisansoyadi=@c,calisanmail=@d,calisantel=@e,calisansifre=@f where calisanID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    calisangetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
                }
            }
            else if (label7.Text == Localization_TR.label21 && button2.Text == Localization_TR.label18)
            {
                string sorgu = "insert into yonetici(yoneticiID,yoneticiadi,yoneticisoyadi,yoneticimail,yoneticitel,yoneticisifre) values(@a,@b,@c,@d,@e,@f)";

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Oluşturuldu!");

                }
            }
            else if (label7.Text == Localization_TR.label21 && button2.Text == Localization_TR.label19)
            {
                string sorgu = "delete from yonetici where yoneticiID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");

                }
            }
            else if (label7.Text == Localization_TR.label21 && button2.Text == Localization_TR.label20)
            {
                string sorgu = "update yonetici set yoneticiadi=@b,yoneticisoyadi=@c,yoneticimail=@d,yoneticitel=@e,yoneticisifre=@f where yoneticiID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
                }
            }
            else if (label7.Text == Localization_EN.label21 && button2.Text == Localization_EN.label18)
            {
                string sorgu = "insert into calisan(calisanID,calisanadi,calisansoyadi,calisanmail,calisantel,calisansifre) values(@a,@b,@c,@d,@e,@f)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {

                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
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
                    calisangetir();
                    Temizle();
                    MessageBox.Show("Your registration has been created successfully!");



                }

            }
            else if (label7.Text == Localization_EN.label21 && button2.Text == Localization_EN.label19)
            {
                string sorgu = "delete from calisan where calisanID=@a";
                if (textBox1.Text == "")
                {

                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text);
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    calisangetir();
                    Temizle();
                    MessageBox.Show("Your Registration Has Been Successfully Deleted!");



                }

            }
            else if (label7.Text == Localization_EN.label21 && button2.Text == Localization_EN.label20)
            {
                string sorgu = "update calisan set calisanadi=@b,calisansoyadi=@c,calisanmail=@d,calisantel=@e,calisansifre=@f where calisanID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    calisangetir();
                    Temizle();
                    MessageBox.Show("Your Registration Has Been Updated Successfully!");
                }

            }
            else if (label7.Text == Localization_EN.label22 && button2.Text == Localization_EN.label18)
            {
                string sorgu = "insert into yonetici(yoneticiID,yoneticiadi,yoneticisoyadi,yoneticimail,yoneticitel,yoneticisifre) values(@a,@b,@c,@d,@e,@f)";

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {
                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Your registration has been created successfully!");

                }
            }
            else if (label7.Text == Localization_EN.label22 && button2.Text == Localization_EN.label19)
            {

                string sorgu = "delete from yonetici where yoneticiID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Your Registration Has Been Successfully Deleted!");

                }
            }
            else if (label7.Text == Localization_EN.label22 && button2.Text == Localization_EN.label20)
            {

                string sorgu = "update yonetici set yoneticiadi=@b,yoneticisoyadi=@c,yoneticimail=@d,yoneticitel=@e,yoneticisifre=@f where yoneticiID=@a";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You entered incorrect information.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    yoneticigetir();
                    Temizle();
                    MessageBox.Show("Your Registration Has Been Updated Successfully!");
                }
            }
        }

        private void cykayit_Load(object sender, EventArgs e)
        {
            if (label7.Text==Localization_TR.label17)
            {
                calisangetir();
            }
            if (label7.Text==Localization_TR.label21)
            {
                yoneticigetir();
            }
            if (label7.Text == Localization_EN.label21)
            {
                workercome();
            }
            if (label7.Text == Localization_EN.label22)
            {
                admincome();
            }

            textBox1.MaxLength = 11;
            textBox5.MaxLength = 11;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
