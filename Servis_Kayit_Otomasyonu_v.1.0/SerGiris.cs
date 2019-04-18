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
    public partial class SerGiris : Form
    {
        public SerGiris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        System.Data.DataTable tablo = new System.Data.DataTable();

        private void SerGiris_Load(object sender, EventArgs e)
        {
            Combo_listeleme();
        }

        private void Combo_listeleme()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText="SELECT *from firmalar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            OleDbDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbFirma.Items.Add(dr["firma_adi"]);
            }
            baglanti.Close();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ServisKaydiGir();
        }
        private void ServisKaydiGir()
        {

            try
            {
                baglanti.Open();
                komut = new OleDbCommand("INSERT INTO servis_kaydi(Firma_adi,Cihaz_Modeli,Tarih,Numarator,Ariza,Yapilan_Islem,Degisilen_Malzeme,Degismesi_Gereken_Malzeme,Ser_Yetk_Adi,Musteri_Yetkilisi) values ('" + cmbFirma.Text + "','" + txtModel.Text + "','" + dtpTar.Text + "','" + txtNumarator.Text + "','" + txtAriza.Text + "','" + txtYapİs.Text + "','" + txtDegMalz.Text + "','" + txtDegGerMalz.Text + "','" + txtTekBil.Text + "','" + txtMusYet.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show(cmbFirma.SelectedItem.ToString() + " Firmesının servis kaydı başarılı bir şekilde eklendi", "KAYIT BAŞARILI", MessageBoxButtons.OK);

            }
            catch (Exception istisna)
            {

                MessageBox.Show(istisna.Message + "Bir hata oluştu :");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa ana1 = new Anasayfa();
            ana1.Show();
            this.Hide();
        }
    }
}
