
namespace FYS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textboxUserName = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxPassword = new CustomControls.MC_Custom_Controls.MCTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new CustomControls.MCButton.MCButton();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxUserName
            // 
            this.textboxUserName.BackColor = System.Drawing.SystemColors.Window;
            this.textboxUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxUserName.BorderRadius = 15;
            this.textboxUserName.BorderSize = 0;
            this.textboxUserName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxUserName.ForeColor = System.Drawing.Color.DimGray;
            this.textboxUserName.Location = new System.Drawing.Point(244, 175);
            this.textboxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUserName.Multiline = false;
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxUserName.PasswordChar = false;
            this.textboxUserName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.textboxUserName.PlaceHolderText = "Kullanıcı Adı";
            this.textboxUserName.Size = new System.Drawing.Size(312, 42);
            this.textboxUserName.TabIndex = 0;
            this.textboxUserName.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxPassword.BorderRadius = 15;
            this.textboxPassword.BorderSize = 0;
            this.textboxPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textboxPassword.Location = new System.Drawing.Point(244, 257);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Multiline = false;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxPassword.PasswordChar = true;
            this.textboxPassword.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.textboxPassword.PlaceHolderText = "Şifre";
            this.textboxPassword.Size = new System.Drawing.Size(312, 42);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.UnderlinedStyle = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonLogin.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.buttonLogin.BorderColor = System.Drawing.Color.Red;
            this.buttonLogin.BorderRadius = 15;
            this.buttonLogin.BorderSize = 0;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(244, 348);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(312, 39);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.TextColor = System.Drawing.Color.Black;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Location = new System.Drawing.Point(263, 412);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(275, 28);
            this.labelWrong.TabIndex = 6;
            this.labelWrong.Text = "Hatalı şifre ya da kullanıcı adı !";
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpty.ForeColor = System.Drawing.Color.Red;
            this.labelEmpty.Location = new System.Drawing.Point(222, 412);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(356, 28);
            this.labelEmpty.TabIndex = 7;
            this.labelEmpty.Text = "Kullanıcı adı veya şifre boş bırakılamaz !";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(338, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(563, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textboxUserName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 546);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.MC_Custom_Controls.MCTextBox textboxUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.MC_Custom_Controls.MCTextBox textboxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.MCButton.MCButton buttonLogin;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}