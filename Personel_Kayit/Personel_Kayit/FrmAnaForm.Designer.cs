
namespace Personel_Kayit
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MedeniTxt = new System.Windows.Forms.TextBox();
            this.MeslekTxt = new System.Windows.Forms.TextBox();
            this.MaasTxt = new System.Windows.Forms.TextBox();
            this.SehirTxt = new System.Windows.Forms.TextBox();
            this.SoyadTxt = new System.Windows.Forms.TextBox();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrafiklerBtn = new System.Windows.Forms.Button();
            this.İstatistikBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medeniDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet2 = new Personel_Kayit.PersonelVeriTabaniDataSet2();
            this.personelInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet1 = new Personel_Kayit.PersonelVeriTabaniDataSet1();
            this.personelInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personel_InfoTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Personel_InfoTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.personel_InfoTableAdapter1 = new Personel_Kayit.PersonelVeriTabaniDataSet1TableAdapters.Personel_InfoTableAdapter();
            this.personel_InfoTableAdapter2 = new Personel_Kayit.PersonelVeriTabaniDataSet2TableAdapters.Personel_InfoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MedeniTxt);
            this.groupBox1.Controls.Add(this.MeslekTxt);
            this.groupBox1.Controls.Add(this.MaasTxt);
            this.groupBox1.Controls.Add(this.SehirTxt);
            this.groupBox1.Controls.Add(this.SoyadTxt);
            this.groupBox1.Controls.Add(this.AdTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(174, 50);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(167, 32);
            this.IdTxt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Personel Id :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MedeniTxt
            // 
            this.MedeniTxt.Location = new System.Drawing.Point(174, 277);
            this.MedeniTxt.Name = "MedeniTxt";
            this.MedeniTxt.Size = new System.Drawing.Size(167, 32);
            this.MedeniTxt.TabIndex = 8;
            // 
            // MeslekTxt
            // 
            this.MeslekTxt.Location = new System.Drawing.Point(174, 322);
            this.MeslekTxt.Name = "MeslekTxt";
            this.MeslekTxt.Size = new System.Drawing.Size(167, 32);
            this.MeslekTxt.TabIndex = 7;
            // 
            // MaasTxt
            // 
            this.MaasTxt.Location = new System.Drawing.Point(174, 231);
            this.MaasTxt.Name = "MaasTxt";
            this.MaasTxt.Size = new System.Drawing.Size(167, 32);
            this.MaasTxt.TabIndex = 4;
            // 
            // SehirTxt
            // 
            this.SehirTxt.Location = new System.Drawing.Point(174, 186);
            this.SehirTxt.Name = "SehirTxt";
            this.SehirTxt.Size = new System.Drawing.Size(167, 32);
            this.SehirTxt.TabIndex = 3;
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.Location = new System.Drawing.Point(174, 141);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(167, 32);
            this.SoyadTxt.TabIndex = 2;
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(174, 95);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(167, 32);
            this.AdTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Meslek :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medeni Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maaş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.GrafiklerBtn);
            this.groupBox2.Controls.Add(this.İstatistikBtn);
            this.groupBox2.Controls.Add(this.TemizleBtn);
            this.groupBox2.Controls.Add(this.SilBtn);
            this.groupBox2.Controls.Add(this.GüncelleBtn);
            this.groupBox2.Controls.Add(this.KaydetBtn);
            this.groupBox2.Controls.Add(this.ListeleBtn);
            this.groupBox2.Location = new System.Drawing.Point(422, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // GrafiklerBtn
            // 
            this.GrafiklerBtn.Location = new System.Drawing.Point(50, 300);
            this.GrafiklerBtn.Name = "GrafiklerBtn";
            this.GrafiklerBtn.Size = new System.Drawing.Size(174, 34);
            this.GrafiklerBtn.TabIndex = 6;
            this.GrafiklerBtn.Text = "Grafikler";
            this.GrafiklerBtn.UseVisualStyleBackColor = true;
            this.GrafiklerBtn.Click += new System.EventHandler(this.GrafiklerBtn_Click);
            // 
            // İstatistikBtn
            // 
            this.İstatistikBtn.Location = new System.Drawing.Point(50, 255);
            this.İstatistikBtn.Name = "İstatistikBtn";
            this.İstatistikBtn.Size = new System.Drawing.Size(174, 34);
            this.İstatistikBtn.TabIndex = 5;
            this.İstatistikBtn.Text = "İstatistik";
            this.İstatistikBtn.UseVisualStyleBackColor = true;
            this.İstatistikBtn.Click += new System.EventHandler(this.İstatistikBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Location = new System.Drawing.Point(50, 210);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(174, 34);
            this.TemizleBtn.TabIndex = 4;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = true;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(50, 165);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(174, 34);
            this.SilBtn.TabIndex = 3;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Location = new System.Drawing.Point(50, 120);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(174, 34);
            this.GüncelleBtn.TabIndex = 2;
            this.GüncelleBtn.Text = "Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Location = new System.Drawing.Point(50, 75);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(174, 34);
            this.KaydetBtn.TabIndex = 1;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.Location = new System.Drawing.Point(50, 30);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(174, 34);
            this.ListeleBtn.TabIndex = 0;
            this.ListeleBtn.Text = "Listele";
            this.ListeleBtn.UseVisualStyleBackColor = true;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(28, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.şehirDataGridViewTextBoxColumn,
            this.maaşDataGridViewTextBoxColumn,
            this.medeniDurumDataGridViewTextBoxColumn,
            this.meslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelInfoBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // şehirDataGridViewTextBoxColumn
            // 
            this.şehirDataGridViewTextBoxColumn.DataPropertyName = "Şehir";
            this.şehirDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.şehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.şehirDataGridViewTextBoxColumn.Name = "şehirDataGridViewTextBoxColumn";
            this.şehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // maaşDataGridViewTextBoxColumn
            // 
            this.maaşDataGridViewTextBoxColumn.DataPropertyName = "Maaş";
            this.maaşDataGridViewTextBoxColumn.HeaderText = "Maaş";
            this.maaşDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maaşDataGridViewTextBoxColumn.Name = "maaşDataGridViewTextBoxColumn";
            this.maaşDataGridViewTextBoxColumn.Width = 125;
            // 
            // medeniDurumDataGridViewTextBoxColumn
            // 
            this.medeniDurumDataGridViewTextBoxColumn.DataPropertyName = "MedeniDurum";
            this.medeniDurumDataGridViewTextBoxColumn.HeaderText = "MedeniDurum";
            this.medeniDurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medeniDurumDataGridViewTextBoxColumn.Name = "medeniDurumDataGridViewTextBoxColumn";
            this.medeniDurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.meslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            this.meslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelInfoBindingSource2
            // 
            this.personelInfoBindingSource2.DataMember = "Personel_Info";
            this.personelInfoBindingSource2.DataSource = this.personelVeriTabaniDataSet2;
            // 
            // personelVeriTabaniDataSet2
            // 
            this.personelVeriTabaniDataSet2.DataSetName = "PersonelVeriTabaniDataSet2";
            this.personelVeriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelInfoBindingSource1
            // 
            this.personelInfoBindingSource1.DataMember = "Personel_Info";
            this.personelInfoBindingSource1.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelInfoBindingSource
            // 
            this.personelInfoBindingSource.DataMember = "Personel_Info";
            this.personelInfoBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // personel_InfoTableAdapter
            // 
            this.personel_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // personel_InfoTableAdapter1
            // 
            this.personel_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // personel_InfoTableAdapter2
            // 
            this.personel_InfoTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1003, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MeslekTxt;
        private System.Windows.Forms.TextBox MaasTxt;
        private System.Windows.Forms.TextBox SehirTxt;
        private System.Windows.Forms.TextBox SoyadTxt;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GrafiklerBtn;
        private System.Windows.Forms.Button İstatistikBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SilBtn;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource personelInfoBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Personel_InfoTableAdapter personel_InfoTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MedeniTxt;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource personelInfoBindingSource1;
        private PersonelVeriTabaniDataSet1TableAdapters.Personel_InfoTableAdapter personel_InfoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet2 personelVeriTabaniDataSet2;
        private System.Windows.Forms.BindingSource personelInfoBindingSource2;
        private PersonelVeriTabaniDataSet2TableAdapters.Personel_InfoTableAdapter personel_InfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medeniDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Button button1;
    }
}

