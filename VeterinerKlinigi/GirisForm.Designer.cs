namespace VeterinerKlinigi
{
    partial class GirisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlSol;
        private Panel pnlSag;
        private Label lblIkon;
        private Label lblSolBaslik;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnGosterGizle;

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
            pnlSol = new Panel();
            lblIkon = new Label();
            lblSolBaslik = new Label();
            pnlSag = new Panel();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnGosterGizle = new Button();
            pnlSol.SuspendLayout();
            pnlSag.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSol
            // 
            pnlSol.BackColor = Color.FromArgb(15, 110, 86);
            pnlSol.Controls.Add(lblIkon);
            pnlSol.Controls.Add(lblSolBaslik);
            pnlSol.Dock = DockStyle.Left;
            pnlSol.Location = new Point(0, 0);
            pnlSol.Name = "pnlSol";
            pnlSol.Size = new Size(230, 220);
            pnlSol.TabIndex = 0;
            // 
            // lblIkon
            // 
            lblIkon.Font = new Font("Segoe UI Emoji", 38F, FontStyle.Regular, GraphicsUnit.Point);
            lblIkon.ForeColor = Color.White;
            lblIkon.Location = new Point(0, 45);
            lblIkon.Name = "lblIkon";
            lblIkon.Size = new Size(230, 70);
            lblIkon.TabIndex = 0;
            lblIkon.Text = "🐶🐱";
            lblIkon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolBaslik
            // 
            lblSolBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSolBaslik.ForeColor = Color.White;
            lblSolBaslik.Location = new Point(0, 125);
            lblSolBaslik.Name = "lblSolBaslik";
            lblSolBaslik.Size = new Size(230, 50);
            lblSolBaslik.TabIndex = 1;
            lblSolBaslik.Text = "Veteriner Kliniği\r\nÇalışan Girişi";
            lblSolBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSag
            // 
            pnlSag.BackColor = Color.White;
            pnlSag.Controls.Add(lblKullaniciAdi);
            pnlSag.Controls.Add(lblSifre);
            pnlSag.Controls.Add(txtKullaniciAdi);
            pnlSag.Controls.Add(txtSifre);
            pnlSag.Controls.Add(btnGiris);
            pnlSag.Controls.Add(btnGosterGizle);
            pnlSag.Dock = DockStyle.Fill;
            pnlSag.Location = new Point(230, 0);
            pnlSag.Name = "pnlSag";
            pnlSag.Size = new Size(290, 220);
            pnlSag.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(22, 58);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(72, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(22, 97);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(105, 55);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(160, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(105, 94);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(122, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGosterGizle
            // 
            btnGosterGizle.Location = new Point(230, 94);
            btnGosterGizle.Name = "btnGosterGizle";
            btnGosterGizle.Size = new Size(35, 23);
            btnGosterGizle.TabIndex = 4;
            btnGosterGizle.Text = "👁";
            btnGosterGizle.UseVisualStyleBackColor = true;
            btnGosterGizle.Click += btnGosterGizle_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(105, 132);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(160, 30);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 220);
            Controls.Add(pnlSag);
            Controls.Add(pnlSol);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışan Girişi";
            pnlSol.ResumeLayout(false);
            pnlSag.ResumeLayout(false);
            pnlSag.PerformLayout();
            ResumeLayout(false);
        }
    }
}