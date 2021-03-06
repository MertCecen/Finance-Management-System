
namespace FYS
{
    partial class İskonto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcButtonHesapla = new CustomControls.MCButton.MCButton();
            this.mcTextBoxFaizOranı = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.mcTextBoxGün = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.mcTextBoxAnaPara = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.labelMaliyet = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 76);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "İskonto İştira Kredisi (Çek - Senet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Faiz Oranı (Yıllık)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Vade (Gün)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kredi Tutarı";
            // 
            // mcButtonHesapla
            // 
            this.mcButtonHesapla.BackColor = System.Drawing.Color.DarkMagenta;
            this.mcButtonHesapla.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.mcButtonHesapla.BorderColor = System.Drawing.Color.Red;
            this.mcButtonHesapla.BorderRadius = 15;
            this.mcButtonHesapla.BorderSize = 0;
            this.mcButtonHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcButtonHesapla.FlatAppearance.BorderSize = 0;
            this.mcButtonHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcButtonHesapla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mcButtonHesapla.ForeColor = System.Drawing.Color.Black;
            this.mcButtonHesapla.Location = new System.Drawing.Point(42, 407);
            this.mcButtonHesapla.Name = "mcButtonHesapla";
            this.mcButtonHesapla.Size = new System.Drawing.Size(316, 48);
            this.mcButtonHesapla.TabIndex = 32;
            this.mcButtonHesapla.Text = "Hesapla";
            this.mcButtonHesapla.TextColor = System.Drawing.Color.Black;
            this.mcButtonHesapla.UseVisualStyleBackColor = false;
            this.mcButtonHesapla.Click += new System.EventHandler(this.mcButtonHesapla_Click);
            // 
            // mcTextBoxFaizOranı
            // 
            this.mcTextBoxFaizOranı.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxFaizOranı.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxFaizOranı.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxFaizOranı.BorderRadius = 15;
            this.mcTextBoxFaizOranı.BorderSize = 2;
            this.mcTextBoxFaizOranı.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxFaizOranı.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxFaizOranı.Location = new System.Drawing.Point(42, 314);
            this.mcTextBoxFaizOranı.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxFaizOranı.Multiline = true;
            this.mcTextBoxFaizOranı.Name = "mcTextBoxFaizOranı";
            this.mcTextBoxFaizOranı.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxFaizOranı.PasswordChar = false;
            this.mcTextBoxFaizOranı.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxFaizOranı.PlaceHolderText = "Faiz Oranı";
            this.mcTextBoxFaizOranı.Size = new System.Drawing.Size(316, 46);
            this.mcTextBoxFaizOranı.TabIndex = 31;
            this.mcTextBoxFaizOranı.UnderlinedStyle = false;
            // 
            // mcTextBoxGün
            // 
            this.mcTextBoxGün.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxGün.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxGün.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxGün.BorderRadius = 15;
            this.mcTextBoxGün.BorderSize = 2;
            this.mcTextBoxGün.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxGün.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxGün.Location = new System.Drawing.Point(42, 221);
            this.mcTextBoxGün.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxGün.Multiline = true;
            this.mcTextBoxGün.Name = "mcTextBoxGün";
            this.mcTextBoxGün.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxGün.PasswordChar = false;
            this.mcTextBoxGün.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxGün.PlaceHolderText = "Gün";
            this.mcTextBoxGün.Size = new System.Drawing.Size(316, 46);
            this.mcTextBoxGün.TabIndex = 30;
            this.mcTextBoxGün.UnderlinedStyle = false;
            // 
            // mcTextBoxAnaPara
            // 
            this.mcTextBoxAnaPara.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxAnaPara.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxAnaPara.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxAnaPara.BorderRadius = 15;
            this.mcTextBoxAnaPara.BorderSize = 2;
            this.mcTextBoxAnaPara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxAnaPara.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxAnaPara.Location = new System.Drawing.Point(42, 128);
            this.mcTextBoxAnaPara.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxAnaPara.Multiline = true;
            this.mcTextBoxAnaPara.Name = "mcTextBoxAnaPara";
            this.mcTextBoxAnaPara.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxAnaPara.PasswordChar = false;
            this.mcTextBoxAnaPara.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxAnaPara.PlaceHolderText = "Kredi Tutarı";
            this.mcTextBoxAnaPara.Size = new System.Drawing.Size(316, 46);
            this.mcTextBoxAnaPara.TabIndex = 29;
            this.mcTextBoxAnaPara.UnderlinedStyle = false;
            // 
            // labelMaliyet
            // 
            this.labelMaliyet.AutoSize = true;
            this.labelMaliyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaliyet.Location = new System.Drawing.Point(42, 485);
            this.labelMaliyet.Name = "labelMaliyet";
            this.labelMaliyet.Size = new System.Drawing.Size(86, 28);
            this.labelMaliyet.TabIndex = 36;
            this.labelMaliyet.Text = "Maliyet: ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(42, 535);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(127, 28);
            this.labelResult.TabIndex = 37;
            this.labelResult.Text = "Net Ödenen: ";
            // 
            // İskonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelMaliyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcButtonHesapla);
            this.Controls.Add(this.mcTextBoxFaizOranı);
            this.Controls.Add(this.mcTextBoxGün);
            this.Controls.Add(this.mcTextBoxAnaPara);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İskonto";
            this.Text = "İskonto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.MCButton.MCButton mcButtonHesapla;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxFaizOranı;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxGün;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxAnaPara;
        private System.Windows.Forms.Label labelMaliyet;
        private System.Windows.Forms.Label labelResult;
    }
}