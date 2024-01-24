namespace MuistipeliApp1
{
    partial class FrmMuistipeli
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
            this.components = new System.ComponentModel.Container();
            this.tmrArvausaika = new System.Windows.Forms.Timer(this.components);
            this.btnAloitapeli = new System.Windows.Forms.Button();
            this.lblPelaaja1Nimi = new System.Windows.Forms.Label();
            this.lblPelaaja2Nimi = new System.Windows.Forms.Label();
            this.lblPelaaja1pisteet = new System.Windows.Forms.Label();
            this.lblPelaaja2Pisteet = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKenenVuoro = new System.Windows.Forms.Label();
            this.tmrPeli = new System.Windows.Forms.Timer(this.components);
            this.lblPelikello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrArvausaika
            // 
            this.tmrArvausaika.Interval = 250;
            this.tmrArvausaika.Tick += new System.EventHandler(this.tmrArvausaika_Tick);
            // 
            // btnAloitapeli
            // 
            this.btnAloitapeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloitapeli.Location = new System.Drawing.Point(616, 161);
            this.btnAloitapeli.Name = "btnAloitapeli";
            this.btnAloitapeli.Size = new System.Drawing.Size(163, 78);
            this.btnAloitapeli.TabIndex = 12;
            this.btnAloitapeli.Text = "Aloita peli";
            this.btnAloitapeli.UseVisualStyleBackColor = true;
            this.btnAloitapeli.Click += new System.EventHandler(this.btnAloitapeli_Click);
            // 
            // lblPelaaja1Nimi
            // 
            this.lblPelaaja1Nimi.AutoSize = true;
            this.lblPelaaja1Nimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1Nimi.Location = new System.Drawing.Point(584, 31);
            this.lblPelaaja1Nimi.Name = "lblPelaaja1Nimi";
            this.lblPelaaja1Nimi.Size = new System.Drawing.Size(73, 20);
            this.lblPelaaja1Nimi.TabIndex = 13;
            this.lblPelaaja1Nimi.Text = "Pelaaja1";
            // 
            // lblPelaaja2Nimi
            // 
            this.lblPelaaja2Nimi.AutoSize = true;
            this.lblPelaaja2Nimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Nimi.Location = new System.Drawing.Point(753, 31);
            this.lblPelaaja2Nimi.Name = "lblPelaaja2Nimi";
            this.lblPelaaja2Nimi.Size = new System.Drawing.Size(0, 20);
            this.lblPelaaja2Nimi.TabIndex = 14;
            // 
            // lblPelaaja1pisteet
            // 
            this.lblPelaaja1pisteet.AutoSize = true;
            this.lblPelaaja1pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1pisteet.Location = new System.Drawing.Point(623, 64);
            this.lblPelaaja1pisteet.Name = "lblPelaaja1pisteet";
            this.lblPelaaja1pisteet.Size = new System.Drawing.Size(0, 20);
            this.lblPelaaja1pisteet.TabIndex = 15;
            // 
            // lblPelaaja2Pisteet
            // 
            this.lblPelaaja2Pisteet.AutoSize = true;
            this.lblPelaaja2Pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Pisteet.Location = new System.Drawing.Point(753, 64);
            this.lblPelaaja2Pisteet.Name = "lblPelaaja2Pisteet";
            this.lblPelaaja2Pisteet.Size = new System.Drawing.Size(0, 20);
            this.lblPelaaja2Pisteet.TabIndex = 16;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(12, 161);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 100);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(142, 161);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(272, 161);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(405, 161);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(12, 301);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(142, 301);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(272, 301);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(405, 301);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(272, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(405, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(142, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblKenenVuoro
            // 
            this.lblKenenVuoro.AutoSize = true;
            this.lblKenenVuoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKenenVuoro.Location = new System.Drawing.Point(601, 278);
            this.lblKenenVuoro.Name = "lblKenenVuoro";
            this.lblKenenVuoro.Size = new System.Drawing.Size(196, 29);
            this.lblKenenVuoro.TabIndex = 17;
            this.lblKenenVuoro.Text = "Pelaaja 1 aloittaa";
            this.lblKenenVuoro.Visible = false;
            // 
            // tmrPeli
            // 
            this.tmrPeli.Interval = 1000;
            this.tmrPeli.Tick += new System.EventHandler(this.tmrPeli_Tick);
            // 
            // lblPelikello
            // 
            this.lblPelikello.AutoSize = true;
            this.lblPelikello.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelikello.Location = new System.Drawing.Point(681, 342);
            this.lblPelikello.Name = "lblPelikello";
            this.lblPelikello.Size = new System.Drawing.Size(57, 39);
            this.lblPelikello.TabIndex = 18;
            this.lblPelikello.Text = "30";
            this.lblPelikello.Visible = false;
            // 
            // FrmMuistipeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 553);
            this.Controls.Add(this.lblPelikello);
            this.Controls.Add(this.lblKenenVuoro);
            this.Controls.Add(this.lblPelaaja2Pisteet);
            this.Controls.Add(this.lblPelaaja1pisteet);
            this.Controls.Add(this.lblPelaaja2Nimi);
            this.Controls.Add(this.lblPelaaja1Nimi);
            this.Controls.Add(this.btnAloitapeli);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMuistipeli";
            this.Text = "Muistipeli 6 parilla";
            this.Load += new System.EventHandler(this.FrmMuistipeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Timer tmrArvausaika;
        private System.Windows.Forms.Button btnAloitapeli;
        private System.Windows.Forms.Label lblPelaaja1Nimi;
        private System.Windows.Forms.Label lblPelaaja2Nimi;
        private System.Windows.Forms.Label lblPelaaja1pisteet;
        private System.Windows.Forms.Label lblPelaaja2Pisteet;
        private System.Windows.Forms.Label lblKenenVuoro;
        private System.Windows.Forms.Timer tmrPeli;
        private System.Windows.Forms.Label lblPelikello;
    }
}