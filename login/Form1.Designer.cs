namespace login
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
            this.label1 = new System.Windows.Forms.Label();
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.altoTextBox2 = new AltoControls.AltoTextBox();
            this.altoSlidingLabel1 = new AltoControls.AltoSlidingLabel();
            this.altoSlidingLabel2 = new AltoControls.AltoSlidingLabel();
            this.altoButton1 = new AltoControls.AltoButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(43, 152);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(146, 33);
            this.altoTextBox1.TabIndex = 2;
            this.altoTextBox1.Text = " ";
            // 
            // altoTextBox2
            // 
            this.altoTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox2.Br = System.Drawing.Color.White;
            this.altoTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox2.Location = new System.Drawing.Point(43, 224);
            this.altoTextBox2.Name = "altoTextBox2";
            this.altoTextBox2.Size = new System.Drawing.Size(146, 33);
            this.altoTextBox2.TabIndex = 3;
            this.altoTextBox2.Text = " ";
            // 
            // altoSlidingLabel1
            // 
            this.altoSlidingLabel1.Location = new System.Drawing.Point(12, 131);
            this.altoSlidingLabel1.Name = "altoSlidingLabel1";
            this.altoSlidingLabel1.Size = new System.Drawing.Size(165, 15);
            this.altoSlidingLabel1.Slide = false;
            this.altoSlidingLabel1.TabIndex = 4;
            this.altoSlidingLabel1.Text = "Kullanıcı Adı Yada e Posta";
            // 
            // altoSlidingLabel2
            // 
            this.altoSlidingLabel2.Location = new System.Drawing.Point(12, 203);
            this.altoSlidingLabel2.Name = "altoSlidingLabel2";
            this.altoSlidingLabel2.Size = new System.Drawing.Size(165, 15);
            this.altoSlidingLabel2.Slide = false;
            this.altoSlidingLabel2.TabIndex = 5;
            this.altoSlidingLabel2.Text = "Şifre";
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton1.ForeColor = System.Drawing.Color.Black;
            this.altoButton1.Inactive1 = System.Drawing.Color.Black;
            this.altoButton1.Inactive2 = System.Drawing.Color.White;
            this.altoButton1.Location = new System.Drawing.Point(68, 306);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(87, 30);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 6;
            this.altoButton1.Text = "Giriş Yap";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(137, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şiremi unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "yada";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(21, 270);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Hesap Oluştur";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.Adsız1;
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 429);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.altoSlidingLabel2);
            this.Controls.Add(this.altoSlidingLabel1);
            this.Controls.Add(this.altoTextBox2);
            this.Controls.Add(this.altoTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoTextBox altoTextBox2;
        private AltoControls.AltoSlidingLabel altoSlidingLabel1;
        private AltoControls.AltoSlidingLabel altoSlidingLabel2;
        private AltoControls.AltoButton altoButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

