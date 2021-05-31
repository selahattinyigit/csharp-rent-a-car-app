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
    public partial class Form2 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        
        DataSet ds;
        OleDbCommandBuilder cmb;
        public Form2()
        {
            InitializeComponent();
        }
        public void göster()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galeri.accdb");
            da = new OleDbDataAdapter("select * from arac", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            con.Close();
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
                        cmd.CommandText = "DELETE from arac where PLAKA='"+ dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=dataGridView1.RowCount;
            if (sayi > 1)
            {
                Form5 frm = new Form5();
                frm.Show();
                frm.textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


                frm.textBox3.Enabled = false;
                
            }
            else
                MessageBox.Show("seçili kayıt yok");
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void satılanaraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void güvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "sayın   " + Form1.türü +" "+Form1.ad;
            if (Form1.türü == "kullanıcı")
            {
                
                girişİşlemleriToolStripMenuItem.Enabled = false;
                raporlamaToolStripMenuItem.Enabled = false;
            }
            else 
            {
                
                girişİşlemleriToolStripMenuItem.Enabled = true;
                raporlamaToolStripMenuItem.Enabled = true;
            }
            göster();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galeri.accdb");
            da = new OleDbDataAdapter("SELECT *from arac where PLAKA like '" + textBox1.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int sayi;
            sayi=dataGridView1.RowCount;
            if (sayi > 1)
            {
            Form9 frm = new Form9();
            frm.Show();
            frm.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox1.Enabled = false;
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox3.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.textBox3.Visible = false;
            frm.label7.Visible = false;
            }
            else
                MessageBox.Show("seçili kayıt yok");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void girişİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
        }

        private void sıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form1 frm = new Form1();
             frm.Show();
             this.Hide();
        }
    }
}
