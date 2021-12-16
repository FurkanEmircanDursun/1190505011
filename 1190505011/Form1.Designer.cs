
namespace _1190505011
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.otele = new System.Windows.Forms.Button();
            this.xOteleText = new System.Windows.Forms.TextBox();
            this.yOteleText = new System.Windows.Forms.TextBox();
            this.zOteleText = new System.Windows.Forms.TextBox();
            this.Olcekle = new System.Windows.Forms.Button();
            this.xOlcekle = new System.Windows.Forms.TextBox();
            this.zOlcekle = new System.Windows.Forms.TextBox();
            this.yOlcekle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eksenleri Çiz     (X,Y,Z)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(19, 462);
            this.temizle.Margin = new System.Windows.Forms.Padding(4);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(147, 55);
            this.temizle.TabIndex = 2;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 101);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cismin İzometrik izdüşümünü al";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // otele
            // 
            this.otele.Location = new System.Drawing.Point(19, 204);
            this.otele.Name = "otele";
            this.otele.Size = new System.Drawing.Size(147, 87);
            this.otele.TabIndex = 4;
            this.otele.Text = "Otele";
            this.otele.UseVisualStyleBackColor = true;
            this.otele.Click += new System.EventHandler(this.otele_Click);
            // 
            // xOteleText
            // 
            this.xOteleText.Location = new System.Drawing.Point(208, 213);
            this.xOteleText.Name = "xOteleText";
            this.xOteleText.Size = new System.Drawing.Size(100, 22);
            this.xOteleText.TabIndex = 5;
            this.xOteleText.TextChanged += new System.EventHandler(this.xOteleText_TextChanged);
            // 
            // yOteleText
            // 
            this.yOteleText.Location = new System.Drawing.Point(208, 241);
            this.yOteleText.Name = "yOteleText";
            this.yOteleText.Size = new System.Drawing.Size(100, 22);
            this.yOteleText.TabIndex = 6;
            this.yOteleText.TextChanged += new System.EventHandler(this.yOteleText_TextChanged);
            // 
            // zOteleText
            // 
            this.zOteleText.Location = new System.Drawing.Point(208, 269);
            this.zOteleText.Name = "zOteleText";
            this.zOteleText.Size = new System.Drawing.Size(100, 22);
            this.zOteleText.TabIndex = 7;
            this.zOteleText.TextChanged += new System.EventHandler(this.zOteleText_TextChanged);
            // 
            // Olcekle
            // 
            this.Olcekle.Location = new System.Drawing.Point(19, 323);
            this.Olcekle.Name = "Olcekle";
            this.Olcekle.Size = new System.Drawing.Size(147, 87);
            this.Olcekle.TabIndex = 8;
            this.Olcekle.Text = "Olcekle";
            this.Olcekle.UseVisualStyleBackColor = true;
            this.Olcekle.Click += new System.EventHandler(this.Olcekle_Click);
            // 
            // xOlcekle
            // 
            this.xOlcekle.Location = new System.Drawing.Point(208, 323);
            this.xOlcekle.Name = "xOlcekle";
            this.xOlcekle.Size = new System.Drawing.Size(100, 22);
            this.xOlcekle.TabIndex = 9;
            this.xOlcekle.TextChanged += new System.EventHandler(this.xOlcekle_TextChanged);
            // 
            // zOlcekle
            // 
            this.zOlcekle.Location = new System.Drawing.Point(208, 388);
            this.zOlcekle.Name = "zOlcekle";
            this.zOlcekle.Size = new System.Drawing.Size(100, 22);
            this.zOlcekle.TabIndex = 10;
            this.zOlcekle.TextChanged += new System.EventHandler(this.zOlcekle_TextChanged);
            // 
            // yOlcekle
            // 
            this.yOlcekle.Location = new System.Drawing.Point(208, 355);
            this.yOlcekle.Name = "yOlcekle";
            this.yOlcekle.Size = new System.Drawing.Size(100, 22);
            this.yOlcekle.TabIndex = 11;
            this.yOlcekle.TextChanged += new System.EventHandler(this.yOlcekle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yOlcekle);
            this.Controls.Add(this.zOlcekle);
            this.Controls.Add(this.xOlcekle);
            this.Controls.Add(this.Olcekle);
            this.Controls.Add(this.zOteleText);
            this.Controls.Add(this.yOteleText);
            this.Controls.Add(this.xOteleText);
            this.Controls.Add(this.otele);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button otele;
        private System.Windows.Forms.TextBox xOteleText;
        private System.Windows.Forms.TextBox yOteleText;
        private System.Windows.Forms.TextBox zOteleText;
        private System.Windows.Forms.Button Olcekle;
        private System.Windows.Forms.TextBox xOlcekle;
        private System.Windows.Forms.TextBox zOlcekle;
        private System.Windows.Forms.TextBox yOlcekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

