namespace VeterinerKlinigi
{
    partial class HayvanListesiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnListele = new Button();
            btnEkle = new Button();
            btnMuayeneEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnGecmis = new Button();
            dgvHayvanlar = new DataGridView();
            pbSahipProfil = new PictureBox();
            lblSahipProfilResmi = new Label();
            lblArama = new Label();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSahipProfil).BeginInit();
            SuspendLayout();
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblArama.Location = new Point(12, 16);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(130, 17);
            lblArama.TabIndex = 9;
            lblArama.Text = "Hýzlý Arama (Ad/Tür):";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 9.75F);
            txtArama.Location = new Point(148, 13);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(250, 25);
            txtArama.TabIndex = 10;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnListele
            // 
            btnListele.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListele.BackColor = Color.FromArgb(19, 107, 94);
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(12, 377);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(130, 40);
            btnListele.TabIndex = 1;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.BackColor = Color.FromArgb(19, 107, 94);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(148, 377);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 40);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Hayvan Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuncelle.BackColor = Color.FromArgb(19, 107, 94);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(284, 377);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 40);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnMuayeneEkle
            // 
            btnMuayeneEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMuayeneEkle.BackColor = Color.FromArgb(19, 107, 94);
            btnMuayeneEkle.FlatStyle = FlatStyle.Flat;
            btnMuayeneEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMuayeneEkle.ForeColor = Color.White;
            btnMuayeneEkle.Location = new Point(420, 377);
            btnMuayeneEkle.Name = "btnMuayeneEkle";
            btnMuayeneEkle.Size = new Size(130, 40);
            btnMuayeneEkle.TabIndex = 4;
            btnMuayeneEkle.Text = "Muayene Ekle";
            btnMuayeneEkle.UseVisualStyleBackColor = false;
            btnMuayeneEkle.Click += btnMuayeneEkle_Click;
            // 
            // btnGecmis
            // 
            btnGecmis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGecmis.BackColor = Color.FromArgb(19, 107, 94);
            btnGecmis.FlatStyle = FlatStyle.Flat;
            btnGecmis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGecmis.ForeColor = Color.White;
            btnGecmis.Location = new Point(556, 377);
            btnGecmis.Name = "btnGecmis";
            btnGecmis.Size = new Size(130, 40);
            btnGecmis.TabIndex = 5;
            btnGecmis.Text = "Geçmiþ Gör";
            btnGecmis.UseVisualStyleBackColor = false;
            btnGecmis.Click += btnGecmis_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.BackColor = Color.DarkRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(692, 377);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 40);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvHayvanlar
            // 
            dgvHayvanlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHayvanlar.BackgroundColor = Color.White;
            dgvHayvanlar.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 107, 94);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(19, 107, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHayvanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHayvanlar.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(38, 166, 154);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHayvanlar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHayvanlar.EnableHeadersVisualStyles = false;
            dgvHayvanlar.Location = new Point(12, 45); // Asagi kaydirdik
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.RowHeadersVisible = false;
            dgvHayvanlar.RowTemplate.Height = 30;
            dgvHayvanlar.Size = new Size(827, 314);
            dgvHayvanlar.TabIndex = 0;
            dgvHayvanlar.SelectionChanged += dgvHayvanlar_SelectionChanged;
            // 
            // pbSahipProfil
            // 
            pbSahipProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSahipProfil.BorderStyle = BorderStyle.FixedSingle;
            pbSahipProfil.Location = new Point(854, 70);
            pbSahipProfil.Name = "pbSahipProfil";
            pbSahipProfil.Size = new Size(200, 200);
            pbSahipProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbSahipProfil.TabIndex = 7;
            pbSahipProfil.TabStop = false;
            // 
            // lblSahipProfilResmi
            // 
            lblSahipProfilResmi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSahipProfilResmi.AutoSize = true;
            lblSahipProfilResmi.Location = new Point(854, 45);
            lblSahipProfilResmi.Name = "lblSahipProfilResmi";
            lblSahipProfilResmi.Size = new Size(70, 15);
            lblSahipProfilResmi.TabIndex = 8;
            lblSahipProfilResmi.Text = "Hayvan Resmi";
            // 
            // HayvanListesiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 429);
            Controls.Add(txtArama);
            Controls.Add(lblArama);
            Controls.Add(lblSahipProfilResmi);
            Controls.Add(pbSahipProfil);
            Controls.Add(dgvHayvanlar);
            Controls.Add(btnListele);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnMuayeneEkle);
            Controls.Add(btnGecmis);
            Controls.Add(btnSil);
            MinimumSize = new Size(1000, 450);
            Name = "HayvanListesiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hayvan Listesi";
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSahipProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnMuayeneEkle;
        private Button btnGecmis;
        private Button btnSil;
        private DataGridView dgvHayvanlar;
        private PictureBox pbSahipProfil;
        private Label lblSahipProfilResmi;
        private Label lblArama;
        private TextBox txtArama;
    }
}