using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace sistemanalizi
{
    public partial class kullaniciarayüzü : Form
    {
        public kullaniciarayüzü()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader rd;
        void KitapGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kitapadi AS [ADI] , kitapyazari AS [YAZARI], kitapturu AS [TÜRÜ], sayfasayisi AS [SAYFA SAYISI], yayinevi AS [YAYINEVİ], yayinyili AS [YAYIN YILI], yayinyeri AS [YAYIN YERİ], kitapozeti AS [ÖZETİ] From kitap", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void DergiGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI], dergituru AS [TÜRÜ], dergieditoru AS [EDİTÖRÜ], sayfasayisi AS [SAYFA SAYISI], yayinevi AS [YAYINEVİ], yayinyili AS [YAYIN YILI], yayinyeri AS [YAYIN YERİ] From dergi", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void BookCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("SELECT kitapadi AS [NAME] , kitapyazari AS [AUTHOR], kitapturu AS [TYPE], sayfasayisi AS [NUMBER OF PAGES], yayinevi AS [PUBLISHER], yayinyili AS [PUBLICATION YEAR], yayinyeri AS [PLACE OF PUBLICATION], kitapozeti AS [SUMMARY] FROM kitap",db);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
        }
        void JournalCome()
        {
            db.Open();
            adapter = new SqlDataAdapter( "SELECT dergiadi AS [NAME], dergibasligi AS [TITLE], dergituru AS [TYPE], dergieditoru AS [EDITOR], sayfasayisi AS [NUMBER OF PAGES], yayinevi AS [PUBLISHER], yayinyili AS [PUBLICATION YEAR], yayinyeri AS [PLACE OF PUBLICATION] FROM dergi",db);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (button1.Text==Localization_TR.label10)
            {
                string sql = "SELECT kitap.kitapadi AS [ADI] , kitap.kitapyazari AS [YAZARI], kitap.kitapturu AS [TÜRÜ], kitap.sayfasayisi AS [SAYFA SAYISI], kitap.yayinevi AS [YAYINEVİ], kitap.yayinyili AS [YAYIN YILI], kitap.yayinyeri AS [YAYIN YERİ], kitap.kitapozeti AS [ÖZETİ] , konum.blok AS [BLOK], konum.raf AS [RAF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapadi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(button1.Text==Localization_TR.label22)
            {
                string sql = "SELECT dergi.dergiadi AS [ADI], dergi.dergibasligi AS [BAŞLIĞI], dergi.dergituru AS [TÜRÜ], dergi.dergieditoru AS [EDİTÖRÜ], dergi.sayfasayisi AS [SAYFA SAYISI], dergi.yayinevi AS [YAYINEVİ], dergi.yayinyili AS [YAYIN YILI], dergi.yayinyeri AS [YAYIN YERİ], konum.blok AS [BLOK], konum.raf AS [RAF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.dergiadi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(button1.Text==Localization_EN.button1)
            {
                string sql = "SELECT kitap.kitapadi AS [NAME] , kitap.kitapyazari AS [AUTHOR], kitap.kitapturu AS [TYPE], kitap.sayfasayisi AS [NUMBER OF PAGES], kitap.yayinevi AS [PUBLISHER], kitap.yayinyili AS [PUBLICATION YEAR], kitap.yayinyeri AS [PLACE OF PUBLICATION], kitap.kitapozeti AS [SUMMARY] , konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapadi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(button1.Text== Localization_EN.button6)
            {
                string sql = "SELECT dergi.dergiadi AS [NAME], dergi.dergibasligi AS [TITLE], dergi.dergituru AS [TYPE], dergi.dergieditoru AS [EDITOR], dergi.sayfasayisi AS [NUMBER OF PAGES], dergi.yayinevi AS [PUBLISHER], dergi.yayinyili AS [PUBLICATION YEAR], dergi.yayinyeri AS [PLACE OF PUBLICATION], konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.dergiadi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (button2.Text == Localization_TR.label11)
            {
                string sql = "SELECT kitap.kitapadi AS [ADI] , kitap.kitapyazari AS [YAZARI], kitap.kitapturu AS [TÜRÜ], kitap.sayfasayisi AS [SAYFA SAYISI], kitap.yayinevi AS [YAYINEVİ], kitap.yayinyili AS [YAYIN YILI], kitap.yayinyeri AS [YAYIN YERİ], kitap.kitapozeti AS [ÖZETİ] , konum.blok AS [BLOK], konum.raf AS [RAF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapyazari='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button2.Text == Localization_TR.label23)
            {
                string sql = "SELECT dergi.dergiadi AS [ADI], dergi.dergibasligi AS [BAŞLIĞI], dergi.dergituru AS [TÜRÜ], dergi.dergieditoru AS [EDİTÖRÜ], dergi.sayfasayisi AS [SAYFA SAYISI], dergi.yayinevi AS [YAYINEVİ], dergi.yayinyili AS [YAYIN YILI], dergi.yayinyeri AS [YAYIN YERİ], konum.blok AS [BLOK], konum.raf AS [RAF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID where dergi.dergibasligi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(button2.Text== Localization_EN.button2)
            {
                string sql = "SELECT kitap.kitapadi AS [NAME] , kitap.kitapyazari AS [AUTHOR], kitap.kitapturu AS [TYPE], kitap.sayfasayisi AS [NUMBER OF PAGES], kitap.yayinevi AS [PUBLISHER], kitap.yayinyili AS [PUBLICATION YEAR], kitap.yayinyeri AS [PLACE OF PUBLICATION], kitap.kitapozeti AS [SUMMARY] , konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapyazari='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(button2.Text== Localization_EN.button7)
            {
                string sql = "SELECT dergi.dergiadi AS [NAME], dergi.dergibasligi AS [TITLE], dergi.dergituru AS [TYPE], dergi.dergieditoru AS [EDITOR], dergi.sayfasayisi AS [NUMBER OF PAGES], dergi.yayinevi AS [PUBLISHER], dergi.yayinyili AS [PUBLICATION YEAR], dergi.yayinyeri AS [PLACE OF PUBLICATION], konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.dergibasligi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (button3.Text == Localization_TR.label12)
            {
                string sql = "SELECT kitap.kitapadi AS [ADI] , kitap.kitapyazari AS [YAZARI], kitap.kitapturu AS [TÜRÜ], kitap.sayfasayisi AS [SAYFA SAYISI], kitap.yayinevi AS [YAYINEVİ], kitap.yayinyili AS [YAYIN YILI], kitap.yayinyeri AS [YAYIN YERİ], kitap.kitapozeti AS [ÖZETİ] , konum.blok AS [BLOK], konum.raf AS [RAF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapturu='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button3.Text == Localization_TR.label24)
            {
                string sql = "SELECT dergi.dergiadi AS [ADI], dergi.dergibasligi AS [BAŞLIĞI], dergi.dergituru AS [TÜRÜ], dergi.dergieditoru AS [EDİTÖRÜ], dergi.sayfasayisi AS [SAYFA SAYISI], dergi.yayinevi AS [YAYINEVİ], dergi.yayinyili AS [YAYIN YILI], dergi.yayinyeri AS [YAYIN YERİ], konum.blok AS [BLOK], konum.raf AS [RAF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID where dergi.dergituru='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button3.Text == Localization_EN.button3)
            {
                string sql = "SELECT kitap.kitapadi AS [NAME] , kitap.kitapyazari AS [AUTHOR], kitap.kitapturu AS [TYPE], kitap.sayfasayisi AS [NUMBER OF PAGES], kitap.yayinevi AS [PUBLISHER], kitap.yayinyili AS [PUBLICATION YEAR], kitap.yayinyeri AS [PLACE OF PUBLICATION], kitap.kitapozeti AS [SUMMARY] , konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.kitapturu='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button3.Text == Localization_EN.button8)
            {
                string sql = "SELECT dergi.dergiadi AS [NAME], dergi.dergibasligi AS [TITLE], dergi.dergituru AS [TYPE], dergi.dergieditoru AS [EDITOR], dergi.sayfasayisi AS [NUMBER OF PAGES], dergi.yayinevi AS [PUBLISHER], dergi.yayinyili AS [PUBLICATION YEAR], dergi.yayinyeri AS [PLACE OF PUBLICATION], konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.dergituru='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (button4.Text == Localization_TR.label13)
            {
                string sql = "SELECT kitap.kitapadi AS [ADI] , kitap.kitapyazari AS [YAZARI], kitap.kitapturu AS [TÜRÜ], kitap.sayfasayisi AS [SAYFA SAYISI], kitap.yayinevi AS [YAYINEVİ], kitap.yayinyili AS [YAYIN YILI], kitap.yayinyeri AS [YAYIN YERİ], kitap.kitapozeti AS [ÖZETİ] , konum.blok AS [BLOK], konum.raf AS [RAF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.yayinevi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button4.Text == Localization_TR.label25)
            {
                string sql = "SELECT dergi.dergiadi AS [ADI], dergi.dergibasligi AS [BAŞLIĞI], dergi.dergituru AS [TÜRÜ], dergi.dergieditoru AS [EDİTÖRÜ], dergi.sayfasayisi AS [SAYFA SAYISI], dergi.yayinevi AS [YAYINEVİ], dergi.yayinyili AS [YAYIN YILI], dergi.yayinyeri AS [YAYIN YERİ], konum.blok AS [BLOK], konum.raf AS [RAF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID where dergi.dergieditoru='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button4.Text == Localization_EN.button4)
            {
                string sql = "SELECT kitap.kitapadi AS [NAME] , kitap.kitapyazari AS [AUTHOR], kitap.kitapturu AS [TYPE], kitap.sayfasayisi AS [NUMBER OF PAGES], kitap.yayinevi AS [PUBLISHER], kitap.yayinyili AS [PUBLICATION YEAR], kitap.yayinyeri AS [PLACE OF PUBLICATION], kitap.kitapozeti AS [SUMMARY] , konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.yayinevi='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button4.Text == Localization_EN.button9)
            {
                string sql = "SELECT dergi.dergiadi AS [NAME], dergi.dergibasligi AS [TITLE], dergi.dergituru AS [TYPE], dergi.dergieditoru AS [EDITOR], dergi.sayfasayisi AS [NUMBER OF PAGES], dergi.yayinevi AS [PUBLISHER], dergi.yayinyili AS [PUBLICATION YEAR], dergi.yayinyeri AS [PLACE OF PUBLICATION], konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.dergieditoru='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToString();
            if (button5.Text == Localization_TR.label14 && button1.Text==Localization_TR.label10)
            {
                string sql = "SELECT kitap.kitapadi AS [ADI] , kitap.kitapyazari AS [YAZARI], kitap.kitapturu AS [TÜRÜ], kitap.sayfasayisi AS [SAYFA SAYISI], kitap.yayinevi AS [YAYINEVİ], kitap.yayinyili AS [YAYIN YILI], kitap.yayinyeri AS [YAYIN YERİ], kitap.kitapozeti AS [ÖZETİ] , konum.blok AS [BLOK], konum.raf AS [RAF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.yayinyili='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button5.Text == Localization_TR.label14 && button1.Text==Localization_TR.label22)
            {
                string sql = "SELECT dergi.dergiadi AS [ADI], dergi.dergibasligi AS [BAŞLIĞI], dergi.dergituru AS [TÜRÜ], dergi.dergieditoru AS [EDİTÖRÜ], dergi.sayfasayisi AS [SAYFA SAYISI], dergi.yayinevi AS [YAYINEVİ], dergi.yayinyili AS [YAYIN YILI], dergi.yayinyeri AS [YAYIN YERİ], konum.blok AS [BLOK], konum.raf AS [RAF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID where dergi.yayinyili='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button5.Text == Localization_EN.button5 && button1.Text== Localization_EN.button1)
            {
                string sql = "SELECT kitap.kitapadi AS [NAME] , kitap.kitapyazari AS [AUTHOR], kitap.kitapturu AS [TYPE], kitap.sayfasayisi AS [NUMBER OF PAGES], kitap.yayinevi AS [PUBLISHER], kitap.yayinyili AS [PUBLICATION YEAR], kitap.yayinyeri AS [PLACE OF PUBLICATION], kitap.kitapozeti AS [SUMMARY] , konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM kitap  INNER JOIN konum ON kitap.yerID=konum.yerID where kitap.yayinyili='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (button5.Text == Localization_EN.button5 && button1.Text== Localization_EN.button6)
            {
                string sql = "SELECT dergi.dergiadi AS [NAME], dergi.dergibasligi AS [TITLE], dergi.dergituru AS [TYPE], dergi.dergieditoru AS [EDITOR], dergi.sayfasayisi AS [NUMBER OF PAGES], dergi.yayinevi AS [PUBLISHER], dergi.yayinyili AS [PUBLICATION YEAR], dergi.yayinyeri AS [PLACE OF PUBLICATION], konum.blok AS [BLOCK], konum.raf AS [SHELF] FROM dergi  INNER JOIN konum ON dergi.yerID=konum.yerID  where dergi.yayinyili='" + a + "' ";
                adapter = new SqlDataAdapter(sql, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void kullaniciarayüzü_Load(object sender, EventArgs e)
        {
            if (button8.Text == Localization_TR.label16)
            {
                DergiGetir();
            }
            else if(button8.Text == Localization_TR.label15)
            {
                KitapGetir();
            }
            else if(button8.Text == Localization_EN.button11)
            {
                BookCome();
            }
            else if(button8.Text==Localization_EN.button10)
            {
                JournalCome();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text == Localization_TR.label10)
            {
                this.Hide();
                button1.Text = Localization_TR.label22;
                button2.Text = Localization_TR.label23;
                button3.Text = Localization_TR.label24;
                button4.Text = Localization_TR.label25;
                button5.Text = Localization_TR.label14;
                button8.Text = Localization_TR.label16;
                DergiGetir();
                this.Show();
            }
            else if(button1.Text == Localization_TR.label22)
            {
                this.Hide();
                button1.Text =Localization_TR.label10;
                button2.Text = Localization_TR.label11;
                button3.Text = Localization_TR.label12;
                button4.Text = Localization_TR.label13;
                button5.Text = Localization_TR.label14;
                button8.Text = Localization_TR.label15;
                KitapGetir();
                this.Show();
            }
            else if(button1.Text==Localization_EN.button1)
            {
                this.Hide();
                button1.Text = Localization_EN.button6;
                button2.Text = Localization_EN.button7;
                button3.Text = Localization_EN.button8;
                button4.Text = Localization_EN.button9;
                button5.Text = Localization_EN.button5;
                button8.Text = Localization_EN.button10;
                JournalCome();
                this.Show();
            }
            else if(button1.Text==Localization_EN.button6)
            {
                this.Hide();
                button1.Text = Localization_EN.button1;
                button2.Text = Localization_EN.button2;
                button3.Text = Localization_EN.button3;
                button4.Text = Localization_EN.button4;
                button5.Text = Localization_EN.button5;
                button8.Text = Localization_EN.button11;
                BookCome();
                this.Show();
            }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            kullanici geridon = new kullanici();
            if(button5.Text == Localization_EN.button5)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (button1.Text == Localization_TR.label10)
            {
                MessageBox.Show(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            }
            else if(button1.Text==Localization_EN.button1)
            {
                MessageBox.Show(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            }
        }
    }
        }
    

