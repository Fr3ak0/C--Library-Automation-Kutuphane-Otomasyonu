namespace Kutuphane_Proje
{
    partial class FromStudentEntrence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromStudentEntrence));
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStdNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStudentPassword = new System.Windows.Forms.TextBox();
            this.bSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(251, 51);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(191, 20);
            this.TxtStudentName.TabIndex = 1;
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Location = new System.Drawing.Point(251, 78);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(191, 20);
            this.TxtStudentSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(107, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mail :";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(251, 113);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(191, 20);
            this.TxtMail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Number :";
            // 
            // TxtStdNum
            // 
            this.TxtStdNum.Location = new System.Drawing.Point(251, 150);
            this.TxtStdNum.Name = "TxtStdNum";
            this.TxtStdNum.Size = new System.Drawing.Size(191, 20);
            this.TxtStdNum.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(96, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password :";
            // 
            // TxtStudentPassword
            // 
            this.TxtStudentPassword.Location = new System.Drawing.Point(251, 191);
            this.TxtStudentPassword.Name = "TxtStudentPassword";
            this.TxtStudentPassword.Size = new System.Drawing.Size(191, 20);
            this.TxtStudentPassword.TabIndex = 5;
            this.TxtStudentPassword.UseSystemPasswordChar = true;
            // 
            // bSignUp
            // 
            this.bSignUp.BackColor = System.Drawing.Color.SeaGreen;
            this.bSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSignUp.Location = new System.Drawing.Point(251, 247);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(139, 39);
            this.bSignUp.TabIndex = 10;
            this.bSignUp.Text = "Sign Up!";
            this.bSignUp.UseVisualStyleBackColor = false;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // FromStudentEntrence
            // 
            this.AcceptButton = this.bSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(504, 347);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.TxtStudentPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStdNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtStudentSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FromStudentEntrence";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStdNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStudentPassword;
        private System.Windows.Forms.Button bSignUp;
    }
}