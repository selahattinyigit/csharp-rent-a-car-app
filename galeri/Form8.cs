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
    public partial class Form8 : Form
    {


        public Form8()
        {
            InitializeComponent();
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();
                Form6 frm1 = new Form6();
                cmd.CommandText = "UPDATE giris SET giris_türü='" + label1.Text + "',adi='" + textBox6.Text + "',sifresi='" + textBox2.Text + "'WHERE adi='" +textBox6.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt düzeltiidi");
                frm1.göster();
          

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 f1 = (Form6)Application.OpenForms["Form6"];
            f1.göster();
        }
    }
}
