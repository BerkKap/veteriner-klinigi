namespace VeterinerKlinigi
{
    partial class MuayeneEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblHayvan;
        private Label lblSikayet;
        private Label lblBulgu;
        private Label lblTedavi;
        private Label lblUcret;
        private ComboBox cmbHayvan;
        private TextBox txtSikayet;
        private TextBox txtBulgu;
        private TextBox txtTedavi;
        private NumericUpDown nudUcret;
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
            lblHayvan = new Label();
            lblSikayet = new Label();
            lblBulgu = new Label();
            lblTedavi = new Label();
            lblUcret = new Label();
            cmbHayvan = new ComboBox();
            txtSikayet = new TextBox();
            txtBulgu = new TextBox();
            txtTedavi = new TextBox();
            nudUcret = new NumericUpDown();
            btnKaydet = new Button();
            btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudUcret).BeginInit();
            SuspendLayout();
            // 
            // lblHayvan
            // 
            lblHayvan.AutoSize = true;
            lblHayvan.Location = new Point(24, 24);
            lblHayvan.Name = "lblHayvan";
            lblHayvan.Size = new Size(49, 15);
            lblHayvan.TabIndex = 0;
            lblHayvan.Text = "Hayvan";
            // 
            // lblSikayet
            // 
            lblSikayet.AutoSize = true;
            lblSikayet.Location = new Point(24, 60);
            lblSikayet.Name = "lblSikayet";
            lblSikayet.Size = new Size(47, 15);
            lblSikayet.TabIndex = 1;
            lblSikayet.Text = "Þikayet";
            // 
            // lblBulgu
            // 
            lblBulgu.AutoSize = true;
            lblBulgu.Location = new Point(24, 96);
            lblBulgu.Name = "lblBulgu";
            lblBulgu.Size = new Size(39, 15);
            lblBulgu.TabIndex = 2;
            lblBulgu.Text = "Bulgu";
            // 
            // lblTedavi
            // 
            lblTedavi.AutoSize = true;
            lblTedavi.Location = new Point(24, 132);
            lblTedavi.Name = "lblTedavi";
            lblTedavi.Size = new Size(43, 15);
            lblTedavi.TabIndex = 3;
            lblTedavi.Text = "Tedavi";
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Location = new Point(24, 168);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(35, 15);
            lblUcret.TabIndex = 4;
            lblUcret.Text = "Ücret";
            // 
            // cmbHayvan
            // 
            cmbHayvan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHayvan.FormattingEnabled = true;
            cmbHayvan.Location = new Point(88, 20);
            cmbHayvan.Name = "cmbHayvan";
            cmbHayvan.Size = new Size(260, 23);
            cmbHayvan.TabIndex = 5;
            // 
            // txtSikayet
            // 
            txtSikayet.Location = new Point(88, 56);
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(260, 23);
            txtSikayet.TabIndex = 6;
            // 
            // txtBulgu
            // 
            txtBulgu.Location = new Point(88, 92);
            txtBulgu.Name = "txtBulgu";
            txtBulgu.Size = new Size(260, 23);
            txtBulgu.TabIndex = 7;
            // 
            // txtTedavi
            // 
            txtTedavi.Location = new Point(88, 128);
            txtTedavi.Name = "txtTedavi";
            txtTedavi.Size = new Size(260, 23);
            txtTedavi.TabIndex = 8;
            // 
            // nudUcret
            // 
            nudUcret.Location = new Point(88, 164);
            nudUcret.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudUcret.Name = "nudUcret";
            nudUcret.Size = new Size(120, 23);
            nudUcret.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(88, 206);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 32);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(238, 206);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(110, 32);
            btnIptal.TabIndex = 11;
            btnIptal.Text = "Ýptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // MuayeneEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 260);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(nudUcret);
            Controls.Add(txtTedavi);
            Controls.Add(txtBulgu);
            Controls.Add(txtSikayet);
            Controls.Add(cmbHayvan);
            Controls.Add(lblUcret);
            Controls.Add(lblTedavi);
            Controls.Add(lblBulgu);
            Controls.Add(lblSikayet);
            Controls.Add(lblHayvan);
            Name = "MuayeneEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Muayene Ekle";
            Load += MuayeneEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudUcret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}