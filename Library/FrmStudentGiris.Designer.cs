namespace Kutuphane_Proje
{
    partial class FrmStudentGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texbPassword = new System.Windows.Forms.TextBox();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.texbStudentNumEmail = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Entrence Panel";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(155, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password :";
            // 
            // texbPassword
            // 
            this.texbPassword.Location = new System.Drawing.Point(310, 170);
            this.texbPassword.Name = "texbPassword";
            this.texbPassword.Size = new System.Drawing.Size(191, 20);
            this.texbPassword.TabIndex = 3;
            this.texbPassword.UseSystemPasswordChar = true;
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkSignup.Location = new System.Drawing.Point(516, 170);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(67, 20);
            this.linkSignup.TabIndex = 4;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Sign up!";
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignup_LinkClicked);
            // 
            // texbStudentNumEmail
            // 
            this.texbStudentNumEmail.Location = new System.Drawing.Point(310, 133);
            this.texbStudentNumEmail.Name = "texbStudentNumEmail";
            this.texbStudentNumEmail.Size = new System.Drawing.Size(191, 20);
            this.texbStudentNumEmail.TabIndex = 5;
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignin.Location = new System.Drawing.Point(348, 205);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(153, 27);
            this.btnSignin.TabIndex = 6;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student No/E-mail  :";
            // 
            // FrmStudentGiris
            // 
            this.AcceptButton = this.btnSignin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(698, 269);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.texbStudentNumEmail);
            this.Controls.Add(this.linkSignup);
            this.Controls.Add(this.texbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStudentGiris";
            this.Text = "Student Entrence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texbPassword;
        private System.Windows.Forms.LinkLabel linkSignup;
        private System.Windows.Forms.TextBox texbStudentNumEmail;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label label4;
    }
}