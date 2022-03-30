
namespace FYS
{
    partial class Banks
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWriteToExcel = new CustomControls.MCButton.MCButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTL = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelEURO = new System.Windows.Forms.Label();
            this.labelGBP = new System.Windows.Forms.Label();
            this.labelGenelToplam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANKALAR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 76);
            this.panel1.TabIndex = 56;
            // 
            // buttonWriteToExcel
            // 
            this.buttonWriteToExcel.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonWriteToExcel.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.buttonWriteToExcel.BorderColor = System.Drawing.Color.Red;
            this.buttonWriteToExcel.BorderRadius = 15;
            this.buttonWriteToExcel.BorderSize = 0;
            this.buttonWriteToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWriteToExcel.FlatAppearance.BorderSize = 0;
            this.buttonWriteToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteToExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWriteToExcel.ForeColor = System.Drawing.Color.Black;
            this.buttonWriteToExcel.Location = new System.Drawing.Point(1050, 518);
            this.buttonWriteToExcel.Name = "buttonWriteToExcel";
            this.buttonWriteToExcel.Size = new System.Drawing.Size(188, 50);
            this.buttonWriteToExcel.TabIndex = 58;
            this.buttonWriteToExcel.Text = "Excel\'e Aktar";
            this.buttonWriteToExcel.TextColor = System.Drawing.Color.Black;
            this.buttonWriteToExcel.UseVisualStyleBackColor = false;
            this.buttonWriteToExcel.Click += new System.EventHandler(this.buttonWriteToExcel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.GridColor = System.Drawing.Color.Tomato;
            this.dataGridView.Location = new System.Drawing.Point(0, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1250, 425);
            this.dataGridView.TabIndex = 59;
            this.dataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValidated);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTL.Location = new System.Drawing.Point(12, 583);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(104, 28);
            this.labelTL.TabIndex = 60;
            this.labelTL.Text = "Toplam TL:";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUSD.Location = new System.Drawing.Point(12, 627);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(124, 28);
            this.labelUSD.TabIndex = 61;
            this.labelUSD.Text = "Toplam USD:";
            // 
            // labelEURO
            // 
            this.labelEURO.AutoSize = true;
            this.labelEURO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEURO.Location = new System.Drawing.Point(12, 671);
            this.labelEURO.Name = "labelEURO";
            this.labelEURO.Size = new System.Drawing.Size(136, 28);
            this.labelEURO.TabIndex = 62;
            this.labelEURO.Text = "Toplam EURO:";
            // 
            // labelGBP
            // 
            this.labelGBP.AutoSize = true;
            this.labelGBP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGBP.Location = new System.Drawing.Point(12, 715);
            this.labelGBP.Name = "labelGBP";
            this.labelGBP.Size = new System.Drawing.Size(121, 28);
            this.labelGBP.TabIndex = 63;
            this.labelGBP.Text = "Toplam GBP:";
            // 
            // labelGenelToplam
            // 
            this.labelGenelToplam.AutoSize = true;
            this.labelGenelToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenelToplam.Location = new System.Drawing.Point(12, 759);
            this.labelGenelToplam.Name = "labelGenelToplam";
            this.labelGenelToplam.Size = new System.Drawing.Size(135, 28);
            this.labelGenelToplam.TabIndex = 64;
            this.labelGenelToplam.Text = "Genel Toplam:";
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.labelGenelToplam);
            this.Controls.Add(this.labelGBP);
            this.Controls.Add(this.labelEURO);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonWriteToExcel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Banks";
            this.Text = "Banks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.MCButton.MCButton buttonWriteToExcel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelEURO;
        private System.Windows.Forms.Label labelGBP;
        private System.Windows.Forms.Label labelGenelToplam;
    }
}