using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class ExcelExportService
    {
        public void ExportToCsv(List<Student> list, string filePath)
        {
            StringBuilder sb = new StringBuilder();
            // Header (UTF-8 with BOM for Excel to recognize Vietnamese)
            sb.AppendLine("MSSV,Họ Tên,Khoa,Điểm TB,Chuyên Ngành,Ngày Sinh,Giới Tính,Địa Chỉ,Số Điện Thoại");

            foreach (var s in list)
            {
                string gender = s.Gender == true ? "Nam" : (s.Gender == false ? "Nữ" : "");
                string birthDate = s.BirthDate?.ToString("dd/MM/yyyy") ?? "";
                
                sb.AppendLine($"{s.StudentID},{s.FullName},{s.Faculty?.FacultyName},{s.AverageScore},{s.Major?.Name},{birthDate},{gender},\"{s.Address}\",{s.PhoneNumber}");
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}
