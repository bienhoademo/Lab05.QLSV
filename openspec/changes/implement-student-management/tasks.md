# Tasks: Triển khai hệ thống QLSV chuẩn

## Giai đoạn 1: Lớp Truy cập Dữ liệu (DAL)
- [x] Xác minh cấu trúc DbContext và các thực thể Student, Faculty, Major [v1]
- [x] Kiểm tra kết nối SQL Server và tạo dữ liệu mẫu nếu cần [v1]

## Giai đoạn 2: Lớp Nghiệp vụ (BUS)
- [x] Triển khai `StudentService`: Các phương thức CRUD [v1]
- [x] Triển khai `FacultyService`: Get list, CRUD khoa [v1]
- [x] Triển khai `MajorService`: Get list chuyên ngành theo khoa [v1]

## Giai đoạn 3: Giao diện Người dùng (GUI)
- [x] Thiết kế `frmQLSV`: Thêm các controls (MSSV, Tên, Điểm, Khoa, Avatar image) [v1]
- [x] Đổ dữ liệu vào DataGridView và ComboBox Khoa [v1]
- [x] Xử lý sự kiện Thêm/Sửa/Xóa Sinh viên trên GUI [v1]
- [x] Xử lý chọn và hiển thị ảnh đại diện [v1]
- [x] Thiết kế và xử lý logic cho `frmFaculty` [v1]
- [x] Thiết kế và xử lý logic cho `frmRegisterMajor` [v1]

## Giai đoạn 4: Hoàn thiện và Kiểm thử
- [x] Kiểm tra sự ràng buộc giữa Khoa - Chuyên ngành - Sinh viên [v1]
- [x] Kiểm tra chức năng tìm kiếm sinh viên [v1]
- [x] Kiểm tra việc lưu trữ và hiển thị ảnh đại diện [v1]
