using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikApp
{
    public partial class lbl15 : Form
    {
        private Dictionary<string, int> hargaObat = new Dictionary<string, int>
        {
            { "Vitamin C", 45000 },
            { "Somet Hinc", 60000 },
            { "Bio True", 35000 },
            { "Facial Wash", 150000 },
            { "Renu Fresh", 450000 },
            { "Brightening", 30000 },
            { "Caraptha", 70000 },
            { "Skin Savior", 30000 },
            { "X2B1", 550000 }
        };
        private int biayaPendaftaran = 25000;
        private int biayaKonsultasi = 100000;
        public lbl15()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var obat in hargaObat.Keys)
            {
                comboBox1.Items.Add(obat);
            }
            comboBox1.SelectedIndex = 0;
            for (int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedObat = comboBox1.SelectedItem.ToString();
            lblHarga.Text = hargaObat[selectedObat].ToString("C0");
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedObat = comboBox1.SelectedItem.ToString();
                int harga = hargaObat[selectedObat];
                int jumlahProduk = (int)comboBox2.SelectedItem;
                int biayaObat = harga * jumlahProduk;
                int biayaLab = checkBox1.Checked ? 500000 : 0;
                int subtotal = biayaPendaftaran + biayaKonsultasi + biayaObat + biayaLab;
                double diskon = 0;
                if (subtotal > 1000000)
                {
                    diskon = subtotal * 0.10;
                }
                double total = subtotal - diskon;

                lblBiayaPendaftaran.Text = biayaPendaftaran.ToString("C0");
                lblBiayaKonsultasiDokter.Text = biayaKonsultasi.ToString("C0");
                lblBiayaObat.Text = biayaObat.ToString("C0");
                lblBiayaLabolatorium.Text = biayaLab.ToString("C0");
                lblSubtotal.Text = subtotal.ToString("C0");
                lblDiskon.Text = diskon.ToString("C0");
                lblTotal.Text = total.ToString("C0");
                lblJumlahObat.Text = jumlahProduk.ToString("N0"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DaftarHarga daftarHarga = new DaftarHarga();
            daftarHarga.Show(); 
            this.Close();
        }
    }
}
