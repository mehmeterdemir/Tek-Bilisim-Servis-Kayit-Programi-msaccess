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
    public partial class Firma_Servis_Arama : Form
    {
        public Firma_Servis_Arama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        System.Data.DataTable tablo = new System.Data.DataTable();

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
          
            if (comboBox1.SelectedItem.ToString() == "FİRMA") ;
            {
                firmaya_gore_ara();
               
            }
            if (comboBox1.SelectedItem.ToString() == "MODEL") ;
            {
                modele_gore_ara();
                
            }
            if (comboBox1.SelectedItem.ToString() == "TARİH") ;
            {
                tarihe_gore_ara();
               
            }
	
        }

        private void firmaya_gore_ara()
        {

            baglanti.Open();
            System.Data.DataTable tablo = new System.Data.DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT *FROM servis_kaydi WHERE Firma_Adi LIKE '%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }
        private void modele_gore_ara()
        {

            baglanti.Open();
            System.Data.DataTable tablo = new System.Data.DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT *FROM servis_kaydi WHERE Cihaz_Modeli LIKE '%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }
        private void tarihe_gore_ara()
        {

            baglanti.Open();
            System.Data.DataTable tablo = new System.Data.DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT *FROM servis_kaydi WHERE Tarih LIKE '%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            label2.Text = comboBox1.SelectedItem.ToString()+" GİRİN :";
            textBox1.Enabled = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa ana1 = new Anasayfa();
            ana1.Show();
            this.Hide();
        }
    }
}
