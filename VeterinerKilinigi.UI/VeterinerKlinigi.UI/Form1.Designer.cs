namespace VeterinerKlinigi.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            
            btnTest = new Button();
            btnSahipEkle = new Button();
            btnSahipListele = new Button();
            
            SuspendLayout();
            
            // btnTest
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(100, 40);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test Et";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            
            // btnSahipEkle
            btnSahipEkle.Location = new Point(120, 12);
            btnSahipEkle.Name = "btnSahipEkle";
            btnSahipEkle.Size = new Size(100, 40);
            btnSahipEkle.TabIndex = 1;
            btnSahipEkle.Text = "Sahip Ekle";
            btnSahipEkle.UseVisualStyleBackColor = true;
            btnSahipEkle.Click += btnSahipEkle_Click;
            
            // btnSahipListele
            btnSahipListele.Location = new Point(228, 12);
            btnSahipListele.Name = "btnSahipListele";
            btnSahipListele.Size = new Size(100, 40);
            btnSahipListele.TabIndex = 2;
            btnSahipListele.Text = "Sahipleri Listele";
            btnSahipListele.UseVisualStyleBackColor = true;
            btnSahipListele.Click += btnSahipListele_Click;
            
            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTest);
            Controls.Add(btnSahipEkle);
            Controls.Add(btnSahipListele);
            Name = "Form1";
            Text = "Veteriner Kliniði Yönetim Sistemi";
            ResumeLayout(false);
        }

        private Button btnTest;
        private Button btnSahipEkle;
        private Button btnSahipListele;
    }
}