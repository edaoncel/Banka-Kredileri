namespace banka_kredileri
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
            this.txtAnapara = new System.Windows.Forms.TextBox();
            this.txtFaizoranı = new System.Windows.Forms.TextBox();
            this.txtVade = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnAnapara = new System.Windows.Forms.Button();
            this.btnFaizoranı = new System.Windows.Forms.Button();
            this.btnVade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnapara
            // 
            this.txtAnapara.Location = new System.Drawing.Point(339, 73);
            this.txtAnapara.Name = "txtAnapara";
            this.txtAnapara.Size = new System.Drawing.Size(100, 26);
            this.txtAnapara.TabIndex = 0;
            // 
            // txtFaizoranı
            // 
            this.txtFaizoranı.Location = new System.Drawing.Point(339, 158);
            this.txtFaizoranı.Name = "txtFaizoranı";
            this.txtFaizoranı.Size = new System.Drawing.Size(100, 26);
            this.txtFaizoranı.TabIndex = 1;
            // 
            // txtVade
            // 
            this.txtVade.Location = new System.Drawing.Point(339, 240);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(100, 26);
            this.txtVade.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(339, 325);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 39);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnAnapara
            // 
            this.btnAnapara.Location = new System.Drawing.Point(170, 75);
            this.btnAnapara.Name = "btnAnapara";
            this.btnAnapara.Size = new System.Drawing.Size(130, 36);
            this.btnAnapara.TabIndex = 4;
            this.btnAnapara.Text = "ana para";
            this.btnAnapara.UseVisualStyleBackColor = true;
            // 
            // btnFaizoranı
            // 
            this.btnFaizoranı.Location = new System.Drawing.Point(170, 158);
            this.btnFaizoranı.Name = "btnFaizoranı";
            this.btnFaizoranı.Size = new System.Drawing.Size(130, 39);
            this.btnFaizoranı.TabIndex = 5;
            this.btnFaizoranı.Text = "faiz oranı";
            this.btnFaizoranı.UseVisualStyleBackColor = true;
            // 
            // btnVade
            // 
            this.btnVade.Location = new System.Drawing.Point(170, 240);
            this.btnVade.Name = "btnVade";
            this.btnVade.Size = new System.Drawing.Size(130, 45);
            this.btnVade.TabIndex = 6;
            this.btnVade.Text = "vade";
            this.btnVade.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVade);
            this.Controls.Add(this.btnFaizoranı);
            this.Controls.Add(this.btnAnapara);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtVade);
            this.Controls.Add(this.txtFaizoranı);
            this.Controls.Add(this.txtAnapara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnapara;
        private System.Windows.Forms.TextBox txtFaizoranı;
        private System.Windows.Forms.TextBox txtVade;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnAnapara;
        private System.Windows.Forms.Button btnFaizoranı;
        private System.Windows.Forms.Button btnVade;
    }
}

