namespace VeterinerKlinigi
{
    partial class HayvanListesiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnListele = new Button();
            btnEkle = new Button();
            btnMuayeneEkle = new Button();
            btnSil = new Button(); // Butonu tanýmlýyoruz
            dgvHayvanlar = new DataGridView();
            pbSahipProfil = new PictureBox();
            lblSahipProfilResmi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSahipProfil).BeginInit();
            SuspendLayout();
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
            // btnMuayeneEkle
            // 
            btnMuayeneEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMuayeneEkle.BackColor = Color.FromArgb(19, 107, 94);
            btnMuayeneEkle.FlatStyle = FlatStyle.Flat;
            btnMuayeneEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMuayeneEkle.ForeColor = Color.White;
            btnMuayeneEkle.Location = new Point(284, 377);
            btnMuayeneEkle.Name = "btnMuayeneEkle";
            btnMuayeneEkle.Size = new Size(130, 40);
            btnMuayeneEkle.TabIndex = 3;
            btnMuayeneEkle.Text = "Muayene Ekle";
            btnMuayeneEkle.UseVisualStyleBackColor = false;
            btnMuayeneEkle.Click += btnMuayeneEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.BackColor = Color.FromArgb(19, 107, 94);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(420, 377);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 40);
            btnSil.TabIndex = 4;
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
            dgvHayvanlar.Location = new Point(12, 12);
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.RowHeadersVisible = false;
            dgvHayvanlar.RowTemplate.Height = 30;
            dgvHayvanlar.Size = new Size(827, 347);
            dgvHayvanlar.TabIndex = 0;
            dgvHayvanlar.SelectionChanged += dgvHayvanlar_SelectionChanged;
            // 
            // pbSahipProfil
            // 
            pbSahipProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSahipProfil.BorderStyle = BorderStyle.FixedSingle;
            pbSahipProfil.Location = new Point(854, 40);
            pbSahipProfil.Name = "pbSahipProfil";
            pbSahipProfil.Size = new Size(200, 200);
            pbSahipProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbSahipProfil.TabIndex = 4;
            pbSahipProfil.TabStop = false;
            // 
            // lblSahipProfilResmi
            // 
            lblSahipProfilResmi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSahipProfilResmi.AutoSize = true;
            lblSahipProfilResmi.Location = new Point(854, 15);
            lblSahipProfilResmi.Name = "lblSahipProfilResmi";
            lblSahipProfilResmi.Size = new Size(106, 15);
            lblSahipProfilResmi.TabIndex = 5;
            lblSahipProfilResmi.Text = "Sahip Profil Resmi";
            // 
            // HayvanListesiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 429);
            Controls.Add(lblSahipProfilResmi);
            Controls.Add(pbSahipProfil);
            Controls.Add(dgvHayvanlar);
            Controls.Add(btnMuayeneEkle);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
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

        #endregion

        private Button btnListele;
        private Button btnEkle;
        private Button btnMuayeneEkle;
        private Button btnSil;
        private DataGridView dgvHayvanlar;
        private PictureBox pbSahipProfil;
        private Label lblSahipProfilResmi;
    }
}