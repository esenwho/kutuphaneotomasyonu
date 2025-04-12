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
    public partial class tablogetir : Form
    {
        public tablogetir()
        {
            InitializeComponent();
        }

        private void tablogetir_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        void konumgetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select yerID AS [YER ID], blok AS [BLOK], raf AS [RAF] From konum", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void locationcome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select yerID AS [LOCATION ID], blok AS [BLOCk], raf AS [SHELF] From konum", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        void kitapgetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }

        void dergigetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void uyegetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b=textBox2.Text;
            string c=textBox3.Text;
            if (button1.Text==Localization_EN.label66)
            {
                if (label1.Text == "Location ID :")
                {
                    string sql = "insert into konum(yerID, blok , raf) values(@a,@b,@c)";
                    cmd = new SqlCommand(sql, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    locationcome();
                    Temizle();
                    MessageBox.Show("Your registration has been created successfully!");
                }
                else if (label1.Text == "Name :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("You entered incorrect information.");
                            }
                            else
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyetel='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyesoyadi='" + b + "' and uyetel='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyesoyadi='" + b + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyeadi='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyeadi='" + a + "' and  uyetel='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyeadi='" + a + "' and uyesoyadi='" + b + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye where uyeadi='" + a + "' and uyesoyadi='" + b + "' and uyeadi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }

                    }
                }
                else if (label1.Text == "ISBN :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("You entered incorrect information.");
                            }
                            else
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where kitapadi='" + b + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where kitapadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where ISBN='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where ISBN='" + a + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where ISBN='" + a + "' and kitapadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap where ISBN='" + a + "' and kitapadi='" + b + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }

                }
                else if (label1.Text == "ISNN :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("You entered incorrect information.");
                            }
                            else
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where dergiadi='" + b + "' and dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where dergiadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where ISNN='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where ISNN='" + a + "' and dergibasligi='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where ISNN='" + a + "' and dergiadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi where ISNN='" + a + "' and dergiadi='" + b + "' and dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                }
            }
            else
            {
                if (label1.Text == "Yer ID :")
                {
                    string sql = "insert into konum(yerID, blok , raf) values(@a,@b,@c)";
                    cmd = new SqlCommand(sql, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    konumgetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
                else if (label1.Text == "Adı :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("Eksik bilgi girdiniz.");
                            }
                            else
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyetel='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyesoyadi='" + b + "' and uyetel='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyesoyadi='" + b + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyeadi='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyeadi='" + a + "' and  uyetel='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyeadi='" + a + "' and uyesoyadi='" + b + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye where uyeadi='" + a + "' and uyesoyadi='" + b + "' and uyeadi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }

                    }
                }
                else if (label1.Text == "ISBN :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("Eksik bilgi girdiniz.");
                            }
                            else
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where kitapadi='" + b + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where kitapadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where ISBN='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where ISBN='" + a + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where ISBN='" + a + "' and kitapadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap where ISBN='" + a + "' and kitapadi='" + b + "' and kitapyazari='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }

                }
                else if (label1.Text == "ISNN :")
                {
                    if (textBox1.Text == "")
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("Eksik bilgi girdiniz.");
                            }
                            else
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where dergiadi='" + b + "' and dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where dergiadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where ISNN='" + a + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where ISNN='" + a + "' and dergibasligi='" + c + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where ISNN='" + a + "' and dergiadi='" + b + "'";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                string sql = "select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi where ISNN='" + a + "' and dergiadi='" + b + "' and dergibasligi='" + c + "' ";
                                adapter = new SqlDataAdapter(sql, db);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from konum where yerID=@a";
            cmd = new SqlCommand(sorgu,db);
            cmd.Parameters.AddWithValue("@a",textBox1.Text.ToString());
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
            konumgetir();
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "update konum set blok=@a,raf=@b where yerID=@c";
            cmd=new SqlCommand(sorgu,db);
            cmd.Parameters.AddWithValue("@c",textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@a", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("b", textBox3.Text.ToString());
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
            konumgetir();
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label1.Text == "Yer ID :")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else if (label1.Text == "ISBN :" && label1.Text == "ISNN :" && label1.Text=="Adı :")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            
        }
    }
}
