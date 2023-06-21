namespace Kutuphane_Proje
{
    partial class FrmStudentMybooks
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
            this.texbBookIdS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bReturnBookS = new System.Windows.Forms.Button();
            this.dataMybooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbStudentNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).BeginInit();
            this.SuspendLayout();
            // 
            // texbBookIdS
            // 
            this.texbBookIdS.Location = new System.Drawing.Point(844, 226);
            this.texbBookIdS.Name = "texbBookIdS";
            this.texbBookIdS.Size = new System.Drawing.Size(209, 20);
            this.texbBookIdS.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(716, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Book Id:";
            // 
            // bReturnBookS
            // 
            this.bReturnBookS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bReturnBookS.Location = new System.Drawing.Point(722, 350);
            this.bReturnBookS.Name = "bReturnBookS";
            this.bReturnBookS.Size = new System.Drawing.Size(258, 56);
            this.bReturnBookS.TabIndex = 22;
            this.bReturnBookS.Text = "Return The Book";
            this.bReturnBookS.UseVisualStyleBackColor = true;
            // 
            // dataMybooks
            // 
            this.dataMybooks.BackgroundColor = System.Drawing.Color.White;
            this.dataMybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMybooks.Location = new System.Drawing.Point(47, 140);
            this.dataMybooks.Name = "dataMybooks";
            this.dataMybooks.Size = new System.Drawing.Size(543, 550);
            this.dataMybooks.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(477, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 61);
            this.label2.TabIndex = 20;
            this.label2.Text = "My Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(596, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student Number :";
            // 
            // textbStudentNum
            // 
            this.textbStudentNum.Location = new System.Drawing.Point(844, 282);
            this.textbStudentNum.Name = "textbStudentNum";
            this.textbStudentNum.Size = new System.Drawing.Size(209, 20);
            this.textbStudentNum.TabIndex = 24;
            // 
            // FrmStudentMybooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1144, 726);
            this.Controls.Add(this.textbStudentNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texbBookIdS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bReturnBookS);
            this.Controls.Add(this.dataMybooks);
            this.Controls.Add(this.label2);
            this.Name = "FrmStudentMybooks";
            this.Text = "FrmStudentMybooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texbBookIdS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bReturnBookS;
        private System.Windows.Forms.DataGridView dataMybooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbStudentNum;
    }
}