namespace VeterinerKlinigi
{
    partial class HayvanEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAd;
        private Label lblTur;
        private Label lblCins;
        private Label lblSahip;
        private TextBox txtAd;
        private TextBox txtTur;
        private TextBox txtCins;
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
            lblSahip = new Label();
            txtAd = new TextBox();
            txtTur = new TextBox();
            txtCins = new TextBox();
            cmbSahip = new ComboBox();
            btnKaydet = new Button();
            btnIptal = new Button();
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
            // lblSahip
            // 
            lblSahip.AutoSize = true;
            lblSahip.Location = new Point(24, 132);
            lblSahip.Name = "lblSahip";
            lblSahip.Size = new Size(37, 15);
            lblSahip.TabIndex = 3;
            lblSahip.Text = "Sahip";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(240, 23);
            txtAd.TabIndex = 4;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(88, 56);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(240, 23);
            txtTur.TabIndex = 5;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(88, 92);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(240, 23);
            txtCins.TabIndex = 6;
            // 
            // cmbSahip
            // 
            cmbSahip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSahip.FormattingEnabled = true;
            cmbSahip.Location = new Point(88, 128);
            cmbSahip.Name = "cmbSahip";
            cmbSahip.Size = new Size(240, 23);
            cmbSahip.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(88, 174);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 32);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(218, 174);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(110, 32);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "Ýptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // HayvanEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 230);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(cmbSahip);
            Controls.Add(txtCins);
            Controls.Add(txtTur);
            Controls.Add(txtAd);
            Controls.Add(lblSahip);
            Controls.Add(lblCins);
            Controls.Add(lblTur);
            Controls.Add(lblAd);
            Name = "HayvanEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hayvan Ekle";
            Load += HayvanEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}