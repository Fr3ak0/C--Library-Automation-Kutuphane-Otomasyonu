namespace Kutuphane_Proje
{
    partial class FrmChangeUserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeUserSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.How_many_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserSettingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet13 = new Kutuphane_Proje.KutuphaneProjeDataSet13();
            this.tblUserSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet11 = new Kutuphane_Proje.KutuphaneProjeDataSet11();
            this.texbBookCap = new System.Windows.Forms.TextBox();
            this.texbStudentMail = new System.Windows.Forms.TextBox();
            this.texbStudentNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bChangeSet = new System.Windows.Forms.Button();
            this.tbl_UserSettingsTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet11TableAdapters.Tbl_UserSettingsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbl_UserSettingsTableAdapter1 = new Kutuphane_Proje.KutuphaneProjeDataSet13TableAdapters.Tbl_UserSettingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserSettingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Settings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.StudentNo,
            this.StudentMail,
            this.How_many_books});
            this.dataGridView1.DataSource = this.tblUserSettingsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 412);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "StudentNo";
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentMail
            // 
            this.StudentMail.DataPropertyName = "StudentMail";
            this.StudentMail.HeaderText = "StudentMail";
            this.StudentMail.Name = "StudentMail";
            // 
            // How_many_books
            // 
            this.How_many_books.DataPropertyName = "How_many_books";
            this.How_many_books.HeaderText = "How_many_books";
            this.How_many_books.Name = "How_many_books";
            // 
            // tblUserSettingsBindingSource1
            // 
            this.tblUserSettingsBindingSource1.DataMember = "Tbl_UserSettings";
            this.tblUserSettingsBindingSource1.DataSource = this.kutuphaneProjeDataSet13;
            // 
            // kutuphaneProjeDataSet13
            // 
            this.kutuphaneProjeDataSet13.DataSetName = "KutuphaneProjeDataSet13";
            this.kutuphaneProjeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserSettingsBindingSource
            // 
            this.tblUserSettingsBindingSource.DataMember = "Tbl_UserSettings";
            this.tblUserSettingsBindingSource.DataSource = this.kutuphaneProjeDataSet11;
            // 
            // kutuphaneProjeDataSet11
            // 
            this.kutuphaneProjeDataSet11.DataSetName = "KutuphaneProjeDataSet11";
            this.kutuphaneProjeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // texbBookCap
            // 
            this.texbBookCap.Location = new System.Drawing.Point(869, 234);
            this.texbBookCap.Name = "texbBookCap";
            this.texbBookCap.Size = new System.Drawing.Size(167, 20);
            this.texbBookCap.TabIndex = 7;
            // 
            // texbStudentMail
            // 
            this.texbStudentMail.Location = new System.Drawing.Point(869, 194);
            this.texbStudentMail.Name = "texbStudentMail";
            this.texbStudentMail.Size = new System.Drawing.Size(167, 20);
            this.texbStudentMail.TabIndex = 8;
            // 
            // texbStudentNum
            // 
            this.texbStudentNum.Location = new System.Drawing.Point(869, 155);
            this.texbStudentNum.Name = "texbStudentNum";
            this.texbStudentNum.Size = new System.Drawing.Size(167, 20);
            this.texbStudentNum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(684, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Capacity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(710, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Mail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(668, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Number : ";
            // 
            // bChangeSet
            // 
            this.bChangeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bChangeSet.Location = new System.Drawing.Point(869, 303);
            this.bChangeSet.Name = "bChangeSet";
            this.bChangeSet.Size = new System.Drawing.Size(145, 40);
            this.bChangeSet.TabIndex = 10;
            this.bChangeSet.Text = "Change Settings";
            this.bChangeSet.UseVisualStyleBackColor = true;
            this.bChangeSet.Click += new System.EventHandler(this.bChangeSet_Click);
            // 
            // tbl_UserSettingsTableAdapter
            // 
            this.tbl_UserSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.ImageKey = "8680038_arrow_go_back_fill_icon.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 58);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "103401_add_book_sans_icon.png");
            this.ımageList1.Images.SetKeyName(1, "103404_book_sans_remove_icon.png");
            this.ımageList1.Images.SetKeyName(2, "8680038_arrow_go_back_fill_icon.png");
            this.ımageList1.Images.SetKeyName(3, "10131994_book_plus_line_icon.png");
            this.ımageList1.Images.SetKeyName(4, "6590491_and_book_delete_education_learning_icon.png");
            // 
            // tbl_UserSettingsTableAdapter1
            // 
            this.tbl_UserSettingsTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmChangeUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1068, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bChangeSet);
            this.Controls.Add(this.texbBookCap);
            this.Controls.Add(this.texbStudentMail);
            this.Controls.Add(this.texbStudentNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChangeUserSettings";
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.FrmChangeUserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserSettingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox texbBookCap;
        private System.Windows.Forms.TextBox texbStudentMail;
        private System.Windows.Forms.TextBox texbStudentNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bChangeSet;
        private KutuphaneProjeDataSet11 kutuphaneProjeDataSet11;
        private System.Windows.Forms.BindingSource tblUserSettingsBindingSource;
        private KutuphaneProjeDataSet11TableAdapters.Tbl_UserSettingsTableAdapter tbl_UserSettingsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn How_many_books;
        private KutuphaneProjeDataSet13 kutuphaneProjeDataSet13;
        private System.Windows.Forms.BindingSource tblUserSettingsBindingSource1;
        private KutuphaneProjeDataSet13TableAdapters.Tbl_UserSettingsTableAdapter tbl_UserSettingsTableAdapter1;
    }
}