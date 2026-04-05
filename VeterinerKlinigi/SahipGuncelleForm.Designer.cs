namespace VeterinerKlinigi
{
    partial class SahipGuncelleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private Label lblCezaPuani;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtCezaPuani;
        private Button btnGuncelle;
        private Button btnSil;

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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtCezaPuani = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
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
            // txtAd
            // 
            txtAd.Location = new Point(110, 23);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(110, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(110, 91);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 23);
            txtTelefon.TabIndex = 6;
            // 
            // txtCezaPuani
            // 
            txtCezaPuani.Location = new Point(110, 125);
            txtCezaPuani.Name = "txtCezaPuani";
            txtCezaPuani.Size = new Size(220, 23);
            txtCezaPuani.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(110, 170);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 30);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(230, 170);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 30);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // SahipGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 224);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtCezaPuani);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblCezaPuani);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "SahipGuncelleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sahip Güncelle";
            Load += SahipGuncelleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}