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
    public partial class DaftarHarga : Form
    {
        public DaftarHarga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl15 lbl15 = new lbl15();
            lbl15.Show(); 
            this.Close();
        }
    }
}
