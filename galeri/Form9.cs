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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "SIFIR")
            {
                textBox6.Text = "0";
                textBox6.Enabled = false;
            }
            else
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox3.Text == "" || comboBox1.Text==""||comboBox2.Text=="")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUN");
            } 
            else
            {
              try
               {
                DialogResult cevap;

                cevap = MessageBox.Show("Kaydı düzenlemek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if (cevap == DialogResult.Yes)
                  {
               OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
               OleDbCommand cmd = new OleDbCommand();
               cmd.Connection = con;
              con.Open();
              cmd.CommandText = "UPDATE arac SET PLAKA='" + textBox1.Text + "', ARAÇ_TİPİ='" + comboBox1.Text + "',MARKASI='" + textBox2.Text + "',MODELİ='" + maskedTextBox2.Text + "',DURUMU='" + comboBox2.Text + "',ALIŞ_FİYATI='" + textBox4.Text + "',SATIŞ_FİYATI='" + textBox5.Text + "',KM='" + textBox6.Text + "',GİRİŞ_TARİHİ='" + textBox3.Text + "'WHERE PLAKA='" + textBox1.Text + "'";
              cmd.ExecuteNonQuery();
              con.Close();
              MessageBox.Show("kayıt düzeltiidi");
              textBox1.Clear();
              textBox2.Clear();
              maskedTextBox2.Clear();
              textBox4.Clear();
              textBox5.Clear();
              textBox6.Clear();
              
              comboBox1.Text = "";
              comboBox2.Text = "";
              textBox3.Clear();
                  }
               }


              catch (Exception hata)
              {

                  MessageBox.Show(hata.Message);

              }
            }
            
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f1 = (Form2)Application.OpenForms["Form2"];
            f1.göster();
        }
    }
}
