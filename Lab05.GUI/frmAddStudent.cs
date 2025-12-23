using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Lab05.BUS.Services;
using Lab05.DAL.Entities;

namespace Lab05.GUI
{
    public partial class frmAddStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private string avatarFilePath = string.Empty;

        public frmAddStudent()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.FromArgb(243, 244, 246);
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(231, 76, 60);
            btnExit.ForeColor = Color.White;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                var faculties = facultyService.GetAll();
                cmbFaculty.DataSource = faculties;
                cmbFaculty.DisplayMember = "FacultyName";
                cmbFaculty.ValueMember = "FacultyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student
                {
                    StudentID = txtMSSV.Text,
                    FullName = txtFullName.Text,
                    AverageScore = string.IsNullOrEmpty(txtAverageScore.Text) ? 0 : double.Parse(txtAverageScore.Text),
                    FacultyID = (int)cmbFaculty.SelectedValue,
                    BirthDate = dtpBirthDate.Value,
                    Gender = rbMale.Checked,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text
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
                MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
