using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.BUS.Services;
using Lab05.DAL.Entities;

namespace Lab05.GUI
{
    public partial class frmReport : Form
    {
        private readonly HTMLReportService reportService = new HTMLReportService();
        private readonly StudentService studentService = new StudentService();

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            try
            {
                var students = studentService.GetAll();
                string html = reportService.GenerateStudentReport(students);
                webBrowser.DocumentText = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
