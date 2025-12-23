using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Lab05.BUS.Services;
using Lab05.DAL.Entities;

namespace Lab05.GUI
{
    public partial class frmQLSV : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly ExcelExportService excelService = new ExcelExportService();
        private readonly StudentImportService importService = new StudentImportService();
        private string avatarFilePath = string.Empty;

        public frmQLSV()
        {
            InitializeComponent();
            SetupModernUI();
        }

        private void SetupModernUI()
        {
            this.BackColor = Color.FromArgb(236, 240, 241); // Clouds (Flat UI)
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Peter River
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            try
            {
                var listFaculties = facultyService.GetAll();
                FillFacultyCombobox(listFaculties);
                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
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

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[1].Value = item.FullName;
                dgvStudents.Rows[index].Cells[2].Value = item.Faculty?.FacultyName ?? "";
                dgvStudents.Rows[index].Cells[3].Value = item.AverageScore;
                dgvStudents.Rows[index].Cells[4].Value = item.Major != null ? item.Major.Name : "";
                dgvStudents.Rows[index].Cells[5].Value = item.BirthDate?.ToString("dd/MM/yyyy") ?? "";
                dgvStudents.Rows[index].Cells[6].Value = item.Gender == true ? "Nam" : (item.Gender == false ? "Nữ" : "");
                dgvStudents.Rows[index].Cells[7].Value = item.Address;
                dgvStudents.Rows[index].Cells[8].Value = item.PhoneNumber;
            }
        }

        private void LoadAvatar(string studentID)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                var student = studentService.FindById(studentID);
                if (student != null && !string.IsNullOrEmpty(student.Avatar))
                {
                    string avatarPath = Path.Combine(folderPath, student.Avatar);
                    if (File.Exists(avatarPath))
                    {
                        if (picAvatar.Image != null) picAvatar.Image.Dispose();
                        picAvatar.Image = Image.FromFile(avatarPath);
                    }
                    else
                    {
                        picAvatar.Image = null;
                    }
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
            catch
            {
                picAvatar.Image = null;
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtFullName.Text = row.Cells[1].Value?.ToString();
                cmbFaculty.Text = row.Cells[2].Value?.ToString();
                txtAverageScore.Text = row.Cells[3].Value?.ToString();
                
                if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime birthDate))
                    dtpBirthDate.Value = birthDate;
                
                string gender = row.Cells[6].Value?.ToString();
                if (gender == "Nam") rbMale.Checked = true;
                else if (gender == "Nữ") rbFemale.Checked = true;

                txtAddress.Text = row.Cells[7].Value?.ToString();
                txtPhone.Text = row.Cells[8].Value?.ToString();

                LoadAvatar(txtMSSV.Text);
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMSSV.Text) || string.IsNullOrEmpty(txtFullName.Text))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");

                Student s = new Student
                {
                    StudentID = txtMSSV.Text,
                    FullName = txtFullName.Text,
                    AverageScore = double.TryParse(txtAverageScore.Text, out double avg) ? avg : 0,
                    FacultyID = cmbFaculty.SelectedValue != null ? (int)cmbFaculty.SelectedValue : 0,
                    BirthDate = dtpBirthDate.Value,
                    Gender = rbMale.Checked,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhone.Text
                };

                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    string folderPath = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                    string fileName = s.StudentID + Path.GetExtension(avatarFilePath);
                    string targetPath = Path.Combine(folderPath, fileName);
                    File.Copy(avatarFilePath, targetPath, true);
                    s.Avatar = fileName;
                }

                studentService.InsertUpdate(s);
                BindGrid(studentService.GetAll());
                MessageBox.Show("Thêm/Cập nhật sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMSSV.Text)) throw new Exception("Vui lòng chọn sinh viên cần xóa!");
                
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    studentService.Delete(txtMSSV.Text);
                    BindGrid(studentService.GetAll());
                    ClearInput();
                    MessageBox.Show("Xóa sinh viên thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            txtMSSV.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            dtpBirthDate.Value = DateTime.Now;
            rbMale.Checked = true;
            if (picAvatar.Image != null) picAvatar.Image.Dispose();
            picAvatar.Image = null;
            avatarFilePath = string.Empty;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                avatarFilePath = dlg.FileName;
                if (picAvatar.Image != null) picAvatar.Image.Dispose();
                picAvatar.Image = Image.FromFile(avatarFilePath);
            }
        }

        private void chkUnregisteredMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = chkUnregisteredMajor.Checked 
                ? studentService.GetAllHasNoMajor() 
                : studentService.GetAll();
            BindGrid(listStudents);
        }

        private void quanLyKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty f = new frmFaculty();
            f.ShowDialog();
            frmQLSV_Load(null, null);
        }

        private void dangKyChuyenNganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterMajor f = new frmRegisterMajor();
            f.ShowDialog();
            frmQLSV_Load(null, null);
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch f = new frmSearch();
            f.ShowDialog();
        }

        private void themSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent f = new frmAddStudent();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGrid(studentService.GetAll());
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    excelService.ExportToCsv(studentService.GetAll(), sfd.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "CSV Files (*.csv)|*.csv";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var result = importService.ImportFromCsv(dlg.FileName);
                    string msg = $"Nhập dữ liệu hoàn tất!\nThành công: {result.SuccessCount}\nThất bại: {result.ErrorCount}";
                    if (result.ErrorCount > 0)
                    {
                        msg += "\n\nCác lỗi chi tiết:\n" + string.Join("\n", result.ErrorMessages.Take(5));
                        if (result.ErrorCount > 5) msg += "\n...";
                    }
                    MessageBox.Show(msg, "Kết quả Import", MessageBoxButtons.OK, 
                        result.ErrorCount > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

                    // Refresh grid
                    BindGrid(studentService.GetAll());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi import: " + ex.Message);
            }
        }
    }
}
