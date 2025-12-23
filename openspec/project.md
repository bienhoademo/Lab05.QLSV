# Bối cảnh dự án (Project Context)

## Mục đích (Purpose)
Đây là hệ thống Quản lý Sinh viên (QLSV), được phát triển như một phần của bài thực hành số 5 (Lab 05). Mục tiêu của ứng dụng là quản lý thông tin sinh viên, khoa, và chuyên ngành, bao gồm cả việc xử lý ảnh đại diện (avatar) của sinh viên.

## Stack công nghệ (Tech Stack)
- **Ngôn ngữ**: C#
- **Framework**: .NET Framework 4.7.2
- **Giao diện**: Windows Forms (WinForms)
- **ORM**: Entity Framework 6 (EF6)
- **Database**: SQL Server
- **Quản lý package**: NuGet

## Quy ước dự án (Project Conventions)

### Phong cách Code (Code Style)
- Sử dụng quy tắc đặt tên **PascalCase** cho các Class, Method, và Property.
- Sử dụng **camelCase** cho các biến cục bộ và tham số.
- Các điều khiển giao diện (Controls) trong WinForms sử dụng tiền tố theo loại (ví dụ: `btn` cho Button, `txt` cho TextBox, `dgv` cho DataGridView).

### Mô hình kiến trúc (Architecture Patterns)
- Dự án tuân theo kiến trúc **3 lớp (3-Layer Architecture)**:
  - **Lab05.GUI**: Lớp giao diện người dùng, chứa các Form và xử lý sự kiện WinForms.
  - **Lab05.BUS**: Lớp nghiệp vụ (Business Logic), chứa các Service để xử lý logic giữa GUI và DAL.
  - **Lab05.DAL**: Lớp truy cập dữ liệu (Data Access Layer), chứa Entity Framework DbContext và các class thực thể (Entities).

### Chiến lược kiểm thử (Testing Strategy)
- Hiện tại dự án tập trung vào kiểm thử thủ công trên giao diện WinForms để đảm bảo các chức năng CRUD hoạt động chính xác.

### Quy trình Git (Git Workflow)
- Sử dụng các thông điệp commit mô tả rõ ràng các thay đổi (ví dụ: "Add StudentService", "Implement 3-layer architecture").

## Bối cảnh nghiệp vụ (Domain Context)
- Dữ liệu cốt lõi xoay quanh `Student` (Sinh viên), `Faculty` (Khoa), và `Major` (Chuyên ngành).
- Sinh viên thuộc về một Khoa và có thể thuộc về một Chuyên ngành (Major) cụ thể trong khoa đó.
- Điểm trung bình (AverageScore) được lưu trữ cho từng sinh viên.

## Các ràng buộc quan trọng (Important Constraints)
- Phải đảm bảo tính toàn vẹn dữ liệu khi xóa hoặc cập nhật thông tin Khoa/Chuyên ngành có liên quan đến Sinh viên.
- Ứng dụng chạy trên nền tảng Windows (.NET Framework).

## Phụ thuộc bên ngoài (External Dependencies)
- **SQL Server**: Cần để lưu trữ dữ liệu thực tế. Chuỗi kết nối được cấu hình trong `App.config`.
