namespace login
{
    partial class Form2
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
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.altoSlidingLabel1 = new AltoControls.AltoSlidingLabel();
            this.altoSlidingLabel2 = new AltoControls.AltoSlidingLabel();
            this.altoButton1 = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(24, 128);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(189, 33);
            this.altoTextBox1.TabIndex = 0;
            // 
            // altoSlidingLabel1
            // 
            this.altoSlidingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altoSlidingLabel1.Location = new System.Drawing.Point(59, 12);
            this.altoSlidingLabel1.Name = "altoSlidingLabel1";
            this.altoSlidingLabel1.Size = new System.Drawing.Size(135, 26);
            this.altoSlidingLabel1.Slide = false;
            this.altoSlidingLabel1.TabIndex = 1;
            this.altoSlidingLabel1.Text = "Şifremi Unuttum";
            // 
            // altoSlidingLabel2
            // 
            this.altoSlidingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altoSlidingLabel2.Location = new System.Drawing.Point(2, 84);
            this.altoSlidingLabel2.Name = "altoSlidingLabel2";
            this.altoSlidingLabel2.Size = new System.Drawing.Size(320, 26);
            this.altoSlidingLabel2.Slide = false;
            this.altoSlidingLabel2.TabIndex = 2;
            this.altoSlidingLabel2.Text = "hesapta kayıtlı olan e posta adresi";
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
            this.altoButton1.Location = new System.Drawing.Point(59, 187);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(109, 45);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 3;
            this.altoButton1.Text = "Giriş Bağlantısı Gönder";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 390);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.altoSlidingLabel2);
            this.Controls.Add(this.altoSlidingLabel1);
            this.Controls.Add(this.altoTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoSlidingLabel altoSlidingLabel1;
        private AltoControls.AltoSlidingLabel altoSlidingLabel2;
        private AltoControls.AltoButton altoButton1;
    }
}