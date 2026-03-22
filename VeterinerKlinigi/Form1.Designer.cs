namespace VeterinerKlinigi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvSahipler;
        private Button btnListele;
        private Button btnEkle;
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
            dgvSahipler = new DataGridView();
            btnListele = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).BeginInit();
            SuspendLayout();
            // 
            // dgvSahipler
            // 
            dgvSahipler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahipler.Location = new Point(12, 12);
            dgvSahipler.Name = "dgvSahipler";
            dgvSahipler.RowHeadersWidth = 51;
            dgvSahipler.Size = new Size(545, 250);
            dgvSahipler.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 322);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(dgvSahipler);
            Name = "Form1";
            Text = "Veteriner Kliniği - Sahip Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgvSahipler).EndInit();
            ResumeLayout(false);
        }
    }
}
