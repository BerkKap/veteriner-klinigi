namespace VeterinerKlinigi
{
    partial class HayvanGuncelleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAd;
        private Label lblTur;
        private Label lblCins;
        private Label lblCinsiyet;
        private Label lblYas;
        private Label lblRenk;
        private Label lblSahip;
        private TextBox txtAd;
        private TextBox txtTur;
        private TextBox txtCins;
        private ComboBox cmbCinsiyet;
        private NumericUpDown nudYas;
        private TextBox txtRenk;
        private ComboBox cmbSahip;
        private Button btnKaydet;
        private Button btnIptal;

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
            lblTur = new Label();
            lblCins = new Label();
            lblCinsiyet = new Label();
            lblYas = new Label();
            lblRenk = new Label();
            lblSahip = new Label();
            txtAd = new TextBox();
            txtTur = new TextBox();
            txtCins = new TextBox();
            cmbCinsiyet = new ComboBox();
            nudYas = new NumericUpDown();
            txtRenk = new TextBox();
            cmbSahip = new ComboBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
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
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(24, 60);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(24, 15);
            lblTur.TabIndex = 1;
            lblTur.Text = "Tür";
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Location = new Point(24, 96);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(30, 15);
            lblCins.TabIndex = 2;
            lblCins.Text = "Cins";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(24, 132);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(49, 15);
            lblCinsiyet.TabIndex = 14;
            lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(24, 168);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(24, 15);
            lblYas.TabIndex = 3;
            lblYas.Text = "Yaþ";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(24, 204);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(33, 15);
            lblRenk.TabIndex = 4;
            lblRenk.Text = "Renk";
            // 
            // lblSahip
            // 
            lblSahip.AutoSize = true;
            lblSahip.Location = new Point(24, 240);
            lblSahip.Name = "lblSahip";
            lblSahip.Size = new Size(37, 15);
            lblSahip.TabIndex = 5;
            lblSahip.Text = "Sahip";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(240, 23);
            txtAd.TabIndex = 6;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(88, 56);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(240, 23);
            txtTur.TabIndex = 7;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(88, 92);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(240, 23);
            txtCins.TabIndex = 8;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Diþi", "Erkek" });
            cmbCinsiyet.Location = new Point(88, 128);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(240, 23);
            cmbCinsiyet.TabIndex = 15;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(88, 164);
            nudYas.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(120, 23);
            nudYas.TabIndex = 9;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(88, 200);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(240, 23);
            txtRenk.TabIndex = 10;
            // 
            // cmbSahip
            // 
            cmbSahip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSahip.FormattingEnabled = true;
            cmbSahip.Location = new Point(88, 236);
            cmbSahip.Name = "cmbSahip";
            cmbSahip.Size = new Size(240, 23);
            cmbSahip.TabIndex = 11;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(88, 280);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 32);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(218, 280);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(110, 32);
            btnIptal.TabIndex = 13;
            btnIptal.Text = "Ýptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // HayvanGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 340);
            Controls.Add(cmbCinsiyet);
            Controls.Add(lblCinsiyet);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(cmbSahip);
            Controls.Add(txtRenk);
            Controls.Add(nudYas);
            Controls.Add(txtCins);
            Controls.Add(txtTur);
            Controls.Add(txtAd);
            Controls.Add(lblSahip);
            Controls.Add(lblRenk);
            Controls.Add(lblYas);
            Controls.Add(lblCins);
            Controls.Add(lblTur);
            Controls.Add(lblAd);
            Name = "HayvanGuncelleForm";
            Text = "Hayvan Güncelle";
            Load += HayvanGuncelleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}