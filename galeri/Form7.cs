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
    public partial class Form7 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==""&textBox6.Text=="")
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
            cmd.CommandText = "insert into giris (giris_türü,adi,sifresi) values ('"+ label1.Text+"','" + textBox6.Text + "','" + textBox2.Text +  "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt eklendi");
            
            textBox6.Clear();
            textBox2.Clear();
            }
              }
              catch (Exception hata)
              {

                  MessageBox.Show(hata.Message);

              }
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 f1 = (Form6)Application.OpenForms["Form6"];
            f1.göster();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }
    }
}
