using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
    public partial class frmMain : Form
    {
        private ucDashboard ucDash;
        private frmQLSV formQLSV;

        public frmMain()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Tối ưu hóa màu sắc Sidebar
            pnlSidebar.BackColor = Color.FromArgb(44, 62, 80);
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(20, 0, 0, 0);
                    btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(null, null);
        }

        private void ShowUC(Control uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (ucDash == null) ucDash = new ucDashboard();
            ucDash.RefreshData();
            ShowUC(ucDash);
            lblTitle.Text = "BẢNG ĐIỀU KHIỂN";
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            if (formQLSV == null) formQLSV = new frmQLSV();
            pnlContent.Controls.Clear();
            formQLSV.TopLevel = false;
            formQLSV.FormBorderStyle = FormBorderStyle.None;
            formQLSV.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(formQLSV);
            formQLSV.Show();
            lblTitle.Text = "QUẢN LÝ SINH VIÊN";
        }

        private void btnFaculties_Click(object sender, EventArgs e)
        {
            frmFaculty f = new frmFaculty();
            f.ShowDialog();
            if (ucDash != null) ucDash.RefreshData();
        }

        private void btnMajors_Click(object sender, EventArgs e)
        {
            frmMajor f = new frmMajor();
            f.ShowDialog();
            if (ucDash != null) ucDash.RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch f = new frmSearch();
            f.ShowDialog();
        }

        private void btnRegisterMajor_Click(object sender, EventArgs e)
        {
            frmRegisterMajor f = new frmRegisterMajor();
            f.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
