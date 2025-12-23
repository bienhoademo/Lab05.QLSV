namespace Lab05.GUI
{
    partial class frmMajor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMajors = new System.Windows.Forms.DataGridView();
            this.colFacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMajors
            // 
            this.dgvMajors.AllowUserToAddRows = false;
            this.dgvMajors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMajors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMajors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacID,
            this.colFacName,
            this.colMajID,
            this.colMajName});
            this.dgvMajors.Location = new System.Drawing.Point(344, 40);
            this.dgvMajors.Name = "dgvMajors";
            this.dgvMajors.Size = new System.Drawing.Size(430, 300);
            this.dgvMajors.TabIndex = 0;
            this.dgvMajors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMajors_CellClick);
            // 
            // colFacID
            // 
            this.colFacID.HeaderText = "Mã Khoa";
            this.colFacID.Name = "colFacID";
            this.colFacID.Visible = false;
            // 
            // colFacName
            // 
            this.colFacName.HeaderText = "Khoa";
            this.colFacName.Name = "colFacName";
            // 
            // colMajID
            // 
            this.colMajID.HeaderText = "Mã Chuyên Ngành";
            this.colMajID.Name = "colMajID";
            // 
            // colMajName
            // 
            this.colMajName.HeaderText = "Tên Chuyên Ngành";
            this.colMajName.Name = "colMajName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMajorID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyên ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên chuyên ngành";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã chuyên ngành";
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(120, 80);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(182, 20);
            this.txtMajorID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(120, 40);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(182, 21);
            this.cmbFaculty.TabIndex = 0;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(60, 240);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnAddUpdate.TabIndex = 2;
            this.btnAddUpdate.Text = "Thêm / Sửa";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMajors);
            this.Name = "frmMajor";
            this.Text = "Quản lý Chuyên Ngành";
            this.Load += new System.EventHandler(this.frmMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvMajors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
