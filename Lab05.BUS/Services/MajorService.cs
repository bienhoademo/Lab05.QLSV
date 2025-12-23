using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class MajorService
    {
        public List<Major> GetAll()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Majors.Include(m => m.Faculty).ToList();
            }
        }

        public List<Major> GetAllByFaculty(int facultyID)
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
            }
        }

        public void InsertUpdate(Major m)
        {
            using (StudentModel context = new StudentModel())
            {
                context.Majors.AddOrUpdate(m);
                context.SaveChanges();
            }
        }

        public void Delete(int facultyId, int majorId)
        {
            using (StudentModel context = new StudentModel())
            {
                var major = context.Majors.FirstOrDefault(m => m.FacultyID == facultyId && m.MajorID == majorId);
                if (major != null)
                {
                    // Kiểm tra xem có sinh viên nào thuộc chuyên ngành này không
                    bool hasStudents = context.Students.Any(s => s.MajorID == majorId && s.FacultyID == facultyId);
                    if (hasStudents) throw new Exception("Không thể xóa chuyên ngành đang có sinh viên theo học!");

                    context.Majors.Remove(major);
                    context.SaveChanges();
                }
            }
        }

        public void RegisterMajor(string studentId, int facultyId, int majorId)
        {
            using (StudentModel context = new StudentModel())
            {
                var student = context.Students.FirstOrDefault(s => s.StudentID == studentId);
                if (student == null) throw new Exception("Không tìm thấy sinh viên!");

                student.FacultyID = facultyId;
                student.MajorID = majorId;
                
                context.SaveChanges();
            }
        }
    }
}
