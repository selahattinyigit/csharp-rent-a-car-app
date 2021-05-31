using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace galeri
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text==""||comboBox2.Text=="")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUN");
            } 
            else
            {
              try
               {
                DialogResult cevap;

                cevap = MessageBox.Show("Kaydı eklemek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if (cevap == DialogResult.Yes)
                  {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into arac(PLAKA,ARAÇ_TİPİ,MARKASI,MODELİ,DURUMU,ALIŞ_FİYATI,SATIŞ_FİYATI,KM,GİRİŞ_TARİHİ) values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + DateTime.Now.ToString("yyyy.MM.dd") + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT EKLENDİ");
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            comboBox1.Text = "";
            comboBox2.Text = "";
            
                  }
               }


              catch (Exception hata)
              {

                  MessageBox.Show(hata.Message);

              }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f1 = (Form2)Application.OpenForms["Form2"];
            f1.göster();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "SIFIR")
            {
                textBox6.Text = "0";
                textBox6.Enabled = false;
                maskedTextBox2.Text = "2016";
                
            }
            else
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
