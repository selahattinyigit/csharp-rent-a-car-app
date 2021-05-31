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
    public partial class Form4 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        
        DataSet ds;
        OleDbCommandBuilder cmb;
        public Form4()
        {
            InitializeComponent();
        }
        public void göster()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galeri.accdb");
            da = new OleDbDataAdapter("select * from satkayıt", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satkayıt");
            dataGridView1.DataSource = ds.Tables["satkayıt"];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            göster();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (Form1.türü == "yönetici")
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galeri.accdb");
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE from satkayıt where PLAKA='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    göster();
                    
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
            da = new OleDbDataAdapter("SELECT *from satkayıt where PLAKA like '" + textBox5.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satkayıt");
            dataGridView1.DataSource = ds.Tables["satkayıt"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
