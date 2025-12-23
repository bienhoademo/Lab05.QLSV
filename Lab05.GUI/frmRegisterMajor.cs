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
    public partial class frmRegisterMajor : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        public frmRegisterMajor()
        {
            InitializeComponent();
        }

        private void frmRegisterMajor_Load(object sender, EventArgs e)
        {
            try
            {
                var listFaculties = facultyService.GetAll();
                FillFacultyCombobox(listFaculties);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFacultyCombobox(List<Faculty> listFaculties)
        {
            this.cmbFaculty.DataSource = listFaculties;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var listMajors = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                cmbMajor.DataSource = listMajors;
                cmbMajor.DisplayMember = "Name";
                cmbMajor.ValueMember = "MajorID";

                LoadStudents(selectedFaculty.FacultyID);
            }
        }

        private void LoadStudents(int facultyId)
        {
            var listStudents = chkNoMajor.Checked
                ? studentService.GetAllHasNoMajor(facultyId)
                : studentService.GetAll(facultyId);
            BindGrid(listStudents);
        }

        private void chkNoMajor_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedValue != null)
            {
                LoadStudents((int)cmbFaculty.SelectedValue);
            }
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = false; // Checkbox column
                dgvStudents.Rows[index].Cells[1].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[2].Value = item.FullName;
                dgvStudents.Rows[index].Cells[3].Value = item.Faculty?.FacultyName ?? "";
                dgvStudents.Rows[index].Cells[4].Value = item.AverageScore;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMajor.SelectedValue == null) throw new Exception("Vui lòng chọn chuyên ngành!");
                
                int facultyId = (int)cmbFaculty.SelectedValue;
                int majorId = (int)cmbMajor.SelectedValue;
                int count = 0;

                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        string studentId = row.Cells[1].Value.ToString();
                        majorService.RegisterMajor(studentId, facultyId, majorId);
                        count++;
                    }
                }

                if (count > 0)
                {
                    MessageBox.Show($"Đã đăng ký chuyên ngành thành công cho {count} sinh viên!", "Thông báo");
                    cmbFaculty_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần đăng ký!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
