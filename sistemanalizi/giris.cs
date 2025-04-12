using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace sistemanalizi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici kullanicigirisi = new kullanici();
            if (button5.Text==Localization_EN.button16)
            {
                kullanicigirisi.Show();
                this.Hide();
            }
            else
            {
                kullanicigirisi.label1.Text = Localization_EN.label3;
                kullanicigirisi.label2.Text = Localization_EN.label4;
                kullanicigirisi.button1.Text = Localization_EN.button17;
                kullanicigirisi.button2.Text = Localization_EN.button18;
                kullanicigirisi.Show();
                this.Hide();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisann calisan = new calisann();
            if(button5.Text==Localization_EN.button16)
            {
                calisan.Show();
                this.Hide();
            }
            else
            {
                calisan.label1.Text = Localization_EN.label3;
                calisan.label2.Text = Localization_EN.label4;
                calisan.button1.Text = Localization_EN.button17;
                calisan.Show();
                this.Hide();
            }
            
        }

        private void giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yönetici y=new yönetici();
            if(button5.Text==Localization_EN.button16)
            {
                y.Show();
                this.Hide();
            }
            else
            {
                y.label1.Text = Localization_EN.label3;
                y.label2.Text = Localization_EN.label4;
                y.button1.Text = Localization_EN.button17;
                y.Show();
                this.Hide();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                
            if(button5.Text == Localization_EN.button16)
            {
                this.Hide();
                label1.Text = Localization_EN.label1;
                button1.Text = Localization_EN.button12;
                button2.Text = Localization_EN.button13;
                button3.Text = Localization_EN.button14;
                button5.Text = Localization_EN.button15;
                this.Show();
            }
            else
            {
                this.Hide();
                label1.Text = Localization_TR.label1;
                button1.Text = Localization_TR.label2;
                button2.Text = Localization_TR.label3;
                button3.Text = Localization_TR.label4;
                button5.Text = Localization_EN.button16;
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            y.Show();
            this.Hide();
        }
    }
}
