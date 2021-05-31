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
    public partial class Form5 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox2.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ YERLERİ DOLDURUN");
            } 
            else
            {
              try
               {
                DialogResult cevap;

                cevap = MessageBox.Show("Satmak istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if (cevap == DialogResult.Yes)
                  {
                  OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
                  con.Open();
                 OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into satkayıt (PLAKA,TC_KİMLİK,AD_SOYAD,SATIŞ_FİYATI,SATIŞI_YAPAN,SATIŞ_TARİHİ) values ('" + textBox3.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + label7.Text + "','" + DateTime.Now.ToString("yyyy.MM.dd") + "')";
               cmd.ExecuteNonQuery();
              OleDbCommand kom = new OleDbCommand();
              kom.Connection = con;
             kom.CommandText = "DELETE from arac where PLAKA='" + textBox3.Text + "'";
             kom.ExecuteNonQuery();
             con.Close();
            MessageBox.Show("ARAÇ SATILDI");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
            textBox6.Text = "";

                }
              }
            
            
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);

            }
        }
       
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.göster();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.ToUpper();
            textBox3.SelectionStart = textBox3.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label7.Text = Form1.ad;
        }
    }
}
