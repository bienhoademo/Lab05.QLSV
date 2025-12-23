using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class DashboardService
    {
        public int GetTotalStudents()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students.Count();
            }
        }

        public int GetTotalFaculties()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Faculties.Count();
            }
        }

        public Dictionary<string, int> GetStudentCountByFaculty()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students
                    .GroupBy(s => s.Faculty.FacultyName)
                    .ToDictionary(g => g.Key, g => g.Count());
            }
        }

        public Dictionary<string, int> GetGpaStatistics()
        {
            using (StudentModel context = new StudentModel())
            {
                var students = context.Students.ToList();
                return new Dictionary<string, int>
                {
                    { "Xuất sắc (>=9.0)", students.Count(s => s.AverageScore >= 9.0) },
                    { "Giỏi (8.0-9.0)", students.Count(s => s.AverageScore >= 8.0 && s.AverageScore < 9.0) },
                    { "Khá (7.0-8.0)", students.Count(s => s.AverageScore >= 7.0 && s.AverageScore < 8.0) },
                    { "Trung bình (5.0-7.0)", students.Count(s => s.AverageScore >= 5.0 && s.AverageScore < 7.0) },
                    { "Yếu (<5.0)", students.Count(s => s.AverageScore < 5.0) }
                };
            }
        }

        public Dictionary<string, double> GetAverageGpaByFaculty()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Students
                    .GroupBy(s => s.Faculty.FacultyName)
                    .ToDictionary(g => g.Key, g => g.Average(s => s.AverageScore));
            }
        }
    }
}
