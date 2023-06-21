namespace Kutuphane_Proje
{
    partial class FrmTeacherRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacherRequest));
            this.bGetin = new System.Windows.Forms.Button();
            this.texbRequestid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kutuphaneProjeDataSet = new Kutuphane_Proje.KutuphaneProjeDataSet();
            this.tblTeacherReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TeacherReqTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSetTableAdapters.Tbl_TeacherReqTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeacherReqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bGetin
            // 
            this.bGetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGetin.Location = new System.Drawing.Point(777, 292);
            this.bGetin.Name = "bGetin";
            this.bGetin.Size = new System.Drawing.Size(145, 37);
            this.bGetin.TabIndex = 10;
            this.bGetin.Text = "Get in !";
            this.bGetin.UseVisualStyleBackColor = true;
            this.bGetin.Click += new System.EventHandler(this.bGetin_Click);
            // 
            // texbRequestid
            // 
            this.texbRequestid.Location = new System.Drawing.Point(777, 224);
            this.texbRequestid.Name = "texbRequestid";
            this.texbRequestid.Size = new System.Drawing.Size(177, 20);
            this.texbRequestid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(651, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Request Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherSurnameDataGridViewTextBoxColumn,
            this.teacherMailDataGridViewTextBoxColumn,
            this.teacherPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTeacherReqBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 491);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teacher Requests";
            // 
            // kutuphaneProjeDataSet
            // 
            this.kutuphaneProjeDataSet.DataSetName = "KutuphaneProjeDataSet";
            this.kutuphaneProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTeacherReqBindingSource
            // 
            this.tblTeacherReqBindingSource.DataMember = "Tbl_TeacherReq";
            this.tblTeacherReqBindingSource.DataSource = this.kutuphaneProjeDataSet;
            // 
            // tbl_TeacherReqTableAdapter
            // 
            this.tbl_TeacherReqTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // teacherSurnameDataGridViewTextBoxColumn
            // 
            this.teacherSurnameDataGridViewTextBoxColumn.DataPropertyName = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.HeaderText = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.Name = "teacherSurnameDataGridViewTextBoxColumn";
            // 
            // teacherMailDataGridViewTextBoxColumn
            // 
            this.teacherMailDataGridViewTextBoxColumn.DataPropertyName = "TeacherMail";
            this.teacherMailDataGridViewTextBoxColumn.HeaderText = "TeacherMail";
            this.teacherMailDataGridViewTextBoxColumn.Name = "teacherMailDataGridViewTextBoxColumn";
            // 
            // teacherPasswordDataGridViewTextBoxColumn
            // 
            this.teacherPasswordDataGridViewTextBoxColumn.DataPropertyName = "TeacherPassword";
            this.teacherPasswordDataGridViewTextBoxColumn.HeaderText = "TeacherPassword";
            this.teacherPasswordDataGridViewTextBoxColumn.Name = "teacherPasswordDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "8680038_arrow_go_back_fill_icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 61);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "8680038_arrow_go_back_fill_icon.png");
            this.ımageList1.Images.SetKeyName(1, "8680038_arrow_go_back_fill_icon.png");
            // 
            // FrmTeacherRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(989, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bGetin);
            this.Controls.Add(this.texbRequestid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTeacherRequest";
            this.Text = "FrmTeacherRequest";
            this.Load += new System.EventHandler(this.FrmTeacherRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeacherReqBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGetin;
        private System.Windows.Forms.TextBox texbRequestid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private KutuphaneProjeDataSet kutuphaneProjeDataSet;
        private System.Windows.Forms.BindingSource tblTeacherReqBindingSource;
        private KutuphaneProjeDataSetTableAdapters.Tbl_TeacherReqTableAdapter tbl_TeacherReqTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}