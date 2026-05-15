namespace VeterinerKlinigi
{
    partial class SahipEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private Button btnKaydet;
        private Button btnIptal;
        private PictureBox pbProfil;
        private Button btnResimSec;
        private Label lblProfil;

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
            lblAd = new Label();
            lblSoyad = new Label();
            lblTelefon = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            pbProfil = new PictureBox();
            btnResimSec = new Button();
            lblProfil = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(24, 24);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(24, 60);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(24, 96);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(46, 15);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAd.Location = new Point(88, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSoyad.Location = new Point(88, 56);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefon.Location = new Point(88, 92);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 23);
            txtTelefon.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKaydet.Location = new Point(88, 186);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIptal.Location = new Point(208, 186);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // pbProfil
            // 
            pbProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbProfil.BorderStyle = BorderStyle.FixedSingle;
            pbProfil.Location = new Point(370, 24);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(140, 140);
            pbProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfil.TabIndex = 10;
            pbProfil.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResimSec.Location = new Point(370, 186);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(140, 30);
            btnResimSec.TabIndex = 7;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // lblProfil
            // 
            lblProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfil.AutoSize = true;
            lblProfil.Location = new Point(370, 6);
            lblProfil.Name = "lblProfil";
            lblProfil.Size = new Size(70, 15);
            lblProfil.TabIndex = 6;
            lblProfil.Text = "Hayvan Resmi";
            lblProfil.Click += lblProfil_Click;
            // 
            // SahipEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 241);
            Controls.Add(lblProfil);
            Controls.Add(btnResimSec);
            Controls.Add(pbProfil);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "SahipEkleForm";
            Text = "Sahip Ekle";
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}