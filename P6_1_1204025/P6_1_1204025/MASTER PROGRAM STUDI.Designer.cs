namespace P6_1_1204025
{
    partial class Form1
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
            this.lbidprodi = new System.Windows.Forms.Label();
            this.lblNamaProdi = new System.Windows.Forms.Label();
            this.lblSingkatan = new System.Windows.Forms.Label();
            this.lbKaProdi = new System.Windows.Forms.Label();
            this.lbSekProdi = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtIdProdi = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtKaProdi = new System.Windows.Forms.TextBox();
            this.txtSekProdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Input Prodi";
            // 
            // lbidprodi
            // 
            this.lbidprodi.AutoSize = true;
            this.lbidprodi.Location = new System.Drawing.Point(40, 67);
            this.lbidprodi.Name = "lbidprodi";
            this.lbidprodi.Size = new System.Drawing.Size(126, 13);
            this.lbidprodi.TabIndex = 1;
            this.lbidprodi.Text = "ID Prodi                          :";
            // 
            // lblNamaProdi
            // 
            this.lblNamaProdi.AutoSize = true;
            this.lblNamaProdi.Location = new System.Drawing.Point(40, 96);
            this.lblNamaProdi.Name = "lblNamaProdi";
            this.lblNamaProdi.Size = new System.Drawing.Size(128, 13);
            this.lblNamaProdi.TabIndex = 2;
            this.lblNamaProdi.Text = "Nama Prodi                     :";
            // 
            // lblSingkatan
            // 
            this.lblSingkatan.AutoSize = true;
            this.lblSingkatan.Location = new System.Drawing.Point(40, 123);
            this.lblSingkatan.Name = "lblSingkatan";
            this.lblSingkatan.Size = new System.Drawing.Size(127, 13);
            this.lblSingkatan.TabIndex = 3;
            this.lblSingkatan.Text = "Singkatan                       :";
            // 
            // lbKaProdi
            // 
            this.lbKaProdi.AutoSize = true;
            this.lbKaProdi.Location = new System.Drawing.Point(40, 154);
            this.lbKaProdi.Name = "lbKaProdi";
            this.lbKaProdi.Size = new System.Drawing.Size(128, 13);
            this.lbKaProdi.TabIndex = 4;
            this.lbKaProdi.Text = "Ketua Prodi                     :\r\n";
            // 
            // lbSekProdi
            // 
            this.lbSekProdi.AutoSize = true;
            this.lbSekProdi.Location = new System.Drawing.Point(40, 187);
            this.lbSekProdi.Name = "lbSekProdi";
            this.lbSekProdi.Size = new System.Drawing.Size(129, 13);
            this.lbSekProdi.TabIndex = 5;
            this.lbSekProdi.Text = "Sekretaris Prodi               :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtIdProdi
            // 
            this.txtIdProdi.Location = new System.Drawing.Point(184, 60);
            this.txtIdProdi.Name = "txtIdProdi";
            this.txtIdProdi.Size = new System.Drawing.Size(100, 20);
            this.txtIdProdi.TabIndex = 8;
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(184, 94);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(246, 20);
            this.txtNamaProdi.TabIndex = 9;
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(184, 120);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(100, 20);
            this.txtSingkatan.TabIndex = 10;
            // 
            // txtKaProdi
            // 
            this.txtKaProdi.Location = new System.Drawing.Point(184, 151);
            this.txtKaProdi.Name = "txtKaProdi";
            this.txtKaProdi.Size = new System.Drawing.Size(246, 20);
            this.txtKaProdi.TabIndex = 11;
            this.txtKaProdi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSekProdi
            // 
            this.txtSekProdi.Location = new System.Drawing.Point(184, 187);
            this.txtSekProdi.Name = "txtSekProdi";
            this.txtSekProdi.Size = new System.Drawing.Size(246, 20);
            this.txtSekProdi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 293);
            this.Controls.Add(this.txtSekProdi);
            this.Controls.Add(this.txtKaProdi);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtIdProdi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSekProdi);
            this.Controls.Add(this.lbKaProdi);
            this.Controls.Add(this.lblSingkatan);
            this.Controls.Add(this.lblNamaProdi);
            this.Controls.Add(this.lbidprodi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Master Program Studi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbidprodi;
        private System.Windows.Forms.Label lblNamaProdi;
        private System.Windows.Forms.Label lblSingkatan;
        private System.Windows.Forms.Label lbKaProdi;
        private System.Windows.Forms.Label lbSekProdi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtIdProdi;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.TextBox txtKaProdi;
        private System.Windows.Forms.TextBox txtSekProdi;
    }
}

