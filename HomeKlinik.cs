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
    public partial class HomeKlinik : Form
    {
        public HomeKlinik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaftarHarga daftarHarga = new DaftarHarga();
            daftarHarga.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
