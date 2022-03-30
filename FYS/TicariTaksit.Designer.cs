
namespace FYS
{
    partial class TicariTaksit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mcTextBoxKrediTutarı = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcTextBoxVade = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mcTextBoxFaiz = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mcButtonHesapla = new CustomControls.MCButton.MCButton();
            this.labelAylıkTaksitTutarı = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridViewCredi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredi)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticari Kredi Hesaplama";
            // 
            // mcTextBoxKrediTutarı
            // 
            this.mcTextBoxKrediTutarı.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxKrediTutarı.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxKrediTutarı.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxKrediTutarı.BorderRadius = 15;
            this.mcTextBoxKrediTutarı.BorderSize = 2;
            this.mcTextBoxKrediTutarı.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxKrediTutarı.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxKrediTutarı.Location = new System.Drawing.Point(38, 118);
            this.mcTextBoxKrediTutarı.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxKrediTutarı.Multiline = true;
            this.mcTextBoxKrediTutarı.Name = "mcTextBoxKrediTutarı";
            this.mcTextBoxKrediTutarı.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxKrediTutarı.PasswordChar = false;
            this.mcTextBoxKrediTutarı.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxKrediTutarı.PlaceHolderText = "Kredi Tutarı";
            this.mcTextBoxKrediTutarı.Size = new System.Drawing.Size(273, 46);
            this.mcTextBoxKrediTutarı.TabIndex = 22;
            this.mcTextBoxKrediTutarı.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kredi Tutarı";
            // 
            // mcTextBoxVade
            // 
            this.mcTextBoxVade.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxVade.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxVade.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxVade.BorderRadius = 15;
            this.mcTextBoxVade.BorderSize = 2;
            this.mcTextBoxVade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxVade.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxVade.Location = new System.Drawing.Point(338, 118);
            this.mcTextBoxVade.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxVade.Multiline = true;
            this.mcTextBoxVade.Name = "mcTextBoxVade";
            this.mcTextBoxVade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxVade.PasswordChar = false;
            this.mcTextBoxVade.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxVade.PlaceHolderText = "Vade";
            this.mcTextBoxVade.Size = new System.Drawing.Size(273, 46);
            this.mcTextBoxVade.TabIndex = 28;
            this.mcTextBoxVade.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(338, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vade";
            // 
            // mcTextBoxFaiz
            // 
            this.mcTextBoxFaiz.BackColor = System.Drawing.SystemColors.Window;
            this.mcTextBoxFaiz.BorderColor = System.Drawing.Color.DarkMagenta;
            this.mcTextBoxFaiz.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mcTextBoxFaiz.BorderRadius = 15;
            this.mcTextBoxFaiz.BorderSize = 2;
            this.mcTextBoxFaiz.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcTextBoxFaiz.ForeColor = System.Drawing.Color.DimGray;
            this.mcTextBoxFaiz.Location = new System.Drawing.Point(638, 118);
            this.mcTextBoxFaiz.Margin = new System.Windows.Forms.Padding(4);
            this.mcTextBoxFaiz.Multiline = true;
            this.mcTextBoxFaiz.Name = "mcTextBoxFaiz";
            this.mcTextBoxFaiz.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mcTextBoxFaiz.PasswordChar = false;
            this.mcTextBoxFaiz.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.mcTextBoxFaiz.PlaceHolderText = "Faiz Oranı";
            this.mcTextBoxFaiz.Size = new System.Drawing.Size(273, 46);
            this.mcTextBoxFaiz.TabIndex = 30;
            this.mcTextBoxFaiz.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(638, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Faiz Oranı";
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
            this.mcButtonHesapla.Location = new System.Drawing.Point(987, 116);
            this.mcButtonHesapla.Name = "mcButtonHesapla";
            this.mcButtonHesapla.Size = new System.Drawing.Size(198, 48);
            this.mcButtonHesapla.TabIndex = 32;
            this.mcButtonHesapla.Text = "Hesapla";
            this.mcButtonHesapla.TextColor = System.Drawing.Color.Black;
            this.mcButtonHesapla.UseVisualStyleBackColor = false;
            this.mcButtonHesapla.Click += new System.EventHandler(this.mcButtonHesapla_Click);
            // 
            // labelAylıkTaksitTutarı
            // 
            this.labelAylıkTaksitTutarı.AutoSize = true;
            this.labelAylıkTaksitTutarı.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAylıkTaksitTutarı.Location = new System.Drawing.Point(44, 173);
            this.labelAylıkTaksitTutarı.Name = "labelAylıkTaksitTutarı";
            this.labelAylıkTaksitTutarı.Size = new System.Drawing.Size(172, 28);
            this.labelAylıkTaksitTutarı.TabIndex = 33;
            this.labelAylıkTaksitTutarı.Text = "Aylık Taksit Tutarı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kredi Kullandırım Ücreti: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(553, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ödeme Planı";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(940, 167);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(289, 28);
            this.labelError.TabIndex = 40;
            this.labelError.Text = "Gerekli alanlar boş bırakılamaz !";
            this.labelError.Visible = false;
            // 
            // dataGridViewCredi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridViewCredi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCredi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCredi.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCredi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCredi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCredi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCredi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCredi.GridColor = System.Drawing.Color.DarkMagenta;
            this.dataGridViewCredi.Location = new System.Drawing.Point(0, 283);
            this.dataGridViewCredi.Name = "dataGridViewCredi";
            this.dataGridViewCredi.RowHeadersWidth = 51;
            this.dataGridViewCredi.RowTemplate.Height = 29;
            this.dataGridViewCredi.Size = new System.Drawing.Size(1250, 517);
            this.dataGridViewCredi.TabIndex = 41;
            // 
            // TicariTaksit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.dataGridViewCredi);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAylıkTaksitTutarı);
            this.Controls.Add(this.mcButtonHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mcTextBoxFaiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcTextBoxVade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcTextBoxKrediTutarı);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicariTaksit";
            this.Text = "TicariTaksit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxKrediTutarı;
        private System.Windows.Forms.Label label2;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxVade;
        private System.Windows.Forms.Label label3;
        private CustomControls.MC_Custom_Controls.MCTextBox mcTextBoxFaiz;
        private System.Windows.Forms.Label label4;
        private CustomControls.MCButton.MCButton mcButtonHesapla;
        private System.Windows.Forms.Label labelAylıkTaksitTutarı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridView dataGridViewCredi;
    }
}