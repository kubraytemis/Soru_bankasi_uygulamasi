using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_Bankası.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 1, dogru = 0, yanlis = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            label9.Text = btnA.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btn_sonraki.Enabled = true;

            if (label8.Text==label9.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label9.Text = btnB.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btn_sonraki.Enabled = true;

            if (label8.Text == label9.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label9.Text = btnC.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btn_sonraki.Enabled = true;

            if (label8.Text == label9.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label9.Text = btnD.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btn_sonraki.Enabled = true;

            if (label8.Text == label9.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = " Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1919";
                btnB.Text = "1920";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label8.Text = "1923";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                btn_sonraki.Enabled = false;

            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblsoruno.Text = soruno.ToString();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            //btn_sonraki.Enabled = false;

            if (soruno == 2)
            {
                richTextBox1.Text = " Sinekli Bakkal hangi yazar tarafından yazılmıştır?";
                btnA.Text = "Ömer Seyfettin";
                btnB.Text = "Halide Edip Adıvar";
                btnC.Text = "Reşat Nuri Güntekin";
                btnD.Text = "Ziya Gökalp";
                label8.Text = "Halide Edip Adıvar";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                btn_sonraki.Enabled =false ;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = " Galatasaray ne zaman kuruldu?";
                btnA.Text = "1905";
                btnB.Text = "1906";
                btnC.Text = "1911";
                btnD.Text = "1915";
                label8.Text = "1905";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                btn_sonraki.Enabled = false;
            }
            if(soruno==4)
            {
                richTextBox1.Text = " Katıldığınız için teşekkür ederiz";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btn_sonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru +"\n"+ "Yanlış:" + yanlis);
            }
        }

    } 
        
        
}
