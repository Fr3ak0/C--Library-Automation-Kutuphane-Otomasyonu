namespace Kutuphane_Proje
{
    partial class FrmTeacherGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacherGiris));
            this.btnSignin = new System.Windows.Forms.Button();
            this.texbEmail = new System.Windows.Forms.TextBox();
            this.linkRequest = new System.Windows.Forms.LinkLabel();
            this.texbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignin.Location = new System.Drawing.Point(404, 233);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(153, 27);
            this.btnSignin.TabIndex = 13;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // texbEmail
            // 
            this.texbEmail.Location = new System.Drawing.Point(366, 161);
            this.texbEmail.Name = "texbEmail";
            this.texbEmail.Size = new System.Drawing.Size(191, 20);
            this.texbEmail.TabIndex = 12;
            // 
            // linkRequest
            // 
            this.linkRequest.AutoSize = true;
            this.linkRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkRequest.Location = new System.Drawing.Point(572, 198);
            this.linkRequest.Name = "linkRequest";
            this.linkRequest.Size = new System.Drawing.Size(164, 20);
            this.linkRequest.TabIndex = 11;
            this.linkRequest.TabStop = true;
            this.linkRequest.Text = "Request Registration!";
            this.linkRequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRequest_LinkClicked);
            // 
            // texbPassword
            // 
            this.texbPassword.Location = new System.Drawing.Point(366, 198);
            this.texbPassword.Name = "texbPassword";
            this.texbPassword.Size = new System.Drawing.Size(191, 20);
            this.texbPassword.TabIndex = 10;
            this.texbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(211, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(248, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-mail  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher Entrence Panel";
            // 
            // FrmTeacherGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(788, 307);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.texbEmail);
            this.Controls.Add(this.linkRequest);
            this.Controls.Add(this.texbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTeacherGiris";
            this.Text = "FrmTeacherGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox texbEmail;
        private System.Windows.Forms.LinkLabel linkRequest;
        private System.Windows.Forms.TextBox texbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}