namespace b16
{
    partial class Laporan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label0 = new System.Windows.Forms.Label();
            this.pemasukan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.jumlah_pemasukan = new System.Windows.Forms.NumericUpDown();
            this.jumlah_pengeluaran = new System.Windows.Forms.NumericUpDown();
            this.metode_id = new System.Windows.Forms.NumericUpDown();
            this.barang_masuk = new System.Windows.Forms.NumericUpDown();
            this.barang_keluar = new System.Windows.Forms.NumericUpDown();
            this.TabelReport = new System.Windows.Forms.DataGridView();
            this.simpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.report_id = new System.Windows.Forms.NumericUpDown();
            this.edit = new System.Windows.Forms.Button();
            this.label00 = new System.Windows.Forms.Label();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.hapus_report_id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_pemasukan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_pengeluaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metode_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_masuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_keluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapus_report_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label0.Location = new System.Drawing.Point(94, 60);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(148, 36);
            this.label0.TabIndex = 0;
            this.label0.Text = "Tanggal :";
            // 
            // pemasukan
            // 
            this.pemasukan.AutoSize = true;
            this.pemasukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukan.ForeColor = System.Drawing.SystemColors.Control;
            this.pemasukan.Location = new System.Drawing.Point(93, 131);
            this.pemasukan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pemasukan.Name = "pemasukan";
            this.pemasukan.Size = new System.Drawing.Size(197, 36);
            this.pemasukan.TabIndex = 1;
            this.pemasukan.Text = "Pemasukan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pengeluaran :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(626, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Metode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(526, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barang Masuk :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(526, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barang Keluar :";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(322, 68);
            this.tanggal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(174, 26);
            this.tanggal.TabIndex = 6;
            // 
            // jumlah_pemasukan
            // 
            this.jumlah_pemasukan.Location = new System.Drawing.Point(322, 142);
            this.jumlah_pemasukan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlah_pemasukan.Name = "jumlah_pemasukan";
            this.jumlah_pemasukan.Size = new System.Drawing.Size(180, 26);
            this.jumlah_pemasukan.TabIndex = 7;
            // 
            // jumlah_pengeluaran
            // 
            this.jumlah_pengeluaran.Location = new System.Drawing.Point(322, 211);
            this.jumlah_pengeluaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlah_pengeluaran.Name = "jumlah_pengeluaran";
            this.jumlah_pengeluaran.Size = new System.Drawing.Size(180, 26);
            this.jumlah_pengeluaran.TabIndex = 8;
            // 
            // metode_id
            // 
            this.metode_id.Location = new System.Drawing.Point(780, 68);
            this.metode_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metode_id.Name = "metode_id";
            this.metode_id.Size = new System.Drawing.Size(84, 26);
            this.metode_id.TabIndex = 9;
            // 
            // barang_masuk
            // 
            this.barang_masuk.Location = new System.Drawing.Point(782, 138);
            this.barang_masuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barang_masuk.Name = "barang_masuk";
            this.barang_masuk.Size = new System.Drawing.Size(82, 26);
            this.barang_masuk.TabIndex = 10;
            // 
            // barang_keluar
            // 
            this.barang_keluar.Location = new System.Drawing.Point(780, 212);
            this.barang_keluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barang_keluar.Name = "barang_keluar";
            this.barang_keluar.Size = new System.Drawing.Size(84, 26);
            this.barang_keluar.TabIndex = 11;
            // 
            // TabelReport
            // 
            this.TabelReport.AllowUserToAddRows = false;
            this.TabelReport.AllowUserToDeleteRows = false;
            this.TabelReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelReport.Location = new System.Drawing.Point(100, 327);
            this.TabelReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabelReport.Name = "TabelReport";
            this.TabelReport.ReadOnly = true;
            this.TabelReport.RowHeadersWidth = 62;
            this.TabelReport.Size = new System.Drawing.Size(999, 278);
            this.TabelReport.TabIndex = 12;
            this.TabelReport.Click += new System.EventHandler(this.TabelReport_Click);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(550, 271);
            this.simpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(112, 35);
            this.simpan.TabIndex = 13;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(970, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edit";
            // 
            // report_id
            // 
            this.report_id.Location = new System.Drawing.Point(969, 103);
            this.report_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report_id.Name = "report_id";
            this.report_id.Size = new System.Drawing.Size(69, 26);
            this.report_id.TabIndex = 15;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Yellow;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(942, 143);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(112, 35);
            this.edit.TabIndex = 16;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label00
            // 
            this.label00.AutoSize = true;
            this.label00.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label00.ForeColor = System.Drawing.Color.Red;
            this.label00.Location = new System.Drawing.Point(954, 203);
            this.label00.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(92, 30);
            this.label00.TabIndex = 17;
            this.label00.Text = "Hapus";
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Red;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hapus_btn.Location = new System.Drawing.Point(942, 282);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(112, 35);
            this.hapus_btn.TabIndex = 18;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_Click);
            // 
            // hapus_report_id
            // 
            this.hapus_report_id.Location = new System.Drawing.Point(969, 242);
            this.hapus_report_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hapus_report_id.Name = "hapus_report_id";
            this.hapus_report_id.Size = new System.Drawing.Size(69, 26);
            this.hapus_report_id.TabIndex = 19;
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.hapus_report_id);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.label00);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.report_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.TabelReport);
            this.Controls.Add(this.barang_keluar);
            this.Controls.Add(this.barang_masuk);
            this.Controls.Add(this.metode_id);
            this.Controls.Add(this.jumlah_pengeluaran);
            this.Controls.Add(this.jumlah_pemasukan);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pemasukan);
            this.Controls.Add(this.label0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Laporan";
            this.Size = new System.Drawing.Size(1215, 692);
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_pemasukan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_pengeluaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metode_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_masuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_keluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapus_report_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label pemasukan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.NumericUpDown jumlah_pemasukan;
        private System.Windows.Forms.NumericUpDown jumlah_pengeluaran;
        private System.Windows.Forms.NumericUpDown metode_id;
        private System.Windows.Forms.NumericUpDown barang_masuk;
        private System.Windows.Forms.NumericUpDown barang_keluar;
        private System.Windows.Forms.DataGridView TabelReport;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown report_id;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.NumericUpDown hapus_report_id;
    }
}
