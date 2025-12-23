using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.Include(s => s.Faculty).Include(s => s.Major).ToList();
            }
        }

        public List<Student> GetAll(int facultyID)
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.Include(s => s.Faculty).Where(p => p.FacultyID == facultyID).ToList();
            }
        }

        public List<Student> GetAllHasNoMajor()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.Include(s => s.Faculty).Where(p => p.MajorID == null).ToList();
            }
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.Include(s => s.Faculty).Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
            }
        }

        public Student FindById(string studentId)
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.FirstOrDefault(p => p.StudentID == studentId);
            }
        }

        public void InsertUpdate(Student s)
        {
            ValidateStudent(s);
            using (StudentModel context = new StudentModel())
            {
                context.Students.AddOrUpdate(s);
                context.SaveChanges();
            }
        }

        public void Delete(string studentId)
        {
            using (StudentModel context = new StudentModel())
            {
                var student = context.Students.FirstOrDefault(p => p.StudentID == studentId);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

        private void ValidateStudent(Student s)
        {
            if (string.IsNullOrEmpty(s.StudentID) || s.StudentID.Length != 10 || !s.StudentID.All(char.IsDigit))
            {
                throw new Exception("MSSV phải là chuỗi 10 ký tự số!");
            }
            if (string.IsNullOrEmpty(s.FullName))
            {
                throw new Exception("Họ tên sinh viên không được để trống!");
            }
            if (s.AverageScore < 0 || s.AverageScore > 10)
            {
                throw new Exception("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!");
            }
        }
    }
}
