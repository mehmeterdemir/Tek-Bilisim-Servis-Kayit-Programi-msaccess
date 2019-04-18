namespace Servis_Kayit_Otomasyonu_v._1._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtFirAd = new System.Windows.Forms.TextBox();
            this.txtBolge = new System.Windows.Forms.TextBox();
            this.txtCModel = new System.Windows.Forms.TextBox();
            this.txtSeriN = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dtpSozBas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpSozBitis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.veriTabaniDataSet = new Servis_Kayit_Otomasyonu_v._1._0.VeriTabaniDataSet();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmalarTableAdapter = new Servis_Kayit_Otomasyonu_v._1._0.VeriTabaniDataSetTableAdapters.firmalarTableAdapter();
            this.firmaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazmodeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sozbaslangicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sozbitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirAd
            // 
            this.txtFirAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFirAd.Location = new System.Drawing.Point(99, 36);
            this.txtFirAd.Multiline = true;
            this.txtFirAd.Name = "txtFirAd";
            this.txtFirAd.Size = new System.Drawing.Size(157, 31);
            this.txtFirAd.TabIndex = 0;
            // 
            // txtBolge
            // 
            this.txtBolge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBolge.Location = new System.Drawing.Point(99, 73);
            this.txtBolge.Multiline = true;
            this.txtBolge.Name = "txtBolge";
            this.txtBolge.Size = new System.Drawing.Size(157, 31);
            this.txtBolge.TabIndex = 0;
            // 
            // txtCModel
            // 
            this.txtCModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCModel.Location = new System.Drawing.Point(437, 36);
            this.txtCModel.Multiline = true;
            this.txtCModel.Name = "txtCModel";
            this.txtCModel.Size = new System.Drawing.Size(157, 31);
            this.txtCModel.TabIndex = 0;
            // 
            // txtSeriN
            // 
            this.txtSeriN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSeriN.Location = new System.Drawing.Point(437, 73);
            this.txtSeriN.Multiline = true;
            this.txtSeriN.Name = "txtSeriN";
            this.txtSeriN.Size = new System.Drawing.Size(157, 31);
            this.txtSeriN.TabIndex = 0;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Items.AddRange(new object[] {
            "1-Sözleşmeli",
            "2-Ücretli"});
            this.cmbDurum.Location = new System.Drawing.Point(99, 113);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(157, 21);
            this.cmbDurum.TabIndex = 1;
            // 
            // dtpSozBas
            // 
            this.dtpSozBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpSozBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSozBas.Location = new System.Drawing.Point(437, 111);
            this.dtpSozBas.Name = "dtpSozBas";
            this.dtpSozBas.Size = new System.Drawing.Size(157, 30);
            this.dtpSozBas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FİRMA ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BÖLGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CİHAZ MODELİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SERİ NUMARASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DURUMU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SÖZLEŞME BAŞLANGIÇ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaidDataGridViewTextBoxColumn,
            this.firmaadiDataGridViewTextBoxColumn,
            this.bolgeDataGridViewTextBoxColumn,
            this.cihazmodeliDataGridViewTextBoxColumn,
            this.serinoDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.sozbaslangicDataGridViewTextBoxColumn,
            this.sozbitisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(900, 331);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(600, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 139);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(706, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 139);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpSozBitis
            // 
            this.dtpSozBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpSozBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSozBitis.Location = new System.Drawing.Point(437, 148);
            this.dtpSozBitis.Name = "dtpSozBitis";
            this.dtpSozBitis.Size = new System.Drawing.Size(157, 30);
            this.dtpSozBitis.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SÖZLEŞME BİTİŞİ";
            // 
            // veriTabaniDataSet
            // 
            this.veriTabaniDataSet.DataSetName = "VeriTabaniDataSet";
            this.veriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataMember = "firmalar";
            this.firmalarBindingSource.DataSource = this.veriTabaniDataSet;
            // 
            // firmalarTableAdapter
            // 
            this.firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // firmaidDataGridViewTextBoxColumn
            // 
            this.firmaidDataGridViewTextBoxColumn.DataPropertyName = "firmaid";
            this.firmaidDataGridViewTextBoxColumn.HeaderText = "firmaid";
            this.firmaidDataGridViewTextBoxColumn.Name = "firmaidDataGridViewTextBoxColumn";
            this.firmaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmaadiDataGridViewTextBoxColumn
            // 
            this.firmaadiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmaadiDataGridViewTextBoxColumn.DataPropertyName = "firma_adi";
            this.firmaadiDataGridViewTextBoxColumn.HeaderText = "firma_adi";
            this.firmaadiDataGridViewTextBoxColumn.Name = "firmaadiDataGridViewTextBoxColumn";
            this.firmaadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolgeDataGridViewTextBoxColumn
            // 
            this.bolgeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolgeDataGridViewTextBoxColumn.DataPropertyName = "bolge";
            this.bolgeDataGridViewTextBoxColumn.HeaderText = "bolge";
            this.bolgeDataGridViewTextBoxColumn.Name = "bolgeDataGridViewTextBoxColumn";
            this.bolgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazmodeliDataGridViewTextBoxColumn
            // 
            this.cihazmodeliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cihazmodeliDataGridViewTextBoxColumn.DataPropertyName = "cihaz_modeli";
            this.cihazmodeliDataGridViewTextBoxColumn.HeaderText = "cihaz_modeli";
            this.cihazmodeliDataGridViewTextBoxColumn.Name = "cihazmodeliDataGridViewTextBoxColumn";
            this.cihazmodeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serinoDataGridViewTextBoxColumn
            // 
            this.serinoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serinoDataGridViewTextBoxColumn.DataPropertyName = "seri_no";
            this.serinoDataGridViewTextBoxColumn.HeaderText = "seri_no";
            this.serinoDataGridViewTextBoxColumn.Name = "serinoDataGridViewTextBoxColumn";
            this.serinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sozbaslangicDataGridViewTextBoxColumn
            // 
            this.sozbaslangicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sozbaslangicDataGridViewTextBoxColumn.DataPropertyName = "soz_baslangic";
            this.sozbaslangicDataGridViewTextBoxColumn.HeaderText = "soz_baslangic";
            this.sozbaslangicDataGridViewTextBoxColumn.Name = "sozbaslangicDataGridViewTextBoxColumn";
            this.sozbaslangicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sozbitisDataGridViewTextBoxColumn
            // 
            this.sozbitisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sozbitisDataGridViewTextBoxColumn.DataPropertyName = "soz_bitis";
            this.sozbitisDataGridViewTextBoxColumn.HeaderText = "soz_bitis";
            this.sozbitisDataGridViewTextBoxColumn.Name = "sozbitisDataGridViewTextBoxColumn";
            this.sozbitisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(811, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 138);
            this.button3.TabIndex = 7;
            this.button3.Text = "ANASAYFAYA DÖN\r\n<<-----------------";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 520);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSozBitis);
            this.Controls.Add(this.dtpSozBas);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.txtSeriN);
            this.Controls.Add(this.txtCModel);
            this.Controls.Add(this.txtBolge);
            this.Controls.Add(this.txtFirAd);
            this.Name = "Form1";
            this.Text = "FİRMA KAYIT EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirAd;
        private System.Windows.Forms.TextBox txtBolge;
        private System.Windows.Forms.TextBox txtCModel;
        private System.Windows.Forms.TextBox txtSeriN;
        private System.Windows.Forms.DateTimePicker dtpSozBas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpSozBitis;
        private System.Windows.Forms.Label label7;
        private VeriTabaniDataSet veriTabaniDataSet;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
        private VeriTabaniDataSetTableAdapters.firmalarTableAdapter firmalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazmodeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sozbaslangicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sozbitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}

