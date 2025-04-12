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
    public partial class calisanarayüzü : Form
    {
        public calisanarayüzü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumislemler kitapekleformu=new tumislemler();
            if(button1.Text==Localization_EN.label14)
            {
                kitapekleformu.label1.Text = Localization_EN.label9;
                kitapekleformu.label2.Text = Localization_EN.label23;
                kitapekleformu.label3.Text = Localization_EN.label27;
                kitapekleformu.label4.Text = Localization_EN.label24;
                kitapekleformu.label5.Text = Localization_EN.label25;
                kitapekleformu.label6.Text = Localization_EN.label26;
                kitapekleformu.label7.Text = Localization_EN.label28;
                kitapekleformu.label8.Text = Localization_EN.label29;
                kitapekleformu.label9.Text = Localization_EN.label30;
                kitapekleformu.label10.Text = Localization_EN.label31;
                kitapekleformu.label11.Text = Localization_EN.label32;
                kitapekleformu.label12.Text = Localization_EN.label33;
                kitapekleformu.label11.Visible = true;
                kitapekleformu.textBox10.Visible = true;
                kitapekleformu.label12.Visible = true;
                kitapekleformu.textBox11.Visible = true;
                kitapekleformu.button4.Visible = true;
                kitapekleformu.button7.Visible = true;
                kitapekleformu.button7.Text = Localization_EN.label65;
                kitapekleformu.button4.Text = Localization_EN.label63;
                kitapekleformu.button1.Text = Localization_EN.label34;
                kitapekleformu.Show();
                this.Hide();
            }
            else
            {
                kitapekleformu.label1.Text = Localization_TR.label26;
                kitapekleformu.label2.Text = Localization_TR.label27;
                kitapekleformu.label3.Text = Localization_TR.label28;
                kitapekleformu.label4.Text = Localization_TR.label29;
                kitapekleformu.label5.Text = Localization_TR.label30;
                kitapekleformu.label6.Text = Localization_TR.label31;
                kitapekleformu.label7.Text = Localization_TR.label32;
                kitapekleformu.label8.Text = Localization_TR.label33;
                kitapekleformu.label9.Text = Localization_TR.label34;
                kitapekleformu.label10.Text = Localization_TR.label35;
                kitapekleformu.label11.Text = Localization_TR.label36;
                kitapekleformu.label12.Text = Localization_TR.label37;
                kitapekleformu.label11.Visible = true;
                kitapekleformu.textBox10.Visible = true;
                kitapekleformu.label12.Visible = true;
                kitapekleformu.textBox11.Visible = true;
                kitapekleformu.button4.Visible = true;
                kitapekleformu.button7.Visible = true;
                kitapekleformu.button1.Text = Localization_TR.label38;
                kitapekleformu.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tumislemler kitapsilmeformu=new tumislemler();
            if(button2.Text==Localization_EN.label15)
            {
                kitapsilmeformu.label1.Text = Localization_EN.label9;
                kitapsilmeformu.label2.Text = Localization_EN.label23;
                kitapsilmeformu.label3.Text = Localization_EN.label27;
                kitapsilmeformu.label4.Text = Localization_EN.label24;
                kitapsilmeformu.label5.Text = Localization_EN.label25;
                kitapsilmeformu.label6.Text = Localization_EN.label26;
                kitapsilmeformu.label7.Text = Localization_EN.label28;
                kitapsilmeformu.label8.Text = Localization_EN.label29;
                kitapsilmeformu.label9.Text = Localization_EN.label30;
                kitapsilmeformu.label10.Text = Localization_EN.label31;
                kitapsilmeformu.label11.Text = Localization_EN.label32;
                kitapsilmeformu.label12.Text = Localization_EN.label33;
                kitapsilmeformu.label11.Visible = true;
                kitapsilmeformu.textBox10.Visible = true;
                kitapsilmeformu.label12.Visible = true;
                kitapsilmeformu.textBox11.Visible = true;
                kitapsilmeformu.button4.Visible = true;
                kitapsilmeformu.button7.Visible = true;
                kitapsilmeformu.button7.Text = Localization_EN.label65;
                kitapsilmeformu.button4.Text = Localization_EN.label63;
                kitapsilmeformu.button1.Text = Localization_EN.label35;
                kitapsilmeformu.Show();
                this.Hide();
            }
            else
            {
                kitapsilmeformu.label1.Text = Localization_TR.label26;
                kitapsilmeformu.label2.Text = Localization_TR.label27;
                kitapsilmeformu.label3.Text = Localization_TR.label28;
                kitapsilmeformu.label4.Text = Localization_TR.label29;
                kitapsilmeformu.label5.Text = Localization_TR.label30;
                kitapsilmeformu.label6.Text = Localization_TR.label31;
                kitapsilmeformu.label7.Text = Localization_TR.label32;
                kitapsilmeformu.label8.Text = Localization_TR.label33;
                kitapsilmeformu.label9.Text = Localization_TR.label34;
                kitapsilmeformu.label10.Text = Localization_TR.label35;
                kitapsilmeformu.label11.Text = Localization_TR.label36;
                kitapsilmeformu.label12.Text = Localization_TR.label37;
                kitapsilmeformu.label11.Visible = true;
                kitapsilmeformu.label12.Visible = true;
                kitapsilmeformu.textBox10.Visible = true;
                kitapsilmeformu.textBox11.Visible = true;
                kitapsilmeformu.button4.Visible = true;
                kitapsilmeformu.button7.Visible = true;
                kitapsilmeformu.button1.Text = Localization_TR.label39;
                kitapsilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tumislemler kitapguncelformu = new tumislemler();

            DialogResult result1 = MessageBox.Show("Emin misin?", "Salla",MessageBoxButtons.YesNo);
            if(result1==DialogResult.Yes)
            {
                tumislemler y = new tumislemler();
                y.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }

            if(button3.Text==Localization_EN.label16)
            {
                kitapguncelformu.label1.Text = Localization_EN.label9;
                kitapguncelformu.label2.Text = Localization_EN.label23;
                kitapguncelformu.label3.Text = Localization_EN.label27;
                kitapguncelformu.label4.Text = Localization_EN.label24;
                kitapguncelformu.label5.Text = Localization_EN.label25;
                kitapguncelformu.label6.Text = Localization_EN.label26;
                kitapguncelformu.label7.Text = Localization_EN.label28;
                kitapguncelformu.label8.Text = Localization_EN.label29;
                kitapguncelformu.label9.Text = Localization_EN.label30;
                kitapguncelformu.label10.Text = Localization_EN.label31;
                kitapguncelformu.label11.Text = Localization_EN.label32;
                kitapguncelformu.label12.Text = Localization_EN.label33;
                kitapguncelformu.label11.Visible = true;
                kitapguncelformu.textBox10.Visible = true;
                kitapguncelformu.label12.Visible = true;
                kitapguncelformu.textBox11.Visible = true;
                kitapguncelformu.button4.Visible = true;
                kitapguncelformu.button7.Visible = true;
                kitapguncelformu.button7.Text = Localization_EN.label65;
                kitapguncelformu.button4.Text = Localization_EN.label63;
                kitapguncelformu.button1.Text = Localization_EN.label36;
                kitapguncelformu.Show();
                this.Hide();
            }
            else
            {
                kitapguncelformu.label1.Text = Localization_TR.label26;
                kitapguncelformu.label2.Text = Localization_TR.label27;
                kitapguncelformu.label3.Text = Localization_TR.label28;
                kitapguncelformu.label4.Text = Localization_TR.label29;
                kitapguncelformu.label5.Text = Localization_TR.label30;
                kitapguncelformu.label6.Text = Localization_TR.label31;
                kitapguncelformu.label7.Text = Localization_TR.label32;
                kitapguncelformu.label8.Text = Localization_TR.label33;
                kitapguncelformu.label9.Text = Localization_TR.label34;
                kitapguncelformu.label10.Text = Localization_TR.label35;
                kitapguncelformu.label11.Text = Localization_TR.label36;
                kitapguncelformu.label12.Text = Localization_TR.label37;
                kitapguncelformu.label11.Visible = true;
                kitapguncelformu.label12.Visible = true;
                kitapguncelformu.textBox10.Visible = true;
                kitapguncelformu.textBox11.Visible = true;
                kitapguncelformu.button4.Visible = true;
                kitapguncelformu.button7.Visible = true;
                kitapguncelformu.button1.Text = Localization_TR.label40;
                kitapguncelformu.Show();
                this.Hide();
            }
            
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            tumislemler uyeekleformu = new tumislemler();
            if(button8.Text==Localization_EN.label14)
            {
                uyeekleformu.label1.Text = Localization_EN.label11;
                uyeekleformu.label2.Text = Localization_EN.label37;
                uyeekleformu.label3.Text = Localization_EN.label5;
                uyeekleformu.label4.Text = Localization_EN.label6;
                uyeekleformu.label5.Text = Localization_EN.label38;
                uyeekleformu.label6.Text = Localization_EN.label7;
                uyeekleformu.label7.Text = Localization_EN.label4;
                uyeekleformu.label8.Visible = false;
                uyeekleformu.label9.Visible = false;
                uyeekleformu.label10.Visible = false;
                uyeekleformu.textBox7.Visible = false;
                uyeekleformu.textBox8.Visible = false;
                uyeekleformu.textBox9.Visible = false;
                uyeekleformu.button1.Location = new Point(858, 226);
                uyeekleformu.button1.Text = Localization_EN.label39;
                uyeekleformu.Show();
                this.Hide();
            }
            else
            {
                uyeekleformu.label1.Text = Localization_TR.label41;
                uyeekleformu.label2.Text = Localization_TR.label42;
                uyeekleformu.label3.Text = Localization_TR.label43;
                uyeekleformu.label4.Text = Localization_TR.label44;
                uyeekleformu.label5.Text = Localization_TR.label45;
                uyeekleformu.label6.Text = Localization_TR.label46;
                uyeekleformu.label7.Text = Localization_TR.label47;
                uyeekleformu.label8.Visible = false;
                uyeekleformu.label9.Visible = false;
                uyeekleformu.label10.Visible = false;
                uyeekleformu.textBox7.Visible = false;
                uyeekleformu.textBox8.Visible = false;
                uyeekleformu.textBox9.Visible = false;
                uyeekleformu.button1.Location = new Point(858, 226);
                uyeekleformu.button1.Text = Localization_TR.label48;
                uyeekleformu.Show();
                this.Hide();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tumislemler uyesilmeformu = new tumislemler();
            if(button7.Text==Localization_EN.label15)
            {
                uyesilmeformu.label1.Text = Localization_EN.label11;
                uyesilmeformu.label2.Text = Localization_EN.label37;
                uyesilmeformu.label3.Text = Localization_EN.label5;
                uyesilmeformu.label4.Text = Localization_EN.label6;
                uyesilmeformu.label5.Text = Localization_EN.label38;
                uyesilmeformu.label6.Text = Localization_EN.label7;
                uyesilmeformu.label7.Text = Localization_EN.label4;
                uyesilmeformu.label8.Visible = false;
                uyesilmeformu.label9.Visible = false;
                uyesilmeformu.label10.Visible = false;
                uyesilmeformu.textBox7.Visible = false;
                uyesilmeformu.textBox8.Visible = false;
                uyesilmeformu.textBox9.Visible = false;
                uyesilmeformu.button1.Location = new Point(858, 226);
                uyesilmeformu.button1.Text = Localization_EN.label40;
                uyesilmeformu.Show();
                this.Hide();
            }
            else
            {
                uyesilmeformu.label1.Text = Localization_TR.label41;
                uyesilmeformu.label2.Text = Localization_TR.label42;
                uyesilmeformu.label3.Text = Localization_TR.label43;
                uyesilmeformu.label4.Text = Localization_TR.label44;
                uyesilmeformu.label5.Text = Localization_TR.label45;
                uyesilmeformu.label6.Text = Localization_TR.label46;
                uyesilmeformu.label7.Text = Localization_TR.label47;
                uyesilmeformu.label8.Visible = false;
                uyesilmeformu.label9.Visible = false;
                uyesilmeformu.label10.Visible = false;
                uyesilmeformu.textBox9.Visible = false;
                uyesilmeformu.textBox7.Visible = false;
                uyesilmeformu.textBox8.Visible = false;
                uyesilmeformu.button1.Location = new Point(858, 226);
                uyesilmeformu.button1.Text = Localization_TR.label49;
                uyesilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tumislemler uyeguncelformu = new tumislemler();
            if(button6.Text==Localization_EN.label16)
            {
                uyeguncelformu.label1.Text = Localization_EN.label11;
                uyeguncelformu.label2.Text = Localization_EN.label37;
                uyeguncelformu.label3.Text = Localization_EN.label5;
                uyeguncelformu.label4.Text = Localization_EN.label6;
                uyeguncelformu.label5.Text = Localization_EN.label38;
                uyeguncelformu.label6.Text = Localization_EN.label7;
                uyeguncelformu.label7.Text = Localization_EN.label4;
                uyeguncelformu.label8.Visible = false;
                uyeguncelformu.label9.Visible = false;
                uyeguncelformu.label10.Visible = false;
                uyeguncelformu.textBox7.Visible = false;
                uyeguncelformu.textBox8.Visible = false;
                uyeguncelformu.textBox9.Visible = false;
                uyeguncelformu.button1.Location = new Point(858, 226);
                uyeguncelformu.button1.Text = Localization_EN.label41;
                uyeguncelformu.Show();
                this.Hide();
            }
            else
            {
                uyeguncelformu.label1.Text = Localization_TR.label41;
                uyeguncelformu.label2.Text = Localization_TR.label42;
                uyeguncelformu.label3.Text = Localization_TR.label43;
                uyeguncelformu.label4.Text = Localization_TR.label44;
                uyeguncelformu.label5.Text = Localization_TR.label45;
                uyeguncelformu.label6.Text = Localization_TR.label46;
                uyeguncelformu.label7.Text = Localization_TR.label47;
                uyeguncelformu.label8.Visible = false;
                uyeguncelformu.label9.Visible = false;
                uyeguncelformu.label10.Visible = false;
                uyeguncelformu.textBox9.Visible = false;
                uyeguncelformu.textBox7.Visible = false;
                uyeguncelformu.textBox8.Visible = false;
                uyeguncelformu.button1.Location = new Point(858, 226);
                uyeguncelformu.button1.Text = Localization_TR.label50;
                uyeguncelformu.Show();
                this.Hide();
            }
            
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            tumislemler kitapemanetekleformu = new tumislemler();
            if(button12.Text==Localization_EN.label14)
            {
                kitapemanetekleformu.label1.Text = Localization_EN.label12;
                kitapemanetekleformu.label2.Text = Localization_EN.label42;
                kitapemanetekleformu.label3.Text = Localization_EN.label37;
                kitapemanetekleformu.label4.Text = Localization_EN.label23;
                kitapemanetekleformu.label5.Text = Localization_EN.label43;
                kitapemanetekleformu.label6.Text = Localization_EN.label44;
                kitapemanetekleformu.label7.Text = Localization_EN.label45;
                kitapemanetekleformu.label8.Visible = false;
                kitapemanetekleformu.label9.Visible = false;
                kitapemanetekleformu.label10.Visible = false;
                kitapemanetekleformu.textBox10.Visible = false;
                kitapemanetekleformu.label11.Visible = false;
                kitapemanetekleformu.textBox7.Visible = false;
                kitapemanetekleformu.textBox8.Visible = false;
                kitapemanetekleformu.textBox9.Visible = false;
                kitapemanetekleformu.textBox10.Visible = false;
                kitapemanetekleformu.button5.Visible = true;
                kitapemanetekleformu.button6.Visible = true;
                kitapemanetekleformu.button6.Text = Localization_EN.label64;
                kitapemanetekleformu.button5.Text = Localization_EN.label46;
                kitapemanetekleformu.button1.Location = new Point(910, 277);
                kitapemanetekleformu.button5.Location = new Point(910, 207);
                kitapemanetekleformu.button6.Location = new Point(910, 137);
                kitapemanetekleformu.button1.Text = Localization_EN.label47;
                kitapemanetekleformu.Show();
                this.Hide();
            }
            else
            {
                kitapemanetekleformu.label1.Text = Localization_TR.label51;
                kitapemanetekleformu.label2.Text = Localization_TR.label52;
                kitapemanetekleformu.label3.Text = Localization_TR.label42;
                kitapemanetekleformu.label4.Text = Localization_TR.label27;
                kitapemanetekleformu.label5.Text = Localization_TR.label53;
                kitapemanetekleformu.label6.Text = Localization_TR.label54;
                kitapemanetekleformu.label7.Text = Localization_TR.label55;
                kitapemanetekleformu.label8.Visible = false;
                kitapemanetekleformu.label9.Visible = false;
                kitapemanetekleformu.label10.Visible = false;
                kitapemanetekleformu.textBox10.Visible = false;
                kitapemanetekleformu.label11.Visible = false;
                kitapemanetekleformu.textBox7.Visible = false;
                kitapemanetekleformu.textBox8.Visible = false;
                kitapemanetekleformu.textBox9.Visible = false;
                kitapemanetekleformu.textBox10.Visible = false;
                kitapemanetekleformu.button5.Visible = true;
                kitapemanetekleformu.button6.Visible = true;
                kitapemanetekleformu.button5.Text = Localization_TR.label56;
                kitapemanetekleformu.button1.Location = new Point(910, 277);
                kitapemanetekleformu.button5.Location = new Point(910, 207);
                kitapemanetekleformu.button6.Location = new Point(910, 137);
                kitapemanetekleformu.button1.Text = Localization_TR.label57;
                kitapemanetekleformu.Show();
                this.Hide();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tumislemler kitapemanetsilmeformu = new tumislemler();
            if(button11.Text==Localization_EN.label15)
            {
                kitapemanetsilmeformu.label1.Text = Localization_EN.label12;
                kitapemanetsilmeformu.label2.Text = Localization_EN.label42;
                kitapemanetsilmeformu.label3.Text = Localization_EN.label37;
                kitapemanetsilmeformu.label4.Text = Localization_EN.label23;
                kitapemanetsilmeformu.label5.Text = Localization_EN.label43;
                kitapemanetsilmeformu.label6.Text = Localization_EN.label44;
                kitapemanetsilmeformu.label7.Text = Localization_EN.label45;
                kitapemanetsilmeformu.label8.Visible = false;
                kitapemanetsilmeformu.label9.Visible = false;
                kitapemanetsilmeformu.label10.Visible = false;
                kitapemanetsilmeformu.textBox10.Visible = false;
                kitapemanetsilmeformu.label11.Visible = false;
                kitapemanetsilmeformu.textBox7.Visible = false;
                kitapemanetsilmeformu.textBox8.Visible = false;
                kitapemanetsilmeformu.textBox9.Visible = false;
                kitapemanetsilmeformu.textBox10.Visible = false;
                kitapemanetsilmeformu.button5.Visible = true;
                kitapemanetsilmeformu.button6.Visible = true;
                kitapemanetsilmeformu.button6.Text = Localization_EN.label64;
                kitapemanetsilmeformu.button5.Text = Localization_EN.label46;
                kitapemanetsilmeformu.button1.Location = new Point(910, 277);
                kitapemanetsilmeformu.button5.Location = new Point(910, 207);
                kitapemanetsilmeformu.button6.Location = new Point(910, 137);
                kitapemanetsilmeformu.button1.Text = Localization_EN.label48;
                kitapemanetsilmeformu.Show();
                this.Hide();
            }
            else
            {
                kitapemanetsilmeformu.label1.Text = Localization_TR.label51;
                kitapemanetsilmeformu.label2.Text = Localization_TR.label52;
                kitapemanetsilmeformu.label3.Text = Localization_TR.label42;
                kitapemanetsilmeformu.label4.Text = Localization_TR.label27;
                kitapemanetsilmeformu.label5.Text = Localization_TR.label53;
                kitapemanetsilmeformu.label6.Text = Localization_TR.label54;
                kitapemanetsilmeformu.label7.Text = Localization_TR.label55;
                kitapemanetsilmeformu.label8.Visible = false;
                kitapemanetsilmeformu.label9.Visible = false;
                kitapemanetsilmeformu.label10.Visible = false;
                kitapemanetsilmeformu.textBox10.Visible = false;
                kitapemanetsilmeformu.label11.Visible = false;
                kitapemanetsilmeformu.textBox7.Visible = false;
                kitapemanetsilmeformu.textBox8.Visible = false;
                kitapemanetsilmeformu.textBox9.Visible = false;
                kitapemanetsilmeformu.textBox10.Visible = false;
                kitapemanetsilmeformu.button5.Visible = true;
                kitapemanetsilmeformu.button6.Visible = true;
                kitapemanetsilmeformu.button5.Text = Localization_TR.label56;
                kitapemanetsilmeformu.button1.Location = new Point(910, 277);
                kitapemanetsilmeformu.button5.Location = new Point(910, 207);
                kitapemanetsilmeformu.button6.Location = new Point(910, 137);
                kitapemanetsilmeformu.button1.Text = Localization_TR.label58;
                kitapemanetsilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tumislemler kitapemanetguncelformu = new tumislemler();
            if(button10.Text==Localization_EN.label16)
            {
                kitapemanetguncelformu.label1.Text = Localization_EN.label12;
                kitapemanetguncelformu.label2.Text = Localization_EN.label42;
                kitapemanetguncelformu.label3.Text = Localization_EN.label37;
                kitapemanetguncelformu.label4.Text = Localization_EN.label23;
                kitapemanetguncelformu.label5.Text = Localization_EN.label43;
                kitapemanetguncelformu.label6.Text = Localization_EN.label44;
                kitapemanetguncelformu.label7.Text = Localization_EN.label45;
                kitapemanetguncelformu.label8.Visible = false;
                kitapemanetguncelformu.label9.Visible = false;
                kitapemanetguncelformu.label10.Visible = false;
                kitapemanetguncelformu.textBox10.Visible = false;
                kitapemanetguncelformu.label11.Visible = false;
                kitapemanetguncelformu.textBox7.Visible = false;
                kitapemanetguncelformu.textBox8.Visible = false;
                kitapemanetguncelformu.textBox9.Visible = false;
                kitapemanetguncelformu.textBox10.Visible = false;
                kitapemanetguncelformu.button5.Visible = true;
                kitapemanetguncelformu.button6.Visible = true;
                kitapemanetguncelformu.button6.Text = Localization_EN.label64;
                kitapemanetguncelformu.button5.Text = Localization_EN.label46;
                kitapemanetguncelformu.button1.Location = new Point(910, 277);
                kitapemanetguncelformu.button5.Location = new Point(910, 207);
                kitapemanetguncelformu.button6.Location = new Point(910, 137);
                kitapemanetguncelformu.button1.Text =Localization_EN.label49;
                kitapemanetguncelformu.Show();
                this.Hide();
            }
            else
            {
                kitapemanetguncelformu.label1.Text = Localization_TR.label51;
                kitapemanetguncelformu.label2.Text = Localization_TR.label52;
                kitapemanetguncelformu.label3.Text = Localization_TR.label42;
                kitapemanetguncelformu.label4.Text = Localization_TR.label27;
                kitapemanetguncelformu.label5.Text = Localization_TR.label53;
                kitapemanetguncelformu.label6.Text = Localization_TR.label54;
                kitapemanetguncelformu.label7.Text = Localization_TR.label55;
                kitapemanetguncelformu.label8.Visible = false;
                kitapemanetguncelformu.label9.Visible = false;
                kitapemanetguncelformu.label10.Visible = false;
                kitapemanetguncelformu.textBox10.Visible = false;
                kitapemanetguncelformu.label11.Visible = false;
                kitapemanetguncelformu.textBox7.Visible = false;
                kitapemanetguncelformu.textBox8.Visible = false;
                kitapemanetguncelformu.textBox9.Visible = false;
                kitapemanetguncelformu.textBox10.Visible = false;
                kitapemanetguncelformu.button5.Visible = true;
                kitapemanetguncelformu.button6.Visible = true;
                kitapemanetguncelformu.button5.Text = Localization_TR.label56;
                kitapemanetguncelformu.button1.Location = new Point(910, 277);
                kitapemanetguncelformu.button5.Location = new Point(910, 207);
                kitapemanetguncelformu.button6.Location = new Point(910, 137);
                kitapemanetguncelformu.button1.Text = Localization_TR.label59;
                kitapemanetguncelformu.Show();
                this.Hide();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tumislemler dergiemanetekleformu = new tumislemler();
            if(button5.Text==Localization_EN.label14)
            {
                dergiemanetekleformu.label1.Text = Localization_EN.label13;
                dergiemanetekleformu.label2.Text = Localization_EN.label42;
                dergiemanetekleformu.label3.Text = Localization_EN.label37;
                dergiemanetekleformu.label4.Text = Localization_EN.label50;
                dergiemanetekleformu.label5.Text = Localization_EN.label43;
                dergiemanetekleformu.label6.Text = Localization_EN.label44;
                dergiemanetekleformu.label7.Text = Localization_EN.label45;
                dergiemanetekleformu.label8.Visible = false;
                dergiemanetekleformu.label9.Visible = false;
                dergiemanetekleformu.label10.Visible = false;
                dergiemanetekleformu.textBox10.Visible = false;
                dergiemanetekleformu.label11.Visible = false;
                dergiemanetekleformu.textBox7.Visible = false;
                dergiemanetekleformu.textBox8.Visible = false;
                dergiemanetekleformu.textBox9.Visible = false;
                dergiemanetekleformu.textBox10.Visible = false;
                dergiemanetekleformu.button5.Visible = true;
                dergiemanetekleformu.button6.Visible = true;
                dergiemanetekleformu.button6.Text = Localization_EN.label64;
                dergiemanetekleformu.button5.Text = Localization_EN.label51;
                dergiemanetekleformu.button1.Location = new Point(910, 277);
                dergiemanetekleformu.button5.Location = new Point(910, 207);
                dergiemanetekleformu.button6.Location = new Point(910, 137);
                dergiemanetekleformu.button1.Text = Localization_EN.label52;
                dergiemanetekleformu.Show();
                this.Hide();
            }
            else
            {
                dergiemanetekleformu.label1.Text = Localization_TR.label60;
                dergiemanetekleformu.label2.Text = Localization_TR.label52;
                dergiemanetekleformu.label3.Text = Localization_TR.label42;
                dergiemanetekleformu.label4.Text = Localization_TR.label61;
                dergiemanetekleformu.label5.Text = Localization_TR.label53;
                dergiemanetekleformu.label6.Text = Localization_TR.label54;
                dergiemanetekleformu.label7.Text = Localization_TR.label55;
                dergiemanetekleformu.label8.Visible = false;
                dergiemanetekleformu.label9.Visible = false;
                dergiemanetekleformu.label10.Visible = false;
                dergiemanetekleformu.textBox10.Visible = false;
                dergiemanetekleformu.label11.Visible = false;
                dergiemanetekleformu.textBox7.Visible = false;
                dergiemanetekleformu.textBox8.Visible = false;
                dergiemanetekleformu.textBox9.Visible = false;
                dergiemanetekleformu.textBox10.Visible = false;
                dergiemanetekleformu.button5.Visible = true;
                dergiemanetekleformu.button6.Visible = true;
                dergiemanetekleformu.button5.Text = Localization_TR.label62;
                dergiemanetekleformu.button1.Location = new Point(910, 277);
                dergiemanetekleformu.button5.Location = new Point(910, 207);
                dergiemanetekleformu.button6.Location = new Point(910, 137);
                dergiemanetekleformu.button1.Text = Localization_TR.label63;
                dergiemanetekleformu.Show();
                this.Hide();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tumislemler dergiemanetsilmeformu = new tumislemler();
            if(button4.Text==Localization_EN.label15)
            {
                dergiemanetsilmeformu.label1.Text = Localization_EN.label13;
                dergiemanetsilmeformu.label2.Text = Localization_EN.label42;
                dergiemanetsilmeformu.label3.Text = Localization_EN.label37;
                dergiemanetsilmeformu.label4.Text = Localization_EN.label50;
                dergiemanetsilmeformu.label5.Text = Localization_EN.label43;
                dergiemanetsilmeformu.label6.Text = Localization_EN.label44;
                dergiemanetsilmeformu.label7.Text = Localization_EN.label45;
                dergiemanetsilmeformu.label8.Visible = false;
                dergiemanetsilmeformu.label9.Visible = false;
                dergiemanetsilmeformu.label10.Visible = false;
                dergiemanetsilmeformu.textBox10.Visible = false;
                dergiemanetsilmeformu.label11.Visible = false;
                dergiemanetsilmeformu.textBox7.Visible = false;
                dergiemanetsilmeformu.textBox8.Visible = false;
                dergiemanetsilmeformu.textBox9.Visible = false;
                dergiemanetsilmeformu.textBox10.Visible = false;
                dergiemanetsilmeformu.button5.Visible = true;
                dergiemanetsilmeformu.button6.Visible = true;
                dergiemanetsilmeformu.button6.Text = Localization_EN.label64;
                dergiemanetsilmeformu.button5.Text = Localization_EN.label51;
                dergiemanetsilmeformu.button1.Location = new Point(910, 277);
                dergiemanetsilmeformu.button5.Location = new Point(910, 207);
                dergiemanetsilmeformu.button6.Location = new Point(910, 137);
                dergiemanetsilmeformu.button1.Text = Localization_EN.label53;
                dergiemanetsilmeformu.Show();
                this.Hide();
            }
            else
            {
                dergiemanetsilmeformu.label1.Text = Localization_TR.label60;
                dergiemanetsilmeformu.label2.Text = Localization_TR.label52;
                dergiemanetsilmeformu.label3.Text = Localization_TR.label42;
                dergiemanetsilmeformu.label4.Text = Localization_TR.label61;
                dergiemanetsilmeformu.label5.Text = Localization_TR.label53;
                dergiemanetsilmeformu.label6.Text = Localization_TR.label54;
                dergiemanetsilmeformu.label7.Text = Localization_TR.label55;
                dergiemanetsilmeformu.label8.Visible = false;
                dergiemanetsilmeformu.label9.Visible = false;
                dergiemanetsilmeformu.label10.Visible = false;
                dergiemanetsilmeformu.textBox10.Visible = false;
                dergiemanetsilmeformu.label11.Visible = false;
                dergiemanetsilmeformu.textBox7.Visible = false;
                dergiemanetsilmeformu.textBox8.Visible = false;
                dergiemanetsilmeformu.textBox9.Visible = false;
                dergiemanetsilmeformu.textBox10.Visible = false;
                dergiemanetsilmeformu.button5.Visible = true;
                dergiemanetsilmeformu.button6.Visible = true;
                dergiemanetsilmeformu.button5.Text = Localization_TR.label62;
                dergiemanetsilmeformu.button1.Location = new Point(910, 277);
                dergiemanetsilmeformu.button5.Location = new Point(910, 207);
                dergiemanetsilmeformu.button6.Location = new Point(910, 137);
                dergiemanetsilmeformu.button1.Text = Localization_TR.label64;
                dergiemanetsilmeformu.Show();
                this.Hide();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tumislemler dergiemanetguncelformu = new tumislemler();
            if(button9.Text==Localization_EN.label16)
            {
                dergiemanetguncelformu.label1.Text = Localization_EN.label13;
                dergiemanetguncelformu.label2.Text = Localization_EN.label42;
                dergiemanetguncelformu.label3.Text = Localization_EN.label37;
                dergiemanetguncelformu.label4.Text = Localization_EN.label50;
                dergiemanetguncelformu.label5.Text = Localization_EN.label43;
                dergiemanetguncelformu.label6.Text = Localization_EN.label44;
                dergiemanetguncelformu.label7.Text = Localization_EN.label45;
                dergiemanetguncelformu.label8.Visible = false;
                dergiemanetguncelformu.label9.Visible = false;
                dergiemanetguncelformu.label10.Visible = false;
                dergiemanetguncelformu.textBox10.Visible = false;
                dergiemanetguncelformu.label11.Visible = false;
                dergiemanetguncelformu.textBox7.Visible = false;
                dergiemanetguncelformu.textBox8.Visible = false;
                dergiemanetguncelformu.textBox9.Visible = false;
                dergiemanetguncelformu.textBox10.Visible = false;
                dergiemanetguncelformu.button5.Visible = true;
                dergiemanetguncelformu.button6.Visible = true;
                dergiemanetguncelformu.button6.Text = Localization_EN.label64;
                dergiemanetguncelformu.button5.Text = Localization_EN.label51;
                dergiemanetguncelformu.button1.Location = new Point(910, 277);
                dergiemanetguncelformu.button5.Location = new Point(910, 207);
                dergiemanetguncelformu.button6.Location = new Point(910, 137);
                dergiemanetguncelformu.button1.Text = Localization_EN.label54;
                dergiemanetguncelformu.Show();
                this.Hide();
            }
            else
            {
                dergiemanetguncelformu.label1.Text = Localization_TR.label60;
                dergiemanetguncelformu.label2.Text = Localization_TR.label52;
                dergiemanetguncelformu.label3.Text = Localization_TR.label42;
                dergiemanetguncelformu.label4.Text = Localization_TR.label61;
                dergiemanetguncelformu.label5.Text = Localization_TR.label53;
                dergiemanetguncelformu.label6.Text = Localization_TR.label54;
                dergiemanetguncelformu.label7.Text = Localization_TR.label55;
                dergiemanetguncelformu.label8.Visible = false;
                dergiemanetguncelformu.label9.Visible = false;
                dergiemanetguncelformu.label10.Visible = false;
                dergiemanetguncelformu.textBox10.Visible = false;
                dergiemanetguncelformu.label11.Visible = false;
                dergiemanetguncelformu.textBox7.Visible = false;
                dergiemanetguncelformu.textBox8.Visible = false;
                dergiemanetguncelformu.textBox9.Visible = false;
                dergiemanetguncelformu.textBox10.Visible = false;
                dergiemanetguncelformu.button5.Visible = true;
                dergiemanetguncelformu.button6.Visible = true;
                dergiemanetguncelformu.button5.Text = Localization_TR.label62;
                dergiemanetguncelformu.button1.Location = new Point(910, 277);
                dergiemanetguncelformu.button5.Location = new Point(910, 207);
                dergiemanetguncelformu.button6.Location = new Point(910, 137);
                dergiemanetguncelformu.button1.Text = Localization_TR.label65;
                dergiemanetguncelformu.Show();
                this.Hide();
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tumislemler dergiekleme=new tumislemler();
            if(button15.Text==Localization_EN.label14)
            {
                dergiekleme.label1.Text = Localization_EN.label10;
                dergiekleme.label2.Text = Localization_EN.label50;
                dergiekleme.label3.Text = Localization_EN.label55;
                dergiekleme.label4.Text = Localization_EN.label56;
                dergiekleme.label5.Text = Localization_EN.label57;
                dergiekleme.label6.Text = Localization_EN.label58;
                dergiekleme.label7.Text = Localization_EN.label59;
                dergiekleme.label8.Text = Localization_EN.label28;
                dergiekleme.label9.Text = Localization_EN.label29;
                dergiekleme.label10.Text = Localization_EN.label30;
                dergiekleme.label12.Text = Localization_EN.label31;
                dergiekleme.label13.Text = Localization_EN.label33;
                dergiekleme.textBox12.Visible = true;
                dergiekleme.textBox11.Visible = true;
                dergiekleme.label13.Visible = true;
                dergiekleme.label12.Visible = true;
                dergiekleme.button4.Visible = true;
                dergiekleme.label13.Location = new Point(808, 251);
                dergiekleme.textBox12.Location = new Point(964, 256);
                dergiekleme.button4.Text = Localization_EN.label63;
                dergiekleme.button1.Text = Localization_EN.label60;
                dergiekleme.Show();
                this.Hide();
            }
            else
            {
                dergiekleme.label1.Text = Localization_TR.label66;
                dergiekleme.label2.Text = Localization_TR.label61;
                dergiekleme.label3.Text = Localization_TR.label67;
                dergiekleme.label4.Text = Localization_TR.label68;
                dergiekleme.label5.Text = Localization_TR.label69;
                dergiekleme.label6.Text = Localization_TR.label70;
                dergiekleme.label7.Text = Localization_TR.label71;
                dergiekleme.label8.Text = Localization_TR.label32;
                dergiekleme.label9.Text = Localization_TR.label33;
                dergiekleme.label10.Text = Localization_TR.label34;
                dergiekleme.label12.Text = Localization_TR.label35;
                dergiekleme.label13.Text = Localization_TR.label37;
                dergiekleme.textBox12.Visible = true;
                dergiekleme.textBox11.Visible = true;
                dergiekleme.label13.Visible = true;
                dergiekleme.label12.Visible = true;
                dergiekleme.button4.Visible = true;
                dergiekleme.label13.Location = new Point(808, 251);
                dergiekleme.textBox12.Location = new Point(964, 256);
                dergiekleme.button1.Text = Localization_TR.label72;
                dergiekleme.Show();
                this.Hide();
            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tumislemler dergisilme = new tumislemler();
            if(button13.Text==Localization_EN.label15)
            {
                dergisilme.label1.Text = Localization_EN.label10;
                dergisilme.label2.Text = Localization_EN.label50;
                dergisilme.label3.Text = Localization_EN.label55;
                dergisilme.label4.Text = Localization_EN.label56;
                dergisilme.label5.Text = Localization_EN.label57;
                dergisilme.label6.Text = Localization_EN.label58;
                dergisilme.label7.Text = Localization_EN.label59;
                dergisilme.label8.Text = Localization_EN.label28;
                dergisilme.label9.Text = Localization_EN.label29;
                dergisilme.label10.Text = Localization_EN.label30;
                dergisilme.label12.Text = Localization_EN.label31;
                dergisilme.label13.Text = Localization_EN.label33;
                dergisilme.textBox12.Visible = true;
                dergisilme.textBox11.Visible = true;
                dergisilme.label13.Visible = true;
                dergisilme.label12.Visible = true;
                dergisilme.button4.Visible = true;
                dergisilme.label13.Location = new Point(808, 251);
                dergisilme.textBox12.Location = new Point(964, 256);
                dergisilme.button4.Text = Localization_EN.label63;
                dergisilme.button1.Text = Localization_EN.label61;
                dergisilme.Show();
                this.Hide();
            }
            else
            {
                dergisilme.label1.Text = Localization_TR.label66;
                dergisilme.label2.Text = Localization_TR.label61;
                dergisilme.label3.Text = Localization_TR.label67;
                dergisilme.label4.Text = Localization_TR.label68;
                dergisilme.label5.Text = Localization_TR.label69;
                dergisilme.label6.Text = Localization_TR.label70;
                dergisilme.label7.Text = Localization_TR.label71;
                dergisilme.label8.Text = Localization_TR.label32;
                dergisilme.label9.Text = Localization_TR.label33;
                dergisilme.label10.Text = Localization_TR.label34;
                dergisilme.label12.Text = Localization_TR.label35;
                dergisilme.label13.Text = Localization_TR.label37;
                dergisilme.textBox12.Visible = true;
                dergisilme.textBox11.Visible = true;
                dergisilme.label13.Visible = true;
                dergisilme.label12.Visible = true;
                dergisilme.button4.Visible = true;
                dergisilme.label13.Location = new Point(808, 251);
                dergisilme.textBox12.Location = new Point(964, 256);
                dergisilme.button1.Text = Localization_TR.label73;
                dergisilme.Show();
                this.Hide();
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tumislemler dergiguncel = new tumislemler();
            if(button14.Text==Localization_EN.label16)
            {
                dergiguncel.label1.Text = Localization_EN.label10;
                dergiguncel.label2.Text = Localization_EN.label50;
                dergiguncel.label3.Text = Localization_EN.label55;
                dergiguncel.label4.Text = Localization_EN.label56;
                dergiguncel.label5.Text = Localization_EN.label57;
                dergiguncel.label6.Text = Localization_EN.label58;
                dergiguncel.label7.Text = Localization_EN.label59;
                dergiguncel.label8.Text = Localization_EN.label28;
                dergiguncel.label9.Text = Localization_EN.label29;
                dergiguncel.label10.Text = Localization_EN.label30;
                dergiguncel.label12.Text = Localization_EN.label31;
                dergiguncel.label13.Text = Localization_EN.label33;
                dergiguncel.textBox12.Visible = true;
                dergiguncel.textBox11.Visible = true;
                dergiguncel.label13.Visible = true;
                dergiguncel.label12.Visible = true;
                dergiguncel.button4.Visible = true;
                dergiguncel.label13.Location = new Point(808, 251);
                dergiguncel.textBox12.Location = new Point(964, 256);
                dergiguncel.button4.Text = Localization_EN.label63;
                dergiguncel.button1.Text = Localization_EN.label62;
                dergiguncel.Show();
                this.Hide();
            }
            else
            {
                dergiguncel.label1.Text = Localization_TR.label66;
                dergiguncel.label2.Text = Localization_TR.label61;
                dergiguncel.label3.Text = Localization_TR.label67;
                dergiguncel.label4.Text = Localization_TR.label68;
                dergiguncel.label5.Text = Localization_TR.label69;
                dergiguncel.label6.Text = Localization_TR.label70;
                dergiguncel.label7.Text = Localization_TR.label71;
                dergiguncel.label8.Text = Localization_TR.label32;
                dergiguncel.label9.Text = Localization_TR.label33;
                dergiguncel.label10.Text = Localization_TR.label34;
                dergiguncel.label12.Text = Localization_TR.label35;
                dergiguncel.label13.Text = Localization_TR.label37;
                dergiguncel.textBox11.Visible = true;
                dergiguncel.label12.Visible = true;
                dergiguncel.textBox12.Visible = true;
                dergiguncel.label13.Visible = true;
                dergiguncel.button4.Visible = true;
                dergiguncel.label13.Location = new Point(808, 251);
                dergiguncel.textBox12.Location = new Point(964, 256);
                dergiguncel.button1.Text = Localization_TR.label74;
                dergiguncel.Show();
                this.Hide();
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calisann geridon = new calisann();
            if(button1.Text==Localization_EN.label14)
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
        SqlDataAdapter adapter;

        private void button18_Click(object sender, EventArgs e)
        {
            tablogetir git = new tablogetir();
            db.Open();
            adapter = new SqlDataAdapter("select kitap.kitapID,kitap.ISBN,kitap.kitapadi,kitap.kitapyazari,kitap.kitapturu,kitap.sayfasayisi,kitap.yayinevi,kitap.yayinyili,kitap.yayinyeri,kitap.kitapozeti from kitap inner join kitapemanet on kitap.kitapID=kitapemanet.kitapID where kitapemanet.teslimtarihi < '01/01/2020'",db);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            git.dataGridView1.DataSource = tablo;
            db.Close();
            git.Show();
        }
    }
}
