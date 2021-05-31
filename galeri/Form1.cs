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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public static string türü;
        public static string ad;
        private void button1_Click(object sender, EventArgs e)
        {

            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM giris where adi='" + textBox1.Text + "' AND sifresi='" + textBox2.Text + "'";   
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                türü = dr["giris_türü"].ToString();
                ad = dr["adi"].ToString();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
