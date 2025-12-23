# Design: Advanced QLSV Features - Phase 2

## Architecture Overview
Tiếp tục duy trì mô hình 3-Layer (GUI, BUS, DAL) nhưng nâng cấp mạnh mẽ ở tầng GUI và mở rộng Entity ở tầng DAL.

## UX/UI Standards (Phase 2)
### Dashboard Layout
- Sử dụng một Form chính làm Container (MDI Form hoặc Sidebar Layout).
- Sidebar chứa các điều hướng: Dashboard, Quản lý Sinh viên, Quản lý Khoa, Thống kê, Cài đặt.
- Trang Home sẽ là các Widget hiển thị con số tổng quát (Tổng sinh viên, Tổng giảng viên, Khoa đông nhất).

### Analytics Details
- **Pie Chart (Cơ cấu)**: Tỷ lệ phần trăm sinh viên theo từng Khoa.
- **Column Chart (Xếp loại)**: Số lượng sinh viên theo các mức: Xuất sắc, Giỏi, Khá, Trung bình, Yếu.
- **Bar Chart (Điểm trung bình)**: So sánh điểm trung bình cộng của các Khoa để thấy được chất lượng đào tạo tương đối.

## Data Model Extensions
### Student Extensions
- `BirthDate`: DateTime.
- `Gender`: Bit (Boolean).
- `Address`: NVARCHAR(500).
- `PhoneNumber`: NVARCHAR(11).

## Technical Decisions
- **Exporting**: Sử dụng bộ thư viện Interop Excel hoặc EPPlus để tạo file XLSX mà không cần cài đặt Office trên máy.
- **Security**: Mật khẩu sẽ được băm bằng SHA256 trước khi lưu vào database.
- **Dashboard Data**: BUS sẽ cung cấp các phương thức `GetStatistics()` trả về các DTO (Data Transfer Object) để GUI hiển thị.
