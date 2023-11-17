namespace MyRapor
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
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaSiswa = new System.Windows.Forms.TextBox();
            this.tbNisn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.cbAgama = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.nisn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbTtl = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTglLahir = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Biodata";
            // 
            // dgvRapor
            // 
            this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisn,
            this.nama_siswa,
            this.jk,
            this.agama,
            this.ttl,
            this.alamat,
            this.delete});
            this.dgvRapor.Location = new System.Drawing.Point(59, 126);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.ReadOnly = true;
            this.dgvRapor.Size = new System.Drawing.Size(997, 287);
            this.dgvRapor.TabIndex = 1;
            this.dgvRapor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapor_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama siswa";
            // 
            // tbNamaSiswa
            // 
            this.tbNamaSiswa.Location = new System.Drawing.Point(56, 460);
            this.tbNamaSiswa.Name = "tbNamaSiswa";
            this.tbNamaSiswa.Size = new System.Drawing.Size(305, 20);
            this.tbNamaSiswa.TabIndex = 3;
            // 
            // tbNisn
            // 
            this.tbNisn.Location = new System.Drawing.Point(56, 510);
            this.tbNisn.Name = "tbNisn";
            this.tbNisn.Size = new System.Drawing.Size(305, 20);
            this.tbNisn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nisn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis kelamin";
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Location = new System.Drawing.Point(56, 558);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(305, 21);
            this.cbJk.TabIndex = 7;
            // 
            // cbAgama
            // 
            this.cbAgama.FormattingEnabled = true;
            this.cbAgama.Location = new System.Drawing.Point(56, 609);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(305, 21);
            this.cbAgama.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tempat lahir";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(56, 715);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(1000, 37);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // nisn
            // 
            this.nisn.HeaderText = "Nisn";
            this.nisn.Name = "nisn";
            this.nisn.ReadOnly = true;
            // 
            // nama_siswa
            // 
            this.nama_siswa.HeaderText = "Nama siswa";
            this.nama_siswa.Name = "nama_siswa";
            this.nama_siswa.ReadOnly = true;
            // 
            // jk
            // 
            this.jk.HeaderText = "Jenis kelamin";
            this.jk.Name = "jk";
            this.jk.ReadOnly = true;
            // 
            // agama
            // 
            this.agama.HeaderText = "Agama";
            this.agama.Name = "agama";
            this.agama.ReadOnly = true;
            // 
            // ttl
            // 
            this.ttl.HeaderText = "Tempat, tanggal lahir";
            this.ttl.Name = "ttl";
            this.ttl.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 50F;
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // tbTtl
            // 
            this.tbTtl.Location = new System.Drawing.Point(56, 658);
            this.tbTtl.Name = "tbTtl";
            this.tbTtl.Size = new System.Drawing.Size(305, 20);
            this.tbTtl.TabIndex = 21;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(410, 510);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(305, 70);
            this.tbAlamat.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tanggal lahir";
            // 
            // dtpTglLahir
            // 
            this.dtpTglLahir.Location = new System.Drawing.Point(410, 460);
            this.dtpTglLahir.Name = "dtpTglLahir";
            this.dtpTglLahir.Size = new System.Drawing.Size(305, 20);
            this.dtpTglLahir.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 786);
            this.Controls.Add(this.dtpTglLahir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbTtl);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAgama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNisn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamaSiswa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaSiswa;
        private System.Windows.Forms.TextBox tbNisn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.ComboBox cbAgama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn agama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.TextBox tbTtl;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTglLahir;
    }
}

