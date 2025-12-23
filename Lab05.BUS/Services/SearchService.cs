using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class SearchService
    {
        public List<Student> Search(string studentId, string fullName, int? facultyId)
        {
            using (StudentModel context = new StudentModel())
            {
                var query = context.Students.Include("Faculty").Include("Major").AsQueryable();

                if (!string.IsNullOrEmpty(studentId))
                {
                    query = query.Where(s => s.StudentID.Contains(studentId));
                }

                if (!string.IsNullOrEmpty(fullName))
                {
                    query = query.Where(s => s.FullName.ToLower().Contains(fullName.ToLower()));
                }

                if (facultyId.HasValue && facultyId.Value > 0)
                {
                    query = query.Where(s => s.FacultyID == facultyId.Value);
                }

                return query.ToList();
            }
        }
    }
}
