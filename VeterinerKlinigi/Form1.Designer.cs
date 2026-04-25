namespace VeterinerKlinigi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvSahipler;
        private Button btnListele;
        private Button btnEkle;
        private Button btnSil;
        private Button btnHayvanlar;
        private Label lblAra;
        private TextBox txtAra;

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
            btnListele = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnHayvanlar = new Button();
            lblAra = new Label();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).BeginInit();
            SuspendLayout();
            // 
            // dgvSahipler
            // 
            dgvSahipler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahipler.Location = new Point(12, 45);
            dgvSahipler.Name = "dgvSahipler";
            dgvSahipler.RowHeadersWidth = 51;
            dgvSahipler.Size = new Size(545, 217);
            dgvSahipler.TabIndex = 0;
            dgvSahipler.CellDoubleClick += dgvSahipler_CellDoubleClick;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 276);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(140, 32);
            btnListele.TabIndex = 1;
            btnListele.Text = "Sahipleri Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(170, 276);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 32);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Sahip Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(328, 276);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 32);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sahip Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnHayvanlar
            // 
            btnHayvanlar.Location = new Point(486, 276);
            btnHayvanlar.Name = "btnHayvanlar";
            btnHayvanlar.Size = new Size(140, 32);
            btnHayvanlar.TabIndex = 6;
            btnHayvanlar.Text = "Hayvanlar";
            btnHayvanlar.UseVisualStyleBackColor = true;
            btnHayvanlar.Click += btnHayvanlar_Click;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Location = new Point(12, 15);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(27, 15);
            lblAra.TabIndex = 4;
            lblAra.Text = "Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(45, 12);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(266, 23);
            txtAra.TabIndex = 5;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 420);
            Controls.Add(txtAra);
            Controls.Add(lblAra);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(btnHayvanlar);
            Controls.Add(dgvSahipler);
            MinimumSize = new Size(760, 420);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veteriner Kliniği - Sahip Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}