using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Servis_Kayit_Otomasyonu_v._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        System.Data.DataTable tablo = new System.Data.DataTable();


        private void button1_Click(object sender, EventArgs e)
        {

         //   firmaOlustur();
            listeleme();

        }

        private void listeleme()
        {
            tablo.Clear();
            baglanti.Open();
            komut = new OleDbCommand("Select *from firmalar", baglanti);
            adtr = new OleDbDataAdapter(komut);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        
        }

            

        private void firmaOlustur()
        {
           
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("INSERT INTO firmalar(firma_adi,bolge,cihaz_modeli,seri_no,durum,soz_baslangic,soz_bitis) values ('" + txtFirAd.Text + "','" + txtBolge.Text + "','" + txtCModel.Text + "','" + Convert.ToInt32(txtSeriN.Text)+ "','" + cmbDurum.Text + "','" + dtpSozBas.Text + "','"+dtpSozBitis.Text+"')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show(txtFirAd.Text+" Firmesı başarılı bir şekilde eklendi","KAYIT BAŞARILI",MessageBoxButtons.OK);

            }
            catch (Exception istisna)
            {

                MessageBox.Show(istisna.Message+ "Bir hata oluştu :");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa ana1 = new Anasayfa();
            ana1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa ana1 = new Anasayfa();
            ana1.Show();
            this.Hide();
        }
    }
}
