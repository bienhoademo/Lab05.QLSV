namespace Lab05.GUI
{
    partial class ucDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalFaculties = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartFaculty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGPA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAvgGPA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgGPA)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartFaculty, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartGPA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartAvgGPA, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.lblTotalStudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(15, 25);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(38, 45);
            this.lblTotalStudents.TabIndex = 1;
            this.lblTotalStudents.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Sinh Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.lblTotalFaculties);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(460, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 80);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalFaculties
            // 
            this.lblTotalFaculties.AutoSize = true;
            this.lblTotalFaculties.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalFaculties.ForeColor = System.Drawing.Color.White;
            this.lblTotalFaculties.Location = new System.Drawing.Point(15, 25);
            this.lblTotalFaculties.Name = "lblTotalFaculties";
            this.lblTotalFaculties.Size = new System.Drawing.Size(38, 45);
            this.lblTotalFaculties.TabIndex = 1;
            this.lblTotalFaculties.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Khoa";
            // 
            // chartFaculty
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFaculty.ChartAreas.Add(chartArea1);
            this.chartFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFaculty.Legends.Add(legend1);
            this.chartFaculty.Location = new System.Drawing.Point(3, 103);
            this.chartFaculty.Name = "chartFaculty";
            this.chartFaculty.Size = new System.Drawing.Size(444, 244);
            this.chartFaculty.TabIndex = 2;
            this.chartFaculty.Text = "chart1";
            // 
            // chartGPA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGPA.ChartAreas.Add(chartArea2);
            this.chartGPA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartGPA.Legends.Add(legend2);
            this.chartGPA.Location = new System.Drawing.Point(453, 103);
            this.chartGPA.Name = "chartGPA";
            this.chartGPA.Size = new System.Drawing.Size(444, 244);
            this.chartGPA.TabIndex = 3;
            this.chartGPA.Text = "chart2";
            // 
            // chartAvgGPA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAvgGPA.ChartAreas.Add(chartArea3);
            this.tableLayoutPanel1.SetColumnSpan(this.chartAvgGPA, 2);
            this.chartAvgGPA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartAvgGPA.Legends.Add(legend3);
            this.chartAvgGPA.Location = new System.Drawing.Point(3, 353);
            this.chartAvgGPA.Name = "chartAvgGPA";
            this.chartAvgGPA.Size = new System.Drawing.Size(894, 244);
            this.chartAvgGPA.TabIndex = 4;
            this.chartAvgGPA.Text = "chart3";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgGPA)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalFaculties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaculty;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGPA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvgGPA;
    }
}
