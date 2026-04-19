namespace VeterinerKlinigi
{
    partial class SahipGuncelleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private Label lblCezaPuani;
        private Label lblProfil;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtCezaPuani;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pbProfil;

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
            lblCezaPuani = new Label();
            lblProfil = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtCezaPuani = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            pbProfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(24, 26);
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
            lblTelefon.Location = new Point(24, 94);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(46, 15);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon";
            // 
            // lblCezaPuani
            // 
            lblCezaPuani.AutoSize = true;
            lblCezaPuani.Location = new Point(24, 128);
            lblCezaPuani.Name = "lblCezaPuani";
            lblCezaPuani.Size = new Size(66, 15);
            lblCezaPuani.TabIndex = 3;
            lblCezaPuani.Text = "Ceza Puaný";
            // 
            // lblProfil
            // 
            lblProfil.AutoSize = true;
            lblProfil.Location = new Point(380, 8);
            lblProfil.Name = "lblProfil";
            lblProfil.Size = new Size(58, 15);
            lblProfil.TabIndex = 4;
            lblProfil.Text = "Profil Foto";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(110, 23);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 23);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(110, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 23);
            txtSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(110, 91);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 23);
            txtTelefon.TabIndex = 7;
            // 
            // txtCezaPuani
            // 
            txtCezaPuani.Location = new Point(110, 125);
            txtCezaPuani.Name = "txtCezaPuani";
            txtCezaPuani.Size = new Size(220, 23);
            txtCezaPuani.TabIndex = 8;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(110, 170);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 30);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(230, 170);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 30);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // pbProfil
            // 
            pbProfil.BorderStyle = BorderStyle.FixedSingle;
            pbProfil.Location = new Point(380, 26);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(140, 140);
            pbProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfil.TabIndex = 11;
            pbProfil.TabStop = false;
            // 
            // SahipGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 224);
            Controls.Add(pbProfil);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtCezaPuani);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblProfil);
            Controls.Add(lblCezaPuani);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "SahipGuncelleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sahip Güncelle";
            Load += SahipGuncelleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}