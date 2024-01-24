namespace MuistipeliApp1
{
    partial class FrmPelitilasto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAloitaPeli = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelitilasto";
            // 
            // btnAloitaPeli
            // 
            this.btnAloitaPeli.Location = new System.Drawing.Point(641, 127);
            this.btnAloitaPeli.Name = "btnAloitaPeli";
            this.btnAloitaPeli.Size = new System.Drawing.Size(130, 41);
            this.btnAloitaPeli.TabIndex = 2;
            this.btnAloitaPeli.Text = "Aloita uusi peli";
            this.btnAloitaPeli.UseVisualStyleBackColor = true;
            this.btnAloitaPeli.Click += new System.EventHandler(this.btnAloitaPeli_Click);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(641, 201);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(130, 41);
            this.btnSulje.TabIndex = 3;
            this.btnSulje.Text = "Lopeta peli";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 318);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmPelitilasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.btnAloitaPeli);
            this.Controls.Add(this.label1);
            this.Name = "FrmPelitilasto";
            this.Text = "Pelitilasto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAloitaPeli;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}