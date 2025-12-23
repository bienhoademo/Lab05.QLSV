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
    public partial class frmFaculty : Form
    {
        private readonly FacultyService facultyService = new FacultyService();

        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = facultyService.GetAll();
                BindGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Faculty> listFaculties)
        {
            dgvFaculties.Rows.Clear();
            foreach (var item in listFaculties)
            {
                int index = dgvFaculties.Rows.Add();
                dgvFaculties.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculties.Rows[index].Cells[1].Value = item.FacultyName;
                dgvFaculties.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFacultyID.Text) || string.IsNullOrEmpty(txtFacultyName.Text))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin mã khoa và tên khoa!");

                Faculty f = new Faculty 
                { 
                    FacultyID = int.Parse(txtFacultyID.Text), 
                    FacultyName = txtFacultyName.Text, 
                    TotalProfessor = string.IsNullOrEmpty(txtTotalProfessor.Text) ? 0 : int.Parse(txtTotalProfessor.Text) 
                };
                
                facultyService.InsertUpdate(f);
                LoadData();
                MessageBox.Show("Thêm/Cập nhật khoa thành công!");
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
                if (string.IsNullOrEmpty(txtFacultyID.Text)) throw new Exception("Vui lòng chọn khoa cần xóa!");

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int facultyId = int.Parse(txtFacultyID.Text);
                    facultyService.Delete(facultyId);
                    LoadData();
                    MessageBox.Show("Xóa khoa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFacultyID.Text = dgvFaculties.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFacultyName.Text = dgvFaculties.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTotalProfessor.Text = dgvFaculties.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
