namespace VeterinerKilinigi.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTest = new Button();
            btnSahipEkle = new Button();
            btnSahipListele = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(100, 34);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 0;
            btnTest.Text = "btnTest";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnSahipEkle
            // 
            btnSahipEkle.Location = new Point(89, 63);
            btnSahipEkle.Name = "btnSahipEkle";
            btnSahipEkle.Size = new Size(99, 23);
            btnSahipEkle.TabIndex = 1;
            btnSahipEkle.Text = "btnSahipEkle";
            btnSahipEkle.UseVisualStyleBackColor = true;
            btnSahipEkle.Click += btnSahipEkle_Click;
            // 
            // btnSahipListele
            // 
            btnSahipListele.Location = new Point(89, 92);
            btnSahipListele.Name = "btnSahipListele";
            btnSahipListele.Size = new Size(102, 23);
            btnSahipListele.TabIndex = 2;
            btnSahipListele.Text = "btnSahipListele";
            btnSahipListele.UseVisualStyleBackColor = true;
            btnSahipListele.Click += btnSahipListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSahipListele);
            Controls.Add(btnSahipEkle);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private Button btnSahipEkle;
        private Button btnSahipListele;
    }
}