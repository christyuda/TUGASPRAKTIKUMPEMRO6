namespace P6_3_1204025
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.pr = new System.Windows.Forms.RadioButton();
            this.lk = new System.Windows.Forms.RadioButton();
            this.tanggal = new System.Windows.Forms.MonthCalendar();
            this.ps = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.Label();
            this.alamt = new System.Windows.Forms.Label();
            this.lbjk = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.hhh = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbnama = new P6_3_1204025.Charbox();
            this.numerictext2 = new P6_3_1204025.numerictext();
            this.numerictext1 = new P6_3_1204025.numerictext();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 470);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "- Pilih Program Studi -";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(220, 352);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(182, 55);
            this.txtalamat.TabIndex = 31;
            // 
            // pr
            // 
            this.pr.AutoSize = true;
            this.pr.Location = new System.Drawing.Point(323, 310);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(79, 17);
            this.pr.TabIndex = 30;
            this.pr.TabStop = true;
            this.pr.Text = "Perempuan";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.Location = new System.Drawing.Point(220, 310);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(68, 17);
            this.lk.TabIndex = 29;
            this.lk.TabStop = true;
            this.lk.Text = "Laki-Laki";
            this.lk.UseVisualStyleBackColor = true;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(220, 122);
            this.tanggal.Name = "tanggal";
            this.tanggal.TabIndex = 28;
            // 
            // ps
            // 
            this.ps.AutoSize = true;
            this.ps.Location = new System.Drawing.Point(85, 476);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(73, 13);
            this.ps.TabIndex = 26;
            this.ps.Text = "Program Studi";
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Location = new System.Drawing.Point(85, 434);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(48, 13);
            this.nt.TabIndex = 25;
            this.nt.Text = "No. Telp";
            // 
            // alamt
            // 
            this.alamt.AutoSize = true;
            this.alamt.Location = new System.Drawing.Point(85, 352);
            this.alamt.Name = "alamt";
            this.alamt.Size = new System.Drawing.Size(39, 13);
            this.alamt.TabIndex = 24;
            this.alamt.Text = "Alamat";
            // 
            // lbjk
            // 
            this.lbjk.AutoSize = true;
            this.lbjk.Location = new System.Drawing.Point(85, 310);
            this.lbjk.Name = "lbjk";
            this.lbjk.Size = new System.Drawing.Size(71, 13);
            this.lbjk.TabIndex = 23;
            this.lbjk.Text = "Jenis Kelamin";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Location = new System.Drawing.Point(85, 121);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(72, 13);
            this.tl.TabIndex = 22;
            this.tl.Text = "Tanggal Lahir";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(85, 79);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(35, 13);
            this.nama.TabIndex = 21;
            this.nama.Text = "Nama";
            // 
            // hhh
            // 
            this.hhh.AutoSize = true;
            this.hhh.Location = new System.Drawing.Point(85, 43);
            this.hhh.Name = "hhh";
            this.hhh.Size = new System.Drawing.Size(31, 13);
            this.hhh.TabIndex = 20;
            this.hhh.Text = "NPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, -57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbnama
            // 
            this.cbnama.Location = new System.Drawing.Point(220, 79);
            this.cbnama.Name = "cbnama";
            this.cbnama.Size = new System.Drawing.Size(150, 20);
            this.cbnama.TabIndex = 37;
            // 
            // numerictext2
            // 
            this.numerictext2.Location = new System.Drawing.Point(220, 431);
            this.numerictext2.Name = "numerictext2";
            this.numerictext2.Size = new System.Drawing.Size(150, 20);
            this.numerictext2.TabIndex = 36;
            // 
            // numerictext1
            // 
            this.numerictext1.Location = new System.Drawing.Point(220, 40);
            this.numerictext1.Name = "numerictext1";
            this.numerictext1.Size = new System.Drawing.Size(150, 20);
            this.numerictext1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 610);
            this.Controls.Add(this.cbnama);
            this.Controls.Add(this.numerictext2);
            this.Controls.Add(this.numerictext1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.alamt);
            this.Controls.Add(this.lbjk);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.hhh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.RadioButton pr;
        private System.Windows.Forms.RadioButton lk;
        private System.Windows.Forms.MonthCalendar tanggal;
        private System.Windows.Forms.Label ps;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.Label alamt;
        private System.Windows.Forms.Label lbjk;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label hhh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private numerictext numerictext1;
        private numerictext numerictext2;
        private Charbox cbnama;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

