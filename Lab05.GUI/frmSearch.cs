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
using System.Data.Entity;

namespace Lab05.GUI
{
    public partial class frmSearch : Form
    {
        private readonly SearchService searchService = new SearchService();
        private readonly FacultyService facultyService = new FacultyService();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            var faculties = facultyService.GetAll();
            faculties.Insert(0, new Faculty { FacultyID = -1, FacultyName = "-- Tất cả khoa --" });
            cmbFaculty.DataSource = faculties;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int? facultyId = (cmbFaculty.SelectedValue != null && (int)cmbFaculty.SelectedValue == -1) ? (int?)null : (int?)cmbFaculty.SelectedValue;
                var results = searchService.Search(txtMSSV.Text, txtFullName.Text, facultyId);
                BindGrid(results);
                lblResultCount.Text = $"Tìm thấy: {results.Count()} kết quả";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Student> list)
        {
            dgvResults.Rows.Clear();
            foreach (var item in list)
            {
                int index = dgvResults.Rows.Add();
                dgvResults.Rows[index].Cells[0].Value = item.StudentID;
                dgvResults.Rows[index].Cells[1].Value = item.FullName;
                dgvResults.Rows[index].Cells[2].Value = item.Faculty?.FacultyName ?? "";
                dgvResults.Rows[index].Cells[3].Value = item.AverageScore;
                dgvResults.Rows[index].Cells[4].Value = item.BirthDate?.ToString("dd/MM/yyyy") ?? "";
                dgvResults.Rows[index].Cells[5].Value = item.Gender == true ? "Nam" : (item.Gender == false ? "Nữ" : "");
                dgvResults.Rows[index].Cells[6].Value = item.Address;
                dgvResults.Rows[index].Cells[7].Value = item.PhoneNumber;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtFullName.Clear();
            cmbFaculty.SelectedIndex = 0;
            dgvResults.Rows.Clear();
            lblResultCount.Text = "Tìm thấy: 0 kết quả";
        }
    }
}
