using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lab05.DAL.Entities;
using System.Data.Entity.Migrations;

namespace Lab05.BUS.Services
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Faculties.ToList();
            }
        }

        public void InsertUpdate(Faculty f)
        {
            if (string.IsNullOrEmpty(f.FacultyName))
                throw new Exception("Tên khoa không được để trống!");

            using (StudentModel context = new StudentModel())
            {
                context.Faculties.AddOrUpdate(f);
                context.SaveChanges();
            }
        }

        public void Delete(int facultyId)
        {
            using (StudentModel context = new StudentModel())
            {
                var faculty = context.Faculties.Include(f => f.Students).FirstOrDefault(p => p.FacultyID == facultyId);
                if (faculty != null)
                {
                    if (faculty.Students.Count > 0)
                        throw new Exception("Không thể xóa khoa đang có sinh viên!");
                    
                    context.Faculties.Remove(faculty);
                    context.SaveChanges();
                }
            }
        }
    }
}
