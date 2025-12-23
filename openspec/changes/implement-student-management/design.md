# Design: Hệ thống Quản lý Sinh viên chuẩn

## Kiến trúc Tổng thể
Hệ thống tuân thủ kiến trúc 3 lớp (3-Layer Architecture) để đảm bảo tính tách biệt và dễ bảo trì.

### 1. Data Access Layer (DAL)
- Sử dụng Entity Framework 6 (Code First hoặc Database First đã có).
- Chứa các thực thể: `Student`, `Faculty`, `Major`.
- `StudentModel` là DbContext chính.

### 2. Business Logic Layer (BUS)
- `StudentService`: Xử lý CRUD cho Sinh viên, tính toán logic liên quan.
- `FacultyService`: Quản lý danh sách Khoa.
- `MajorService`: Quản lý danh sách Chuyên ngành.
- Các Service sẽ trả về các Model hoặc DTO cho lớp GUI.

### 3. Presentation Layer (GUI)
- WinForms làm giao diện chính.
- `frmQLSV`: Form chính hiển thị danh sách sinh viên và các nút chức năng.
- `frmFaculty`: Quản lý danh sách Khoa.
- `frmRegisterMajor`: Giao diện đăng ký chuyên ngành cho sinh viên.
- Sử dụng DataGridView để hiển thị dữ liệu và các Controls phù hợp để nhập liệu.

## Luồng xử lý chính (Data Flow)
1. GUI gọi Service tương ứng trong BUS.
2. BUS thực hiện logic nghiệp vụ và gọi DAL (DbContext) để truy vấn hoặc cập nhật database.
3. Dữ liệu được trả ngược lại GUI để hiển thị.

## Xử lý Ảnh đại diện (Avatar)
- Ảnh sẽ được lưu trong thư mục `Images` tại thư mục root của project GUI.
- Đường dẫn tương đối sẽ được lưu trong thuộc tính `Avatar` của `Student`.
