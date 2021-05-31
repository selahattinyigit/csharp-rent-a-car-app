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
    public partial class Form10 : Form
    {
       
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbCommandBuilder cmb;
        public Form10()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            göster();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            göster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galeri.accdb");
            con.Open();
            cmd = new OleDbCommand("SELECT * FROM satkayıt WHERE SATIŞ_TARİHİ    BETWEEN ? AND ?", con);
            cmd.Parameters.AddWithValue("tarih1", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("tarih2", dateTimePicker2.Value);
            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
