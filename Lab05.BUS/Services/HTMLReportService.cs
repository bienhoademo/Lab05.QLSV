using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab05.DAL.Entities;

namespace Lab05.BUS.Services
{
    public class HTMLReportService
    {
        public string GenerateStudentReport(List<Student> students, string title = "DANH SÁCH SINH VIÊN")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 40px; color: #333; }
        .header { text-align: center; border-bottom: 2px solid #2c3e50; padding-bottom: 20px; margin-bottom: 30px; }
        .header h1 { color: #2c3e50; margin: 0; text-transform: uppercase; letter-spacing: 2px; }
        .info { margin-bottom: 20px; color: #7f8c8d; font-style: italic; }
        table { width: 100%; border-collapse: collapse; box-shadow: 0 2px 15px rgba(0,0,0,0.1); border-radius: 8px; overflow: hidden; }
        th { background-color: #3498db; color: white; padding: 12px; text-align: left; }
        td { padding: 10px; border-bottom: 1px solid #eee; }
        tr:nth-child(even) { background-color: #f9f9f9; }
        tr:hover { background-color: #f1f1f1; }
        .footer { margin-top: 40px; text-align: right; color: #95a5a6; font-size: 0.9em; }
        .avg-badge { background: #2ecc71; color: white; padding: 2px 8px; border-radius: 12px; font-weight: bold; }
        @media print {
            body { margin: 0; }
            button { display: none; }
        }
    </style>
</head>
<body>
    <div class='header'>
        <h1>" + title + @"</h1>
    </div>
    <div class='info'>Ngày xuất báo cáo: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + @"</div>
    <table>
        <thead>
            <tr>
                <th>STT</th>
                <th>MSSV</th>
                <th>Họ Tên</th>
                <th>Khoa</th>
                <th>Chuyên Ngành</th>
                <th>Ngày Sinh</th>
                <th>Giới Tính</th>
                <th>Điểm TB</th>
            </tr>
        </thead>
        <tbody>");

            int stt = 1;
            foreach (var s in students)
            {
                string gender = s.Gender == true ? "Nam" : (s.Gender == false ? "Nữ" : "Chưa xác định");
                string birthDate = s.BirthDate?.ToString("dd/MM/yyyy") ?? "-";
                string majorName = s.Major?.Name ?? "Chưa ĐK";

                sb.Append($@"
            <tr>
                <td>{stt++}</td>
                <td><b>{s.StudentID}</b></td>
                <td>{s.FullName}</td>
                <td>{s.Faculty?.FacultyName}</td>
                <td>{majorName}</td>
                <td>{birthDate}</td>
                <td>{gender}</td>
                <td><span class='avg-badge'>{s.AverageScore:N1}</span></td>
            </tr>");
            }

            sb.Append(@"
        </tbody>
    </table>
    <div class='footer'>
        <p>Tổng số sinh viên: " + students.Count + @"</p>
        <p>Xác nhận của hệ thống QLSV Pro © " + DateTime.Now.Year + @"</p>
    </div>
</body>
</html>");

            return sb.ToString();
        }
    }
}
