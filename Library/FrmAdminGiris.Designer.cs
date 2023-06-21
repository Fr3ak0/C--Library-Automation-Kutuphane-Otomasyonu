namespace Kutuphane_Proje
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.btnSigninA = new System.Windows.Forms.Button();
            this.texbEmailA = new System.Windows.Forms.TextBox();
            this.texbPasswordA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSigninA
            // 
            this.btnSigninA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSigninA.Location = new System.Drawing.Point(388, 229);
            this.btnSigninA.Name = "btnSigninA";
            this.btnSigninA.Size = new System.Drawing.Size(153, 27);
            this.btnSigninA.TabIndex = 3;
            this.btnSigninA.Text = "Sign in";
            this.btnSigninA.UseVisualStyleBackColor = true;
            this.btnSigninA.Click += new System.EventHandler(this.btnSigninA_Click);
            // 
            // texbEmailA
            // 
            this.texbEmailA.Location = new System.Drawing.Point(350, 157);
            this.texbEmailA.Name = "texbEmailA";
            this.texbEmailA.Size = new System.Drawing.Size(191, 20);
            this.texbEmailA.TabIndex = 1;
            // 
            // texbPasswordA
            // 
            this.texbPasswordA.Location = new System.Drawing.Point(350, 194);
            this.texbPasswordA.Name = "texbPasswordA";
            this.texbPasswordA.Size = new System.Drawing.Size(191, 20);
            this.texbPasswordA.TabIndex = 2;
            this.texbPasswordA.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(195, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(232, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-mail  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 80);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin Entrence Panel";
            // 
            // FrmAdminGiris
            // 
            this.AcceptButton = this.btnSigninA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(764, 316);
            this.Controls.Add(this.btnSigninA);
            this.Controls.Add(this.texbEmailA);
            this.Controls.Add(this.texbPasswordA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdminGiris";
            this.Text = "Admin Entrence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSigninA;
        private System.Windows.Forms.TextBox texbEmailA;
        private System.Windows.Forms.TextBox texbPasswordA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}