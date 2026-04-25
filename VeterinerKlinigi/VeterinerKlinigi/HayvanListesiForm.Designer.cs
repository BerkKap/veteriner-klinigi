namespace VeterinerKlinigi
{
    partial class HayvanListesiForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvHayvanlar;
        private Button btnListele;
        private Button btnEkle;
        private PictureBox pbSahipProfil;
        private Label lblSahipProfil;

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
            dgvHayvanlar = new DataGridView();
            btnListele = new Button();
            btnEkle = new Button();
            pbSahipProfil = new PictureBox();
            lblSahipProfil = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSahipProfil).BeginInit();
            SuspendLayout();
            // 
            // dgvHayvanlar
            // 
            dgvHayvanlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHayvanlar.Location = new Point(12, 12);
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.RowHeadersWidth = 51;
            dgvHayvanlar.Size = new Size(760, 320);
            dgvHayvanlar.TabIndex = 0;
            dgvHayvanlar.SelectionChanged += dgvHayvanlar_SelectionChanged;
            // 
            // btnListele
            // 
            btnListele.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListele.Location = new Point(12, 350);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(140, 32);
            btnListele.TabIndex = 1;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.Location = new Point(170, 350);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 32);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Hayvan Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // pbSahipProfil
            // 
            pbSahipProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSahipProfil.BorderStyle = BorderStyle.FixedSingle;
            pbSahipProfil.Location = new Point(804, 34);
            pbSahipProfil.Name = "pbSahipProfil";
            pbSahipProfil.Size = new Size(180, 180);
            pbSahipProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbSahipProfil.TabIndex = 3;
            pbSahipProfil.TabStop = false;
            // 
            // lblSahipProfil
            // 
            lblSahipProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSahipProfil.AutoSize = true;
            lblSahipProfil.Location = new Point(804, 12);
            lblSahipProfil.Name = "lblSahipProfil";
            lblSahipProfil.Size = new Size(101, 15);
            lblSahipProfil.TabIndex = 4;
            lblSahipProfil.Text = "Sahip Profil Resmi";
            // 
            // HayvanListesiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 430);
            Controls.Add(lblSahipProfil);
            Controls.Add(pbSahipProfil);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(dgvHayvanlar);
            MinimumSize = new Size(1080, 470);
            Name = "HayvanListesiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hayvan Listesi";
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSahipProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}