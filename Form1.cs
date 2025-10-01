using System.Numerics;

namespace pengeluaran_harian_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            // Isi pilihan kategori
            cmbkategori.Items.AddRange(new string[] { "Makanan", "Pakaian", "Belanja", "Transportasi" });

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbkategori.SelectedIndex;
            switch (pilih)
            {
                case 0://Makanan
                    txttotalpengeluaran.Text = "50000";
                    txtjumlahtransaksi.Text = "1";
                    break;
                case 1://Pakaian
                    txttotalpengeluaran.Text = "100000";
                    txtjumlahtransaksi.Text = "1";
                    break;
                case 2://Belanja
                    txttotalpengeluaran.Text = "150000";
                    txtjumlahtransaksi.Text = "1";
                    break;
                case 3://Transportasi
                    txttotalpengeluaran.Text = "20000";
                    txtjumlahtransaksi.Text = "1";
                    break;
            }

        }
    }
}
