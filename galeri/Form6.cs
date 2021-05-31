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
    public partial class Form6 : Form
    {
        OleDbConnection con;

        OleDbDataAdapter da;
        OleDbDataReader dr;
        DataSet ds;

        public Form6()
        {
            InitializeComponent();
        }
        public void göster()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galeri.accdb");
            da = new OleDbDataAdapter("select * from giris", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "giris");
            dataGridView1.DataSource = ds.Tables["giris"];
            con.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            göster();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ("kullanıcı" == dataGridView1.CurrentRow.Cells[0].Value.ToString())
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
 
                        cmd.CommandText = "DELETE from giris where adi='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
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
            else
            { MessageBox.Show("yönetici silinemez"); }
        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            if ("kullanıcı" == dataGridView1.CurrentRow.Cells[0].Value.ToString())
            {
                Form8 frm1 = new Form8();
                frm1.Show();
               
                frm1.textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm1.textBox6.Enabled = false;
                frm1.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            { MessageBox.Show("yönetici düzeltilemez");}
        }
    }
}
