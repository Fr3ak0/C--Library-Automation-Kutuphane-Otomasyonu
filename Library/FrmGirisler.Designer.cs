﻿namespace Kutuphane_Proje
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.bStudent = new System.Windows.Forms.Button();
            this.bTeacher = new System.Windows.Forms.Button();
            this.bAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bStudent
            // 
            this.bStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bStudent.BackgroundImage")));
            this.bStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bStudent.Location = new System.Drawing.Point(67, 280);
            this.bStudent.Name = "bStudent";
            this.bStudent.Size = new System.Drawing.Size(184, 138);
            this.bStudent.TabIndex = 0;
            this.bStudent.UseVisualStyleBackColor = true;
            this.bStudent.Click += new System.EventHandler(this.bStudent_Click);
            // 
            // bTeacher
            // 
            this.bTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTeacher.BackgroundImage")));
            this.bTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTeacher.Location = new System.Drawing.Point(312, 280);
            this.bTeacher.Name = "bTeacher";
            this.bTeacher.Size = new System.Drawing.Size(184, 138);
            this.bTeacher.TabIndex = 0;
            this.bTeacher.UseVisualStyleBackColor = true;
            this.bTeacher.Click += new System.EventHandler(this.bTeacher_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAdmin.BackgroundImage")));
            this.bAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdmin.Location = new System.Drawing.Point(555, 280);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(184, 138);
            this.bAdmin.TabIndex = 0;
            this.bAdmin.UseVisualStyleBackColor = true;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 80);
            this.label4.TabIndex = 3;
            this.label4.Text = "Library Entrence";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(812, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bTeacher);
            this.Controls.Add(this.bStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Library Entrence";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStudent;
        private System.Windows.Forms.Button bTeacher;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

