using System;
using System.Drawing;
using System.Windows.Forms;

namespace KlinikApp
{
    partial class lbl15
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJumlahObat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.lblBiayaObat = new System.Windows.Forms.Label();
            this.lblBiayaLabolatorium = new System.Windows.Forms.Label();
            this.lblBiayaKonsultasiDokter = new System.Windows.Forms.Label();
            this.lblBiayaPendaftaran = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lbl1.Location = new System.Drawing.Point(113, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "kyy Apoteker";
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPembayaran.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.ForeColor = System.Drawing.Color.White;
            this.btnPembayaran.Location = new System.Drawing.Point(90, 182);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(193, 34);
            this.btnPembayaran.TabIndex = 3;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = false;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(53, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Biaya Labolatorium Rp 500.000";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Daftar Harga ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obat";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHarga.Location = new System.Drawing.Point(50, 133);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(39, 16);
            this.lblHarga.TabIndex = 10;
            this.lblHarga.Text = "Harga";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.lblJumlahObat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.lblDiskon);
            this.groupBox1.Controls.Add(this.lblBiayaObat);
            this.groupBox1.Controls.Add(this.lblBiayaLabolatorium);
            this.groupBox1.Controls.Add(this.lblBiayaKonsultasiDokter);
            this.groupBox1.Controls.Add(this.lblBiayaPendaftaran);
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl13);
            this.groupBox1.Controls.Add(this.lbl12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(52, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 296);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rincian Pembayaran";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblJumlahObat
            // 
            this.lblJumlahObat.AutoSize = true;
            this.lblJumlahObat.Location = new System.Drawing.Point(82, 129);
            this.lblJumlahObat.Name = "lblJumlahObat";
            this.lblJumlahObat.Size = new System.Drawing.Size(13, 16);
            this.lblJumlahObat.TabIndex = 18;
            this.lblJumlahObat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Jumlah Obat :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(51, 263);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(63, 190);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(13, 16);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "0";
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Location = new System.Drawing.Point(63, 217);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(13, 16);
            this.lblDiskon.TabIndex = 14;
            this.lblDiskon.Text = "0";
            // 
            // lblBiayaObat
            // 
            this.lblBiayaObat.AutoSize = true;
            this.lblBiayaObat.Location = new System.Drawing.Point(82, 156);
            this.lblBiayaObat.Name = "lblBiayaObat";
            this.lblBiayaObat.Size = new System.Drawing.Size(13, 16);
            this.lblBiayaObat.TabIndex = 13;
            this.lblBiayaObat.Text = "0";
            // 
            // lblBiayaLabolatorium
            // 
            this.lblBiayaLabolatorium.AutoSize = true;
            this.lblBiayaLabolatorium.Location = new System.Drawing.Point(129, 100);
            this.lblBiayaLabolatorium.Name = "lblBiayaLabolatorium";
            this.lblBiayaLabolatorium.Size = new System.Drawing.Size(13, 16);
            this.lblBiayaLabolatorium.TabIndex = 12;
            this.lblBiayaLabolatorium.Text = "0";
            // 
            // lblBiayaKonsultasiDokter
            // 
            this.lblBiayaKonsultasiDokter.AutoSize = true;
            this.lblBiayaKonsultasiDokter.Location = new System.Drawing.Point(148, 67);
            this.lblBiayaKonsultasiDokter.Name = "lblBiayaKonsultasiDokter";
            this.lblBiayaKonsultasiDokter.Size = new System.Drawing.Size(13, 16);
            this.lblBiayaKonsultasiDokter.TabIndex = 11;
            this.lblBiayaKonsultasiDokter.Text = "0";
            // 
            // lblBiayaPendaftaran
            // 
            this.lblBiayaPendaftaran.AutoSize = true;
            this.lblBiayaPendaftaran.Location = new System.Drawing.Point(120, 32);
            this.lblBiayaPendaftaran.Name = "lblBiayaPendaftaran";
            this.lblBiayaPendaftaran.Size = new System.Drawing.Size(13, 16);
            this.lblBiayaPendaftaran.TabIndex = 10;
            this.lblBiayaPendaftaran.Text = "0";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(6, 263);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(39, 16);
            this.lbl10.TabIndex = 9;
            this.lbl10.Text = "Total :";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(6, 217);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(49, 16);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = "Diskon :";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(6, 190);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(57, 16);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "Subtotal :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(442, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 156);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(70, 16);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Biaya Obat :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(114, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Biaya Labolatorium :";
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(6, 67);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(136, 16);
            this.lbl13.TabIndex = 1;
            this.lbl13.Text = "Biaya Konsultasi Dokter :";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(6, 32);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(108, 16);
            this.lbl12.TabIndex = 0;
            this.lbl12.Text = "Biaya Pendaftaran :";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(289, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(30, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::KlinikApp.Properties.Resources.volunteer;
            this.pictureBox2.Location = new System.Drawing.Point(52, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // lbl15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPembayaran);
            this.Controls.Add(this.lbl1);
            this.MaximizeBox = false;
            this.Name = "lbl15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klinik Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.ComboBox comboBox2;
        private Label lblBiayaObat;
        private Label lblBiayaLabolatorium;
        private Label lblBiayaKonsultasiDokter;
        private Label lblBiayaPendaftaran;
        private Label lblSubtotal;
        private Label lblDiskon;
        private Label lblTotal;
        private Label lblJumlahObat;
        private Label label4;
        private PictureBox pictureBox2;
    }
}