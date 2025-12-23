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
    public partial class frmMajor : Form
    {
        private readonly MajorService majorService = new MajorService();
        private readonly FacultyService facultyService = new FacultyService();

        public frmMajor()
        {
            InitializeComponent();
        }

        private void frmMajor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var faculties = facultyService.GetAll();
                cmbFaculty.DataSource = faculties;
                cmbFaculty.DisplayMember = "FacultyName";
                cmbFaculty.ValueMember = "FacultyID";

                var majors = majorService.GetAll();
                BindGrid(majors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Major> list)
        {
            dgvMajors.Rows.Clear();
            foreach (var item in list)
            {
                int index = dgvMajors.Rows.Add();
                dgvMajors.Rows[index].Cells[0].Value = item.FacultyID;
                dgvMajors.Rows[index].Cells[1].Value = item.Faculty?.FacultyName ?? "";
                dgvMajors.Rows[index].Cells[2].Value = item.MajorID;
                dgvMajors.Rows[index].Cells[3].Value = item.Name;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMajorID.Text) || string.IsNullOrEmpty(txtName.Text))
                    throw new Exception("Vui lòng nhập đầy đủ mã và tên chuyên ngành!");

                Major m = new Major
                {
                    FacultyID = (int)cmbFaculty.SelectedValue,
                    MajorID = int.Parse(txtMajorID.Text),
                    Name = txtName.Text
                };

                majorService.InsertUpdate(m);
                LoadData();
                MessageBox.Show("Thêm/Cập nhật chuyên ngành thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMajors.CurrentRow == null) throw new Exception("Vui lòng chọn chuyên ngành cần xóa!");

                var result = MessageBox.Show("Bạn có chắc muốn xóa chuyên ngành này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int fid = (int)dgvMajors.CurrentRow.Cells[0].Value;
                    int mid = (int)dgvMajors.CurrentRow.Cells[2].Value;
                    majorService.Delete(fid, mid);
                    LoadData();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMajors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbFaculty.SelectedValue = dgvMajors.Rows[e.RowIndex].Cells[0].Value;
                txtMajorID.Text = dgvMajors.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtName.Text = dgvMajors.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
