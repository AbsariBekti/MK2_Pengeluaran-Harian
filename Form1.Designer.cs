namespace pengeluaran_harian_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtjumlahtransaksi = new TextBox();
            txtcatatan = new TextBox();
            txttotalpengeluaran = new TextBox();
            LBLPENGELUARAN = new Label();
            label1 = new Label();
            groupjumlahtransaksi = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grouptotalpengeluaran = new GroupBox();
            grouptambahpengeluaran = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbkategori = new ComboBox();
            txttanggal = new TextBox();
            groupjumlahtransaksi.SuspendLayout();
            grouptotalpengeluaran.SuspendLayout();
            grouptambahpengeluaran.SuspendLayout();
            SuspendLayout();
            // 
            // txtjumlahtransaksi
            // 
            txtjumlahtransaksi.Location = new Point(18, 40);
            txtjumlahtransaksi.Name = "txtjumlahtransaksi";
            txtjumlahtransaksi.Size = new Size(169, 31);
            txtjumlahtransaksi.TabIndex = 0;
            txtjumlahtransaksi.TextChanged += textBox1_TextChanged;
            // 
            // txtcatatan
            // 
            txtcatatan.Location = new Point(27, 248);
            txtcatatan.Name = "txtcatatan";
            txtcatatan.Size = new Size(243, 31);
            txtcatatan.TabIndex = 1;
            txtcatatan.TextChanged += textBox2_TextChanged;
            // 
            // txttotalpengeluaran
            // 
            txttotalpengeluaran.Location = new Point(27, 40);
            txttotalpengeluaran.Name = "txttotalpengeluaran";
            txttotalpengeluaran.Size = new Size(144, 31);
            txttotalpengeluaran.TabIndex = 2;
            txttotalpengeluaran.TextChanged += textBox3_TextChanged;
            // 
            // LBLPENGELUARAN
            // 
            LBLPENGELUARAN.AutoSize = true;
            LBLPENGELUARAN.Location = new Point(147, 9);
            LBLPENGELUARAN.Name = "LBLPENGELUARAN";
            LBLPENGELUARAN.Size = new Size(204, 25);
            LBLPENGELUARAN.TabIndex = 3;
            LBLPENGELUARAN.Text = "PENGELUARAN HARIAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 131);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 8;
            label1.Text = "Kategori";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupjumlahtransaksi
            // 
            groupjumlahtransaksi.BackColor = SystemColors.ActiveBorder;
            groupjumlahtransaksi.Controls.Add(txtjumlahtransaksi);
            groupjumlahtransaksi.Location = new Point(272, 54);
            groupjumlahtransaksi.Name = "groupjumlahtransaksi";
            groupjumlahtransaksi.Size = new Size(210, 86);
            groupjumlahtransaksi.TabIndex = 9;
            groupjumlahtransaksi.TabStop = false;
            groupjumlahtransaksi.Text = "JUMLAH TRANSAKSI";
            groupjumlahtransaksi.Enter += groupBox1_Enter;
            // 
            // grouptotalpengeluaran
            // 
            grouptotalpengeluaran.BackColor = SystemColors.ActiveBorder;
            grouptotalpengeluaran.Controls.Add(txttotalpengeluaran);
            grouptotalpengeluaran.Location = new Point(23, 54);
            grouptotalpengeluaran.Name = "grouptotalpengeluaran";
            grouptotalpengeluaran.Size = new Size(206, 86);
            grouptotalpengeluaran.TabIndex = 10;
            grouptotalpengeluaran.TabStop = false;
            grouptotalpengeluaran.Text = "TOTAL PENGELUARAN";
            grouptotalpengeluaran.Enter += groupBox2_Enter;
            // 
            // grouptambahpengeluaran
            // 
            grouptambahpengeluaran.BackColor = SystemColors.ActiveBorder;
            grouptambahpengeluaran.Controls.Add(label4);
            grouptambahpengeluaran.Controls.Add(textBox1);
            grouptambahpengeluaran.Controls.Add(label3);
            grouptambahpengeluaran.Controls.Add(label2);
            grouptambahpengeluaran.Controls.Add(cmbkategori);
            grouptambahpengeluaran.Controls.Add(txttanggal);
            grouptambahpengeluaran.Controls.Add(txtcatatan);
            grouptambahpengeluaran.Controls.Add(label1);
            grouptambahpengeluaran.Location = new Point(68, 169);
            grouptambahpengeluaran.Name = "grouptambahpengeluaran";
            grouptambahpengeluaran.Size = new Size(377, 405);
            grouptambahpengeluaran.TabIndex = 11;
            grouptambahpengeluaran.TabStop = false;
            grouptambahpengeluaran.Text = "TAMBAH PENGELUARAN";
            grouptambahpengeluaran.Enter += groupBox3_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 220);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 12;
            label4.Text = "Harga";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 331);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 303);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 10;
            label3.Text = "Catatan";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 9;
            label2.Text = "Tanggal";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbkategori
            // 
            cmbkategori.AutoCompleteCustomSource.AddRange(new string[] { "Makanan", "Pakaian", "Belanja", "Transportasi" });
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Items.AddRange(new object[] { "Makanan", "Pakaian", "Belanja", "Transportasi" });
            cmbkategori.Location = new Point(27, 159);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(243, 33);
            cmbkategori.TabIndex = 3;
            cmbkategori.SelectedIndexChanged += cmbkategori_SelectedIndexChanged;
            // 
            // txttanggal
            // 
            txttanggal.Location = new Point(27, 82);
            txttanggal.Name = "txttanggal";
            txttanggal.Size = new Size(243, 31);
            txttanggal.TabIndex = 2;
            txttanggal.TextChanged += textBox7_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(569, 596);
            Controls.Add(grouptambahpengeluaran);
            Controls.Add(grouptotalpengeluaran);
            Controls.Add(groupjumlahtransaksi);
            Controls.Add(LBLPENGELUARAN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupjumlahtransaksi.ResumeLayout(false);
            groupjumlahtransaksi.PerformLayout();
            grouptotalpengeluaran.ResumeLayout(false);
            grouptotalpengeluaran.PerformLayout();
            grouptambahpengeluaran.ResumeLayout(false);
            grouptambahpengeluaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtjumlahtransaksi;
        private TextBox txtcatatan;
        private TextBox txttotalpengeluaran;
        private Label LBLPENGELUARAN;
        private Label label1;
        private GroupBox groupjumlahtransaksi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grouptotalpengeluaran;
        private GroupBox grouptambahpengeluaran;
        private TextBox txttanggal;
        private ComboBox cmbkategori;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}
