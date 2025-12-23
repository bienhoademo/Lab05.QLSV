using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class StudentImportService
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        public struct ImportResult
        {
            public int SuccessCount;
            public int ErrorCount;
            public List<string> ErrorMessages;
        }

        public ImportResult ImportFromCsv(string filePath)
        {
            ImportResult result = new ImportResult
            {
                ErrorMessages = new List<string>()
            };

            try
            {
                var faculties = facultyService.GetAll();
                var majors = majorService.GetAll();
                
                // Read lines, skipping header
                var lines = File.ReadAllLines(filePath, Encoding.UTF8).Skip(1);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        // Simple CSV split (handling basic quotes if needed)
                        // This assumes the format exported by ExcelExportService:
                        // MSSV,Họ Tên,Khoa,Điểm TB,Chuyên Ngành,Ngày Sinh,Giới Tính,Địa Chỉ,Số Điện Thoại
                        var parts = ParseCsvLine(line);
                        if (parts.Length < 4) throw new Exception("Dòng dữ liệu không đủ cột!");

                        string studentId = parts[0].Trim();
                        string fullName = parts[1].Trim();
                        string facultyName = parts[2].Trim();
                        double.TryParse(parts[3], out double avgScore);
                        string majorName = parts.Length > 4 ? parts[4].Trim() : "";
                        string birthStr = parts.Length > 5 ? parts[5].Trim() : "";
                        string genderStr = parts.Length > 6 ? parts[6].Trim() : "";
                        string address = parts.Length > 7 ? parts[7].Trim().Trim('"') : "";
                        string phone = parts.Length > 8 ? parts[8].Trim() : "";

                        var faculty = faculties.FirstOrDefault(f => f.FacultyName.Equals(facultyName, StringComparison.OrdinalIgnoreCase));
                        if (faculty == null) throw new Exception($"Không tìm thấy khoa: {facultyName}");

                        int? majorId = null;
                        if (!string.IsNullOrEmpty(majorName))
                        {
                            var major = majors.FirstOrDefault(m => m.Name.Equals(majorName, StringComparison.OrdinalIgnoreCase) && m.FacultyID == faculty.FacultyID);
                            if (major != null) majorId = major.MajorID;
                        }

                        DateTime? birthDate = null;
                        if (DateTime.TryParse(birthStr, out DateTime dt)) birthDate = dt;

                        bool? gender = null;
                        if (genderStr.Equals("Nam", StringComparison.OrdinalIgnoreCase)) gender = true;
                        else if (genderStr.Equals("Nữ", StringComparison.OrdinalIgnoreCase)) gender = false;

                        Student s = new Student
                        {
                            StudentID = studentId,
                            FullName = fullName,
                            FacultyID = faculty.FacultyID,
                            AverageScore = avgScore,
                            MajorID = majorId,
                            BirthDate = birthDate,
                            Gender = gender,
                            Address = address,
                            PhoneNumber = phone
                        };

                        studentService.InsertUpdate(s);
                        result.SuccessCount++;
                    }
                    catch (Exception ex)
                    {
                        result.ErrorCount++;
                        result.ErrorMessages.Add($"Lỗi dòng '{line}': {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessages.Add("Lỗi hệ thống khi đọc file: " + ex.Message);
            }

            return result;
        }

        private string[] ParseCsvLine(string line)
        {
            // Basic CSV parser that handles quotes
            List<string> parts = new List<string>();
            bool inQuotes = false;
            StringBuilder current = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '\"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    parts.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
            parts.Add(current.ToString());
            return parts.ToArray();
        }
    }
}
