using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Kayit_Otomasyonu_v._1._0
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void firmaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void servisGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerGiris ser1 = new SerGiris();
            ser1.Show();
            this.Hide();
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma_Servis_Arama firser1 = new Firma_Servis_Arama();
            firser1.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
