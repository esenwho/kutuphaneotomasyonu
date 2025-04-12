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
using System.Reflection.Emit;

namespace sistemanalizi
{
    public partial class tumislemler : Form
    {
        public tumislemler()
        {
            InitializeComponent();
        }
        kutuphaneeEntities islemler =new kutuphaneeEntities();

        SqlConnection db = new SqlConnection("Data Source=DESKTOP-1UOJVJ5\\ESEN;Initial Catalog=kutuphanee;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }
        void KitapGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR], kitapturu AS [TÜRÜ], sayfasayisi AS [SAYFA SAYISI], yayinevi AS [YAYINEVİ], yayinyili AS [YAYIN YILI], yayinyeri AS [YAYIN YERİ], kitapozeti AS [ÖZET], yerID AS [YER ID] From kitap", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void BookCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR], kitapturu AS [TYPE], sayfasayisi AS [NUMBER OF PAGES], yayinevi AS [PUBLISHER], yayinyili AS [YEAR], yayinyeri AS [PLACE OF PUBLICATION], kitapozeti AS [SUMMARY], yerID AS [LOCATION ID] From kitap", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void UyeGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select uyeID AS [ÜYE ID], uyeadi AS [AD], uyesoyadi AS [SOYAD], uyemail AS [MAİL], uyetel AS [TELEFON NO], uyesifre AS [ŞİFRE]  From uye", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void UserCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyemail AS [MAİL], uyetel AS [TELEPHONE NUMBER], uyesifre AS [PASSWORD]  From uye", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void DergiGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI], dergituru AS [TÜRÜ], dergieditoru AS [EDİTÖRÜ], sayfasayisi AS [SAYFA SAYISI], yayinevi AS [YAYINEVİ], yayinyili AS [YAYIN YILI], yayinyeri AS [YAYIN YERİ], yerID AS [YER ID] From dergi", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void JournalCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE], dergituru AS [TYPE], dergieditoru AS [EDITOR], sayfasayisi AS [NUMBER OF PAGES], yayinevi AS [PUBLISHER], yayinyili AS [YEAR], yayinyeri AS [PLACE OF PUBLICATION], yerID AS [LOCATION ID] From dergi", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void KitapEmanetGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kemanetID AS [EMANET ID], uyeID AS [ÜYE ID], kitapID AS [KİTAP ID], alimtarihi AS [ALIM TARİHİ], teslimtarihi AS [TESLİM TARİHİ], durumu AS [DURUM] From kitapemanet", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void BookTrustCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select kemanetID AS [TRUST ID], uyeID AS [USER ID], kitapID AS [BOOK ID], alimtarihi AS [PURCHASE DATE], teslimtarihi AS [DELIVERY DATE], durumu AS [STATUS] From kitapemanet", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void DergiEmanetGetir()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select demanetID AS [EMANET ID], uyeID AS [ÜYE ID], dergiID AS [DERGİ ID], alimtarihi AS [ALIM TARİHİ], teslimtarihi AS [TESLİM TARİHİ], durumu AS [DURUM] From dergiemanet", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }
        void JournalTrustCome()
        {
            db.Open();
            adapter = new SqlDataAdapter("Select demanetID AS [TRUST ID], uyeID AS [USER ID], dergiID AS [JOURNAL ID], alimtarihi AS [PURCHASE DATE], teslimtarihi AS [DELIVERY DATE], durumu AS [STATUS] From dergiemanet", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == Localization_TR.label38 || button1.Text==Localization_EN.label34)
            {
                string sorgu = "Insert into kitap (kitapID,ISBN,kitapadi,kitapyazari,kitapturu,sayfasayisi,yayinevi,yayinyili,yayinyeri,kitapozeti,yerID) values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "")
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
                    cmd.Parameters.AddWithValue("@g", textBox7.Text.ToString());
                    cmd.Parameters.AddWithValue("@h", textBox8.Text.ToString());
                    cmd.Parameters.AddWithValue("@i", textBox9.Text.ToString());
                    cmd.Parameters.AddWithValue("@j", textBox10.Text.ToString());
                    cmd.Parameters.AddWithValue("@k", textBox11.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    KitapGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
            }
            else if (button1.Text == Localization_TR.label39 || button1.Text == Localization_EN.label35)
            {
                string sorgu = "Delete From kitap Where kitapID=@no";
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    KitapGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");
                }
                
            }
            else if (button1.Text == Localization_TR.label40 || button1.Text == Localization_EN.label36)
            {
                string sorgu = "Update kitap Set kitapadi=@b,kitapyazari=@c,kitapturu=@d,sayfasayisi=@e,yayinevi=@f,yayinyili=@g,yayinyeri=@h,kitapozeti=@i,yerID=@j Where kitapID=@no and ISBN=@a";
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@no",textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@a", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@c", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@d", textBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@e", textBox6.Text.ToString());
                cmd.Parameters.AddWithValue("@f", textBox7.Text.ToString());
                cmd.Parameters.AddWithValue("@g", textBox8.Text.ToString());
                cmd.Parameters.AddWithValue("@h", textBox9.Text.ToString());
                cmd.Parameters.AddWithValue("@i", textBox10.Text.ToString());
                cmd.Parameters.AddWithValue("@j", textBox11.Text.ToString());
                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
                KitapGetir();
                Temizle();
                MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
            }
            else if (button1.Text == Localization_TR.label48 || button1.Text == Localization_EN.label39)
            {
                string sorgu = "Insert into uye (uyeID,uyeadi,uyesoyadi,uyemail,uyetel,uyesifre) values (@a,@b,@c,@d,@e,@f)";
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
                    UyeGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
            }
            else if (button1.Text == Localization_TR.label49 || button1.Text == Localization_EN.label40)
            {
                string sorgu = "Delete From uye Where uyeID=@no";
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    UyeGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");
                }
                
            }
            else if (button1.Text ==Localization_TR.label50 || button1.Text == Localization_EN.label41)
            {
                string sorgu = "Update uye Set uyeadi=@a,uyesoyadi=@b,uyemail=@c,uyetel=@d,uyesifre=@e Where uyeID=@no";
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@no",textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@a", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@c", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@d", textBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@e", textBox6.Text.ToString());
                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
                UyeGetir();
                Temizle();
                MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
            }
            else if (label1.Text == Localization_TR.label66 && button1.Text == Localization_TR.label72 || label1.Text==Localization_EN.label10 && button1.Text==Localization_EN.label60)
            {
                string sorgu = "Insert into dergi (dergiID,ISNN,dergiadi,dergibasligi,dergituru,dergieditoru,sayfasayisi,yayinevi,yayinyili,yayinyeri,yerID) values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox11.Text == "" && textBox12.Text == "" )
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
                    cmd.Parameters.AddWithValue("@g", textBox7.Text.ToString());
                    cmd.Parameters.AddWithValue("@h", textBox8.Text.ToString());
                    cmd.Parameters.AddWithValue("@i", textBox9.Text.ToString());
                    cmd.Parameters.AddWithValue("@j", textBox11.Text.ToString());
                    cmd.Parameters.AddWithValue("@k", textBox12.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DergiGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
            }
            else if(label1.Text == Localization_TR.label66 && button1.Text == Localization_TR.label73 || label1.Text == Localization_EN.label10 && button1.Text == Localization_EN.label61)
            {
                string sorgu = "Delete From dergi Where dergiID=@no";
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DergiGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");
                }
                
            }
            else if(label1.Text == Localization_TR.label66 && button1.Text == Localization_TR.label74 || label1.Text == Localization_EN.label10 && button1.Text == Localization_EN.label62)
            {
                string sorgu = "Update dergi Set ISNN=@b,dergiadi=@c,dergibasligi=@d,dergituru=@e,dergieditoru=@f,sayfasayisi=@g,yayinevi=@h,yayinyili=@i,yayinyeri=@j,yerID=@k where dergiID=@a";
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@d", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@e", textBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@f", textBox6.Text.ToString());
                cmd.Parameters.AddWithValue("@g", textBox7.Text.ToString());
                cmd.Parameters.AddWithValue("@h", textBox8.Text.ToString());
                cmd.Parameters.AddWithValue("@i", textBox9.Text.ToString());
                cmd.Parameters.AddWithValue("@j", textBox11.Text.ToString());
                cmd.Parameters.AddWithValue("@k", textBox12.Text.ToString());
                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
                DergiGetir();
                Temizle();
                MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
            }
            else if (label1.Text == Localization_TR.label51 && button1.Text == Localization_TR.label57 || label1.Text==Localization_EN.label12 && button1.Text==Localization_EN.label47)
            {
                string sorgu = "Insert into kitapemanet (kemanetID,uyeID,kitapID,alimtarihi,teslimtarihi,durumu) values (@a,@b,@c,@d,@e,@f)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@d", Convert.ToDateTime(textBox4.Text));
                    cmd.Parameters.AddWithValue("@e", Convert.ToDateTime(textBox5.Text));
                    cmd.Parameters.AddWithValue("@f", textBox6.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    KitapEmanetGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
            }
            else if (label1.Text == Localization_TR.label51 && button1.Text == Localization_TR.label58 || label1.Text == Localization_EN.label12 && button1.Text == Localization_EN.label48)
            {
                string sorgu = "Delete From kitapemanet Where kemanetID=@no";
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    KitapEmanetGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");
                }
                
            }
            else if (label1.Text == Localization_TR.label51 && button1.Text == Localization_TR.label59 || label1.Text == Localization_EN.label12 && button1.Text == Localization_EN.label49)
            {
                string sorgu = "Update kitapemanet Set uyeID=@a,kitapID=@b,alimtarihi=@c,teslimtarihi=@d,durumu=@e Where kemanetID=@no";
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@a", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@c", Convert.ToDateTime( textBox4.Text));
                cmd.Parameters.AddWithValue("@d", Convert.ToDateTime(textBox5.Text));
                cmd.Parameters.AddWithValue("@e", textBox6.Text.ToString());
                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
                KitapEmanetGetir();
                Temizle();
                MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
            }
            else if(label1.Text == Localization_TR.label60 && button1.Text == Localization_TR.label63 || label1.Text == Localization_EN.label13 && button1.Text == Localization_EN.label52)
            {
                string sorgu = "Insert into dergiemanet (demanetID,uyeID,dergiID,alimtarihi,teslimtarihi,durumu) values (@a,@b,@c,@d,@e,@f)";
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@a", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@b", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@d", Convert.ToDateTime(textBox4.Text));
                    cmd.Parameters.AddWithValue("@e", Convert.ToDateTime(textBox5.Text));
                    cmd.Parameters.AddWithValue("@f", textBox6.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DergiEmanetGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız başarıyla oluşuturuldu!");
                }
            }
            else if(label1.Text == Localization_TR.label60 && button1.Text == Localization_TR.label64 || label1.Text == Localization_EN.label13 && button1.Text == Localization_EN.label53)
            {
                string sorgu = "Delete From dergiemanet Where demanetID=@no";
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Eksik bilgi girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd = new SqlCommand(sorgu, db);
                    cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DergiEmanetGetir();
                    Temizle();
                    MessageBox.Show("Kaydınız Başarıyla Silindi!");
                }
                
            }
            else if(label1.Text == Localization_TR.label60 && button1.Text == Localization_TR.label65 || label1.Text == Localization_EN.label13 && button1.Text == Localization_EN.label54)
            {
                string sorgu = "Update dergiemanet Set uyeID=@a,dergiID=@b,alimtarihi=@c,teslimtarihi=@d,durumu=@e Where demanetID=@no";
                cmd = new SqlCommand(sorgu, db);
                cmd.Parameters.AddWithValue("@no", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@a", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@b", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@c", Convert.ToDateTime(textBox4.Text));
                cmd.Parameters.AddWithValue("@d", Convert.ToDateTime(textBox5.Text));
                cmd.Parameters.AddWithValue("@e", textBox6.Text.ToString());
                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
                DergiEmanetGetir();
                Temizle();
                MessageBox.Show("Kaydınız Başarıyla Güncellendi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisanarayüzü k = new calisanarayüzü();
            if(button1.Text== Localization_EN.label54 || button1.Text == Localization_EN.label53 || button1.Text == Localization_EN.label52 || button1.Text == Localization_EN.label60 || button1.Text == Localization_EN.label61 || button1.Text == Localization_EN.label62 || button1.Text == Localization_EN.label47 || button1.Text == Localization_EN.label48 || button1.Text == Localization_EN.label49 || button1.Text == Localization_EN.label34 || button1.Text == Localization_EN.label35 || button1.Text == Localization_EN.label36 || button1.Text == Localization_EN.label39 || button1.Text == Localization_EN.label40 || button1.Text == Localization_EN.label41)
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
                k.Show();
                this.Hide();
            }
            else
            {
                k.Show();
                this.Hide();
            }
            
        }

        private void tumislemler_Load(object sender, EventArgs e)
        {
            if (label1.Text== Localization_TR.label26)
            {
                textBox2.MaxLength = 13;
                textBox11.MaxLength = 5;
                KitapGetir();


            }
            else if (label1.Text== Localization_TR.label41)
            {
                textBox5.MaxLength = 11;
                UyeGetir();
            }
            else if(label1.Text== Localization_TR.label66)
            {
                textBox2.MaxLength = 8;
                textBox12.MaxLength = 5;
                DergiGetir();
            }
            else if (label1.Text== Localization_TR.label51)
            {
                textBox2.MaxLength = 11;
                textBox3.MaxLength = 11;
                KitapEmanetGetir();
            }
            else if(label1.Text== Localization_TR.label60)
            {
                textBox2.MaxLength = 11;
                textBox3.MaxLength = 11;
                DergiEmanetGetir();
            }
            else if(label1.Text==Localization_EN.label9)
            {
                textBox2.MaxLength = 13;
                textBox11.MaxLength = 5;
                BookCome();
            }
            else if (label1.Text == Localization_EN.label11)
            {
                textBox5.MaxLength = 11;
                UserCome();
            }
            else if (label1.Text == Localization_EN.label10)
            {
                textBox2.MaxLength = 8;
                textBox12.MaxLength = 5;
                JournalCome();
            }
            else if (label1.Text == Localization_EN.label12)
            {
                textBox2.MaxLength = 11;
                textBox3.MaxLength = 11;
                BookTrustCome();
            }
            else if (label1.Text == Localization_EN.label13)
            {
                textBox2.MaxLength = 11;
                textBox3.MaxLength = 11;
                JournalTrustCome();
            }

            textBox1.MaxLength = 11;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label1.Text == Localization_TR.label26)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            if(label1.Text== Localization_TR.label41)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if(label1.Text== Localization_TR.label66)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            if(label1.Text== Localization_TR.label51)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if(label1.Text == Localization_TR.label60)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (label1.Text == Localization_EN.label9)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            if (label1.Text == Localization_EN.label11)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (label1.Text == Localization_EN.label10)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            if (label1.Text == Localization_EN.label12)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (label1.Text == Localization_EN.label13)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tablogetir git = new tablogetir();
            if (button4.Text==Localization_EN.label63)
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button2.Visible = true;
                git.button3.Visible = true;
                git.label1.Text = "Location ID :";
                git.label2.Text = "Block :";
                git.label3.Text = "Shelf :";
                git.button1.Text = Localization_EN.label18;
                git.button2.Text = Localization_EN.label19;
                git.button3.Text=Localization_EN.label20;
                db.Open();
                adapter = new SqlDataAdapter("Select yerID [LOCATION ID], blok AS [BLOCK], raf AS [SHELF] From konum", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            else
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button2.Visible = true;
                git.button3.Visible = true;
                db.Open();
                adapter = new SqlDataAdapter("Select yerID [YER ID], blok AS [BLOK], raf AS [RAF] From konum", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tablogetir git = new tablogetir();
            if (button5.Text=="KİTAP TABLOSU")
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "ISBN :";
                git.label2.Text = "Adı :";
                git.label3.Text = "Yazarı :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "ARA";
                db.Open();
                adapter = new SqlDataAdapter("Select kitapID AS [KİTAP ID], ISBN AS [ISBN], kitapadi AS [ADI], kitapyazari AS [YAZAR] From kitap", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            else if (button5.Text=="DERGİ TABLOSU")
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "ISNN :";
                git.label2.Text = "Adı :";
                git.label3.Text = "Başlığı :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "ARA";
                db.Open();
                adapter = new SqlDataAdapter("Select dergiID AS [DERGİ ID], ISNN AS [ISNN], dergiadi AS [ADI], dergibasligi AS [BAŞLIĞI] From dergi", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            else if(button5.Text == Localization_EN.label46)
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "ISBN :";
                git.label2.Text = "Name :";
                git.label3.Text = "Author :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "SEARCH";
                db.Open();
                adapter = new SqlDataAdapter("Select kitapID AS [BOOK ID], ISBN AS [ISBN], kitapadi AS [NAME], kitapyazari AS [AUTHOR] From kitap", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            else if(button5.Text == Localization_EN.label51)
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "ISNN :";
                git.label2.Text = "Name :";
                git.label3.Text = "Title :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "SEARCH";
                db.Open();
                adapter = new SqlDataAdapter("Select dergiID AS [JOURNAL ID], ISNN AS [ISNN], dergiadi AS [NAME], dergibasligi AS [TITLE] From dergi", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tablogetir git = new tablogetir();
            if(button6.Text==Localization_EN.label64)
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "Name :";
                git.label2.Text = "Surname :";
                git.label3.Text = "Telephone :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "SEARCH";
                db.Open();
                adapter = new SqlDataAdapter("Select uyeID AS [USER ID], uyeadi AS [NAME], uyesoyadi AS [SURNAME], uyetel AS [TELEPHONE] From uye", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            else
            {
                git.label1.Visible = true;
                git.label2.Visible = true;
                git.label3.Visible = true;
                git.label1.Text = "Adı :";
                git.label2.Text = "Soyadı :";
                git.label3.Text = "Telefon :";
                git.textBox1.Visible = true;
                git.textBox2.Visible = true;
                git.textBox3.Visible = true;
                git.button1.Visible = true;
                git.button1.Text = "ARA";
                db.Open();
                adapter = new SqlDataAdapter("Select uyeID AS [ÜYE ID], uyeadi AS [ADI], uyesoyadi AS [SOYADI], uyetel AS [TELEFONU] From uye", db);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                git.dataGridView1.DataSource = tablo;
                db.Close();
                git.Show();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            islem();
        }

        void islem()
        {
            tablogetir git = new tablogetir();
            db.Open();
            adapter = new SqlDataAdapter("Select * From tblkitap_Log", db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            git.dataGridView1.DataSource = tablo;
            db.Close();
            git.Show();
        }

        
    }
}
