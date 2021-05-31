namespace galeri
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılanaraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenliÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 482);
            this.dataGridView1.TabIndex = 38;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(656, 512);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 133);
            this.button7.TabIndex = 37;
            this.button7.Text = "SAT&";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 80);
            this.label1.TabIndex = 36;
            this.label1.Text = " \r\n     A r a ç      B u l     \r\n     (Plakaya Göre)\r\n\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(690, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 24);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(3, 595);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 50);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(801, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 133);
            this.button5.TabIndex = 33;
            this.button5.Text = "KAPAT ESC";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(486, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 133);
            this.button3.TabIndex = 32;
            this.button3.Text = "&SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(184, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 133);
            this.button1.TabIndex = 31;
            this.button1.Text = "&EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(335, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 133);
            this.button2.TabIndex = 39;
            this.button2.Text = "&DÜZENLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayıtİşlemleriToolStripMenuItem
            // 
            this.kayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem});
            this.kayıtİşlemleriToolStripMenuItem.Name = "kayıtİşlemleriToolStripMenuItem";
            this.kayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.kayıtİşlemleriToolStripMenuItem.Text = "Kayıt İşlemleri";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // satılanaraçlarToolStripMenuItem
            // 
            this.satılanaraçlarToolStripMenuItem.Name = "satılanaraçlarToolStripMenuItem";
            this.satılanaraçlarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.satılanaraçlarToolStripMenuItem.Text = "Satılan Araçlar";
            this.satılanaraçlarToolStripMenuItem.Click += new System.EventHandler(this.satılanaraçlarToolStripMenuItem_Click);
            // 
            // girişİşlemleriToolStripMenuItem
            // 
            this.girişİşlemleriToolStripMenuItem.Name = "girişİşlemleriToolStripMenuItem";
            this.girişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.girişİşlemleriToolStripMenuItem.Text = "Giriş İşlemleri";
            this.girişİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.girişİşlemleriToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // sıralamaToolStripMenuItem
            // 
            this.sıralamaToolStripMenuItem.Name = "sıralamaToolStripMenuItem";
            this.sıralamaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.sıralamaToolStripMenuItem.Text = "kullanıcı değiştir";
            this.sıralamaToolStripMenuItem.Click += new System.EventHandler(this.sıralamaToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güvenliÇıkışToolStripMenuItem});
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // güvenliÇıkışToolStripMenuItem
            // 
            this.güvenliÇıkışToolStripMenuItem.Name = "güvenliÇıkışToolStripMenuItem";
            this.güvenliÇıkışToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.güvenliÇıkışToolStripMenuItem.Text = "Güvenli Çıkış";
            this.güvenliÇıkışToolStripMenuItem.Click += new System.EventHandler(this.güvenliÇıkışToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtİşlemleriToolStripMenuItem,
            this.satılanaraçlarToolStripMenuItem,
            this.girişİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.sıralamaToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "aaaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(516, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 41;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "GALERİ KAYIT PROGRAMI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılanaraçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenliÇıkışToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
    }
}