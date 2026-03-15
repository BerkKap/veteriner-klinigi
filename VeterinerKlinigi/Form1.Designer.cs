namespace VeterinerKlinigi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvSahipler;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private Button btnListele;
        private Button btnEkle;

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
            dgvSahipler = new DataGridView();
            lblAd = new Label();
            lblSoyad = new Label();
            lblTelefon = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            btnListele = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).BeginInit();
            SuspendLayout();
            // 
            // dgvSahipler
            // 
            dgvSahipler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahipler.Location = new Point(10, 9);
            dgvSahipler.Margin = new Padding(3, 2, 3, 2);
            dgvSahipler.Name = "dgvSahipler";
            dgvSahipler.RowHeadersWidth = 51;
            dgvSahipler.Size = new Size(542, 210);
            dgvSahipler.TabIndex = 0;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(10, 236);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(10, 260);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(10, 284);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(46, 15);
            lblTelefon.TabIndex = 3;
            lblTelefon.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(79, 234);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(158, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(79, 258);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(158, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(79, 282);
            txtTelefon.Margin = new Padding(3, 2, 3, 2);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(158, 23);
            txtTelefon.TabIndex = 6;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(262, 234);
            btnListele.Margin = new Padding(3, 2, 3, 2);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(122, 26);
            btnListele.TabIndex = 7;
            btnListele.Text = "Sahipleri Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(262, 270);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 26);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Sahip Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(403, 234);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sahip Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 322);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(dgvSahipler);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Veteriner Kliniği - Sahip Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnSil;
    }
}
