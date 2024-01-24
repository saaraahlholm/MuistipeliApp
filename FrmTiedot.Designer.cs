namespace MuistipeliApp1
{
    partial class FrmTiedot
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
            this.btnYksinpeli = new System.Windows.Forms.Button();
            this.btnKaksinpeli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btnPelitilastoon = new System.Windows.Forms.Button();
            this.btnLopeta = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYksinpeli
            // 
            this.btnYksinpeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYksinpeli.Location = new System.Drawing.Point(71, 53);
            this.btnYksinpeli.Name = "btnYksinpeli";
            this.btnYksinpeli.Size = new System.Drawing.Size(141, 52);
            this.btnYksinpeli.TabIndex = 0;
            this.btnYksinpeli.Text = "Yksinpeli";
            this.btnYksinpeli.UseVisualStyleBackColor = true;
            this.btnYksinpeli.Click += new System.EventHandler(this.btnYksinpeli_Click);
            // 
            // btnKaksinpeli
            // 
            this.btnKaksinpeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaksinpeli.Location = new System.Drawing.Point(281, 53);
            this.btnKaksinpeli.Name = "btnKaksinpeli";
            this.btnKaksinpeli.Size = new System.Drawing.Size(141, 52);
            this.btnKaksinpeli.TabIndex = 1;
            this.btnKaksinpeli.Text = "Kaksinpeli";
            this.btnKaksinpeli.UseVisualStyleBackColor = true;
            this.btnKaksinpeli.Click += new System.EventHandler(this.btnKaksinpeli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valitse pelin koko";
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(559, 114);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 49);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6 paria";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(665, 114);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(71, 49);
            this.btn10.TabIndex = 5;
            this.btn10.Text = "10 paria";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(771, 114);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(71, 49);
            this.btn14.TabIndex = 6;
            this.btn14.Text = "14 paria";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btnPelitilastoon
            // 
            this.btnPelitilastoon.Location = new System.Drawing.Point(665, 300);
            this.btnPelitilastoon.Name = "btnPelitilastoon";
            this.btnPelitilastoon.Size = new System.Drawing.Size(193, 48);
            this.btnPelitilastoon.TabIndex = 7;
            this.btnPelitilastoon.Text = "Tarkastele pelitilastoja";
            this.btnPelitilastoon.UseVisualStyleBackColor = true;
            this.btnPelitilastoon.Click += new System.EventHandler(this.btnPelitilastoon_Click);
            // 
            // btnLopeta
            // 
            this.btnLopeta.Location = new System.Drawing.Point(665, 369);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(195, 48);
            this.btnLopeta.TabIndex = 8;
            this.btnLopeta.Text = "Lopeta peli";
            this.btnLopeta.UseVisualStyleBackColor = true;
            this.btnLopeta.Click += new System.EventHandler(this.btnLopeta_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FrmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 446);
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.btnPelitilastoon);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaksinpeli);
            this.Controls.Add(this.btnYksinpeli);
            this.Name = "FrmTiedot";
            this.Text = "Pelaajien tiedot";
            this.Load += new System.EventHandler(this.FrmTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYksinpeli;
        private System.Windows.Forms.Button btnKaksinpeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btnPelitilastoon;
        private System.Windows.Forms.Button btnLopeta;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

